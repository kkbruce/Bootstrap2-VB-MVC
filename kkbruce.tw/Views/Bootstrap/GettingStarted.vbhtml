﻿@Code
    ViewData("Title") = "旅程開始"
    ViewData("Description") = "概觀整個 Bootstrap 專案與內容，並瞭解 Bootstrap 文件章節和有那些元件可以使用，學習如何打造一個簡單 Bootstrap 範本，最後有數幾可學習參考的 Bootstrap 範例。"
    ViewData("Keywords") = "下載Bootstrap, Bootstrap檔案結構, Bootstrap文件內容, Bootstrap元件清單, Bootstrap範例實作, Bootstrap範例學習"
End Code

@section navbar
    @Html.Partial("_NavBar")
End Section

<header class="jumbotron subhead" id="overview">
    <div class="container">
        <h1>旅程開始</h1>
        <p class="lead">概觀整個專案與內容，和如何使用一個簡單的範本。</p>
    </div>
</header>

<div class="container">
    <!-- Docs nav
    ================================================== -->
    <div class="row">
        <nav class="span3 bs-docs-sidebar">
            <ul class="nav nav-list bs-docs-sidenav">
                <li><a href="#download-bootstrap"><i class="icon-chevron-right"></i> 下載</a></li>
                <li><a href="#file-structure"><i class="icon-chevron-right"></i> 檔案結構</a></li>
                <li><a href="#contents"><i class="icon-chevron-right"></i> 含有什麼</a></li>
                <li><a href="#html-template"><i class="icon-chevron-right"></i> HTML範本</a></li>
                <li><a href="#examples"><i class="icon-chevron-right"></i> 範例</a></li>
                <li><a href="#what-next"><i class="icon-chevron-right"></i> 下一步?</a></li>
            </ul>
        </nav>
        <div class="span9">
            <nav>
                目前位置：@Html.MvcSiteMap().SiteMapPath()
            </nav>
                        
            <!-- Download
            ================================================== -->
            <section id="download-bootstrap">
                <div class="page-header">
                    <h1>1. 下載</h1>
                </div>
                <p class="lead">下載之前，確認你是否有一個程式碼編輯器（我們推薦 <a href="http://sublimetext.com/2" target="_blank">Sublime Text 2</a>）, 且你是否已經有了足夠的 HTML 與 CSS 知識以開始作業。這裡我們不詳細說明原始碼文件，但他們可以隨時被下載。我們專注在完整的 Bootstrap 文件以開始作業。</p>
                <p><span class="label label-info">譯者註</span>：這裡的”<b>我們</b>“是指原文件作者。我另外推薦 <a href="http://www.microsoft.com/web/webmatrix/" target="_blank">Microsoft WebMatrix</a> 或 <a href="http://www.microsoft.com/visualstudio/cht/downloads#d-2012-express" target="_blank">Visual Studio Express 2012 for Web</a>，<strong>它們都是完全免費的網頁開發工具</strong>，好處是，撰寫程式碼時能有<em>自動提示（IntelliSense）</em>功能。</p>

                <div class="row-fluid">
                    <div class="span6">
                        <h2>下載完整文件</h2>
                        <p><strong>快速開始：</strong>取得完整與最小化版本，里面含有 CSS、JS、和圖片。但是，不包含文件和原始碼。</p>
                        <p>@Html.ActionLink("下載 Bootstrap", "Customize", Nothing, Nothing, Nothing, "download", Nothing, New With {.class = "btn btn-large btn-primary"})</p>
                    </div>
                    <div class="span6">
                        <h2>下載原始碼</h2>
                        <p>直接從 GitHub 下載最新版原始碼，包含 CSS、JavaScript 及說明文件。</p>
                        <p><a class="btn btn-large" href="https://github.com/twitter/bootstrap/zipball/master" target="_blank">下載 Bootstrap 原始碼</a></p>
                    </div>
                </div>
            </section>

            <!-- File structure
            ================================================== -->
            <section id="file-structure">
                <div class="page-header">
                    <h1>2. 檔案結構</h1>
                </div>
                <p class="lead">下載後可以找到下面檔案結構和內容，檔案都照著邏輯分類且提供完整與最小化兩個版本。</p>
                <p>將下載的檔案解壓縮後，可以看到 bootstrap 目錄下的結構，看起來像：</p>
                <pre class="prettyprint">
  bootstrap/
  ├── css/
  │   ├── bootstrap.css
  │   ├── bootstrap.min.css
  ├── js/
  │   ├── bootstrap.js
  │   ├── bootstrap.min.js
  └── img/
      ├── glyphicons-halflings.png
      └── glyphicons-halflings-white.png
