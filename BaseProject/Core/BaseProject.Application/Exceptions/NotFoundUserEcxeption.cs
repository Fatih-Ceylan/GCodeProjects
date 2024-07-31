using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Application.Exceptions
{
    public class NotFoundUserEcxeption : Exception
    {
        public NotFoundUserEcxeption() : base("User not found!")
        {
        }

        public NotFoundUserEcxeption(string? message) : base(message)
        {
        }

        public NotFoundUserEcxeption(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
