﻿@Code
    ViewData("Title") = "元件"
    ViewData("Description") = "Bootstrap內建數十個可重覆使用的元件，含有下拉式選單、按鈕群組、下拉式按鈕、巡覽、巡覽列、麵包屑、分頁、標籤和徽章、排版、縮圖、警告、進度列、媒體物件和其他元件。"
    ViewData("Keywords") = "Bootstrap元件, 下拉式選單, 按鈕群組, 巡覽, 麵包屑, 分頁, 排版, 縮圖, 警告, 進度列"
End Code

@section navbar
    @Html.Partial("_NavBar")
End Section

<header class="jumbotron subhead" id="overview">
    <div class="container">
        <h1>元件</h1>
        <p class="lead">內建數十個可重覆使用的元件，包含巡覽、警告、彈出視窗…還有更多。</p>
    </div>
</header>


<div class="container">

    <!-- Docs nav
    ================================================== -->
    <div class="row">
        <nav class="span3 bs-docs-sidebar">
            <ul class="nav nav-list bs-docs-sidenav">
                <li><a href="#dropdowns"><i class="icon-chevron-right"></i> 下拉式選單</a></li>
                <li><a href="#buttonGroups"><i class="icon-chevron-right"></i> 按鈕群組</a></li>
                <li><a href="#buttonDropdowns"><i class="icon-chevron-right"></i> 下拉式按鈕</a></li>
                <li><a href="#navs"><i class="icon-chevron-right"></i> 巡覽</a></li>
                <li><a href="#navbar"><i class="icon-chevron-right"></i> 巡覽列</a></li>
                <li><a href="#breadcrumbs"><i class="icon-chevron-right"></i> 麵包屑</a></li>
                <li><a href="#pagination"><i class="icon-chevron-right"></i> 分頁</a></li>
                <li><a href="#labels-badges"><i class="icon-chevron-right"></i> 標籤和徽章</a></li>
                <li><a href="#typography"><i class="icon-chevron-right"></i> 排版</a></li>
                <li><a href="#thumbnails"><i class="icon-chevron-right"></i> 縮圖</a></li>
                <li><a href="#alerts"><i class="icon-chevron-right"></i> 警告</a></li>
                <li><a href="#progress"><i class="icon-chevron-right"></i> 進度列</a></li>
                <li><a href="#media"><i class="icon-chevron-right"></i> 媒體物件</a></li>
                <li><a href="#misc"><i class="icon-chevron-right"></i> <abbr title="miscellaneous">Misc</abbr></a></li>
            </ul>
        </nav>
        <div class="span9">
            <nav>
                目前位置：@Html.MvcSiteMap().SiteMapPath()
            </nav>

            <!-- Dropdowns
            ================================================== -->
            <section id="dropdowns">
                <div class="page-header">
                    <h1>下拉式選單</h1>
                </div>

                <h2>範例</h2>
                <p>可切換、有關聯性的連結清單。與 @Html.ActionLink("下拉選單 JavaScript 外掛", "JavaScript", Nothing, Nothing, Nothing, "dropdowns", Nothing, Nothing) 配合使用。</p>
                <div class="bs-docs-example">
                    <div class="dropdown clearfix">
                        <ul class="dropdown-menu" role="menu" aria-labelledby="dropdownMenu" style="display: block; position: static; margin-bottom: 5px; *width: 180px;">
                            <li><a tabindex="-1" href="#">Action</a></li>
                            <li><a tabindex="-1" href="#">Another action</a></li>
                            <li><a tabindex="-1" href="#">Something else here</a></li>
                            <li class="divider"></li>
                            <li><a tabindex="-1" href="#">Separated link</a></li>
                        </ul>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;ul class="dropdown-menu" role="menu" aria-labelledby="dropdownMenu"&gt;
  &lt;li&gt;&lt;a tabindex="-1" href="#"&gt;Action&lt;/a&gt;&lt;/li&gt;
  &lt;li&gt;&lt;a tabindex="-1" href="#"&gt;Another action&lt;/a&gt;&lt;/li&gt;
  &lt;li&gt;&lt;a tabindex="-1" href="#"&gt;Something else here&lt;/a&gt;&lt;/li&gt;
  &lt;li class="divider"&gt;&lt;/li&gt;
  &lt;li&gt;&lt;a tabindex="-1" href="#"&gt;Separated link&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
</pre>

                <h2>標記</h2>
                <p>以下是下拉式選單所需要 HTML。下拉式選單的觸發器和和整個下拉式選單都必須包含在 <code>.dropdown</code> 之中，或者宣告為 <code>position: relative;</code> 的其他頁面元素中，然後就能建立選單。</p>

                <pre class="prettyprint linenums">
&lt;div class="dropdown"&gt;
  &lt;!-- Link or button to toggle dropdown --&gt;
  &lt;ul class="dropdown-menu" role="menu" aria-labelledby="dLabel"&gt;
    &lt;li&gt;&lt;a tabindex="-1" href="#"&gt;Action&lt;/a&gt;&lt;/li&gt;
    &lt;li&gt;&lt;a tabindex="-1" href="#"&gt;Another action&lt;/a&gt;&lt;/li&gt;
    &lt;li&gt;&lt;a tabindex="-1" href="#"&gt;Something else here&lt;/a&gt;&lt;/li&gt;
    &lt;li class="divider"&gt;&lt;/li&gt;
    &lt;li&gt;&lt;a tabindex="-1" href="#"&gt;Separated link&lt;/a&gt;&lt;/li&gt;
  &lt;/ul&gt;
&lt;/div&gt;
</pre>

                <h2>選項</h2>
                <p>選單可以向右對齊，並可以加入第二層下拉式選單。</p>

                <h3>對齊選單</h3>
                <p>向 <code>.dropdown-menu</code> 類別再加入 <code>.pull-right</code> 即可向右對齊下拉式選單。</p>
                <pre class="prettyprint linenums">
&lt;ul class="dropdown-menu pull-right" role="menu" aria-labelledby="dLabel"&gt;
  ...
&lt;/ul&gt;
</pre>

                <h3>禁用選單選項</h3>
                <p>向 <code>&lt;li&gt;</code> 加入 <code>.disabled</code> 類別即可禁用選單中某個連結。</p>
                <div class="bs-docs-example">
                    <div class="dropdown clearfix">
                        <ul class="dropdown-menu" role="menu" aria-labelledby="dropdownMenu" style="display: block; position: static; margin-bottom: 5px; *width: 180px;">
                            <li><a tabindex="-1" href="#">Regular link</a></li>
                            <li class="disabled"><a tabindex="-1" href="#">Disabled link</a></li>
                            <li><a tabindex="-1" href="#">Another link</a></li>
                        </ul>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;ul class="dropdown-menu" role="menu" aria-labelledby="dropdownMenu"&gt;
  &lt;li&gt;&lt;a tabindex="-1" href="#"&gt;Regular link&lt;/a&gt;&lt;/li&gt;
  &lt;li class="disabled"&gt;&lt;a tabindex="-1" href="#"&gt;Disabled link&lt;/a&gt;&lt;/li&gt;
  &lt;li&gt;&lt;a tabindex="-1" href="#"&gt;Another link&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
</pre>

                <h3>第二層下拉式選單</h3>
                <p>透過加入一些簡單的標記，可以給下拉式選單加入第二層選單，這些選單會在滑鼠移至時自動呈現，就像 OS X 的效果一樣。在現有的下拉式選單中，給任意的 <code>li</code> 加入 <code>.dropdown-submenu</code> 類別可即自動給於第二層選單的樣式。</p>
                <div class="bs-docs-example bs-docs-example-submenus">

                    <div class="pull-left">
                        <p class="muted">預設樣式</p>
                        <div class="dropdown clearfix">
                            <ul class="dropdown-menu" role="menu" aria-labelledby="dropdownMenu">
                                <li><a tabindex="-1" href="#">Action</a></li>
                                <li><a tabindex="-1" href="#">Another action</a></li>
                                <li><a tabindex="-1" href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li class="dropdown-submenu">
                                    <a tabindex="-1" href="#">More options</a>
                                    <ul class="dropdown-menu">
                                        <li><a tabindex="-1" href="#">Second level link</a></li>
                                        <li><a tabindex="-1" href="#">Second level link</a></li>
                                        <li><a tabindex="-1" href="#">Second level link</a></li>
                                        <li><a tabindex="-1" href="#">Second level link</a></li>
                                        <li><a tabindex="-1" href="#">Second level link</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </div>
                    </div>

                    <div class="pull-left">
                        <p class="muted">向上子選單</p>
                        <div class="dropup">
                            <ul class="dropdown-menu" role="menu" aria-labelledby="dropdownMenu">
                                <li><a tabindex="-1" href="#">Action</a></li>
                                <li><a tabindex="-1" href="#">Another action</a></li>
                                <li><a tabindex="-1" href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li class="dropdown-submenu">
                                    <a tabindex="-1" href="#">More options</a>
                                    <ul class="dropdown-menu">
                                        <li><a tabindex="-1" href="#">Second level link</a></li>
                                        <li><a tabindex="-1" href="#">Second level link</a></li>
                                        <li><a tabindex="-1" href="#">Second level link</a></li>
                                        <li><a tabindex="-1" href="#">Second level link</a></li>
                                        <li><a tabindex="-1" href="#">Second level link</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </div>
                    </div>

                    <div class="pull-left">
                        <p class="muted">向左子選單</p>
                        <div class="dropdown">
                            <ul class="dropdown-menu" role="menu" aria-labelledby="dropdownMenu">
                                <li><a tabindex="-1" href="#">Action</a></li>
                                <li><a tabindex="-1" href="#">Another action</a></li>
                                <li><a tabindex="-1" href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li class="dropdown-submenu pull-left">
                                    <a tabindex="-1" href="#">More options</a>
                                    <ul class="dropdown-menu">
                                        <li><a tabindex="-1" href="#">Second level link</a></li>
                                        <li><a tabindex="-1" href="#">Second level link</a></li>
                                        <li><a tabindex="-1" href="#">Second level link</a></li>
                                        <li><a tabindex="-1" href="#">Second level link</a></li>
                                        <li><a tabindex="-1" href="#">Second level link</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </div>
                    </div>

                </div>
                <pre class="prettyprint linenums">
&lt;ul class="dropdown-menu" role="menu" aria-labelledby="dLabel"&gt;
  ...
  &lt;li class="dropdown-submenu"&gt;
    &lt;a tabindex="-1" href="#"&gt;More options&lt;/a&gt;
    &lt;ul class="dropdown-menu"&gt;
      ...
    &lt;/ul&gt;
  &lt;/li&gt;
&lt;/ul&gt;
</pre>

            </section>

            <!-- Button Groups
            ================================================== -->
            <section id="buttonGroups">
                <div class="page-header">
                    <h1>按鈕群組</h1>
                </div>

                <h2>範例</h2>
                <p>有兩個基本選項和其他更多變化類型。</p>

                <h3>單一按鈕群組</h3>
                <p>將一系列 <code>.btn</code>類別的按鈕包在 <code>.btn-gruop</code> 類別中。</p>
                <div class="bs-docs-example">
                    <div class="btn-group" style="margin: 9px 0 5px;">
                        <button class="btn">Left</button>
                        <button class="btn">Middle</button>
                        <button class="btn">Right</button>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="btn-group"&gt;
  &lt;button class="btn"&gt;Left&lt;/button&gt;
  &lt;button class="btn"&gt;Middle&lt;/button&gt;
  &lt;button class="btn"&gt;Right&lt;/button&gt;
