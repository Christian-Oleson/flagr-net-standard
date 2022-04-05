using System;
using System.Runtime.Serialization;

namespace Flagr.Api.Exceptions
{
    /// <summary>
    /// Flagr API Factory Initialization Exceptions
    /// </summary>
    public class FlagrApiInitializationException : Exception
    {
        /// <summary>
        /// Base exception type - empty constructor.
        /// </summary>
        public FlagrApiInitializationException() : base()
        {
        }

        /// <summary>
        /// Base exception type - string in constructor.
        /// </summary>
        public FlagrApiInitializationException(string message) : base(message)
        {
        }

        /// <summary>
        /// Base exception type - string and inner exception constructor.
        /// </summary>
        public FlagrApiInitializationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Serializable exception for child exceptions
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected FlagrApiInitializationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        /// <summary>
        /// Get Object Data from the Serialization info and streaming context for child exceptions.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException(nameof(info));
            }

            base.GetObjectData(info, context);
        }
    }
}
