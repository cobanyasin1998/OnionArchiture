using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchiture.Application.Wrappers
{
    public class PageResponse<T> : ServiceResponse<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public PageResponse(T value) : base(value)
        {

        }
        public PageResponse()
        {
            PageNumber = 1;
            PageSize = 1;
        }
        public PageResponse(T value,int pageNumber, int pageSize):base(value)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;

        }
      
    }
}