&lt;/div&gt;
</pre>

                <h3>多按鈕群組</h3>
                <p>組合多個 <code>&lt;div class="btn-group"&gt;</code> 放入 <code>&lt;div class="btn-toolbar"&gt;</code> 之中，可取得更複雜的元件。</p>
                <div class="bs-docs-example">
                    <div class="btn-toolbar" style="margin: 0;">
                        <div class="btn-group">
                            <button class="btn">1</button>
                            <button class="btn">2</button>
                            <button class="btn">3</button>
                            <button class="btn">4</button>
                        </div>
                        <div class="btn-group">
                            <button class="btn">5</button>
                            <button class="btn">6</button>
                            <button class="btn">7</button>
                        </div>
                        <div class="btn-group">
                            <button class="btn">8</button>
                        </div>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="btn-toolbar"&gt;
  &lt;div class="btn-group"&gt;
    ...
  &lt;/div&gt;
&lt;/div&gt;
</pre>

                <h3>垂直按鈕群組</h3>
                <p>讓一組按鈕群組呈現垂直堆疊的樣式。</p>
                <div class="bs-docs-example">
                    <div class="btn-group btn-group-vertical">
                        <button type="button" class="btn"><i class="icon-align-left"></i></button>
                        <button type="button" class="btn"><i class="icon-align-center"></i></button>
                        <button type="button" class="btn"><i class="icon-align-right"></i></button>
                        <button type="button" class="btn"><i class="icon-align-justify"></i></button>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="btn-group btn-group-vertical"&gt;
  ...
&lt;/div&gt;
</pre>


                <hr class="bs-docs-separator">


                <h4>checkbox 和 radio 形式</h4>
                <p>按鈕群組也能當成 radio 之用（一次只有一個按鈕能被點選），或是當成 checkbox 之用（一次能有多個按鈕能被點選）。詳細請參考 @Html.ActionLink("JavaScript 外掛文件", "JavaScript", Nothing, Nothing, Nothing, "buttons", Nothing, Nothing)。</p>

                <h4>按鈕群組裡的下拉選單</h4>
                <p><span class="label label-info">注意！</span> 下拉式選單的按鈕必須單獨包在 <code>.btn-group</code> 中，然後才放入 <code>.btn-toolbar</code> 中，這樣才能與正確呈現。</p>
            </section>

            <!-- Split button dropdowns
            ================================================== -->
            <section id="buttonDropdowns">
                <div class="page-header">
                    <h1>按鈕議下拉式選單</h1>
                </div>


                <h2>概觀與範例</h2>
                <p>將按鈕放入 <code>.btn-group</code> 之中，並加入適當的選單標籤，即可讓按鈕觸發下拉式選單。</p>
                <div class="bs-docs-example">
                    <div class="btn-toolbar" style="margin: 0;">
                        <div class="btn-group">
                            <button class="btn dropdown-toggle" data-toggle="dropdown">Action <span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                        <div class="btn-group">
                            <button class="btn btn-primary dropdown-toggle" data-toggle="dropdown">Action <span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                        <div class="btn-group">
                            <button class="btn btn-danger dropdown-toggle" data-toggle="dropdown">Danger <span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                        <div class="btn-group">
                            <button class="btn btn-warning dropdown-toggle" data-toggle="dropdown">Warning <span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                        <div class="btn-group">
                            <button class="btn btn-success dropdown-toggle" data-toggle="dropdown">Success <span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                        <div class="btn-group">
                            <button class="btn btn-info dropdown-toggle" data-toggle="dropdown">Info <span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                        <div class="btn-group">
                            <button class="btn btn-inverse dropdown-toggle" data-toggle="dropdown">Inverse <span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                    </div>
                    <!-- /btn-toolbar -->
                </div>
                <pre class="prettyprint linenums">
&lt;div class="btn-group"&gt;
  &lt;a class="btn dropdown-toggle" data-toggle="dropdown" href="#"&gt;
    Action
    &lt;span class="caret"&gt;&lt;/span&gt;
  &lt;/a&gt;
  &lt;ul class="dropdown-menu"&gt;
    &lt;!-- dropdown menu links --&gt;
  &lt;/ul&gt;
&lt;/div&gt;
</pre>

                <h3>相容所有尺寸的按鈕</h3>
                <p>按鈕式下拉式選單能相容於所有尺寸：<code>.btn-large</code>、<code>.btn-small</code> 或 <code>.btn-mini</code>。</p>
                <div class="bs-docs-example">
                    <div class="btn-toolbar" style="margin: 0;">
                        <div class="btn-group">
                            <button class="btn btn-large dropdown-toggle" data-toggle="dropdown">大按鈕 <span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                        <div class="btn-group">
                            <button class="btn btn-small dropdown-toggle" data-toggle="dropdown">小按鈕 <span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                        <div class="btn-group">
                            <button class="btn btn-mini dropdown-toggle" data-toggle="dropdown">迷你按鈕 <span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                    </div>
                    <!-- /btn-toolbar -->
                </div>

                <h3>需要 JavaScript</h3>
                <p>按鈕式下拉式選單需要和 @Html.ActionLink("Bootstrap 下拉選單外掛", "JavaScript", Nothing, Nothing, Nothing, "dropdowns", Nothing, Nothing) 一起使用。</p>
                <p>在某些情況下 &mdash; 像是手機 &mdash; 下拉式選單可能會超出可視範圍，你必須自己手動解決問題或修改 JavaScript。</p>

                <hr class="bs-docs-separator">

                <h2>分割式按鈕下拉式選單</h2>
                <p>建置在按鈕群組的樣式與標記上，我們很容易去建立的一個分割的按鈕。分割的按鈕左邊是一個標準按鈕，右邊是一個可以可觸發開關的選單內容的連結。</p>
                <div class="bs-docs-example">
                    <div class="btn-toolbar" style="margin: 0;">
                        <div class="btn-group">
                            <button class="btn">Action</button>
                            <button class="btn dropdown-toggle" data-toggle="dropdown"><span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                        <div class="btn-group">
                            <button class="btn btn-primary">Action</button>
                            <button class="btn btn-primary dropdown-toggle" data-toggle="dropdown"><span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                        <div class="btn-group">
                            <button class="btn btn-danger">Danger</button>
                            <button class="btn btn-danger dropdown-toggle" data-toggle="dropdown"><span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                        <div class="btn-group">
                            <button class="btn btn-warning">Warning</button>
                            <button class="btn btn-warning dropdown-toggle" data-toggle="dropdown"><span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                        <div class="btn-group">
                            <button class="btn btn-success">Success</button>
                            <button class="btn btn-success dropdown-toggle" data-toggle="dropdown"><span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                        <div class="btn-group">
                            <button class="btn btn-info">Info</button>
                            <button class="btn btn-info dropdown-toggle" data-toggle="dropdown"><span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                        <div class="btn-group">
                            <button class="btn btn-inverse">Inverse</button>
                            <button class="btn btn-inverse dropdown-toggle" data-toggle="dropdown"><span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                    </div>
                    <!-- /btn-toolbar -->
                </div>
                <pre class="prettyprint linenums">
&lt;div class="btn-group"&gt;
  &lt;button class="btn"&gt;Action&lt;/button&gt;
  &lt;button class="btn dropdown-toggle" data-toggle="dropdown"&gt;
    &lt;span class="caret"&gt;&lt;/span&gt;
  &lt;/button&gt;
  &lt;ul class="dropdown-menu"&gt;
    &lt;!-- dropdown menu links --&gt;
  &lt;/ul&gt;
&lt;/div&gt;
</pre>

                <h3>尺寸</h3>
                <p>使用額外按鈕類別 <code>.btn-mini</code>、<code>.btn-small</code> 或 <code>.btn-large</code> 可以調整大小尺寸。</p>
                <div class="bs-docs-example">
                    <div class="btn-toolbar">
                        <div class="btn-group">
                            <button class="btn btn-large">Large action</button>
                            <button class="btn btn-large dropdown-toggle" data-toggle="dropdown"><span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                    </div>
                    <!-- /btn-toolbar -->
                    <div class="btn-toolbar">
                        <div class="btn-group">
                            <button class="btn btn-small">Small action</button>
                            <button class="btn btn-small dropdown-toggle" data-toggle="dropdown"><span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                    </div>
                    <!-- /btn-toolbar -->
                    <div class="btn-toolbar">
                        <div class="btn-group">
                            <button class="btn btn-mini">Mini action</button>
                            <button class="btn btn-mini dropdown-toggle" data-toggle="dropdown"><span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                    </div>
                    <!-- /btn-toolbar -->
                </div>
                <pre class="prettyprint linenums">
&lt;div class="btn-group"&gt;
  &lt;button class="btn btn-mini"&gt;Action&lt;/button&gt;
  &lt;button class="btn btn-mini dropdown-toggle" data-toggle="dropdown"&gt;
    &lt;span class="caret"&gt;&lt;/span&gt;
  &lt;/button&gt;
  &lt;ul class="dropdown-menu"&gt;
    &lt;!-- dropdown menu links --&gt;
  &lt;/ul&gt;
&lt;/div&gt;
</pre>

                <h3>向上選單</h3>
                <p>給 <code>.dropdown-menu</code> 的直接父節點加入一個 <code>.dropup</code> 類別，就可以讓選單由下而上呈現。<code>.caret</code> 類別會把三角符號轉為由下而上。</p>
                <div class="bs-docs-example">
                    <div class="btn-toolbar" style="margin: 0;">
                        <div class="btn-group dropup">
                            <button class="btn">Dropup</button>
                            <button class="btn dropdown-toggle" data-toggle="dropdown"><span class="caret"></span></button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                        <div class="btn-group dropup">
                            <button class="btn primary">Right dropup</button>
                            <button class="btn primary dropdown-toggle" data-toggle="dropdown"><span class="caret"></span></button>
                            <ul class="dropdown-menu pull-right">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <!-- /btn-group -->
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="btn-group dropup"&gt;
  &lt;button class="btn"&gt;Dropup&lt;/button&gt;
  &lt;button class="btn dropdown-toggle" data-toggle="dropdown"&gt;
    &lt;span class="caret"&gt;&lt;/span&gt;
  &lt;/button&gt;
  &lt;ul class="dropdown-menu"&gt;
    &lt;!-- dropdown menu links --&gt;
  &lt;/ul&gt;
&lt;/div&gt;
</pre>

            </section>

            <!-- Nav, Tabs, & Pills
            ================================================== -->
            <section id="navs">
                <div class="page-header">
                    <h1>巡覽: 頁籤、pill和清單</small></h1>
                </div>

                <h2>輕量的預設樣式<small>相同的標記，不同的類別</small></h2>
                <p>所有的巡覽元件都在這裡 &mdash; 頁籤（Tab）、pill和清單 &mdash; 它們分享 <code>.nav</code> 類別，<strong>具有相同標記與樣式</strong>。</p>

                <h3>基礎頁籤</h3>
                <p>在含有連結 <code>&lt;ul&gt;</code> 加入 <code>.nav-tabs</code> 類別：</p>
                <div class="bs-docs-example">
                    <ul class="nav nav-tabs">
                        <li class="active"><a href="#">Home</a></li>
                        <li><a href="#">Profile</a></li>
                        <li><a href="#">Messages</a></li>
                    </ul>
                </div>
                <pre class="prettyprint linenums">
&lt;ul class="nav nav-tabs"&gt;
  &lt;li class="active"&gt;
    &lt;a href="#"&gt;Home&lt;/a&gt;
  &lt;/li&gt;
  &lt;li&gt;&lt;a href="#"&gt;...&lt;/a&gt;&lt;/li&gt;
  &lt;li&gt;&lt;a href="#"&gt;...&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
