using System;
using System.Net;

namespace Unsplash.Client
{
    class ApiException : Exception
    {
        public ApiException(HttpStatusCode statusCode, string message) : this(statusCode, message, null)
        {
        }

        public ApiException(HttpStatusCode statusCode, string message, Exception innerException) : base(message, innerException)
        {
            Data.Add("StatusCode", statusCode);
        }
    }
}
