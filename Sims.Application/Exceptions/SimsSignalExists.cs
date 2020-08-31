using System;
using System.Runtime.Serialization;

namespace Sims.Application.Exceptions
{

    public class SimsSignalExists : SIMSException
    {
        public SimsSignalExists()
        {
        }

        public SimsSignalExists(string message) : base(message)
        {
        }

        public SimsSignalExists(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SimsSignalExists(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