</pre>

                <h3>基礎pill</h3>
                <p>相同的 HTML，只是用 <code>.nav-pills</code> 類別替代：</p>
                <div class="bs-docs-example">
                    <ul class="nav nav-pills">
                        <li class="active"><a href="#">Home</a></li>
                        <li><a href="#">Profile</a></li>
                        <li><a href="#">Messages</a></li>
                    </ul>
                </div>
                <pre class="prettyprint linenums">
&lt;ul class="nav nav-pills"&gt;
  &lt;li class="active"&gt;
    &lt;a href="#"&gt;Home&lt;/a&gt;
  &lt;/li&gt;
  &lt;li&gt;&lt;a href="#"&gt;...&lt;/a&gt;&lt;/li&gt;
  &lt;li&gt;&lt;a href="#"&gt;...&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
</pre>

                <h3>禁用狀態</h3>
                <p>不管任何巡覽元件（頁籤、pill、清單）加入 <code>.disabled</code> 類別，都會讓<strong>連結變灰且沒有滑鼠移至的效果</strong>。但是連結仍然可以點擊，除非你將連結的 <code>href</code> 屬性移除，或者，你可以自行撰寫 JavaScript 預防使用者去點擊。</p>
                <div class="bs-docs-example">
                    <ul class="nav nav-pills">
                        <li><a href="#">Clickable link</a></li>
                        <li><a href="#">Clickable link</a></li>
                        <li class="disabled"><a href="#">Disabled link</a></li>
                    </ul>
                </div>
                <pre class="prettyprint linenums">
&lt;ul class="nav nav-pills"&gt;
  ...
  &lt;li class="disabled"&gt;&lt;a href="#"&gt;Home&lt;/a&gt;&lt;/li&gt;
  ...
&lt;/ul&gt;
</pre>

                <h3>元件對齊</h3>
                <p>使用 <code>.pull-left</code> 或 <code>.pull-right</code> 工具類別來對齊巡覽連結。每個類別都實作了特定方向的 CSS 浮動。</p>


                <hr class="bs-docs-separator">


                <h2>堆疊式佈局</h2>
                <p>頁籤與 pill 預設都是水平方向，僅需要加第二個 <code>.nav-stacked</code> 類別即可讓它們呈現為堆疊方條。</p>

                <h3>堆疊頁籤</h3>
                <div class="bs-docs-example">
                    <ul class="nav nav-tabs nav-stacked">
                        <li class="active"><a href="#">Home</a></li>
                        <li><a href="#">Profile</a></li>
                        <li><a href="#">Messages</a></li>
                    </ul>
                </div>
                <pre class="prettyprint linenums">
&lt;ul class="nav nav-tabs nav-stacked"&gt;
  ...
&lt;/ul&gt;
</pre>

                <h3>堆疊 pill</h3>
                <div class="bs-docs-example">
                    <ul class="nav nav-pills nav-stacked">
                        <li class="active"><a href="#">Home</a></li>
                        <li><a href="#">Profile</a></li>
                        <li><a href="#">Messages</a></li>
                    </ul>
                </div>
                <pre class="prettyprint linenums">
&lt;ul class="nav nav-pills nav-stacked"&gt;
  ...
&lt;/ul&gt;
</pre>

                <hr class="bs-docs-separator">

                <h2>下拉式選單</h2>
                <p>透過一點點 HTML 和 @Html.ActionLink("下拉選單 JavaScript 外掛", "JavaScript", Nothing, Nothing, Nothing, "dropdowns", Nothing, Nothing) 即可加入一個下拉式選單。</p>

                <h3>下拉式頁籤選單</h3>
                <div class="bs-docs-example">
                    <ul class="nav nav-tabs">
                        <li class="active"><a href="#">Home</a></li>
                        <li><a href="#">Help</a></li>
                        <li class="dropdown">
                            <a class="dropdown-toggle" data-toggle="dropdown" href="#">Dropdown <b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </li>
                    </ul>
                </div>
                <pre class="prettyprint linenums">
&lt;ul class="nav nav-tabs"&gt;
  &lt;li class="dropdown"&gt;
    &lt;a class="dropdown-toggle"
       data-toggle="dropdown"
       href="#"&gt;
        Dropdown
        &lt;b class="caret"&gt;&lt;/b&gt;
      &lt;/a&gt;
    &lt;ul class="dropdown-menu"&gt;
      &lt;!-- links --&gt;
    &lt;/ul&gt;
  &lt;/li&gt;
&lt;/ul&gt;
</pre>

                <h3>下拉式pill選單</h3>
                <div class="bs-docs-example">
                    <ul class="nav nav-pills">
                        <li class="active"><a href="#">Home</a></li>
                        <li><a href="#">Help</a></li>
                        <li class="dropdown">
                            <a class="dropdown-toggle" data-toggle="dropdown" href="#">Dropdown <b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </li>
                    </ul>
                </div>
                <pre class="prettyprint linenums">
&lt;ul class="nav nav-pills"&gt;
  &lt;li class="dropdown"&gt;
    &lt;a class="dropdown-toggle"
       data-toggle="dropdown"
       href="#"&gt;
        Dropdown
        &lt;b class="caret"&gt;&lt;/b&gt;
      &lt;/a&gt;
    &lt;ul class="dropdown-menu"&gt;
      &lt;!-- links --&gt;
    &lt;/ul&gt;
  &lt;/li&gt;
&lt;/ul&gt;
</pre>

                <hr class="bs-docs-separator">

                <h2>巡覽清單</h2>
                <p>這是一個簡單且容易來建置帶有選項標頭的巡覽連結群組。它們經常被使用在側邊欄，像是 OS X 裡 Finder。</p>

                <h3>巡覽清單範例</h3>
                <p>將 <code>class="nav nav-list"</code> 加到一組連結清單中：</p>
                <div class="bs-docs-example">
                    <div class="well" style="max-width: 340px; padding: 8px 0;">
                        <ul class="nav nav-list">
                            <li class="nav-header">List header</li>
                            <li class="active"><a href="#">Home</a></li>
                            <li><a href="#">Library</a></li>
                            <li><a href="#">Applications</a></li>
                            <li class="nav-header">Another list header</li>
                            <li><a href="#">Profile</a></li>
                            <li><a href="#">Settings</a></li>
                            <li class="divider"></li>
                            <li><a href="#">Help</a></li>
                        </ul>
                    </div>
                    <!-- /well -->
                </div>
                <pre class="prettyprint linenums">
&lt;ul class="nav nav-list"&gt;
  &lt;li class="nav-header"&gt;List header&lt;/li&gt;
  &lt;li class="active"&gt;&lt;a href="#"&gt;Home&lt;/a&gt;&lt;/li&gt;
  &lt;li&gt;&lt;a href="#"&gt;Library&lt;/a&gt;&lt;/li&gt;
  ...
&lt;/ul&gt;
</pre>
                <p>
                    <span class="label label-info">注意！</span> 當需要巢狀的導列清單時，將 <code>class="nav nav-list"</code> 包含在任何巢狀的 <code>&lt;ul&gt;</code> 裡。
                </p>

                <h3>水平分割線</h3>
                <p>建立一個空白清單項目 <code>&lt;li&gt;</code> 並加入 <code>.divider</code> 類別，即可建立一條水平分割線，類似這樣：</p>
                <pre class="prettyprint linenums">
&lt;ul class="nav nav-list"&gt;
  ...
  &lt;li class="divider"&gt;&lt;/li&gt;
  ...
&lt;/ul&gt;
</pre>

                <hr class="bs-docs-separator">

                <h2>頁籤式巡覽</h2>
                <p>只需一個簡單的外掛就可以在頁籤（Tab）之間切換內容。Bootstrap 整合了 4 種頁籤樣式：top、right、bottom 和 left。預設是 top 樣式。</p>

                <h3>頁籤範例</h3>
                <p>做一個可切換頁籤，建立 <code>.tab-pane</code> 並且要有唯一的 ID，然後包含在 <code>.tab-content</code> 裡。</p>
                <p><span class="label label-info">譯者註</span>：這裡指的是建立對應頁籤的內容。</p>
                <div class="bs-docs-example">
                    <div class="tabbable" style="margin-bottom: 18px;">
                        <ul class="nav nav-tabs">
                            <li class="active"><a href="#tab1" data-toggle="tab">Section 1</a></li>
                            <li><a href="#tab2" data-toggle="tab">Section 2</a></li>
                            <li><a href="#tab3" data-toggle="tab">Section 3</a></li>
                        </ul>
                        <div class="tab-content" style="padding-bottom: 9px; border-bottom: 1px solid #ddd;">
                            <div class="tab-pane active" id="tab1">
                                <p>I'm in Section 1.</p>
                            </div>
                            <div class="tab-pane" id="tab2">
                                <p>Howdy, I'm in Section 2.</p>
                            </div>
                            <div class="tab-pane" id="tab3">
                                <p>What up girl, this is Section 3.</p>
                            </div>
                        </div>
                    </div>
                    <!-- /tabbable -->
                </div>
                <pre class="prettyprint linenums">
&lt;div class="tabbable"&gt; &lt;!-- Only required for left/right tabs --&gt;
  &lt;ul class="nav nav-tabs"&gt;
    &lt;li class="active"&gt;&lt;a href="#tab1" data-toggle="tab"&gt;Section 1&lt;/a&gt;&lt;/li&gt;
    &lt;li&gt;&lt;a href="#tab2" data-toggle="tab"&gt;Section 2&lt;/a&gt;&lt;/li&gt;
  &lt;/ul&gt;
  &lt;div class="tab-content"&gt;
    &lt;div class="tab-pane active" id="tab1"&gt;
      &lt;p&gt;I'm in Section 1.&lt;/p&gt;
    &lt;/div&gt;
    &lt;div class="tab-pane" id="tab2"&gt;
      &lt;p&gt;Howdy, I'm in Section 2.&lt;/p&gt;
    &lt;/div&gt;
  &lt;/div&gt;
&lt;/div&gt;
</pre>

                <h4>淡入頁籤</h4>
                <p>讓頁籤有淡入效果，在每一個 <code>.tab-pane</code> 加入 <code>.fade</code> 類別。</p>

                <h4>需要 jQuery 外掛</h4>
                <p>所有可切換頁籤都需要我們輕量的 jQuery 外掛。閱讀更多關於頁籤 @Html.ActionLink("JavaScript 文件", "JavaScript", Nothing, Nothing, Nothing, "tabs", Nothing, Nothing)。</p>

                <h3>轉換頁籤至任何方向</h3>

                <h4>底部頁籤</h4>
                <p>
                    翻轉頁籤 HTML 順序且加入一個 <code>.tabs-below</code> 類別，即可讓頁籤置於底部。
                </p>
                <div class="bs-docs-example">
                    <div class="tabbable tabs-below">
                        <div class="tab-content">
                            <div class="tab-pane active" id="A">
                                <p>I'm in Section A.</p>
                            </div>
                            <div class="tab-pane" id="B">
                                <p>Howdy, I'm in Section B.</p>
                            </div>
                            <div class="tab-pane" id="C">
                                <p>What up girl, this is Section C.</p>
                            </div>
                        </div>
                        <ul class="nav nav-tabs">
                            <li class="active"><a href="#A" data-toggle="tab">Section 1</a></li>
                            <li><a href="#B" data-toggle="tab">Section 2</a></li>
                            <li><a href="#C" data-toggle="tab">Section 3</a></li>
                        </ul>
                    </div>
                    <!-- /tabbable -->
                </div>
                <pre class="prettyprint linenums">
&lt;div class="tabbable tabs-below"&gt;
  &lt;div class="tab-content"&gt;
    ...
  &lt;/div&gt;
  &lt;ul class="nav nav-tabs"&gt;
    ...
  &lt;/ul&gt;
