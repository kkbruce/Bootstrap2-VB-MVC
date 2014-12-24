Imports System.Web
Imports System.Web.Optimization

Public Class BundleConfig
    ' 如需 Bundling 的詳細資訊，請造訪 http://go.microsoft.com/fwlink/?LinkId=254725
    Public Shared Sub RegisterBundles(ByVal bundles As BundleCollection)
        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                   "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryui").Include(
                    "~/Scripts/jquery-ui-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.unobtrusive*",
                    "~/Scripts/jquery.validate*"))

        ' 使用開發版本的 Modernizr 進行開發並學習。然後，當您
        ' 準備好實際執行時，請使用 http://modernizr.com 上的建置工具，只選擇您需要的測試。
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New StyleBundle("~/Content/css").Include("~/Content/site.css"))

        bundles.Add(New StyleBundle("~/Content/themes/base/css").Include(
                    "~/Content/themes/base/jquery.ui.core.css",
                    "~/Content/themes/base/jquery.ui.resizable.css",
                    "~/Content/themes/base/jquery.ui.selectable.css",
                    "~/Content/themes/base/jquery.ui.accordion.css",
                    "~/Content/themes/base/jquery.ui.autocomplete.css",
                    "~/Content/themes/base/jquery.ui.button.css",
                    "~/Content/themes/base/jquery.ui.dialog.css",
                    "~/Content/themes/base/jquery.ui.slider.css",
                    "~/Content/themes/base/jquery.ui.tabs.css",
                    "~/Content/themes/base/jquery.ui.datepicker.css",
                    "~/Content/themes/base/jquery.ui.progressbar.css",
                    "~/Content/themes/base/jquery.ui.theme.css"))

        ' Bootstrap 設置
        bundles.Add(New StyleBundle("~/Content/bootstrap/css").Include(
                    "~/Content/bootstrap/bootstrap.css",
                    "~/Content/bootstrap/bootstrap-responsive.css",
                    "~/Content/bootstrap/docs.css",
                    "~/Scripts/bootstrap/google-code-prettify/prettify.css"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrapSourceJS").Include(
                    "~/Scripts/bootstrap/jquery.js",
                    "~/Scripts/bootstrap/bootstrap-transition.js",
                    "~/Scripts/bootstrap/bootstrap-alert.js",
                    "~/Scripts/bootstrap/bootstrap-modal.js",
                    "~/Scripts/bootstrap/bootstrap-dropdown.js",
                    "~/Scripts/bootstrap/bootstrap-scrollspy.js",
                    "~/Scripts/bootstrap/bootstrap-tab.js",
                    "~/Scripts/bootstrap/bootstrap-tooltip.js",
                    "~/Scripts/bootstrap/bootstrap-popover.js",
                    "~/Scripts/bootstrap/bootstrap-button.js",
                    "~/Scripts/bootstrap/bootstrap-collapse.js",
                    "~/Scripts/bootstrap/bootstrap-carousel.js",
                    "~/Scripts/bootstrap/bootstrap-typeahead.js"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                    "~/Scripts/bootstrap/bootstrap.js",
                    "~/Scripts/bootstrap/holder/holder.js",
                    "~/Scripts/bootstrap/google-code-prettify/prettify.js",
                    "~/Scripts/bootstrap/application.js"))

        ' Online jQuery
        'BundleTable.EnableOptimizations = True
        bundles.UseCdn = True
        Dim jqCdnPath As String = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.0.2.min.js"
        'Dim jqCdnPath2 As String = "http://ajax.googleapis.com/ajax/libs/jquery/2.0.0/jquery.min.js"
        bundles.Add(New ScriptBundle("~/bundles/jqueryonline", jqCdnPath).Include(
                    "~/Scripts/jquery-{version}.js"))
    End Sub
End Class