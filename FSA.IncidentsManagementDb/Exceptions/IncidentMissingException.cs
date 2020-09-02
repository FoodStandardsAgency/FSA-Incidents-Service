using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace FSA.IncidentsManagementDb.Exceptions
{
    public class IncidentMissingException : OldSIMSException
    {
        public IncidentMissingException()
        {
        }

        public IncidentMissingException(string message) : base(message)
        {
        }

        public IncidentMissingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IncidentMissingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