&lt;/div&gt;
</pre>

                <h4>左邊頁籤</h4>
                <p>加入 <code>.tabs-left</code> 類別即可讓頁籤置於左邊。</p>
                <div class="bs-docs-example">
                    <div class="tabbable tabs-left">
                        <ul class="nav nav-tabs">
                            <li class="active"><a href="#lA" data-toggle="tab">Section 1</a></li>
                            <li><a href="#lB" data-toggle="tab">Section 2</a></li>
                            <li><a href="#lC" data-toggle="tab">Section 3</a></li>
                        </ul>
                        <div class="tab-content">
                            <div class="tab-pane active" id="lA">
                                <p>I'm in Section A.</p>
                            </div>
                            <div class="tab-pane" id="lB">
                                <p>Howdy, I'm in Section B.</p>
                            </div>
                            <div class="tab-pane" id="lC">
                                <p>What up girl, this is Section C.</p>
                            </div>
                        </div>
                    </div>
                    <!-- /tabbable -->
                </div>
                <pre class="prettyprint linenums">
&lt;div class="tabbable tabs-left"&gt;
  &lt;ul class="nav nav-tabs"&gt;
    ...
  &lt;/ul&gt;
  &lt;div class="tab-content"&gt;
    ...
  &lt;/div&gt;
&lt;/div&gt;
</pre>

                <h4>右邊頁籤</h4>
                <p>加入 <code>.tabs-right</code> 類別即可讓頁籤置於左邊。</p>
                <div class="bs-docs-example">
                    <div class="tabbable tabs-right">
                        <ul class="nav nav-tabs">
                            <li class="active"><a href="#rA" data-toggle="tab">Section 1</a></li>
                            <li><a href="#rB" data-toggle="tab">Section 2</a></li>
                            <li><a href="#rC" data-toggle="tab">Section 3</a></li>
                        </ul>
                        <div class="tab-content">
                            <div class="tab-pane active" id="rA">
                                <p>I'm in Section A.</p>
                            </div>
                            <div class="tab-pane" id="rB">
                                <p>Howdy, I'm in Section B.</p>
                            </div>
                            <div class="tab-pane" id="rC">
                                <p>What up girl, this is Section C.</p>
                            </div>
                        </div>
                    </div>
                    <!-- /tabbable -->
                </div>
                <pre class="prettyprint linenums">
&lt;div class="tabbable tabs-right"&gt;
  &lt;ul class="nav nav-tabs"&gt;
    ...
  &lt;/ul&gt;
  &lt;div class="tab-content"&gt;
    ...
  &lt;/div&gt;
&lt;/div&gt;
</pre>

            </section>

            <!-- Navbar
            ================================================== -->
            <section id="navbar">
                <div class="page-header">
                    <h1>巡覽列</h1>
                </div>

                <h2>基礎巡覽列</h2>
                <p>巡覽列（又稱巡覽列）預設定位樣式為 static （不固定在頁面頂端），且支援包含一個專案（或網站）名稱和基礎巡覽項目。將巡覽列放入 <code>.container</code> 內可以限制其寬度。</p>
                <p><span class="label label-info">譯者註</span>：CSS 的 position 屬性預設值為 static，也就是沒有定位，元素正常出現在流中。（忽略 top、bottom、left、right 或 z-index 的宣告）</p>
                <div class="bs-docs-example">
                    <div class="navbar">
                        <div class="navbar-inner">
                            <a class="brand" href="#">Title</a>
                            <ul class="nav">
                                <li class="active"><a href="#">Home</a></li>
                                <li><a href="#">Link</a></li>
                                <li><a href="#">Link</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="navbar"&gt;
  &lt;div class="navbar-inner"&gt;
    &lt;a class="brand" href="#"&gt;Title&lt;/a&gt;
    &lt;ul class="nav"&gt;
      &lt;li class="active"&gt;&lt;a href="#"&gt;Home&lt;/a&gt;&lt;/li&gt;
      &lt;li&gt;&lt;a href="#"&gt;Link&lt;/a&gt;&lt;/li&gt;
      &lt;li&gt;&lt;a href="#"&gt;Link&lt;/a&gt;&lt;/li&gt;
    &lt;/ul&gt;
  &lt;/div&gt;
&lt;/div&gt;
</pre>

                <hr class="bs-docs-separator">

                <h2>巡覽列元件</h2>

                <h3>品牌</h3>
                <p>僅需要一個連結標籤就可以呈現你的品牌或專案（或網站）名稱。</p>
                <div class="bs-docs-example">
                    <div class="navbar">
                        <div class="navbar-inner">
                            <a class="brand" href="#">Title</a>
                        </div>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;a class="brand" href="#"&gt;Project name&lt;/a&gt;
</pre>

                <h3>巡覽連結</h3>
                <p>在無序清單可以簡單加入新項目。</p>
                <div class="bs-docs-example">
                    <div class="navbar">
                        <div class="navbar-inner">
                            <ul class="nav">
                                <li class="active"><a href="#">Home</a></li>
                                <li><a href="#">Link</a></li>
                                <li><a href="#">Link</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;ul class="nav"&gt;
  &lt;li class="active"&gt;
    &lt;a href="#">Home&lt;/a&gt;
  &lt;/li&gt;
  &lt;li&gt;&lt;a href="#"&gt;Link&lt;/a&gt;&lt;/li&gt;
  &lt;li&gt;&lt;a href="#"&gt;Link&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
</pre>
                <p>你可以很輕鬆加入分隔線，只需要在巡覽連結之間加入一個空白 <code>&lt;li&gt;</code> 項目並加入一個 <code>.divider-vertical</code> 類別。</p>
                <div class="bs-docs-example">
                    <div class="navbar">
                        <div class="navbar-inner">
                            <ul class="nav">
                                <li class="active"><a href="#">Home</a></li>
                                <li class="divider-vertical"></li>
                                <li><a href="#">Link</a></li>
                                <li class="divider-vertical"></li>
                                <li><a href="#">Link</a></li>
                                <li class="divider-vertical"></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;ul class="nav"&gt;
  ...
  &lt;li class="divider-vertical"&gt;&lt;/li&gt;
  ...
&lt;/ul&gt;
</pre>

                <h3>表單</h3>
                <p>想在巡覽列裡放置一個表單，需要像下面範例加入數個對應的類別。一個預設表單需包含 <code>.navbar-form</code> 類別以及 <code>.pull-left</code> 或 <code>.pull-right</code> 用來對齊。</p>
                <div class="bs-docs-example">
                    <div class="navbar">
                        <div class="navbar-inner">
                            <form class="navbar-form pull-left">
                                <input type="text" class="span2">
                                <button type="submit" class="btn">Submit</button>
                            </form>
                        </div>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;form class="navbar-form pull-left"&gt;
  &lt;input type="text" class="span2"&gt;
  &lt;button type="submit" class="btn"&gt;Submit&lt;/button&gt;
&lt;/form&gt;
</pre>

                <h3>搜尋表單</h3>
                <p>在巡覽列裡為 <code>form</code> 元素加入 <code>.navbar-search</code> 類別，並為輸入框加入 <code>.search-query</code> 類別，即可得到一個搜尋表單。</p>
                <div class="bs-docs-example">
                    <div class="navbar">
                        <div class="navbar-inner">
                            <form class="navbar-search pull-left">
                                <input type="text" class="search-query" placeholder="Search">
                            </form>
                        </div>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;form class="navbar-search pull-left"&gt;
  &lt;input type="text" class="search-query" placeholder="Search"&gt;
&lt;/form&gt;
</pre>

                <h3>元件對齊</h3>
                <p>使用 <code>.pull-left</code> 或 <code>.pull-right</code> 工具類別來對齊巡覽連結、搜尋表單、文字等。兩個類別都會設置 CSS 的 float 屬性 到指定的方向。</p>

                <h3>使用下拉式選單</h3>
                <p>只需要少數的標記即可在巡覽列中加入下拉式選單，這需要 @Html.ActionLink("下拉選單 JavaScript 外掛", "JavaScript", Nothing, Nothing, Nothing, "dropdowns", Nothing, Nothing) 配合使用。</p>
                <pre class="prettyprint linenums">
&lt;ul class="nav"&gt;
  &lt;li class="dropdown"&gt;
    &lt;a href="#" class="dropdown-toggle" data-toggle="dropdown">
      Account
      &lt;b class="caret"&gt;&lt;/b&gt;
    &lt;/a&gt;
    &lt;ul class="dropdown-menu"&gt;
      ...
    &lt;/ul&gt;
  &lt;/li&gt;
&lt;/ul&gt;
</pre>
                <p>訪問 @Html.ActionLink("JavaScript 下拉式選單文件", "JavaScript", Nothing, Nothing, Nothing, "dropdowns", Nothing, Nothing) 以瞭解更多標記使用下拉式選單的訊息。</p>

                <h3>文字</h3>
                <p>將文字字串包含在 <code>.navbar-text</code> 類別中可以有突出的效果，但一般會使用<code>&lt;p&gt;</code> 然後設置突顯大小與顏色。</p>

                <hr class="bs-docs-separator">

                <h2>選擇性顯示變化</h2>
                <p>在最外層 div 元素加入 <code>.navbar</code> 類別，就可以在可視範圍固定巡覽列在頂端或底部。</p>

                <h3>固定在頂端</h3>
                <p>加入 <code>.navbar-fixed-top</code> 類別，還要記得給 <code>&lt;body&gt;</code> 增加 40px 的 <code>padding</code>，這樣巡覽列才不會擋到下面的內容。一定要在 Bootstrap 核心（bootstrap.css）之後與選擇性的嚮應式 CSS（bootstrap-responsive.css）之前。</p>
                <div class="bs-docs-example bs-navbar-top-example">
                    <div class="navbar navbar-fixed-top" style="position: absolute;">
                        <div class="navbar-inner">
                            <div class="container" style="width: auto; padding: 0 20px;">
                                <a class="brand" href="#">Title</a>
                                <ul class="nav">
                                    <li class="active"><a href="#">Home</a></li>
                                    <li><a href="#">Link</a></li>
                                    <li><a href="#">Link</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="navbar navbar-fixed-top"&gt;
  ...
&lt;/div&gt;
</pre>

                <h3>固定在底部</h3>
                <p>加入 <code>.navbar-fixed-bottom</code> 即可。</p>
                <div class="bs-docs-example bs-navbar-bottom-example">
                    <div class="navbar navbar-fixed-bottom" style="position: absolute;">
                        <div class="navbar-inner">
                            <div class="container" style="width: auto; padding: 0 20px;">
                                <a class="brand" href="#">Title</a>
                                <ul class="nav">
                                    <li class="active"><a href="#">Home</a></li>
                                    <li><a href="#">Link</a></li>
                                    <li><a href="#">Link</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="navbar navbar-fixed-bottom"&gt;
  ...
&lt;/div&gt;
</pre>

                <h3>靜態頂端巡覽列</h3>
                <p>加入 <code>.navbar-static-top</code> 類別可以建立一個與頁面等寬的巡覽列，它會隨著頁面向下滑動而消失。和 <code>.navbar-fixed-top</code> 類別不同的是，你不需要去修改 <code>&lt;body&gt;</code> 元素的 padding。</p>
                <div class="bs-docs-example bs-navbar-top-example">
                    <div class="navbar navbar-static-top" style="margin: -1px -1px 0;">
                        <div class="navbar-inner">
                            <div class="container" style="width: auto; padding: 0 20px;">
                                <a class="brand" href="#">Title</a>
                                <ul class="nav">
                                    <li class="active"><a href="#">Home</a></li>
                                    <li><a href="#">Link</a></li>
                                    <li><a href="#">Link</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="navbar navbar-static-top"&gt;
  ...
