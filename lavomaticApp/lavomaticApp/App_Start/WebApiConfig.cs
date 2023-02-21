using System.Web.Http;
using System.Web.Http.OData.Builder;
using System.Web.Http.OData.Extensions;
using lavomaticApp.Dal;
using lavomaticApp.Dto;

namespace lavomaticApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Laundry>("Laundries");
            builder.EntitySet<Dryer>("Dryers");
            builder.EntitySet<LaundryExt>("LaundryExts");
            builder.EntitySet<Washer>("Washers");
            builder.EntitySet<DtoLaundry>("DtoLaundries");
            
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            
            config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
        }
    }
}
