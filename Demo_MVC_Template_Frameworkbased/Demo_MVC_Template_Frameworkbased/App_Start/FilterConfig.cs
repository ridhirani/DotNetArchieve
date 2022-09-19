using System.Web;
using System.Web.Mvc;

namespace Demo_MVC_Template_Frameworkbased
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