&lt;/div&gt;
</pre>

                <hr class="bs-docs-separator">

                <h2>嚮應式巡覽列</h2>
                <p>要實現一個可收放嚮應式巡覽列，需要把巡覽列內容放置在 div 容器內，然後設置 <code>.nav-collapse.collapse</code> 類別，還需要一個觸發切換按鈕並設置 <code>.btn-navbar</code>。</p>
                <div class="bs-docs-example">
                    <div class="navbar">
                        <div class="navbar-inner">
                            <div class="container">
                                <a class="btn btn-navbar" data-toggle="collapse" data-target=".navbar-responsive-collapse">
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                </a>
                                <a class="brand" href="#">Title</a>
                                <div class="nav-collapse collapse navbar-responsive-collapse">
                                    <ul class="nav">
                                        <li class="active"><a href="#">Home</a></li>
                                        <li><a href="#">Link</a></li>
                                        <li><a href="#">Link</a></li>
                                        <li class="dropdown">
                                            <a href="#" class="dropdown-toggle" data-toggle="dropdown">Dropdown <b class="caret"></b></a>
                                            <ul class="dropdown-menu">
                                                <li><a href="#">Action</a></li>
                                                <li><a href="#">Another action</a></li>
                                                <li><a href="#">Something else here</a></li>
                                                <li class="divider"></li>
                                                <li class="nav-header">Nav header</li>
                                                <li><a href="#">Separated link</a></li>
                                                <li><a href="#">One more separated link</a></li>
                                            </ul>
                                        </li>
                                    </ul>
                                    <form class="navbar-search pull-left" action="">
                                        <input type="text" class="search-query span2" placeholder="Search">
                                    </form>
                                    <ul class="nav pull-right">
                                        <li><a href="#">Link</a></li>
                                        <li class="divider-vertical"></li>
                                        <li class="dropdown">
                                            <a href="#" class="dropdown-toggle" data-toggle="dropdown">Dropdown <b class="caret"></b></a>
                                            <ul class="dropdown-menu">
                                                <li><a href="#">Action</a></li>
                                                <li><a href="#">Another action</a></li>
                                                <li><a href="#">Something else here</a></li>
                                                <li class="divider"></li>
                                                <li><a href="#">Separated link</a></li>
                                            </ul>
                                        </li>
                                    </ul>
                                </div>
                                <!-- /.nav-collapse -->
                            </div>
                        </div>
                        <!-- /navbar-inner -->
                    </div>
                    <!-- /navbar -->
                </div>
                <pre class="prettyprint linenums">
&lt;div class="navbar"&gt;
  &lt;div class="navbar-inner"&gt;
    &lt;div class="container"&gt;

      &lt;!-- .btn-navbar is used as the toggle for collapsed navbar content --&gt;
      &lt;a class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse"&gt;
        &lt;span class="icon-bar"&gt;&lt;/span&gt;
        &lt;span class="icon-bar"&gt;&lt;/span&gt;
        &lt;span class="icon-bar"&gt;&lt;/span&gt;
      &lt;/a&gt;

      &lt;!-- Be sure to leave the brand out there if you want it shown --&gt;
      &lt;a class="brand" href="#"&gt;Project name&lt;/a&gt;

      &lt;!-- Everything you want hidden at 940px or less, place within here --&gt;
      &lt;div class="nav-collapse collapse"&gt;
        &lt;!-- .nav, .navbar-search, .navbar-form, etc --&gt;
      &lt;/div&gt;

    &lt;/div&gt;
  &lt;/div&gt;
&lt;/div&gt;
</pre>
                <div class="alert alert-info">
                    <strong>注意！</strong>嚮應式巡覽列需要 @Html.ActionLink("collapse 外掛", "JavaScript", Nothing, Nothing, Nothing, "collapse", Nothing, Nothing) 和 @Html.ActionLink("嚮應式 Bootstrap CSS 檔案", "Scaffolding", Nothing, Nothing, Nothing, "responsive", Nothing, Nothing)。
                </div>

                <hr class="bs-docs-separator">

                <h2>反向色</h2>
                <p>加入 <code>.navbar-inverse</code> 類別可以改變巡覽列的外觀。</p>
                <div class="bs-docs-example">
                    <div class="navbar navbar-inverse" style="position: static;">
                        <div class="navbar-inner">
                            <div class="container">
                                <a class="btn btn-navbar" data-toggle="collapse" data-target=".navbar-inverse-collapse">
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                    <span class="icon-bar"></span>
                                </a>
                                <a class="brand" href="#">Title</a>
                                <div class="nav-collapse collapse navbar-inverse-collapse">
                                    <ul class="nav">
                                        <li class="active"><a href="#">Home</a></li>
                                        <li><a href="#">Link</a></li>
                                        <li><a href="#">Link</a></li>
                                        <li class="dropdown">
                                            <a href="#" class="dropdown-toggle" data-toggle="dropdown">Dropdown <b class="caret"></b></a>
                                            <ul class="dropdown-menu">
                                                <li><a href="#">Action</a></li>
                                                <li><a href="#">Another action</a></li>
                                                <li><a href="#">Something else here</a></li>
                                                <li class="divider"></li>
                                                <li class="nav-header">Nav header</li>
                                                <li><a href="#">Separated link</a></li>
                                                <li><a href="#">One more separated link</a></li>
                                            </ul>
                                        </li>
                                    </ul>
                                    <form class="navbar-search pull-left" action="">
                                        <input type="text" class="search-query span2" placeholder="Search">
                                    </form>
                                    <ul class="nav pull-right">
                                        <li><a href="#">Link</a></li>
                                        <li class="divider-vertical"></li>
                                        <li class="dropdown">
                                            <a href="#" class="dropdown-toggle" data-toggle="dropdown">Dropdown <b class="caret"></b></a>
                                            <ul class="dropdown-menu">
                                                <li><a href="#">Action</a></li>
                                                <li><a href="#">Another action</a></li>
                                                <li><a href="#">Something else here</a></li>
                                                <li class="divider"></li>
                                                <li><a href="#">Separated link</a></li>
                                            </ul>
                                        </li>
                                    </ul>
                                </div>
                                <!-- /.nav-collapse -->
                            </div>
                        </div>
                        <!-- /navbar-inner -->
                    </div>
                    <!-- /navbar -->
                </div>
                <pre class="prettyprint linenums">
&lt;div class="navbar navbar-inverse"&gt;
  ...
&lt;/div&gt;
</pre>

            </section>

            <!-- Breadcrumbs
            ================================================== -->
            <section id="breadcrumbs">
                <div class="page-header">
                    <h1>麵包屑<small></small></h1>
                </div>

                <h2>範例</h2>
                <p>一個簡單範例呈現它可能顯示多個頁面。</p>
                <div class="bs-docs-example">
                    <ul class="breadcrumb">
                        <li class="active">Home</li>
                    </ul>
                    <ul class="breadcrumb">
                        <li><a href="#">Home</a> <span class="divider">/</span></li>
                        <li class="active">Library</li>
                    </ul>
                    <ul class="breadcrumb" style="margin-bottom: 5px;">
                        <li><a href="#">Home</a> <span class="divider">/</span></li>
                        <li><a href="#">Library</a> <span class="divider">/</span></li>
                        <li class="active">Data</li>
                    </ul>
                </div>
                <pre class="prettyprint linenums">
&lt;ul class="breadcrumb"&gt;
  &lt;li&gt;&lt;a href="#"&gt;Home&lt;/a&gt; &lt;span class="divider"&gt;/&lt;/span&gt;&lt;/li&gt;
  &lt;li&gt;&lt;a href="#"&gt;Library&lt;/a&gt; &lt;span class="divider"&gt;/&lt;/span&gt;&lt;/li&gt;
  &lt;li class="active"&gt;Data&lt;/li&gt;
&lt;/ul&gt;
</pre>
                <p><span class="label label-info">譯者註</span>：Breadcrumbs 可翻譯為軌跡瀏覽和麵包屑，網站應用上的中文通常使用麵包屑來稱呼。</p>
            </section>

            <!-- Pagination
            ================================================== -->
            <section id="pagination">
                <div class="page-header">
                    <h1>分頁 <small>兩種可選擇內容的分頁方式</small></h1>
                </div>

                <h2>標準分頁</h2>
                <p>此種簡單分頁的靈感來自 Rdio，非常合適 App 和搜尋結果。大區塊不易搞錯，而且容易擴展，還有非常大的可點擊區域。</p>
                <div class="bs-docs-example">
                    <div class="pagination">
                        <ul>
                            <li><a href="#">&laquo;</a></li>
                            <li><a href="#">1</a></li>
                            <li><a href="#">2</a></li>
                            <li><a href="#">3</a></li>
                            <li><a href="#">4</a></li>
                            <li><a href="#">5</a></li>
                            <li><a href="#">&raquo;</a></li>
                        </ul>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="pagination"&gt;
  &lt;ul&gt;
    &lt;li&gt;&lt;a href="#"&gt;Prev&lt;/a&gt;&lt;/li&gt;
    &lt;li&gt;&lt;a href="#"&gt;1&lt;/a&gt;&lt;/li&gt;
    &lt;li&gt;&lt;a href="#"&gt;2&lt;/a&gt;&lt;/li&gt;
    &lt;li&gt;&lt;a href="#"&gt;3&lt;/a&gt;&lt;/li&gt;
    &lt;li&gt;&lt;a href="#"&gt;4&lt;/a&gt;&lt;/li&gt;
    &lt;li&gt;&lt;a href="#"&gt;5&lt;/a&gt;&lt;/li&gt;
    &lt;li&gt;&lt;a href="#"&gt;Next&lt;/a&gt;&lt;/li&gt;
  &lt;/ul&gt;
&lt;/div&gt;
</pre>

                <hr class="bs-docs-separator">

                <h2>選項</h2>

                <h3>禁用與啟用狀態</h3>
                <p>可依不同情況自訂連結。使用 <code>.disabled</code> 指出不能點擊，使用 <code>.active</code> 指出這是當前頁面。</p>
                <div class="bs-docs-example">
                    <div class="pagination pagination-centered">
                        <ul>
                            <li class="disabled"><a href="#">&laquo;</a></li>
                            <li class="active"><a href="#">1</a></li>
                            <li><a href="#">2</a></li>
                            <li><a href="#">3</a></li>
                            <li><a href="#">4</a></li>
                            <li><a href="#">5</a></li>
                            <li><a href="#">&raquo;</a></li>
                        </ul>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="pagination"&gt;
  &lt;ul&gt;
    &lt;li class="disabled"&gt;&lt;a href="#"&gt;&amp;laquo;&lt;/a&gt;&lt;/li&gt;
    &lt;li class="active"&gt;&lt;a href="#"&gt;1&lt;/a&gt;&lt;/li&gt;
    ...
  &lt;/ul&gt;
&lt;/div&gt;
</pre>
                <p>你還能選擇使用 span 元素替代 a 元素，這樣就能移除點擊功能又能保有原樣式。</p>
                <pre class="prettyprint linenums">
&lt;div class="pagination"&gt;
  &lt;ul&gt;
    &lt;li class="disabled"&gt;&lt;span&gt;&amp;laquo;&lt;/span&gt;&lt;/li&gt;
    &lt;li class="active"&gt;&lt;span&gt;1&lt;/span&gt;&lt;/li&gt;
    ...
  &lt;/ul&gt;
