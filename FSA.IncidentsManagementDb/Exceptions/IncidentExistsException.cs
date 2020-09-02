using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace FSA.IncidentsManagementDb.Exceptions
{
    public class IncidentExistsException : OldSIMSException
    {
        public IncidentExistsException()
        {
        }

        public IncidentExistsException(string message) : base(message)
        {
        }

        public IncidentExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IncidentExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
