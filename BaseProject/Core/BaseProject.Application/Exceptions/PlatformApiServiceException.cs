using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Application.Exceptions
{
    public class PlatformApiServiceException : Exception
    {
        public PlatformApiServiceException()
        {
        }

        public PlatformApiServiceException(string? message) : base(message)
        {
        }

        public PlatformApiServiceException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
