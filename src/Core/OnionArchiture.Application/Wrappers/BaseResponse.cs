using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchiture.Application.Wrappers
{
    public class BaseResponse
    {
        public Guid Id { get; set; }
        public Boolean Success { get; set; }
        public String Message { get; set; }

    }
}