&lt;/div&gt;
</pre>

                <h3>尺寸</h3>
                <p>想要更大或更小的分頁？ 加入 <code>.pagination-large</code>，<code>.pagination-small</code> 或 <code>.pagination-mini</code> 類別就可以改變分頁尺寸。</p>
                <div class="bs-docs-example">
                    <div class="pagination pagination-large">
                        <ul>
                            <li><a href="#">&laquo;</a></li>
                            <li><a href="#">1</a></li>
                            <li><a href="#">2</a></li>
                            <li><a href="#">3</a></li>
                            <li><a href="#">4</a></li>
                            <li><a href="#">5</a></li>
                            <li><a href="#">&raquo;</a></li>
                        </ul>
                    </div>
                    <div class="pagination">
                        <ul>
                            <li><a href="#">&laquo;</a></li>
                            <li><a href="#">1</a></li>
                            <li><a href="#">2</a></li>
                            <li><a href="#">3</a></li>
                            <li><a href="#">4</a></li>
                            <li><a href="#">5</a></li>
                            <li><a href="#">&raquo;</a></li>
                        </ul>
                    </div>
                    <div class="pagination pagination-small">
                        <ul>
                            <li><a href="#">&laquo;</a></li>
                            <li><a href="#">1</a></li>
                            <li><a href="#">2</a></li>
                            <li><a href="#">3</a></li>
                            <li><a href="#">4</a></li>
                            <li><a href="#">5</a></li>
                            <li><a href="#">&raquo;</a></li>
                        </ul>
                    </div>
                    <div class="pagination pagination-mini">
                        <ul>
                            <li><a href="#">&laquo;</a></li>
                            <li><a href="#">1</a></li>
                            <li><a href="#">2</a></li>
                            <li><a href="#">3</a></li>
                            <li><a href="#">4</a></li>
                            <li><a href="#">5</a></li>
                            <li><a href="#">&raquo;</a></li>
                        </ul>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="pagination pagination-large"&gt;
  &lt;ul&gt;
    ...
  &lt;/ul&gt;
&lt;/div&gt;
&lt;div class="pagination"&gt;
  &lt;ul&gt;
    ...
  &lt;/ul&gt;
&lt;/div&gt;
&lt;div class="pagination pagination-small"&gt;
  &lt;ul&gt;
    ...
  &lt;/ul&gt;
&lt;/div&gt;
&lt;div class="pagination pagination-mini"&gt;
  &lt;ul&gt;
    ...
  &lt;/ul&gt;
&lt;/div&gt;
</pre>

                <h3>對齊</h3>
                <p>加入後面選擇性類別可以改變分頁對齊方式：<code>.pagination-centered</code> 和 <code>.pagination-right</code>。</p>
                <div class="bs-docs-example">
                    <div class="pagination pagination-centered">
                        <ul>
                            <li><a href="#">&laquo;</a></li>
                            <li><a href="#">1</a></li>
                            <li><a href="#">2</a></li>
                            <li><a href="#">3</a></li>
                            <li><a href="#">4</a></li>
                            <li><a href="#">5</a></li>
                            <li><a href="#">&raquo;</a></li>
                        </ul>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="pagination pagination-centered"&gt;
  ...
&lt;/div&gt;
</pre>
                <div class="bs-docs-example">
                    <div class="pagination pagination-right">
                        <ul>
                            <li><a href="#">&laquo;</a></li>
                            <li><a href="#">1</a></li>
                            <li><a href="#">2</a></li>
                            <li><a href="#">3</a></li>
                            <li><a href="#">4</a></li>
                            <li><a href="#">5</a></li>
                            <li><a href="#">&raquo;</a></li>
                        </ul>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="pagination pagination-right"&gt;
  ...
&lt;/div&gt;
</pre>

                <hr class="bs-docs-separator">

                <h2>換頁</h2>
                <p>用少量標記和構式就可快速提供前一頁與下一頁的分頁連結。這非常合適簡單的網站，例如部落格或雜誌網站。</p>

                <h3>預設範例</h3>
                <p>預設情況，換頁會置中呈現。</p>
                <div class="bs-docs-example">
                    <ul class="pager">
                        <li><a href="#">Previous</a></li>
                        <li><a href="#">Next</a></li>
                    </ul>
                </div>
                <pre class="prettyprint linenums">
&lt;ul class="pager"&gt;
  &lt;li&gt;&lt;a href="#"&gt;Previous&lt;/a&gt;&lt;/li&gt;
  &lt;li&gt;&lt;a href="#"&gt;Next&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
</pre>

                <h3>對齊連結</h3>
                <p>另外，透過 <code>.previous</code> 與 <code>.next</code> 類別還可以把連結放置在兩邊。</p>
                <div class="bs-docs-example">
                    <ul class="pager">
                        <li class="previous"><a href="#">&larr; Older</a></li>
                        <li class="next"><a href="#">Newer &rarr;</a></li>
                    </ul>
                </div>
                <pre class="prettyprint linenums">
&lt;ul class="pager"&gt;
  &lt;li class="previous"&gt;
    &lt;a href="#"&gt;&amp;larr; Older&lt;/a&gt;
  &lt;/li&gt;
  &lt;li class="next"&gt;
    &lt;a href="#"&gt;Newer &amp;rarr;&lt;/a&gt;
  &lt;/li&gt;
&lt;/ul&gt;
</pre>

                <h3>選擇性禁用狀態</h3>
                <p>換頁連結也能和分頁一樣使用 <code>.disabled</code> 工具類別。</p>
                <div class="bs-docs-example">
                    <ul class="pager">
                        <li class="previous disabled"><a href="#">&larr; Older</a></li>
                        <li class="next"><a href="#">Newer &rarr;</a></li>
                    </ul>
                </div>
                <pre class="prettyprint linenums">
&lt;ul class="pager"&gt;
  &lt;li class="previous disabled"&gt;
    &lt;a href="#"&gt;&amp;larr; Older&lt;/a&gt;
  &lt;/li&gt;
  ...
&lt;/ul&gt;
</pre>

            </section>

            <!-- Labels and badges
            ================================================== -->
            <section id="labels-badges">
                <div class="page-header">
                    <h1>標籤和徽章</h1>
                </div>
                <h3>標籤</h3>
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th>標籤</th>
                            <th>標記</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                                <span class="label">預設</span>
                            </td>
                            <td>
                                <code>&lt;span class="label"&gt;預設&lt;/span&gt;</code>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <span class="label label-success">成功</span>
                            </td>
                            <td>
                                <code>&lt;span class="label label-success"&gt;成功&lt;/span&gt;</code>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <span class="label label-warning">警告</span>
                            </td>
                            <td>
                                <code>&lt;span class="label label-warning"&gt;警告&lt;/span&gt;</code>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <span class="label label-important">重要</span>
                            </td>
                            <td>
                                <code>&lt;span class="label label-important"&gt;重要&lt;/span&gt;</code>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <span class="label label-info">資訊</span>
                            </td>
                            <td>
                                <code>&lt;span class="label label-info"&gt;資訊&lt;/span&gt;</code>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <span class="label label-inverse">相反色</span>
                            </td>
                            <td>
                                <code>&lt;span class="label label-inverse"&gt;相反色&lt;/span&gt;</code>
                            </td>
                        </tr>
                    </tbody>
                </table>

                <h3>徽章</h3>
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th>名稱</th>
                            <th>範例</th>
                            <th>標記</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>預設
                            </td>
                            <td>
                                <span class="badge">1</span>
                            </td>
                            <td>
                                <code>&lt;span class="badge"&gt;1&lt;/span&gt;</code>
                            </td>
                        </tr>
                        <tr>
                            <td>成功
                            </td>
                            <td>
                                <span class="badge badge-success">2</span>
                            </td>
                            <td>
                                <code>&lt;span class="badge badge-success"&gt;2&lt;/span&gt;</code>
                            </td>
                        </tr>
                        <tr>
                            <td>警告
                            </td>
                            <td>
                                <span class="badge badge-warning">4</span>
                            </td>
                            <td>
                                <code>&lt;span class="badge badge-warning"&gt;4&lt;/span&gt;</code>
                            </td>
                        </tr>
                        <tr>
                            <td>重要
                            </td>
                            <td>
                                <span class="badge badge-important">6</span>
                            </td>
                            <td>
                                <code>&lt;span class="badge badge-important"&gt;6&lt;/span&gt;</code>
                            </td>
                        </tr>
                        <tr>
                            <td>資訊
                            </td>
                            <td>
                                <span class="badge badge-info">8</span>
                            </td>
                            <td>
                                <code>&lt;span class="badge badge-info"&gt;8&lt;/span&gt;</code>
                            </td>
                        </tr>
                        <tr>
                            <td>相反色
                            </td>
                            <td>
                                <span class="badge badge-inverse">10</span>
                            </td>
                            <td>
                                <code>&lt;span class="badge badge-inverse"&gt;10&lt;/span&gt;</code>
                            </td>
                        </tr>
                    </tbody>
                </table>

                <h3>輕鬆地折疊</h3>
                <p>這是易於實作的，當沒有內容存在時，標籤和徽章將可簡單折疊（透過CSS的 :empty 選擇器）。</p>

            </section>

            <!-- Typographic components
            ================================================== -->
            <section id="typography">
                <div class="page-header">
                    <h1>排版元件</h1>
                </div>

                <h2>Hero unit</h2>
                <p><code>.hero-unit</code> 類別，一個輕量與有彈性用於展示網站重點內容的元件。它非常合適用於行銷或內容為主的網站。</p>
                <div class="bs-docs-example">
                    <div class="hero-unit">
                        <h1>Hello, world!</h1>
                        <p>This is a simple hero unit, a simple jumbotron-style component for calling extra attention to featured content or information.</p>
                        <p><a class="btn btn-primary btn-large">Learn more</a></p>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="hero-unit"&gt;
  &lt;h1&gt;Heading&lt;/h1&gt;
  &lt;p&gt;Tagline&lt;/p&gt;
  &lt;p&gt;
    &lt;a class="btn btn-primary btn-large"&gt;
      Learn more
    &lt;/a&gt;
  &lt;/p&gt;
&lt;/div&gt;
</pre>
                <p><span class="label label-info">譯者註</span>：hreo unit 不合適翻譯，它在頁面裡用一個很大區塊與大標頭等來突顯最重要的主題與主要描述，和網頁內的其他內容相比，它就像英雄一樣。</p>

                <h2>頁面標題</h2>
                <p>為 <code>h1</code> 加上簡單的外形，這可以增加適當空間和從頁面內容中分離出來。也可以在 <code>h1</code> 裡加入 <code>small</code> 元素，這就像其他元件一樣（需要額外樣式）。</p>
                <div class="bs-docs-example">
                    <div class="page-header">
                        <h1>Example page header <small>Subtext for header</small></h1>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="page-header"&gt;
  &lt;h1&gt;Example page header &lt;small&gt;Subtext for header&lt;/small&gt;&lt;/h1&gt;
&lt;/div&gt;
</pre>

            </section>

            <!-- Thumbnails
            ================================================== -->
            <section id="thumbnails">
                <div class="page-header">
                    <h1>縮圖 <small>給圖片、影片、文字等等加入網格功能</small></h1>
                </div>

                <h2>預設縮圖</h2>
                <p>預設，Bootstrap 縮圖被設計用最少標記來展示帶有連結的圖片。</p>
                <div class="row-fluid">
                    <ul class="thumbnails">
                        <li class="span3">
                            <a href="#" class="thumbnail">
                                <img data-src="holder.js/260x180" alt="">
                            </a>
                        </li>
                        <li class="span3">
                            <a href="#" class="thumbnail">
                                <img data-src="holder.js/260x180" alt="">
                            </a>
                        </li>
                        <li class="span3">
                            <a href="#" class="thumbnail">
                                <img data-src="holder.js/260x180" alt="">
                            </a>
                        </li>
                        <li class="span3">
                            <a href="#" class="thumbnail">
                                <img data-src="holder.js/260x180" alt="">
                            </a>
                        </li>
                    </ul>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="row-fluid"&gt;
  &lt;ul class="thumbnails"&gt;
    &lt;li class="span3"&gt;
      &lt;a href="#" class="thumbnail"&gt;
        &lt;img data-src="holder.js/260x180" alt=""&gt;
      &lt;/a&gt;
    &lt;/li&gt;
    ...
  &lt;/ul&gt;
