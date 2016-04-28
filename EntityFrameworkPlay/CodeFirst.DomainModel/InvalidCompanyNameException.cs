using System;
using System.Runtime.Serialization;

namespace Vituha.Play.EntityFramework.CodeFirst
{
    [Serializable]
    public class InvalidCompanyNameException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public InvalidCompanyNameException()
        {
        }

        public InvalidCompanyNameException(string message) : base(message)
        {
        }

        public InvalidCompanyNameException(string message, Exception inner) : base(message, inner)
        {
        }

        protected InvalidCompanyNameException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}