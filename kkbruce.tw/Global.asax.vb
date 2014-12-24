' 注意: 如需啟用 IIS6 或 IIS7 傳統模式的說明，
' 請造訪 http://go.microsoft.com/?LinkId=9394802
Imports System.Web.Http
Imports System.Web.Optimization

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Sub Application_Start()
        AreaRegistration.RegisterAllAreas()

        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)



        MvcHandler.DisableMvcResponseHeader = True
        ViewEngines.Engines.Clear()
        ViewEngines.Engines.Add(New RazorViewEngine)
    End Sub
End Class
