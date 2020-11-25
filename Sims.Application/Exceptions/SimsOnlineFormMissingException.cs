using System;
using System.Runtime.Serialization;

namespace Sims.Application.Exceptions
{
    public class SimsOnlineFormMissingException : SIMSException
    {
        public SimsOnlineFormMissingException()
        {
        }

        public SimsOnlineFormMissingException(string message) : base(message)
        {
        }

        public SimsOnlineFormMissingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SimsOnlineFormMissingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
