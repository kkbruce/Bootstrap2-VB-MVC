﻿@Code
    ViewData("Title") = "架構"
    ViewData("Description") = "Bootstrap 建置於HTML5與CCS3技術之上，利用了重置樣式重新設置。Bootstrap是以12列網格系統來進行固定或流動式佈局，最棒的是 Bootstrap 也能快速進行嚮應式網頁設計（RWD）。"
    ViewData("Keywords") = "Bootstrap架構, 12列網格系統, 流動式網格系統, Bootstrap佈局, Bootstrap嚮應式設計, Bootstrap RWD"
End Code

@section navbar
    @Html.Partial("_NavBar")
End Section

<header class="jumbotron subhead" id="overview">
    <div class="container">
        <h1>架構</h1>
        <p class="lead">Bootstrap 是建立在12列網格、佈局和元件之上。</p>
    </div>
</header>

<div class="container">
    <!-- Docs nav
    ================================================== -->
    <div class="row">
        <nav class="span3 bs-docs-sidebar">
            <ul class="nav nav-list bs-docs-sidenav">
                <li><a href="#global"><i class="icon-chevron-right"></i> 全域樣式</a></li>
                <li><a href="#gridSystem"><i class="icon-chevron-right"></i> 網格系統</a></li>
                <li><a href="#fluidGridSystem"><i class="icon-chevron-right"></i> 流動網格系統</a></li>
                <li><a href="#layouts"><i class="icon-chevron-right"></i> 佈局</a></li>
                <li><a href="#responsive"><i class="icon-chevron-right"></i> 嚮應式設計</a></li>
            </ul>
        </nav>
        <div class="span9">
            <nav>
                目前位置：@Html.MvcSiteMap().SiteMapPath()
            </nav>

            <!-- Global Bootstrap settings
            ================================================== -->
            <section id="global">
                <div class="page-header">
                    <h1>全域設置</h1>
                </div>

                <h3>必須使用HTML5 doctype</h3>
                <p>Bootstrap 使用的某些 HTML 元素和 CSS 屬性必須使用 HTML5 doctype。因此，所有網頁開頭中都必須包含此宣告。</p>
<pre class="prettyprint linenums">
&lt;!DOCTYPE html&gt;
&lt;html lang="en"&gt;
  ...
&lt;/html&gt;
</pre>

                <h3>佈局與連結</h3>
                <p>Bootstrap 為螢幕、佈局和連結設置了基本的全域樣式。尤其是，我們：</p>
                <ul>
                    <li>移除 body 的 <code>margin</code></li>
                    <li>設置了 <code>body</code> 的背景顏色 <code>background-color: white;</code></li>
                    <li>使用 <code>@@baseFontFamily</code>、<code>@@baseFontSize</code> 和 <code>@@baseLineHeight</code> 屬性做為佈局的基礎</li>
                    <li>透過 <code>@@linkColor</code> 設置全域連結顏色，當連結處於 <code>:hover</code> 狀態時才會帶有下劃線</li>
                </ul>
                <p>這些樣式可以在 <strong>scaffolding.less</strong> 找到。</p>
                <p><span class="label label-info">譯者註</span>：Bootstrap 是使用 LESS 撰寫，如果讀者習慣使用 <a href="http://sass-lang.com/" target="_blank">SCSS</a> 的話，可以參考 <a href="https://github.com/jlong/sass-twitter-bootstrap" target="_blank">bootstrap.scss</a> 這個專案的內容。</p>

                <h3>用Normalize重置樣式</h3>
                <p>在 Bootstrap 2 開始，舊的重置方式被 <a href="http://necolas.github.com/normalize.css/" target="_blank">Normalize.css</a> 取代，這是由 <a href="http://twitter.com/necolas" target="_blank">Nicolas Gallagher</a> 和 <a href="http://twitter.com/jon_neal" target="_blank">Jonathan Neal</a> 共同維護，並且還被 <a href="http://html5boilerplate.com" target="_blank">HTML5 Boilerplate</a> 採用。雖然我們在 <strong>reset.less</strong> 裡使用許多 Normalize，不過我們也移除不合適 Bootstrap 的元素。</p>
            </section>

            <!-- Grid system
            ================================================== -->
            <section id="gridSystem">
                <div class="page-header">
                    <h1>預設網格系統</h1>
                </div>

                <h2>網格範例</h2>
                <p>預設的 Bootstrap 網格系統（grid system）為 <strong>12 列</strong>，這會做出一個 940px 寬的容器，並且沒有 @Html.ActionLink("嚮應式特性", "Scaffolding", Nothing, Nothing, Nothing, "responsive", Nothing, Nothing)。如果加入嚮應式 CSS 檔案，網格系統會自動依可視視窗的寬度從 724px 到 1170px 進行動態調整。可視視窗在低於 767px 寬度下，列會變成流動且垂直堆疊。</p>
                <div class="bs-docs-grid">
                    <div class="row show-grid">
                        <div class="span1">1</div>
                        <div class="span1">1</div>
                        <div class="span1">1</div>
                        <div class="span1">1</div>
                        <div class="span1">1</div>
                        <div class="span1">1</div>
                        <div class="span1">1</div>
                        <div class="span1">1</div>
                        <div class="span1">1</div>
                    </div>
                    <div class="row show-grid">
                        <div class="span2">2</div>
                        <div class="span3">3</div>
                        <div class="span4">4</div>
                    </div>
                    <div class="row show-grid">
                        <div class="span4">4</div>
                        <div class="span5">5</div>
                    </div>
                    <div class="row show-grid">
                        <div class="span9">9</div>
                    </div>
                </div>

                <h3>基礎網格的 HTML</h3>
                <p>一個簡易的兩列佈局，建立一個 <code>.row</code> 類別量，然在容器中加入適量的 <code>.span*</code> 的列。由於預設是 12 列的網格，所以 <code>.span*</code> 列網格量總合最多為 12（或者等於父容器的網格數）。</p>
                <p><span class="label label-info">譯者註</span>：－－－－這是行，｜｜｜｜這是列。1 行（row）可容納 12 列（column）。</p>
