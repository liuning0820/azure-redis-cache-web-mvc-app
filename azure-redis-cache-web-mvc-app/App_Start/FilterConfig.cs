using System.Web;
using System.Web.Mvc;

namespace azure_redis_cache_web_mvc_app
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