&lt;/div&gt;
</pre>

                <h2>可自定義縮圖</h2>
                <p>需要一些額外的標記，就可以在縮圖裡加入任何類型的 HTML 內容，例如標題、段落、按鈕等。</p>
                <div class="row-fluid">
                    <ul class="thumbnails">
                        <li class="span4">
                            <div class="thumbnail">
                                <img data-src="holder.js/300x200" alt="">
                                <div class="caption">
                                    <h3>Thumbnail label</h3>
                                    <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                                    <p><a href="#" class="btn btn-primary">Action</a> <a href="#" class="btn">Action</a></p>
                                </div>
                            </div>
                        </li>
                        <li class="span4">
                            <div class="thumbnail">
                                <img data-src="holder.js/300x200" alt="">
                                <div class="caption">
                                    <h3>Thumbnail label</h3>
                                    <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                                    <p><a href="#" class="btn btn-primary">Action</a> <a href="#" class="btn">Action</a></p>
                                </div>
                            </div>
                        </li>
                        <li class="span4">
                            <div class="thumbnail">
                                <img data-src="holder.js/300x200" alt="">
                                <div class="caption">
                                    <h3>Thumbnail label</h3>
                                    <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                                    <p><a href="#" class="btn btn-primary">Action</a> <a href="#" class="btn">Action</a></p>
                                </div>
                            </div>
                        </li>
                    </ul>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="row-fluid"&gt;
  &lt;ul class="thumbnails"&gt;
    &lt;li class="span4"&gt;
      &lt;div class="thumbnail"&gt;
        &lt;img data-src="holder.js/300x200" alt="&gt;
        &lt;div class="caption"&gt;
          &lt;h3&gt;Thumbnail label&lt;/h3&gt;
          &lt;p&gt;...&lt;/p&gt;
          &lt;p&gt;&lt;a href="#" class="btn btn-primary"&gt;Action&lt;/a&gt; &lt;a href="#"&gt;Action&lt;/a&gt;&lt;/p&gt;
        &lt;/div&gt;
      &lt;/div&gt;
    &lt;/li&gt;
  &lt;/ul&gt;
&lt;/div&gt;
</pre>

                <h3>為何使用縮圖</h3>
                <p>縮圖（在v1.4版之前稱呼叫 <code>.media-grid</code>）很合適將圖片、影片、圖片搜尋結果、商品陳列、作品集…等用網格樣式來展示。它們可以是含連結或是單純的內容。</p>

                <h3>簡單、有彈性的標記</h3>
                <p>縮圖標記很簡單 &mdash; 用 <code>ul</code> 包含任意的 <code>li</code> 元素即可。它也非常有彈性，只需要少量的標記即可包含你想要呈現的任何類型內容。</p>

                <h3>使用網格列尺寸</h3>
                <p>最後，縮圖元件使用現有的網格系統的類別 &mdash; 像是 <code>.span2</code> 或 <code>.span3</code> &mdash; 來控制縮圖尺寸。</p>

                <h2>標記</h2>
                <p>如前面所提，縮圖所需的標記很少且直觀。以下是一個預設的<strong>圖片連結</strong>：</p>
                <pre class="prettyprint linenums">
&lt;ul class="thumbnails"&gt;
  &lt;li class="span4"&gt;
    &lt;a href="#" class="thumbnail"&gt;
      &lt;img data-src="holder.js/300x200" alt=""&gt;
    &lt;/a&gt;
  &lt;/li&gt;
  ...
&lt;/ul&gt;
</pre>
                <p>要在縮圖裡自訂 HTML 的內容，標記變化不大。為了允許區塊元素內容，我們將 <code>&lt;a&gt;</code> 替換成 <code>&lt;div&gt;</code>，像這樣：</p>
                <pre class="prettyprint linenums">
&lt;ul class="thumbnails"&gt;
  &lt;li class="span4"&gt;
    &lt;div class="thumbnail"&gt;
      &lt;img data-src="holder.js/300x200" alt=""&gt;
      &lt;h3&gt;Thumbnail label&lt;/h3&gt;
      &lt;p&gt;Thumbnail caption...&lt;/p&gt;
    &lt;/div&gt;
  &lt;/li&gt;
  ...
&lt;/ul&gt;
</pre>

                <h2>更多範例</h2>
                <p>探索一下不同網格系統類別的不同效果。你還可以設置不同的尺寸。</p>
                <ul class="thumbnails">
                    <li class="span4">
                        <a href="#" class="thumbnail">
                            <img data-src="holder.js/360x270" alt="">
                        </a>
                    </li>
                    <li class="span3">
                        <a href="#" class="thumbnail">
                            <img data-src="holder.js/260x120" alt="">
                        </a>
                    </li>
                    <li class="span2">
                        <a href="#" class="thumbnail">
                            <img data-src="holder.js/160x120" alt="">
                        </a>
                    </li>
                    <li class="span3">
                        <a href="#" class="thumbnail">
                            <img data-src="holder.js/260x120" alt="">
                        </a>
                    </li>
                    <li class="span2">
                        <a href="#" class="thumbnail">
                            <img data-src="holder.js/160x120" alt="">
                        </a>
                    </li>
                </ul>
                <pre class="prettyprint linenums">
&lt;ul class="thumbnails"&gt;
  &lt;li class="span4"&gt;
    &lt;a href="#" class="thumbnail"&gt;
      &lt;img data-src="holder.js/360x270" alt=""&gt;
    &lt;/a&gt;
  &lt;/li&gt;
  &lt;li class="span3"&gt;
    &lt;a href="#" class="thumbnail"&gt;
      &lt;img data-src="holder.js/260x120" alt=""&gt;
    &lt;/a&gt;
  &lt;/li&gt;
  &lt;li class="span2"&gt;
    &lt;a href="#" class="thumbnail"&gt;
      &lt;img data-src="holder.js/160x120" alt=""&gt;
    &lt;/a&gt;
  &lt;/li&gt;
  &lt;li class="span3"&gt;
    &lt;a href="#" class="thumbnail"&gt;
      &lt;img data-src="holder.js/260x120" alt=""&gt;
    &lt;/a&gt;
  &lt;/li&gt;
  &lt;li class="span2"&gt;
    &lt;a href="#" class="thumbnail"&gt;
      &lt;img data-src="holder.js/160x120" alt=""&gt;
    &lt;/a&gt;
  &lt;/li&gt;
&lt;/ul&gt;
</pre>
            </section>

            <!-- Alerts
            ================================================== -->
            <section id="alerts">
                <div class="page-header">
                    <h1>警告 <small>成功、警告、錯誤訊息的樣式</small></h1>
                </div>

                <h2>預設警告視窗</h2>
                <p>基本警告視窗訊息是在 <code>.alert</code> 類別包含任何文字和可選用的關閉按鈕。</p>
                <div class="bs-docs-example">
                    <div class="alert">
                        <button type="button" class="close" data-dismiss="alert">&times;</button>
                        <strong>Warning!</strong> Best check yo self, you're not looking too good.
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="alert"&gt;
  &lt;button type="button" class="close" data-dismiss="alert"&gt;&amp;times;&lt;/button&gt;
  &lt;strong&gt;Warning!&lt;/strong&gt; Best check yo self, you're not looking too good.
&lt;/div&gt;
</pre>
                <p><span class="label label-info">譯者註</span>：關閉按鈕會以「X」的樣式呈現。</p>

                <h3>關閉按鈕</h3>
                <p>行動版的 Safari 和 Opera 瀏覽器上，當使用 <code>a</code> 標籤關閉警告視窗時，除了加入 <code>data-dismiss="alert"</code> 屬性外，還要加入 <code>href="#"</code> 屬性。</p>
                <pre class="prettyprint linenums">&lt;a href="#" class="close" data-dismiss="alert"&gt;&amp;times;&lt;/a&gt;</pre>
                <p>可替代的是使用帶有 data 屬性的 <code>&lt;button&gt;</code> 元素，就像此文件的範例一樣。當使用 <code>&lt;button&gt;</code> 時，還必須包含 <code>type="button"</code> 屬性，不然你的表單不會執行 submit 動作。</p>
                <pre class="prettyprint linenums">&lt;button type="button" class="close" data-dismiss="alert"&gt;&amp;times;&lt;/button&gt;</pre>

                <h3>透過 JavaScript 關閉警告視窗</h3>
                <p>使用 @Html.ActionLink("警告視窗 jQuery 外掛", "JavaScript", Nothing, Nothing, Nothing, "alerts", Nothing, Nothing) 可以快速又簡單關閉警告視窗。</p>

                <hr class="bs-docs-separator">

                <h2>選項</h2>
                <p>對於較長的訊息，可加入 <code>.alert-block</code> 類別，用以增加警告視窗上下的邊距（padding）。</p>
                <div class="bs-docs-example">
                    <div class="alert alert-block">
                        <button type="button" class="close" data-dismiss="alert">&times;</button>
                        <h4>Warning!</h4>
                        <p>Best check yo self, you're not looking too good. Nulla vitae elit libero, a pharetra augue. Praesent commodo cursus magna, vel scelerisque nisl consectetur et.</p>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="alert alert-block"&gt;
  &lt;button type="button" class="close" data-dismiss="alert"&gt;&amp;times;&lt;/button&gt;
  &lt;h4&gt;Warning!&lt;/h4&gt;
  Best check yo self, you're not...
&lt;/div&gt;
</pre>

                <hr class="bs-docs-separator">

                <h2>其他內容</h2>
                <p>加入其他類別可改變警告視窗的含義。</p>

                <h3>錯誤或危險</h3>
                <div class="bs-docs-example">
                    <div class="alert alert-error">
                        <button type="button" class="close" data-dismiss="alert">&times;</button>
                        <strong>Oh snap!</strong> Change a few things up and try submitting again.
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="alert alert-error"&gt;
  ...
&lt;/div&gt;
</pre>

                <h3>成功</h3>
                <div class="bs-docs-example">
                    <div class="alert alert-success">
                        <button type="button" class="close" data-dismiss="alert">&times;</button>
                        <strong>Well done!</strong> You successfully read this important alert message.
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="alert alert-success"&gt;
  ...
&lt;/div&gt;
</pre>

                <h3>訊息</h3>
                <div class="bs-docs-example">
                    <div class="alert alert-info">
                        <button type="button" class="close" data-dismiss="alert">&times;</button>
                        <strong>Heads up!</strong> This alert needs your attention, but it's not super important.
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="alert alert-info"&gt;
  ...
&lt;/div&gt;
</pre>

            </section>

            <!-- Progress bars
            ================================================== -->
            <section id="progress">
                <div class="page-header">
                    <h1>進度列 <small>用於載入、轉導向、執行狀態</small></h1>
                </div>

                <h2>範例和標記</h2>

                <h3>基礎樣式</h3>
                <p>預設是一水平漸層的進度列。</p>
                <div class="bs-docs-example">
                    <div class="progress">
                        <div class="bar" style="width: 60%;"></div>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="progress"&gt;
  &lt;div class="bar" style="width: 60%;"&gt;&lt;/div&gt;