<pre class="prettyprint linenums">
&lt;div class="row"&gt;
  &lt;div class="span4"&gt;...&lt;/div&gt;
  &lt;div class="span8"&gt;...&lt;/div&gt;
&lt;/div&gt;
</pre>
                <p>在上面範例，我們使用了 <code>.span4</code> 和 <code>.span8</code> 兩列，兩列的總合共 12 列（1 行）。</p>

                <h2>偏移列</h2>
                <p>把列向右移動使用 <code>.offset*</code> 類別。每個類別都會給列的左邊距（left margin）加增指定偏移的列數。例如，<code>.offset4</code> 將 <code>.span4</code> 右偏移 4 個列的寬度。</p>
                <div class="bs-docs-grid">
                    <div class="row show-grid">
                        <div class="span4">4</div>
                        <div class="span3 offset2">3 offset 2</div>
                    </div>
                    <!-- /row -->
                    <div class="row show-grid">
                        <div class="span3 offset1">3 offset 1</div>
                        <div class="span3 offset2">3 offset 2</div>
                    </div>
                    <!-- /row -->
                    <div class="row show-grid">
                        <div class="span6 offset3">6 offset 3</div>
                    </div>
                    <!-- /row -->
                </div>
<pre class="prettyprint linenums">
&lt;div class="row"&gt;
  &lt;div class="span4"&gt;...&lt;/div&gt;
  &lt;div class="span3 offset2"&gt;...&lt;/div&gt;
&lt;/div&gt;
</pre>

                <h2>巢狀列</h2>
                <p>在預設的網格中，在已知的 <code>.span*</code> 內加入一個新的 <code>.row</code> 與 <code>.span*</code> 列，就能巢狀你的內容。巢狀行中的列總數最大數應該等於父列數。</p>
                <div class="row show-grid">
                    <div class="span9">
                        Level 1 column
              <div class="row show-grid">
                  <div class="span6">
                      Level 2
                  </div>
                  <div class="span3">
                      Level 2
                  </div>
              </div>
                    </div>
                </div>
<pre class="prettyprint linenums">
&lt;div class="row"&gt;
  &lt;div class="span9"&gt;
    Level 1 column
    &lt;div class="row"&gt;
      &lt;div class="span6"&gt;Level 2&lt;/div&gt;
      &lt;div class="span3"&gt;Level 2&lt;/div&gt;
    &lt;/div&gt;
  &lt;/div&gt;
