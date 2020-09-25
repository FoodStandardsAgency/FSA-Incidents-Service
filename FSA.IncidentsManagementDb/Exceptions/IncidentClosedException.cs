using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace FSA.IncidentsManagementDb.Exceptions
{
    public class IncidentClosedException : OldSIMSException
    {
        public IncidentClosedException()
        {
        }

        public IncidentClosedException(string message) : base(message)
        {
        }

        public IncidentClosedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IncidentClosedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