</pre>
                <p>這就是 Bootstrap 基本結構：完整的檔案可以快速應用於任何網頁專案。我們提供完整的 CSS 和 JS 檔案（<code>bootstrap.*</code>），也同時提供完整與最小化 CSS 與 JS 檔案（<code>bootstrap.min.*</code>）。圖片檔是使用 <a href="http://imageoptim.com/">ImageOptim</a> 來壓縮，它是一支 Mac 用來壓縮 PNG 檔案的應用程式。</p>
                <p>
                    注意，所有 JavaScript 外掛都需依賴 jQuery。
                </p>
            </section>

            <!-- Contents
            ================================================== -->
            <section id="contents">
                <div class="page-header">
                    <h1>3. 含有什麼</h1>
                </div>
                <p class="lead">Bootstrap 中的 HTML、CSS 和 JS 適合各種設備，不過，它們可以被簡單分類成幾個類別，可以參考本文件頂部的巡覽列。</p>

                <h2>文件章節</h2>
                <h4>@Html.ActionLink("架構", "Scaffolding")</h4>
                <p>body元素的全域樣式，用於重設背景、連結樣式、網格系統和兩個簡單佈局結構。</p>
                <h4>@Html.ActionLink("基礎CSS", "BaseCSS")</h4>
                <p>常見HTML元素，像是佈局、程式碼、表格、表單和按鈕。還包含 <a href="http://glyphicons.com">Glyphicons</a>。一個非常優秀的icon圖集。</p>
                <h4>@Html.ActionLink("元件", "Components")</h4>
                <p>常見介面元件，像是標簽、pill、巡覽、警告、頁面標頭等。</p>
                <h4>@Html.ActionLink("JavaScript", "JavaScript")</h4>
                <p>和元件類似，這些JavaScript外掛用以實現如提示（tooltip）、彈出視窗（popover）、對話視窗（modal）等具互動性的元件。</p>

                <h2>元件清單</h2>
                <p><strong>元件庫</strong>和<strong>JavaScript外掛庫</strong>提供以下介面元素。</p>
                <ul>
                    <li>按鈕群組</li>
                    <li>按鈕下拉選單</li>
                    <li>巡覽標籤、pill、清單</li>
                    <li>巡覽列</li>
                    <li>標籤</li>
                    <li>徽章</li>
                    <li>頁面標題和 hero unit</li>
                    <li>縮圖</li>
                    <li>警告視窗</li>
                    <li>進度列</li>
                    <li>對話視窗</li>
                    <li>下接式選單</li>
                    <li>工具提示</li>
                    <li>彈出視窗</li>
                    <li>手風琴樣式</li>
                    <li>輪播</li>
                    <li>排版</li>
                </ul>
                <p>接下來的介紹中，我們會每一個的詳細介紹。在此之前，先看看如何使用且客製它們。</p>
            </section>

            <!-- HTML template
            ================================================== -->
            <section id="html-template">
                <div class="page-header">
                    <h1>4. 基本HTML範本</h1>
                </div>
                <p class="lead">為了把關注點完全放到使用Bootstrap這件事情上，我們先做一些準備工作，我們將利用一個基本的 HTML 範本，其中包含了 @Html.ActionLink("檔案結構", "GettingStarted", Nothing, Nothing, Nothing, "file-structure", Nothing, Nothing) 一章中提到的所有內容。</p>
                <p>現在，這裡呈現一個<strong>典型的 HTML 內容</strong>：</p>
                <pre class="prettyprint linenums">
&lt;!DOCTYPE html&gt;
&lt;html&gt;
  &lt;head&gt;
    &lt;title&gt;Bootstrap 101 Template&lt;/title&gt;
    &lt;meta name="viewport" content="width=device-width, initial-scale=1.0"&gt;
  &lt;/head&gt;
  &lt;body&gt;
    &lt;h1&gt;Hello, world!&lt;/h1&gt;
    &lt;script src="http://code.jquery.com/jquery.js"&gt;&lt;/script&gt;
  &lt;/body&gt;
&lt;/html&gt;
</pre>
                <p>加入必要的 CSS（bootstrap.min.css） 與 JS（bootstrap.min.js） 檔案，使其成為一個<strong>Bootstrap範本</strong>：</p>
                <p><span class="label label-info">譯者註</span>：範例引用最小化版本，可修改為完整版本。另外，路徑請依讀者環境自行修改。</p>
                <pre class="prettyprint linenums">
&lt;!DOCTYPE html&gt;
&lt;html&gt;
  &lt;head&gt;
    &lt;title&gt;Bootstrap 101 Template&lt;/title&gt;
    &lt;meta name="viewport" content="width=device-width, initial-scale=1.0"&gt;
    &lt;!-- Bootstrap --&gt;
    &lt;link href="css/bootstrap.min.css" rel="stylesheet" media="screen"&gt;
  &lt;/head&gt;
  &lt;body&gt;
    &lt;h1&gt;Hello, world!&lt;/h1&gt;
    &lt;script src="http://code.jquery.com/jquery.js"&gt;&lt;/script&gt;
    &lt;script src="js/bootstrap.min.js"&gt;&lt;/script&gt;
  &lt;/body&gt;
