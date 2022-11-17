using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchiture.Application.Wrappers
{
  public  class ServiceResponse<T>
    {
        public T Value { get; set; }
        public ServiceResponse(T value)
        {
            Value = value;
        }
        public ServiceResponse()
        {

        }
    }
}
