using FluentValidation;
using FSA.IncidentsManagement.Models;

namespace FSA.IncidentsManagement.ModelValidators
{
    public class NewProductValidator : AbstractValidator<ProductViewModel>
    {
        public NewProductValidator()
        {
            RuleFor(product => product.Name).NotNull().WithMessage("Product must have a name");
            RuleFor(product => product.Brand).NotNull().WithMessage("Product must have a brand");
            RuleFor(product => product.ProductTypeId).NotEqual(0).WithMessage("Product type is missing");
        }
    }
}
