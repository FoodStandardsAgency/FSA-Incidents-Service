using System;
using System.Runtime.Serialization;

namespace Sims.Application.Exceptions
{
    public class SIMSException : Exception
    {
        public SIMSException()
        {
        }

        public SIMSException(string message) : base(message)
        {
        }

        public SIMSException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SIMSException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
