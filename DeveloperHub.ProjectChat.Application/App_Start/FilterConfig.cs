using System.Web;
using System.Web.Mvc;

namespace DeveloperHub.ProjectChat.Application
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