&lt;/div&gt;
</pre>
            </section>

            <!-- Fluid grid system
            ================================================== -->
            <section id="fluidGridSystem">
                <div class="page-header">
                    <h1>流動網格系統</h1>
                </div>

                <h2>流動網格範例</h2>
                <p>流動網格系統裡的列寬度使用百分比替代像素。它和固定網格系統一樣擁有嚮應式能力，這能保證它能對關鍵的螢幕解析度和設備做出調整。</p>
                <div class="bs-docs-grid">
                    <div class="row-fluid show-grid">
                        <div class="span1">1</div>
                        <div class="span1">1</div>
                        <div class="span1">1</div>
                        <div class="span1">1</div>
                        <div class="span1">1</div>
                        <div class="span1">1</div>
                        <div class="span1">1</div>
                        <div class="span1">1</div>
                        <div class="span1">1</div>
                        <div class="span1">1</div>
                        <div class="span1">1</div>
                        <div class="span1">1</div>
                    </div>
                    <div class="row-fluid show-grid">
                        <div class="span4">4</div>
                        <div class="span4">4</div>
                        <div class="span4">4</div>
                    </div>
                    <div class="row-fluid show-grid">
                        <div class="span4">4</div>
                        <div class="span8">8</div>
                    </div>
                    <div class="row-fluid show-grid">
                        <div class="span6">6</div>
                        <div class="span6">6</div>
                    </div>
                    <div class="row-fluid show-grid">
                        <div class="span12">12</div>
                    </div>
                </div>

                <h3>基本流動網格的 HTML</h3>
                <p>將 <code>.row</code> 替代為 <code>.row-fluid</code> 就能讓任何一行“流動（fluid）”起來。用於列裡的類別（<code>.span*</code>）不用改變，這樣方便在流動與固定網格之間轉換。</p>
<pre class="prettyprint linenums">
&lt;div class="row-fluid"&gt;
  &lt;div class="span4"&gt;...&lt;/div&gt;
  &lt;div class="span8"&gt;...&lt;/div&gt;
&lt;/div&gt;
</pre>

                <h2>流動的偏移</h2>
                <p>操作方式與固定網格系統偏移一樣：給任何想偏移的列加入 <code>.offset*</code> 。</p>
                <div class="bs-docs-grid">
                    <div class="row-fluid show-grid">
                        <div class="span4">4</div>
                        <div class="span4 offset4">4 offset 4</div>
                    </div>
                    <!-- /row -->
                    <div class="row-fluid show-grid">
                        <div class="span3 offset3">3 offset 3</div>
                        <div class="span3 offset3">3 offset 3</div>
                    </div>
                    <!-- /row -->
                    <div class="row-fluid show-grid">
                        <div class="span6 offset6">6 offset 6</div>
                    </div>
                    <!-- /row -->
                </div>
<pre class="prettyprint linenums">
&lt;div class="row-fluid"&gt;
  &lt;div class="span4"&gt;...&lt;/div&gt;
  &lt;div class="span4 offset2"&gt;...&lt;/div&gt;
&lt;/div&gt;
</pre>

                <h2>流動的巢狀</h2>
                <p>這和固定網頁的巢狀就有點不同：巢狀的列數總合要等於 12。這是因為流動網格使用百分比來設置每列的寬度。</p>
                <div class="row-fluid show-grid">
                    <div class="span12">
                        Fluid 12
              <div class="row-fluid show-grid">
                  <div class="span6">
                      Fluid 6
                  <div class="row-fluid show-grid">
                      <div class="span6">
                          Fluid 6
                      </div>
                      <div class="span6">
                          Fluid 6
                      </div>
                  </div>
                  </div>
                  <div class="span6">
                      Fluid 6
                  </div>
              </div>
                    </div>
                </div>
<pre class="prettyprint linenums">
&lt;div class="row-fluid"&gt;
  &lt;div class="span12"&gt;
    Fluid 12
    &lt;div class="row-fluid"&gt;
      &lt;div class="span6"&gt;
        Fluid 6
        &lt;div class="row-fluid"&gt;
          &lt;div class="span6"&gt;Fluid 6&lt;/div&gt;
          &lt;div class="span6"&gt;Fluid 6&lt;/div&gt;
        &lt;/div&gt;
      &lt;/div&gt;
      &lt;div class="span6"&gt;Fluid 6&lt;/div&gt;
    &lt;/div&gt;
  &lt;/div&gt;
