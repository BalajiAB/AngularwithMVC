using System.Web;
using System.Web.Mvc;

namespace Angular_Save_ngroute
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}