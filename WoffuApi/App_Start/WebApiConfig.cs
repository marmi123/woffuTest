﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WoffuApi.Filters;


namespace WoffuApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Filters.Add(new BasicAuthenticationAttribute());
        }
    }
}
