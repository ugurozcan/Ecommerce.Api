using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Streetwood.Core.Dto
{
    public class GenericListWithPagingRequestModel
    {
        [Range(1, 10000)]
        private int limit = 50;

        public int Limit
        {
            get { return limit; }
            set { limit = value; }
        }

        private int offset = 1;

        public int Offset
        {
            get { return offset; }
            set { offset = value; }
        }

        private string orderField = "Id";

        public string OrderField
        {
            get { return orderField; }
            set { orderField = value; }
        }

        public string OrderType { get; set; }
    }
}