&lt;/html&gt;
</pre>
                <p><strong>設置成功！</strong>加入這兩個檔案，你就可以開始用 Bootstrap 開發任何網站應用程式。</p>
            </section>

            <!-- Examples
            ================================================== -->
            <section id="examples">
                <div class="page-header">
                    <h1>5. 範例</h1>
                </div>
                <p class="lead">以下幾個以基本範本為範例的排例，希望能導引大家進行舉一反三的腦力激盪，而不是把它們當成最後結果。</p>
                <p><span class="label label-info">譯者註</span>：讀者要學習原始程式碼裡的設置。看不懂的細節部分，可以學習完後面文件後再回頭當成複習用教材。</p>
                <ul class="thumbnails bootstrap-examples">
                    <li class="span3">
                        <a class="thumbnail" href="@Url.Action("Examples", "Bootstrap", New With {.sitename = "starter-template"})">
                            <img src="~/Images/bootstrap/examples/bootstrap-example-starter.png" alt="">
                        </a>
                        <h4>簡易範本</h4>
                        <p>一個包含 Bootstrap 所需的 CSS 與 JavaScript 的最簡易 HTML 範本。</p>
                    </li>
                    <li class="span3">
                        <a class="thumbnail" href="@Url.Action("Examples", "Bootstrap", New With {.sitename = "hero"})">
                            <img src="~/Images/bootstrap/examples/bootstrap-example-marketing.png" alt="">
                        </a>
                        <h4>基本行銷網站</h4>
                        <p>一個主訊息區塊和三個支援性元性區塊。</p>
                    </li>
                    <li class="span3">
                        <a class="thumbnail" href="@Url.Action("Examples", "Bootstrap", New With {.sitename = "fluid"})">
                            <img src="~/Images/bootstrap/examples/bootstrap-example-fluid.png" alt="">
                        </a>
                        <h4>流動佈局</h4>
                        <p>使用新的嚮應式設計，流動網格系統建立一個流動式佈局網頁。</p>
                    </li>

                    <li class="span3">
                        <a class="thumbnail" href="@Url.Action("Examples", "Bootstrap", New With {.sitename = "marketing-narrow"})">
                            <img src="~/Images/bootstrap/examples/bootstrap-example-marketing-narrow.png" alt="">
                        </a>
                        <h4>精簡行銷網站</h4>
                        <p>適用於小專案或團隊簡單、輕量的行銷網站範本。</p>
                    </li>
                    <li class="span3">
                        <a class="thumbnail" href="@Url.Action("Examples", "Bootstrap", New With {.sitename = "justified-nav"})">
                            <img src="~/Images/bootstrap/examples/bootstrap-example-justified-nav.png" alt="">
                        </a>
                        <h4>合適巡覽</h4>
                        <p>一個等寬巡覽連結列的行銷網頁。</p>
                    </li>
                    <li class="span3">
                        <a class="thumbnail" href="@Url.Action("Examples", "Bootstrap", New With {.sitename = "signin"})">
                            <img src="~/Images/bootstrap/examples/bootstrap-example-signin.png" alt="">
                        </a>
                        <h4>登入</h4>
                        <p>
                            基本的登入表單，使用客製化、大表單控制項和彈性佈局。
                        </p>
                    </li>

                    <li class="span3">
                        <a class="thumbnail" href="@Url.Action("Examples", "Bootstrap", New With {.sitename = "sticky-footer"})">
                            <img src="~/Images/bootstrap/examples/bootstrap-example-sticky-footer.png" alt="">
                        </a>
                        <h4>固定頁腳</h4>
                        <p>把固定高度的頁腳釘在使用者可見區域的底部。</p>
                    </li>
                    <li class="span3">
                        <a class="thumbnail" href="@Url.Action("Examples", "Bootstrap", New With {.sitename = "carousel"})">
                            <img src="~/Images/bootstrap/examples/bootstrap-example-carousel.png" alt="">
                        </a>
                        <h4>大螢幕輪播</h4>
                        <p>一個更有互動性與高可看性輪播的行銷網站。</p>
                    </li>
                </ul>
            </section>

            <!-- Next
            ================================================== -->
            <section id="what-next">
                <div class="page-header">
                    <h1>下一步？</h1>
                </div>
                <p class="lead">根據文件頂端的分類資訊查詢更多範例、程式碼片段或客製化 Bootstrap，為你將展開的專案進行引導。</p>
                @Html.ActionLink("瀏覽 Bootstrap 文件", "Scaffolding", Nothing, New With {.class = "btn btn-large btn-primary"})
                @Html.ActionLink("客製化 Bootstrap", "Customize", Nothing, New With {.class = "btn btn-large",.style="margin-left: 5px;" })
            </section>
            
        </div>
    </div>
</div>

