using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Sims.Application.Exceptions
{
    public class SimsIncidentExistsException : SimsItemExists
    {
        public SimsIncidentExistsException()
        {
        }

        public SimsIncidentExistsException(string message) : base(message)
        {
        }

        public SimsIncidentExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SimsIncidentExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
