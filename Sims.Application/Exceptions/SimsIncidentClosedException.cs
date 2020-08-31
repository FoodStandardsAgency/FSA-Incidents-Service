using System;
using System.Runtime.Serialization;

namespace Sims.Application.Exceptions
{
    public class SimsIncidentClosedException : SIMSException
    {
        public SimsIncidentClosedException()
        {
        }

        public SimsIncidentClosedException(string message) : base(message)
        {
        }

        public SimsIncidentClosedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SimsIncidentClosedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
