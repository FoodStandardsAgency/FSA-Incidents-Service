using System;
using System.Runtime.Serialization;

namespace Sims.Application.Exceptions
{

    public class SimsItemExists : SIMSException
    {
        public SimsItemExists()
        {
        }

        public SimsItemExists(string message) : base(message)
        {
        }

        public SimsItemExists(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SimsItemExists(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
