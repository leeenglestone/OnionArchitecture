using System.Web;
using System.Web.Mvc;

namespace PetStore.Web.WebApiApplication
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
