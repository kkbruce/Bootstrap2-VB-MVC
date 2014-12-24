@ModelType MvcSiteMapProvider.Web.Html.Models.SiteMapPathHelperModel
@Imports System.Web.Mvc.Html
@Imports System.Linq
@Imports MvcSiteMapProvider.Web.Html.Models

@For Each node In Model
    @Html.DisplayFor(Function(m) node)

    @If node IsNot Model.Last() Then
            @<text> &gt; </text>
    End If
Next