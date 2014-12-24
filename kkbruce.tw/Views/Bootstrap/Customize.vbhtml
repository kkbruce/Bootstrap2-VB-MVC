﻿@Code
    ViewData("Title") = "客製化"
    ViewData("Description") = "可自定 Bootstrap 變數、元件、JavaScript外掛或其他設置之後，下載客製化的 Bootstrap 程式碼。"
    ViewData("Keywords") = "Bootstrap Customize, 自定變數, 自定元件, 自定JavaScript外掛"
End Code

@section navbar
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
                <nav class="nav-collapse collapse">
                    <ul class="nav">
                        <li class="">
                            @Html.ActionLink("首頁", "Index")
                        </li>
                        <li class="">
                            @Html.ActionLink("旅程開始", "GettingStarted")
                        </li>
                        <li class="">
                            @Html.ActionLink("架構", "Scaffolding")
                        </li>
                        <li class="">
                            @Html.ActionLink("基礎CSS", "BaseCSS")
                        </li>
                        <li class="">
                            @Html.ActionLink("元件", "Components")
                        </li>
                        <li class="">
                            @Html.ActionLink("JavaScript", "JavaScript")
                        </li>
                        <li class="active">
                            @Html.ActionLink("客製化", "Customize")
                        </li>
                    </ul>
                </nav>
            </div>
        </div>
    </div>
End Section

<header class="jumbotron subhead" id="overview">
    <div class="container">
        <h1>客製化與下載</h1>
        <p class="lead"><a href="https://github.com/twitter/bootstrap/zipball/master">下載 Bootstrap</a> 或自定變數、元件、 JavaScript 外掛或其他。</p>
    </div>
</header>


