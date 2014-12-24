@ModelType MvcSiteMapProvider.Web.Html.Models.SiteMapNodeModel
@Imports System.Web.Mvc.Html
@Imports MvcSiteMapProvider.Web.Html.Models

@If Model.IsCurrentNode AndAlso Model.SourceMetadata("HtmlHelper").ToString() <> "MvcSiteMapProvider.Web.Html.MenuHelper" Then
    @<text>@Model.Title</text>
ElseIf Model.IsClickable Then
    @<a href="@Model.Url">@Model.Title</a>
Else
    @<text>@Model.Title</text>    
End If