using System;
using System.Runtime.Serialization;

namespace Sims.Application.Exceptions
{
    public class SimsProductExistsException : SIMSException
    {
        public SimsProductExistsException()
        {
        }

        public SimsProductExistsException(string message) : base(message)
        {
        }

        public SimsProductExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SimsProductExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
