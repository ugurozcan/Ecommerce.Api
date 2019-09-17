using ReflectionIT.Mvc.Paging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Streetwood.Core.Dto
{
    public class GenericListWithPagingResponseModel<T> where T : class
    {
        public int Limit { get; set; }

        public int Offset { get; set; }

        public int Count { get; set; }

        public IPagingList<T> Data;
    }
}
