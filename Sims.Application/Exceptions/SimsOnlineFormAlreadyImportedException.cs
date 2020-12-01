using System;
using System.Runtime.Serialization;

namespace Sims.Application.Exceptions
{
    public class SimsOnlineFormAlreadyImportedException : SIMSException
    {
        public SimsOnlineFormAlreadyImportedException()
        {
        }

        public SimsOnlineFormAlreadyImportedException(string message) : base(message)
        {
        }

        public SimsOnlineFormAlreadyImportedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SimsOnlineFormAlreadyImportedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
