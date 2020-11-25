using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FSA.SIMSManagerDb
{
    // https://stackoverflow.com/questions/5595338/add-the-where-clause-dynamically-in-entity-framework
    // Used to build where statements in IQuerable
    // It looks like magic, but click through the .Visit() to see where how the Vistior pattern is applied.
    internal static class ExpressionExtensions
    {
        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> leftExpression, Expression<Func<T, bool>> rightExpression)
        {
            if (leftExpression == null) return rightExpression;
            if (rightExpression == null) return leftExpression;
            var paramExpr = Expression.Parameter(typeof(T));
            var exprBody = Expression.And(leftExpression.Body, rightExpression.Body);
            exprBody = (BinaryExpression)new ParameterReplacer(paramExpr).Visit(exprBody);

            return Expression.Lambda<Func<T, bool>>(exprBody, paramExpr);
        }

        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> leftExpression, Expression<Func<T, bool>> rightExpression)
        {
            if (leftExpression == null) return rightExpression;
            if (rightExpression == null) return leftExpression;
            var paramExpr = Expression.Parameter(typeof(T));
            var exprBody = Expression.Or(leftExpression.Body, rightExpression.Body);
            exprBody = (BinaryExpression)new ParameterReplacer(paramExpr).Visit(exprBody);

            return Expression.Lambda<Func<T, bool>>(exprBody, paramExpr);
        }
    }

    internal class ParameterReplacer : ExpressionVisitor
    {
        private readonly ParameterExpression _parameter;

        internal ParameterReplacer(ParameterExpression parameter)
        {
            _parameter = parameter;
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            return base.VisitParameter(_parameter);
        }
    }
}
