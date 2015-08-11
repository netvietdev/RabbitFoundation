using System.Linq;
using System.Web.Mvc;

namespace Rabbit.Web.Mvc.Filters
{
    public static class GlobalFilterCollectionExtensions
    {
        public static void AddFilters(this GlobalFilterCollection filterCollection, params FilterAttribute[] filters)
        {
            filterCollection.AddFilters(0, filters);
        }

        public static void AddFilters(this GlobalFilterCollection filterCollection, int baseOrder, params FilterAttribute[] filters)
        {
            var orderStartsFrom = baseOrder;

            filters.ToList().ForEach(filter =>
            {
                filter.Order = orderStartsFrom++;
                filterCollection.Add(filter);
            });
        }
    }
}