&lt;/div&gt;
</pre>
            </section>

            <!-- Layouts (Default and fluid)
           ================================================== -->
            <section id="layouts">
                <div class="page-header">
                    <h1>佈局</h1>
                </div>

                <h2>固定佈局</h2>
                <p>提供一個共用固定寬度（也可選擇嚮應式）的佈局方式，僅僅需要 <code>&lt;div class="container"&gt;</code>。</p>
                <div class="mini-layout">
                    <div class="mini-layout-body"></div>
                </div>
<pre class="prettyprint linenums">
&lt;body&gt;
  &lt;div class="container"&gt;
    ...
  &lt;/div&gt;
&lt;/body&gt;
</pre>

                <h2>流動佈局</h2>
                <p>使用 <code>&lt;div class="container-fluid"&gt;</code> 建立一個流動、兩列的網頁 &mdash; 非常合適應用程式和文件使用。</p>
                <div class="mini-layout fluid">
                    <div class="mini-layout-sidebar"></div>
                    <div class="mini-layout-body"></div>
                </div>
<pre class="prettyprint linenums">
&lt;div class="container-fluid"&gt;
  &lt;div class="row-fluid"&gt;
    &lt;div class="span2"&gt;
      &lt;!--Sidebar content--&gt;
    &lt;/div&gt;
    &lt;div class="span10"&gt;
      &lt;!--Body content--&gt;
    &lt;/div&gt;
  &lt;/div&gt;
&lt;/div&gt;
</pre>
            </section>

            <!-- Responsive design
            ================================================== -->
            <section id="responsive">
                <div class="page-header">
                    <h1>嚮應式設計</h1>
                </div>

                <h2>啟用嚮應式功能</h2>
                <p>在文件中的 <code>&lt;head&gt;</code> 加入合適的 meta 標籤並且引用額外的樣式表，即可啟用嚮應式 CSS。如果你已經在客製化網頁取得一個 Bootstrap，只需要加入 meta 標籤。</p>
<pre class="prettyprint linenums">
&lt;meta name="viewport" content="width=device-width, initial-scale=1.0"&gt;
&lt;link href="assets/css/bootstrap-responsive.css" rel="stylesheet"&gt;
</pre>
                <p><span class="label label-info">注意！</span>  Bootstrap 預設情況下沒有引用嚮應式功能，這是因為不是任何情況都需要嚮應式。我們不鼓勵開發者移除此功能，而是在需要時才啟用它。</p>

                <h2>關於嚮應式 Bootstrap</h2>
                <img src="~/Images/bootstrap/responsive-illustrations.png" alt="Responsive devices" style="float: right; margin: 0 0 20px 20px;">
                <p>媒體查詢（Media queries）允許在一些條件基礎上自定義 CSS，例如：ratios、widths、display type等，但通常都是關注在 <code>min-width</code> 和 <code>max-width</code>。</p>
                <ul>
                    <li>修改網格中列的寬度</li>
                    <li>需要時，用堆疊元素替代浮動</li>
                    <li>調整標題與文字的大小以便更合適各種設備</li>
                </ul>
                <p>謹慎使用媒體查詢，先從你的手機用戶上開始。對於大型專案，應該考慮專門的程式碼來處理，而不是使用媒體查詢。</p>

                <h2>支援設備</h2>
                <p>Bootstrap 支援的媒體查詢都放在一個檔案中，這讓你的專案更靈活去適應不同的設備與螢幕解析度。包含：</p>
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th>類型</th>
                            <th>佈局寬度</th>
                            <th>列寬度</th>
                            <th>間隙寬度</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>大螢幕</td>
                            <td>1200px（含）以上</td>
                            <td>70px</td>
                            <td>30px</td>
                        </tr>
                        <tr>
                            <td>預設</td>
                            <td>980px（含）以上</td>
                            <td>60px</td>
                            <td>20px</td>
                        </tr>
                        <tr>
                            <td>平板電腦</td>
                            <td>768px（含）以上</td>
                            <td>42px</td>
                            <td>20px</td>
                        </tr>
                        <tr>
                            <td>智慧手機到平版電腦</td>
                            <td>767px（含）以下</td>
                            <td class="muted" colspan="2">流動式列，固定寬度</td>
                        </tr>
                        <tr>
                            <td>智慧手機</td>
                            <td>480px（含）以下</td>
                            <td class="muted" colspan="2">流動式列，固定寬度</td>
                        </tr>
                    </tbody>
                </table>
