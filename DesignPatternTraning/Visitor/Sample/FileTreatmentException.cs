using System;
using System.Runtime.Serialization;

namespace Visitor.Sample
{
    [Serializable]
    public class FileTreatmentException : Exception
    {
        public FileTreatmentException()
        {
        }

        public FileTreatmentException(string message) : base(message)
        {
        }

        public FileTreatmentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FileTreatmentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}