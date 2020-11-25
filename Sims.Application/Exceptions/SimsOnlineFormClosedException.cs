using System;
using System.Runtime.Serialization;

namespace Sims.Application.Exceptions
{
    public class SimsOnlineFormClosedException : SIMSException
    {
        public SimsOnlineFormClosedException()
        {
        }

        public SimsOnlineFormClosedException(string message) : base(message)
        {
        }

        public SimsOnlineFormClosedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SimsOnlineFormClosedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
