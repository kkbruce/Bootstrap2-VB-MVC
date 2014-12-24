@ModelType MvcSiteMapProvider.Web.Html.Models.SiteMapNodeModelList
@Imports System.Web.Mvc.Html
@Imports MvcSiteMapProvider.Web.Html.Models

<ul>
    @For Each node In Model
        @<li>
            @Html.DisplayFor(Function(m) node)
            @If node.Children.Any() Then
                @Html.DisplayFor(Function(m) node.Children)
            End If
         </li>
    Next
</ul>