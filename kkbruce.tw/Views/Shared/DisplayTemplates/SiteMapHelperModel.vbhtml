@ModelType MvcSiteMapProvider.Web.Html.Models.SiteMapHelperModel
@Imports System.Web.Mvc.Html
@Imports MvcSiteMapProvider.Web.Html.Models

<ul class="sitemap">
    @For Each node In Model.Nodes
        @<li>
            @Html.DisplayFor(Function(m) node)
            @If node.Children.Any() Then
                Html.DisplayFor(Function(m) node.Children)
            End If
         </li>
    Next
</ul>