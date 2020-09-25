using System;
using System.Runtime.Serialization;

namespace Sims.Application.Exceptions
{
    public class SimsItemMissing : SIMSException
    {
        public SimsItemMissing()
        {
        }

        public SimsItemMissing(string message) : base(message)
        {
        }

        public SimsItemMissing(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SimsItemMissing(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