&lt;/div&gt;
</pre>

                <h3>斑馬條紋樣式</h3>
                <p>使用漸層建立一個馬斑條紋效果的進度列。不支援IE7-8。</p>
                <div class="bs-docs-example">
                    <div class="progress progress-striped">
                        <div class="bar" style="width: 20%;"></div>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="progress progress-striped"&gt;
  &lt;div class="bar" style="width: 20%;"&gt;&lt;/div&gt;
&lt;/div&gt;
</pre>

                <h3>動畫樣式</h3>
                <p>在 <code>.progress-striped</code> 加入 <code>.active</code> 類別，即可建立一個從右到左的動畫樣式。IE 僅 IE 10 支援。</p>
                <div class="bs-docs-example">
                    <div class="progress progress-striped active">
                        <div class="bar" style="width: 45%"></div>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="progress progress-striped active"&gt;
  &lt;div class="bar" style="width: 40%;"&gt;&lt;/div&gt;
&lt;/div&gt;
</pre>

                <h3>堆疊樣式</h3>
                <p>可以將多個進度列放入 <code>.progress</code> 以建立堆疊式進度列。</p>
                <div class="bs-docs-example">
                    <div class="progress">
                        <div class="bar bar-success" style="width: 35%"></div>
                        <div class="bar bar-warning" style="width: 20%"></div>
                        <div class="bar bar-danger" style="width: 10%"></div>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="progress"&gt;
  &lt;div class="bar bar-success" style="width: 35%;"&gt;&lt;/div&gt;
  &lt;div class="bar bar-warning" style="width: 20%;"&gt;&lt;/div&gt;
  &lt;div class="bar bar-danger" style="width: 10%;"&gt;&lt;/div&gt;
&lt;/div&gt;
</pre>

                <hr class="bs-docs-separator">

                <h2>選項</h2>

                <h3>額外顏色</h3>
                <p>進度列和按鈕、警告視窗共用某些類別，以取得一致的樣式。</p>
                <div class="bs-docs-example">
                    <div class="progress progress-info" style="margin-bottom: 9px;">
                        <div class="bar" style="width: 20%"></div>
                    </div>
                    <div class="progress progress-success" style="margin-bottom: 9px;">
                        <div class="bar" style="width: 40%"></div>
                    </div>
                    <div class="progress progress-warning" style="margin-bottom: 9px;">
                        <div class="bar" style="width: 60%"></div>
                    </div>
                    <div class="progress progress-danger">
                        <div class="bar" style="width: 80%"></div>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="progress progress-info"&gt;
  &lt;div class="bar" style="width: 20%"&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;div class="progress progress-success"&gt;
  &lt;div class="bar" style="width: 40%"&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;div class="progress progress-warning"&gt;
  &lt;div class="bar" style="width: 60%"&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;div class="progress progress-danger"&gt;
  &lt;div class="bar" style="width: 80%"&gt;&lt;/div&gt;
&lt;/div&gt;
</pre>

                <h3>斑馬條紋進行列</h3>
                <p>類似純色顏色，我們也能建立各種不同顏色的斑馬條紋進度列。</p>
                <div class="bs-docs-example">
                    <div class="progress progress-info progress-striped" style="margin-bottom: 9px;">
                        <div class="bar" style="width: 20%"></div>
                    </div>
                    <div class="progress progress-success progress-striped" style="margin-bottom: 9px;">
                        <div class="bar" style="width: 40%"></div>
                    </div>
                    <div class="progress progress-warning progress-striped" style="margin-bottom: 9px;">
                        <div class="bar" style="width: 60%"></div>
                    </div>
                    <div class="progress progress-danger progress-striped">
                        <div class="bar" style="width: 80%"></div>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="progress progress-info progress-striped"&gt;
  &lt;div class="bar" style="width: 20%"&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;div class="progress progress-success progress-striped"&gt;
  &lt;div class="bar" style="width: 40%"&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;div class="progress progress-warning progress-striped"&gt;
  &lt;div class="bar" style="width: 60%"&gt;&lt;/div&gt;
&lt;/div&gt;
&lt;div class="progress progress-danger progress-striped"&gt;
  &lt;div class="bar" style="width: 80%"&gt;&lt;/div&gt;
&lt;/div&gt;
</pre>

                <hr class="bs-docs-separator">

                <h2>瀏覽器支援</h2>
                <p>進度列使用 CSS3 漸層、轉場和動畫效果，這些都不被 IE7-9 或舊版的 Firefox 支援。</p>
                <p>基本上，Internet Explorer 10 和 Opera 12 之前所有版本均不支援動畫。</p>

            </section>

            <!-- Media object
            ================================================== -->
            <section id="media">
                <div class="page-header">
                    <h1>媒體物件</h1>
                </div>
                <p class="lead">這是一個抽像物件樣式，用來建立各種不同類型的元件（像部落格的評論、Tweet 等），這些元件都有文字內容的左邊或右邊對齊的圖片。</p>

                <h2>預設範例</h2>
                <p>預設媒體樣式是在內容區塊的左邊或右邊浮動一個媒體物件（圖片、影片、聲音）。</p>
                <div class="bs-docs-example">
                    <div class="media">
                        <a class="pull-left" href="#">
                            <img class="media-object" data-src="holder.js/64x64">
                        </a>
                        <div class="media-body">
                            <h4 class="media-heading">Media heading</h4>
                            Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.
                        </div>
                    </div>
                    <div class="media">
                        <a class="pull-left" href="#">
                            <img class="media-object" data-src="holder.js/64x64">
                        </a>
                        <div class="media-body">
                            <h4 class="media-heading">Media heading</h4>
                            Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.
                <div class="media">
                    <a class="pull-left" href="#">
                        <img class="media-object" data-src="holder.js/64x64">
                    </a>
                    <div class="media-body">
                        <h4 class="media-heading">Media heading</h4>
                        Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.
                    </div>
                </div>
                        </div>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="media"&gt;
  &lt;a class="pull-left" href="#"&gt;
    &lt;img class="media-object" data-src="holder.js/64x64"&gt;
  &lt;/a&gt;
  &lt;div class="media-body"&gt;
    &lt;h4 class="media-heading"&gt;Media heading&lt;/h4&gt;
    ...

    &lt;!-- Nested media object --&gt;
    &lt;div class="media"&gt;
      ...
    &lt;/div&gt;
  &lt;/div&gt;
&lt;/div&gt;
</pre>

                <hr class="bs-docs-separator">

                <h2>媒體清單</h2>
                <p>利用一些額外標記就可以將媒體包含在清單之內（這對評論回應與文章清單很有用）。</p>
                <div class="bs-docs-example">
                    <ul class="media-list">
                        <li class="media">
                            <a class="pull-left" href="#">
                                <img class="media-object" data-src="holder.js/64x64">
                            </a>
                            <div class="media-body">
                                <h4 class="media-heading">Media heading</h4>
                                <p>Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis.</p>
                                <!-- Nested media object -->
                                <div class="media">
                                    <a class="pull-left" href="#">
                                        <img class="media-object" data-src="holder.js/64x64">
                                    </a>
                                    <div class="media-body">
                                        <h4 class="media-heading">Nested media heading</h4>
                                        Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis.
                                        <!-- Nested media object -->
                                        <div class="media">
                                            <a class="pull-left" href="#">
                                                <img class="media-object" data-src="holder.js/64x64">
                                            </a>
                                            <div class="media-body">
                                                <h4 class="media-heading">Nested media heading</h4>
                                                Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis.
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <!-- Nested media object -->
                                <div class="media">
                                    <a class="pull-left" href="#">
                                        <img class="media-object" data-src="holder.js/64x64">
                                    </a>
                                    <div class="media-body">
                                        <h4 class="media-heading">Nested media heading</h4>
                                        Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis.
                                    </div>
                                </div>
                            </div>
                        </li>
                        <li class="media">
                            <a class="pull-right" href="#">
                                <img class="media-object" data-src="holder.js/64x64">
                            </a>
                            <div class="media-body">
                                <h4 class="media-heading">Media heading</h4>
                                Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis.
                            </div>
                        </li>
                    </ul>
                </div>
                <pre class="prettyprint linenums">
&lt;ul class="media-list"&gt;
  &lt;li class="media"&gt;
    &lt;a class="pull-left" href="#"&gt;
      &lt;img class="media-object" data-src="holder.js/64x64"&gt;
    &lt;/a&gt;
    &lt;div class="media-body"&gt;
      &lt;h4 class="media-heading"&gt;Media heading&lt;/h4&gt;
      ...

      &lt;!-- Nested media object --&gt;
      &lt;div class="media"&gt;
        ...
     &lt;/div&gt;
    &lt;/div&gt;
  &lt;/li&gt;
&lt;/ul&gt;
</pre>

            </section>

            <!-- Miscellaneous
            ================================================== -->
            <section id="misc">
                <div class="page-header">
                    <h1>Misc <small>輕量工具元件</small></h1>
                </div>

                <h2>Well樣式</h2>
                <p>使用 well 樣式能給元素加入一個簡單的嵌入（inset）效果。</p>
                <div class="bs-docs-example">
                    <div class="well">
                        Look, I'm in a well!
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="well"&gt;
  ...
&lt;/div&gt;
</pre>
                <h3>選擇性類別</h3>
                <p><code>.well-large</code> 與 <code>.well-small</code> 兩個選擇性類別可以控制邊距（padding）與圓角。</p>
                <div class="bs-docs-example">
                    <div class="well well-large">
                        Look, I'm in a well!
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="well well-large"&gt;
  ...
&lt;/div&gt;
</pre>
                <div class="bs-docs-example">
                    <div class="well well-small">
                        Look, I'm in a well!
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="well well-small"&gt;
  ...
&lt;/div&gt;
</pre>

                <h2>關閉 icon</h2>
                <p>使用一般關閉 icon 來關閉對話視窗或警告視窗。</p>
                <div class="bs-docs-example">
                    <p>
                        <button class="close" style="float: none;">&times;</button></p>
                </div>
                <pre class="prettyprint linenums">&lt;button class="close"&gt;&amp;times;&lt;/button&gt;</pre>
                <p>如果寧可使用連結，iOS 設備為了 click 事件需要 <code>href="#"</code>。</p>
                <pre class="prettyprint linenums">&lt;a class="close" href="#"&gt;&amp;times;&lt;/a&gt;</pre>

                <h2>輔助類別</h2>
                <p>用於小螢幕或調整行為的簡單且功能單一的類別。</p>

                <h4>.pull-left</h4>
                <p>讓元素向左浮動。</p>
                <pre class="prettyprint linenums">
class="pull-left"
</pre>
                <pre class="prettyprint linenums">
.pull-left {
  float: left;
}
</pre>

                <h4>.pull-right</h4>
                <p>讓元素向右浮動。</p>
                <pre class="prettyprint linenums">
class="pull-right"
</pre>
                <pre class="prettyprint linenums">
.pull-right {
  float: right;
}
</pre>

                <h4>.muted</h4>
                <p>改變元素顏色為 <code>#999</code>。</p>
                <pre class="prettyprint linenums">
class="muted"
</pre>
                <pre class="prettyprint linenums">
.muted {
  color: #999;
}
</pre>

                <h4>.clearfix</h4>
                <p>為任何元素取消 <code>浮動（float）</code> 效果。</p>
                <pre class="prettyprint linenums">
class="clearfix"
</pre>
                <pre class="prettyprint linenums">
.clearfix {
  *zoom: 1;
  &:before,
  &:after {
    display: table;
    content: "";
  }
  &:after {
    clear: both;
  }
}
</pre>

            </section>
        </div>
    </div>
</div>