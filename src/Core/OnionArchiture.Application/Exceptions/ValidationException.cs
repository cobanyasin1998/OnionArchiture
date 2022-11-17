using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchiture.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException() : this("Validation Error Occured")
        {

        }
        public ValidationException(String msg) : base(msg)
        {

        }

        public ValidationException(Exception exp) : this(exp.Message)
        {

        }
    }
}
