using ReflectionIT.Mvc.Paging;

namespace Streetwood.Infrastructure.Dto
{
    public class GenericListWithPagingDto<T> where T : class
    {
        public int Limit { get; set; }

        public int Offset { get; set; }

        public int Count { get; set; }

        public IPagingList<T> Data;
    }
}
