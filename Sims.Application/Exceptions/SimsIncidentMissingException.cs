using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Sims.Application.Exceptions
{
    public class SimsIncidentMissingException : SIMSException
    {
        public SimsIncidentMissingException()
        {
        }

        public SimsIncidentMissingException(string message) : base(message)
        {
        }

        public SimsIncidentMissingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SimsIncidentMissingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
