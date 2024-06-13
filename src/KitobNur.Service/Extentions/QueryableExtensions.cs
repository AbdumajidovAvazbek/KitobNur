using System;
using System.Linq;
using System.Threading.Tasks;
using KitobNur.Service.Configurations;
using Microsoft.EntityFrameworkCore;

namespace KitobNur.Service.Extensions
{
    public static class QueryableExtensions
    {
        public static async Task<PagedList<T>> ToPagedList<T, TKey>(this IQueryable<T> query, PaginationParams @params)
        {
            var totalCount = await query.CountAsync();
            var items = await query.Skip((@params.PageIndex - 1) * @params.PageSize)
                                   .Take(@params.PageSize)
                                   .ToListAsync();

            return new PagedList<T>(items, totalCount, @params);
        }
    }
}
