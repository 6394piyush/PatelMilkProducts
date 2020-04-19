using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PatelMilkProducts
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Accounts", action = "Login", id = UrlParameter.Optional }
            );

            routes.MapRoute(
           "...",                                              // Route name
           "EmpAccounts/GetVillageMembers/{Vname}",                           // URL with parameters
           new { controller = "EmpAccounts", action = "GetVillageMembers", Vname = "" }  // Parameter defaults
       );
        }
    }
}
