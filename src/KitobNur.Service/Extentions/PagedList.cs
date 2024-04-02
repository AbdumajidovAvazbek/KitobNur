using KitobNur.Service.Configurations;

namespace KitobNur.Service.Extensions
{
    public class PagedList<T>
    {
        public List<T> Items { get; set; }
        public int TotalCount { get; set; }
        public PaginationMetaData MetaData { get; set; }

        public PagedList(List<T> items, int totalCount, PaginationParams @params)
        {
            Items = items;
            TotalCount = totalCount;
            MetaData = new PaginationMetaData(totalCount, @params);
        }
    }
}
