using System;
using System.Runtime.Serialization;

namespace Sims.Application.Exceptions
{
    public class SimsSignalClosedException : SIMSException
    {
        public SimsSignalClosedException()
        {
        }

        public SimsSignalClosedException(string message) : base(message)
        {
        }

        public SimsSignalClosedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SimsSignalClosedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
