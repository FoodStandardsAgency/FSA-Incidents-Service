using System;
using System.Runtime.Serialization;

namespace Sims.Application.Exceptions
{
    public class SimsSignalMissingException : SIMSException
    {
        public SimsSignalMissingException()
        {
        }

        public SimsSignalMissingException(string message) : base(message)
        {
        }

        public SimsSignalMissingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SimsSignalMissingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
