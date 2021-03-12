using System.Web;
using System.Web.Mvc;

namespace _5951071031_Ha_Nhat_Huy
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
