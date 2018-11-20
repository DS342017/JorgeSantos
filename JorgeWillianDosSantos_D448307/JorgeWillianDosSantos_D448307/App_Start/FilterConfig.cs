using System.Web;
using System.Web.Mvc;

namespace JorgeWillianDosSantos_D448307
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
