Imports System.Web.Mvc
Imports System.Web.Routing

Public Class RouteConfig
    Public Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

        ' Route for Home page
        routes.MapRoute(
            name:="Home",
            url:="",
            defaults:=New With {.controller = "Home", .action = "Index"}
        )

        ' Route for About page
        routes.MapRoute(
            name:="About",
            url:="About",
            defaults:=New With {.controller = "Home", .action = "About"}
        )

        ' Route for Contact page
        routes.MapRoute(
            name:="Contact",
            url:="Contact",
            defaults:=New With {.controller = "Home", .action = "Contact"}
        )

        ' Default route
        routes.MapRoute(
            name:="Default",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional}
        )
    End Sub
End Class
