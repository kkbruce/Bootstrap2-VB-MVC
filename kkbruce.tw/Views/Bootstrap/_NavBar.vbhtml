<!-- Navbar
    ================================================== -->
<div class="navbar navbar-inverse navbar-fixed-top">
    <div class="navbar-inner">
        <div class="container">
            <button type="button" class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse">
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            @Html.ActionLink("Bootstrap 2中文教學", "Index", Nothing, New With {.class = "brand"})
            @Code
                Dim ActionName As String = ViewContext.RouteData.Values("Action").ToString()
            End Code
            <nav class="nav-collapse collapse">
                <ul class="nav">
                    @If ActionName = "Index" Then
                        @<text><li class="active"></text>
                    Else
                        @<text><li class=""></text>
                    End If                    
                        @Html.ActionLink("首頁", "Index")
                    </li>
                    @If ActionName = "GettingStarted" Then
                        @<text><li class="active"></text>
                    Else
                        @<text><li class=""></text>
                    End If
                    @Html.ActionLink("旅程開始", "GettingStarted")
                    </li>
                    @If ActionName = "Scaffolding" Then
                        @<text><li class="active"></text>
                    Else
                        @<text><li class=""></text>
                    End If
                        @Html.ActionLink("架構", "Scaffolding")
                    </li>
                    @If ActionName = "BaseCSS" Then
                        @<text><li class="active"></text>
                    Else
                        @<text><li class=""></text>
                    End If
                        @Html.ActionLink("基礎CSS", "BaseCSS")
                    </li>
                    @If ActionName = "Components" Then
                        @<text><li class="active"></text>
                    Else
                        @<text><li class=""></text>
                    End If
                        @Html.ActionLink("元件", "Components")
                    </li>
                    @If ActionName = "JavaScript" Then
                        @<text><li class="active"></text>
                    Else
                        @<text><li class=""></text>
                    End If
                        @Html.ActionLink("JavaScript", "JavaScript")
                    </li>
                    @If ActionName = "Customize" Then
                        @<text><li class="active"></text>
                    Else
                        @<text><li class=""></text>
                    End If
                        @Html.ActionLink("客製化", "Customize")
                    </li>
                </ul>
            </nav>
        </div>
    </div>
</div>
