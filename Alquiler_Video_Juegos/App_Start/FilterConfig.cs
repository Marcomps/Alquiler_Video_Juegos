using System.Web;
using System.Web.Mvc;

namespace Alquiler_Video_Juegos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