<pre class="prettyprint linenums">
/* 大螢幕 */
@@Media (min-width: 1200px) { ... }

/* 平板電腦、橫向手機和一般桌機解析度 */
@@Media (min-width: 768px) and (max-width: 979px) { ... }

/* 橫向智慧手機到竪立平板電腦解析度 */
@@Media (max-width: 767px) { ... }

/* 橫向智慧手機及其他更小解析度 */
@@Media (max-width: 480px) { ... }
</pre>
                <p><span class="label label-info">譯者註</span>：平板電腦與智慧手機絕大部分都支援轉向功能，所以是一個螢幕兩種解析度。</p>


                <h2>嚮應式輔助類別</h2>
                <p>為了更快速針對移動設備進行開發，下面列出輔助類別用於不同設備顯示和隱藏內容。下表是可用的類別和它們在媒體查詢佈局效果。這些類別如以在 <code>responsive.less</code> 找到。</p>
                <table class="table table-bordered table-striped responsive-utilities">
                    <thead>
                        <tr>
                            <th>類別</th>
                            <th>手機 <small>767px（含）以下</small></th>
                            <th>平版 <small>979px 到 768px</small></th>
                            <th>電腦 <small>預設</small></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th><code>.visible-phone</code></th>
                            <td class="is-visible">顯示</td>
                            <td class="is-hidden">隱藏</td>
                            <td class="is-hidden">隱藏</td>
                        </tr>
                        <tr>
                            <th><code>.visible-tablet</code></th>
                            <td class="is-hidden">隱藏</td>
                            <td class="is-visible">顯示</td>
                            <td class="is-hidden">隱藏</td>
                        </tr>
                        <tr>
                            <th><code>.visible-desktop</code></th>
                            <td class="is-hidden">隱藏</td>
                            <td class="is-hidden">隱藏</td>
                            <td class="is-visible">顯示</td>
                        </tr>
                        <tr>
                            <th><code>.hidden-phone</code></th>
                            <td class="is-hidden">隱藏</td>
                            <td class="is-visible">顯示</td>
                            <td class="is-visible">顯示</td>
                        </tr>
                        <tr>
                            <th><code>.hidden-tablet</code></th>
                            <td class="is-visible">顯示</td>
                            <td class="is-hidden">隱藏</td>
                            <td class="is-visible">顯示</td>
                        </tr>
                        <tr>
                            <th><code>.hidden-desktop</code></th>
                            <td class="is-visible">顯示</td>
                            <td class="is-visible">顯示</td>
                            <td class="is-hidden">隱藏</td>
                        </tr>
                    </tbody>
                </table>

                <h3>何時使用</h3>
                <p>在有限的基礎下使用，應避免在同一網站內使用不同版本。當這些類別對於設備展示有用的才使用。嚮應式工具不應該使用在 table 元素，而且本來就不支持。</p>

                <h3>嚮應式工具測試情境</h3>
                <p>調整瀏覽器的大小或在不同設備上載入嚮應式頁面，以測試上述類別。</p>
                <h4>在...顯示</h4>
                <p>綠色勾標記指示此類別在你現在視窗裡是顯示的。</p>
                <ul class="responsive-utilities-test">
                    <li>Phone<span class="visible-phone">&#10004; 智慧手機</span></li>
                    <li>Tablet<span class="visible-tablet">&#10004; 平板電腦</span></li>
                    <li>Desktop<span class="visible-desktop">&#10004; 電腦</span></li>
                </ul>
                <h4>在...隱藏</h4>
                <p>綠色勾標記指示此類別在你現在視窗裡是隱藏的。</p>
                <ul class="responsive-utilities-test hidden-on">
                    <li>Phone<span class="hidden-phone">&#10004; Phone</span></li>
                    <li>Tablet<span class="hidden-tablet">&#10004; Tablet</span></li>
                    <li>Desktop<span class="hidden-desktop">&#10004; Desktop</span></li>
                </ul>
            </section>
        </div>
    </div>
</div>