using System;
using System.Runtime.Serialization;

namespace Composite.Sample
{
    [Serializable]
    internal class FileTreatmebtException : Exception
    {
        public FileTreatmebtException()
        {
        }

        public FileTreatmebtException(string message) : base(message)
        {
        }

        public FileTreatmebtException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FileTreatmebtException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}