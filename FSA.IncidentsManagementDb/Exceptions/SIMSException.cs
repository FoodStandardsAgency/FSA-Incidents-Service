using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace FSA.IncidentsManagementDb.Exceptions
{
    [Obsolete]
    public class OldSIMSException : Exception
    {
        public OldSIMSException()
        {
        }

        public OldSIMSException(string message) : base(message)
        {
        }

        public OldSIMSException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OldSIMSException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
