using System.Web.Http;
using System.Web.Routing;

namespace lavomaticApp
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RegisterRoutes(RouteTable.Routes);
        }

        protected void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("Index", "", "~/map.html");
        }
    }
}
