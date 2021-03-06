using System;
using System.Runtime.Serialization;

namespace View
{
    [Serializable]
    internal class SystemOperationException : Exception
    {
        private object error;

        public SystemOperationException()
        {
        }

        public SystemOperationException(object error)
        {
            this.error = error;
        }

        public SystemOperationException(string message) : base(message)
        {
        }

        public SystemOperationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SystemOperationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}