<div class="container">

    <!-- Docs nav
    ================================================== -->
    <div class="row">
        <nav class="span3 bs-docs-sidebar">
            <ul class="nav nav-list bs-docs-sidenav">
                <li><a href="#components"><i class="icon-chevron-right"></i>1. 選擇元件</a></li>
                <li><a href="#plugins"><i class="icon-chevron-right"></i>2. 選擇 jQuery 外掛</a></li>
                <li><a href="#variables"><i class="icon-chevron-right"></i>3. 自定變數</a></li>
                <li><a href="#download"><i class="icon-chevron-right"></i>4. 下載</a></li>
            </ul>
        </nav>
        <div class="span9">
            <nav>
                目前位置：@Html.MvcSiteMap().SiteMapPath()
            </nav>

            <!-- Customize form
            ================================================== -->
            <form>
                <section class="download" id="components">
                    <div class="page-header">
                        <a class="btn btn-small pull-right toggle-all" href="#">Toggle all</a>
                        <h1>1. 選擇元件
                        </h1>
                    </div>
                    <div class="row download-builder">
                        <div class="span3">
                            <h3>架構</h3>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="reset.less">
                                Normalize and reset</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="scaffolding.less">
                                Body type and links</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="grid.less">
                                Grid system</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="layouts.less">
                                Layouts</label>
                            <h3>基礎 CSS</h3>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="type.less">
                                Headings, body, etc</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="code.less">
                                Code and pre</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="labels-badges.less">
                                Labels and badges</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="tables.less">
                                Tables</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="forms.less">
                                Forms</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="buttons.less">
                                Buttons</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="sprites.less">
                                Icons</label>
                        </div>
                        <!-- /span -->
                        <div class="span3">
                            <h3>元件</h3>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="button-groups.less">
                                Button groups and dropdowns</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="navs.less">
                                Navs, tabs, and pills</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="navbar.less">
                                Navbar</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="breadcrumbs.less">
                                Breadcrumbs</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="pagination.less">
                                Pagination</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="pager.less">
                                Pager</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="thumbnails.less">
                                Thumbnails</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="alerts.less">
                                Alerts</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="progress-bars.less">
                                Progress bars</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="hero-unit.less">
                                Hero unit</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="media.less">
                                Media component</label>
                            <h3>JS 元件</h3>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="tooltip.less">
                                Tooltips</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="popovers.less">
                                Popovers</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="modals.less">
                                Modals</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="dropdowns.less">
                                Dropdowns</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="accordion.less">
                                Collapse</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="carousel.less">
                                Carousel</label>
                        </div>
                        <!-- /span -->
                        <div class="span3">
                            <h3>其他</h3>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="wells.less">
                                Wells</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="close.less">
                                Close icon</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="utilities.less">
                                Utilities</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="component-animations.less">
                                Component animations</label>
                            <h3>嚮應式</h3>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="responsive-utilities.less">
                                Visible/hidden classes</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="responsive-767px-max.less">
                                Narrow tablets and below (<767px)</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="responsive-768px-979px.less">
                                Tablets to desktops (767-979px)</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="responsive-1200px-min.less">
                                Large desktops (>1200px)</label>
                            <label class="checkbox">
                                <input checked="checked" type="checkbox" value="responsive-navbar.less">
                                Responsive navbar</label>
                        </div>
                        <!-- /span -->
                    </div>
                    <!-- /row -->
                </section>

                <section class="download" id="plugins">
                    <div class="page-header">
                        <a class="btn btn-small pull-right toggle-all" href="#">Toggle all</a>
                        <h1>2. 選擇 jQuery 外掛
                        </h1>
                    </div>
                    <div class="row download-builder">
                        <div class="span3">
                            <label class="checkbox">
                                <input type="checkbox" checked="true" value="bootstrap-transition.js">
                                Transitions <small>(所有動畫都需要它)</small>
                            </label>
                            <label class="checkbox">
                                <input type="checkbox" checked="true" value="bootstrap-modal.js">
                                Modals
                            </label>
                            <label class="checkbox">
                                <input type="checkbox" checked="true" value="bootstrap-dropdown.js">
                                Dropdowns
                            </label>
                            <label class="checkbox">
                                <input type="checkbox" checked="true" value="bootstrap-scrollspy.js">
                                Scrollspy
                            </label>
                            <label class="checkbox">
                                <input type="checkbox" checked="true" value="bootstrap-tab.js">
                                Togglable tabs
                            </label>
                            <label class="checkbox">
                                <input type="checkbox" checked="true" value="bootstrap-tooltip.js">
                                Tooltips
                            </label>
                            <label class="checkbox">
                                <input type="checkbox" checked="true" value="bootstrap-popover.js">
                                Popovers <small>(相依於 Tooltips)</small>
                            </label>
                        </div>
                        <!-- /span -->
                        <div class="span3">
                            <label class="checkbox">
                                <input type="checkbox" checked="true" value="bootstrap-affix.js">
                                Affix
                            </label>
                            <label class="checkbox">
                                <input type="checkbox" checked="true" value="bootstrap-alert.js">
                                Alert messages
                            </label>
                            <label class="checkbox">
                                <input type="checkbox" checked="true" value="bootstrap-button.js">
                                Buttons
                            </label>
                            <label class="checkbox">
                                <input type="checkbox" checked="true" value="bootstrap-collapse.js">
                                Collapse
                            </label>
                            <label class="checkbox">
                                <input type="checkbox" checked="true" value="bootstrap-carousel.js">
                                Carousel
                            </label>
                            <label class="checkbox">
                                <input type="checkbox" checked="true" value="bootstrap-typeahead.js">
                                Typeahead
                            </label>
                        </div>
                        <!-- /span -->
                        <div class="span3">
                            <h4 class="muted">注意！</h4>
                            <p class="muted">當勾選全部的外掛時，會產生單一的 bootstrap.js 檔案。任何的外掛都需要包含與引用最新版本的 <a href="http://jquery.com/" target="_blank">jQuery</a>。</p>
                        </div>
                        <!-- /span -->
                    </div>
                    <!-- /row -->
                </section>

                <section class="download" id="variables">
                    <div class="page-header">
                        <a class="btn btn-small pull-right toggle-all" href="#">Reset to defaults</a>
                        <h1>3. 自定變數
                        </h1>
                    </div>
                    <div class="row download-builder">
                        <div class="span3">
                            <h3>架構</h3>
                            <label>@@bodyBackground</label>
                            <input type="text" class="span3" placeholder="@("@white")">
                            <label>@@textColor</label>
                            <input type="text" class="span3" placeholder="@("@grayDark")">

                            <h3>連結</h3>
                            <label>@@linkColor</label>
                            <input type="text" class="span3" placeholder="#08c">
                            <label>@@linkColorHover</label>
                            <input type="text" class="span3" placeholder="darken(@("@linkColor"), 15%)">
                            <h3>顏色</h3>
                            <label>@@blue</label>
                            <input type="text" class="span3" placeholder="#049cdb">
                            <label>@@green</label>
                            <input type="text" class="span3" placeholder="#46a546">
                            <label>@@red</label>
                            <input type="text" class="span3" placeholder="#9d261d">
                            <label>@@yellow</label>
                            <input type="text" class="span3" placeholder="#ffc40d">
                            <label>@@orange</label>
                            <input type="text" class="span3" placeholder="#f89406">
                            <label>@@pink</label>
                            <input type="text" class="span3" placeholder="#c3325f">
                            <label>@@purple</label>
                            <input type="text" class="span3" placeholder="#7a43b6">

                            <h3>Sprites</h3>
                            <label>@@iconSpritePath</label>
                            <input type="text" class="span3" placeholder="'../img/glyphicons-halflings.png'">
                            <label>@@iconWhiteSpritePath</label>
                            <input type="text" class="span3" placeholder="'../img/glyphicons-halflings-white.png'">

                            <h3>網格系統</h3>
                            <label>@@gridColumns</label>
                            <input type="text" class="span3" placeholder="12">
                            <label>@@gridColumnWidth</label>
                            <input type="text" class="span3" placeholder="60px">
                            <label>@@gridGutterWidth</label>
                            <input type="text" class="span3" placeholder="20px">
                            <label>@@gridColumnWidth1200</label>
                            <input type="text" class="span3" placeholder="70px">
                            <label>@@gridGutterWidth1200</label>
                            <input type="text" class="span3" placeholder="30px">
                            <label>@@gridColumnWidth768</label>
                            <input type="text" class="span3" placeholder="42px">
                            <label>@@gridGutterWidth768</label>
                            <input type="text" class="span3" placeholder="20px">
                        </div>
                        <!-- /span -->
                        <div class="span3">

                            <h3>排版</h3>
                            <label>@@sansFontFamily</label>
                            <input type="text" class="span3" placeholder="'Helvetica Neue', Helvetica, Arial, sans-serif">
                            <label>@@serifFontFamily</label>
                            <input type="text" class="span3" placeholder="Georgia, 'Times New Roman', Times, serif">
                            <label>@@monoFontFamily</label>
                            <input type="text" class="span3" placeholder="Menlo, Monaco, 'Courier New', monospace">

                            <label>@@baseFontSize</label>
                            <input type="text" class="span3" placeholder="14px">
                            <label>@@baseFontFamily</label>
                            <input type="text" class="span3" placeholder="@("@sansFontFamily")">
                            <label>@@baseLineHeight</label>
                            <input type="text" class="span3" placeholder="20px">

                            <label>@@altFontFamily</label>
                            <input type="text" class="span3" placeholder="@("@serifFontFamily")">
                            <label>@@headingsFontFamily</label>
                            <input type="text" class="span3" placeholder="inherit">
                            <label>@@headingsFontWeight</label>
                            <input type="text" class="span3" placeholder="bold">
                            <label>@@headingsColor</label>
                            <input type="text" class="span3" placeholder="inherit">

                            <label>@@fontSizeLarge</label>
                            <input type="text" class="span3" placeholder="@("@baseFontSize") * 1.25">
                            <label>@@fontSizeSmall</label>
                            <input type="text" class="span3" placeholder="@("@baseFontSize") * 0.85">
                            <label>@@fontSizeMini</label>
                            <input type="text" class="span3" placeholder="@("@baseFontSize") * 0.75">

                            <label>@@paddingLarge</label>
                            <input type="text" class="span3" placeholder="11px 19px">
                            <label>@@paddingSmall</label>
                            <input type="text" class="span3" placeholder="2px 10px">
                            <label>@@paddingMini</label>
                            <input type="text" class="span3" placeholder="1px 6px">

                            <label>@@baseBorderRadius</label>
                            <input type="text" class="span3" placeholder="4px">
                            <label>@@borderRadiusLarge</label>
                            <input type="text" class="span3" placeholder="6px">
                            <label>@@borderRadiusSmall</label>
                            <input type="text" class="span3" placeholder="3px">

                            <label>@@heroUnitBackground</label>
                            <input type="text" class="span3" placeholder="@("@grayLighter")">
                            <label>@@heroUnitHeadingColor</label>
                            <input type="text" class="span3" placeholder="inherit">
                            <label>@@heroUnitLeadColor</label>
                            <input type="text" class="span3" placeholder="inherit">

                            <h3>表格</h3>
                            <label>@@tableBackground</label>
                            <input type="text" class="span3" placeholder="transparent">
                            <label>@@tableBackgroundAccent</label>
                            <input type="text" class="span3" placeholder="#f9f9f9">
                            <label>@@tableBackgroundHover</label>
                            <input type="text" class="span3" placeholder="#f5f5f5">
                            <label>@@tableBorder</label>
                            <input type="text" class="span3" placeholder="#ddd">

                            <h3>表單</h3>
                            <label>@@placeholderText</label>
                            <input type="text" class="span3" placeholder="@("@grayLight")">
                            <label>@@inputBackground</label>
                            <input type="text" class="span3" placeholder="@("@white")">
                            <label>@@inputBorder</label>
                            <input type="text" class="span3" placeholder="#ccc">
                            <label>@@inputBorderRadius</label>
                            <input type="text" class="span3" placeholder="3px">
                            <label>@@inputDisabledBackground</label>
                            <input type="text" class="span3" placeholder="@("@grayLighter")">
                            <label>@@formActionsBackground</label>
                            <input type="text" class="span3" placeholder="#f5f5f5">
                            <label>@@btnPrimaryBackground</label>
                            <input type="text" class="span3" placeholder="@("@linkColor")">
                            <label>@@btnPrimaryBackgroundHighlight</label>
                            <input type="text" class="span3" placeholder="darken(@("@white"), 10%)">
                        </div>
                        <!-- /span -->
                        <div class="span3">

                            <h3>表單狀態 &amp; 警告</h3>
                            <label>@@warningText</label>
                            <input type="text" class="span3" placeholder="#c09853">
                            <label>@@warningBackground</label>
                            <input type="text" class="span3" placeholder="#fcf8e3">
                            <label>@@errorText</label>
                            <input type="text" class="span3" placeholder="#b94a48">
                            <label>@@errorBackground</label>
                            <input type="text" class="span3" placeholder="#f2dede">
                            <label>@@successText</label>
                            <input type="text" class="span3" placeholder="#468847">
                            <label>@@successBackground</label>
                            <input type="text" class="span3" placeholder="#dff0d8">
                            <label>@@infoText</label>
                            <input type="text" class="span3" placeholder="#3a87ad">
                            <label>@@infoBackground</label>
                            <input type="text" class="span3" placeholder="#d9edf7">

                            <h3>巡覽列</h3>
                            <label>@@navbarHeight</label>
                            <input type="text" class="span3" placeholder="40px">
                            <label>@@navbarBackground</label>
                            <input type="text" class="span3" placeholder="@("@grayDarker")">
                            <label>@@navbarBackgroundHighlight</label>
                            <input type="text" class="span3" placeholder="@("@grayDark")">
                            <label>@@navbarText</label>
                            <input type="text" class="span3" placeholder="@("@grayLight")">
                            <label>@@navbarBrandColor</label>
                            <input type="text" class="span3" placeholder="@("@navbarLinkColor")">
                            <label>@@navbarLinkColor</label>
                            <input type="text" class="span3" placeholder="@("@grayLight")">
                            <label>@@navbarLinkColorHover</label>
                            <input type="text" class="span3" placeholder="@("@white")">
                            <label>@@navbarLinkColorActive</label>
                            <input type="text" class="span3" placeholder="@("@navbarLinkColorHover")">
                            <label>@@navbarLinkBackgroundHover</label>
                            <input type="text" class="span3" placeholder="transparent">
                            <label>@@navbarLinkBackgroundActive</label>
                            <input type="text" class="span3" placeholder="@("@navbarBackground")">
                            <label>@@navbarSearchBackground</label>
                            <input type="text" class="span3" placeholder="lighten(@("@navbarBackground"), 25%)">
                            <label>@@navbarSearchBackgroundFocus</label>
                            <input type="text" class="span3" placeholder="@("@white")">
                            <label>@@navbarSearchBorder</label>
                            <input type="text" class="span3" placeholder="darken(@("@navbarSearchBackground"), 30%)">
                            <label>@@navbarSearchPlaceholderColor</label>
                            <input type="text" class="span3" placeholder="#ccc">

                            <label>@@navbarCollapseWidth</label>
                            <input type="text" class="span3" placeholder="979px">
                            <label>@@navbarCollapseDesktopWidth</label>
                            <input type="text" class="span3" placeholder="@("@navbarCollapseWidth") + 1">

                            <h3>下拉式選單</h3>
                            <label>@@dropdownBackground</label>
                            <input type="text" class="span3" placeholder="@("@white")">
                            <label>@@dropdownBorder</label>
                            <input type="text" class="span3" placeholder="rgba(0,0,0,.2)">
                            <label>@@dropdownLinkColor</label>
                            <input type="text" class="span3" placeholder="@("@grayDark")">
                            <label>@@dropdownLinkColorHover</label>
                            <input type="text" class="span3" placeholder="@("@white")">
                            <label>@@dropdownLinkBackgroundHover</label>
                            <input type="text" class="span3" placeholder="@("@linkColor")">
                        </div>
                        <!-- /span -->
                    </div>
                    <!-- /row -->
                </section>

                <section class="download" id="download">
                    <div class="page-header">
                        <h1>4. 下載
                        </h1>
                    </div>
                    <div class="download-btn">
                        <a class="btn btn-primary" href="#">客製化與下載</a>
                        <h4>包含什麼？</h4>
                        <p>下載內容包含完整的 CSS、最小化 CSS、完整的 jQuery 外掛等且很方便的為你壓縮在一起。</p>
                    </div>
                </section>
                <!-- /download -->
            </form>
        </div>
    </div>
</div>

