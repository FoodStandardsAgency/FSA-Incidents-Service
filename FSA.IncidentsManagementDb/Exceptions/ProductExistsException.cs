using System;
using System.Runtime.Serialization;

namespace FSA.IncidentsManagementDb.Exceptions
{
    public class ProductExistsException : SIMSException
    {
        public ProductExistsException()
        {
        }

        public ProductExistsException(string message) : base(message)
        {
        }

        public ProductExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ProductExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
