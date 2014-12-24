﻿@Code
    ViewData("Title") = "JavaScript"
    ViewData("Description") = "Bootstrap 內含 13 個 jQuery 外掛，它們賦予了元件生命。這些外掛包含轉場效果、對話視窗、下拉式選單、滑動監視、頁籤、工具提示、彈出提示、警告視窗、按鈕、折疊效果、輪播效果、輸入提示及附加巡覽等 jQuery 外掛。"
    ViewData("Keywords") = "Bootstrap JavaScript, 轉場效果, 對話視窗, 下拉式選單, 滑動監視, 頁籤, 工具提示, 彈出提示, 警告視窗, 按鈕"
End Code

@section navbar
    @Html.Partial("_NavBar")
End Section

<header class="jumbotron subhead">
    <div class="container">
        <h1>JavaScript</h1>
        <p class="lead">
            Bootstrap 內含 13 個 jQuery 外掛，它們賦予了元件生命。
    </div>
</header>

<div class="container">

    <!-- Docs nav
    ================================================== -->
    <div class="row">
        <nav class="span3 bs-docs-sidebar">
            <ul class="nav nav-list bs-docs-sidenav">
                <li><a href="#overview"><i class="icon-chevron-right"></i> 概觀</a></li>
                <li><a href="#transitions"><i class="icon-chevron-right"></i> 轉場效果</a></li>
                <li><a href="#modals"><i class="icon-chevron-right"></i> 對話視窗</a></li>
                <li><a href="#dropdowns"><i class="icon-chevron-right"></i> 下拉式選單</a></li>
                <li><a href="#scrollspy"><i class="icon-chevron-right"></i> 滑動監視</a></li>
                <li><a href="#tabs"><i class="icon-chevron-right"></i> 頁籤</a></li>
                <li><a href="#tooltips"><i class="icon-chevron-right"></i> 工具提示</a></li>
                <li><a href="#popovers"><i class="icon-chevron-right"></i> 彈出提示</a></li>
                <li><a href="#alerts"><i class="icon-chevron-right"></i> 警告視窗</a></li>
                <li><a href="#buttons"><i class="icon-chevron-right"></i> 按鈕</a></li>
                <li><a href="#collapse"><i class="icon-chevron-right"></i> 折疊效果</a></li>
                <li><a href="#carousel"><i class="icon-chevron-right"></i> 輪播效果</a></li>
                <li><a href="#typeahead"><i class="icon-chevron-right"></i> 輸入提示</a></li>
                <li><a href="#affix"><i class="icon-chevron-right"></i> 附加巡覽</a></li>
            </ul>
        </nav>
        <div class="span9">
            <nav>
                目前位置：@Html.MvcSiteMap().SiteMapPath()
            </nav>

            <!-- Overview
            ================================================== -->
            <section id="overview">
                <div class="page-header">
                    <h1>Bootstrap 裡的 JavaScript</h1>
                </div>

                <h3>單獨或完整的外掛</h3>
                <p>每個外掛都可以單獨引用（注意各外掛相依性問題）或一次全部引用。<strong>bootstrap.js</strong> 和 <strong>bootstrap.min.js</strong>（最小化） 檔案都包含全部外掛內容。</p>

                <h3>Data 屬性</h3>
                <p>你能單純只透過標記 API 而不需要撰寫任何一行 JavaScript 來使用所有 Bootstrap 外掛。這是 Bootstrap 最頂層 API 且應該是你首選使用外掛的方式。</p>
                <p><span class="label label-info">譯者註</span>：first class，直譯可有「第一類別」、「首類別」也有「甲級」、「第一級」的意思，但這裡我譯為「頂層」或「最頂層」。</p>
                <p>
                    某些情況，可能需要特意去關閉某些功能或動作，因此，我們也提供了關閉 data 屬性 API，透過解除繫結在 body 上命名空間為 `'data-api'` 的所有事件。如下所示：
          <pre class="prettyprint linenums">$('body').off('.data-api')</pre>

                    <p>另一種選擇，解除特定的外掛事件繫結，只需要將外掛名稱後面加上 data-api 即可，如下所示：</p>
                    <pre class="prettyprint linenums">$('body').off('.alert.data-api')</pre>

                    <h3>程式設計 API</h3>
                    <p>我們認為你應該能夠透過 JavaScript API 來使用所有 Bootstrap 外掛。所有公開 API 可以是單一或可鏈接的方法，且回傳所操作的集合。</p>
                    <p><span class="label label-info">譯者註</span>：使用方法和 jQuery 的 API 一樣。</p>
                    <pre class="prettyprint linenums">$(".btn.danger").button("toggle").addClass("fat")</pre>
                    <p>所有方法都接受一個選擇性參數物件，一個對此方法有特別意義的字串或什麼也不傳（這是外掛預設行為）。</p>
                    <pre class="prettyprint linenums">
                    $("#myModal").modal()                       // 初始化與採取預設值
$("#myModal").modal({ keyboard: false })   // 初始化與無鍵盤設置
$("#myModal").modal('show')                // 初始化與立即呼叫show
                </p>
                </pre>
          <p>每個外掛透過 Constructor 屬性來揭露原始的建構函數：<code>$.fn.popover.Constructor</code>。如果你想取得某個特定外掛的執行個體（instance），可以直接從頁面元素取得：<code>$('[rel=popover]').data('popover')</code>。</p>
                <p><span class="label label-info">譯者註</span>：Instance可譯為「執行個體」或「實例」。</p>

                <h3>不衝突</h3>
                <p>有時候，你需要同時使用 Bootstrap 外掛和其他 UI 框架。在這種情況下，可能偶爾會發生命名空間衝突。如果發生了這種情況，你可以呼叫外掛的 <code>.noConflict</code> 函數回復預設值。</p>

                <pre class="prettyprint linenums">
var bootstrapButton = $.fn.button.noConflict() // 回傳 $.fn.button 的預設值
$.fn.bootstrapBtn = bootstrapButton            // 取得 $().bootstrapBtn Bootstrap 的功能
</pre>

                <h3>事件</h3>
                <p>Bootstrap 對多數外掛的特別行為提供自訂事件。一般而言，這些事件都是以動詞的原型和過去分詞形式來呈現。動詞原型呈現在事件執行之前觸發，例如，<code>show</code>。過去分詞形式呈現在動作執行完畢之後觸發，例如，<code>shown</code>。</p>
                <p><span class="label label-info">譯者註</span>：這裡指英文的動詞原型和過去分詞。</p>
                <p>所有動詞原型的事件都提供 preventDefault 函數。這能在動作被執行之前停止。</p>
                <pre class="prettyprint linenums">
$('#myModal').on('show', function (e) {
    if (!data) return e.preventDefault() // stops modal from being shown
})
</pre>
            </section>



            <!-- Transitions
        ================================================== -->
            <section id="transitions">
                <div class="page-header">
                    <h1>轉場效果 <small>bootstrap-transition.js</small></h1>
                </div>
                <h3>關於轉場</h3>
                <p>一個簡單的轉場效果（transition），只要在引用其他 JavaScript 檔案時一同引用 <strong>bootstrap-transition.js</strong> 檔案即可。如果你引用的是完整（或最小化）的 <strong>bootstrap.js</strong> 檔案，就不需要在引用此檔案，因為它已經包含此檔案的內容。</p>
                <h3>使用情境</h3>
                <p>一些簡單的範例可以使用轉場效果：</p>
                <ul>
                    <li>投影片或淡入效果的對話視窗</li>
                    <li>淡出效果的頁籤</li>
                    <li>淡出效果的警告視窗</li>
                    <li>投影片輪播控制面板</li>
                </ul>
                <p><span class="label label-info">譯者註</span>：可參考 <a href="http://www.w3schools.com/css3/css3_transitions.asp" target="_blank" title="CSS3 轉場效果">CSS3 transitions</a> 以瞭解什麼是轉場效果。另外，從 bootstrap-transition.js 原始碼得知，此檔案只是做瀏覽器是否支援轉場效果的檢測（由 <a href="http://www.modernizr.com/" target="_blank">modernizr</a> 提供的功能），主要是提供給 Bootstrap 其他有使用到轉場效果的外掛使用。</p>
            </section>



            <!-- Modal
        ================================================== -->
            <section id="modals">
                <div class="page-header">
                    <h1>對話視窗 <small>bootstrap-modal.js</small></h1>
                </div>


                <h2>範例</h2>
                <p>對話視窗是一個流線、彈性的視窗，對話提示有最低需求功能和聰明的預設值。</p>

                <h3>靜態範例</h3>
                <p>呈現一個有標題、本體和帶有動作的頁尾的對話視窗。</p>
                <div class="bs-docs-example" style="background-color: #f5f5f5;">
                    <div class="modal" style="position: relative; top: auto; left: auto; right: auto; margin: 0 auto 20px; z-index: 1; max-width: 100%;">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                            <h3>對話視窗標題</h3>
                        </div>
                        <div class="modal-body">
                            <p>一個好的本體&hellip;</p>
                        </div>
                        <div class="modal-footer">
                            <a href="#" class="btn">關閉</a>
                            <a href="#" class="btn btn-primary">儲存變更</a>
                        </div>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="modal hide fade"&gt;
  &lt;div class="modal-header"&gt;
    &lt;button type="button" class="close" data-dismiss="modal" aria-hidden="true"&gt;&amp;times;&lt;/button&gt;
    &lt;h3&gt;對話視窗標題&lt;/h3&gt;
  &lt;/div&gt;
  &lt;div class="modal-body"&gt;
    &lt;p&gt;一個好的本體&hellip;&lt;/p&gt;
  &lt;/div&gt;
  &lt;div class="modal-footer"&gt;
    &lt;a href="#" class="btn"&gt;關閉&lt;/a&gt;
    &lt;a href="#" class="btn btn-primary"&gt;儲存變更&lt;/a&gt;
  &lt;/div&gt;
&lt;/div&gt;
</pre>

                <h3>Live demo</h3>
                <p>點擊下面的按鈕後透過 JavaScript 去切換一個對話視窗。對話視窗會從頂端向下滑動且以淡入效果呈現。</p>
                <!-- sample modal content -->
                <div id="myModal" class="modal hide fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                        <h3 id="myModalLabel">對話視窗標題</h3>
                    </div>
                    <div class="modal-body">
                        <h4>對話視窗中的文字</h4>
                        <p>Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem.</p>

                        <h4>對話視窗中的彈出視窗</h4>
                        <p>This <a href="#" role="button" class="btn popover-test" title="A Title" data-content="And here's some amazing content. It's very engaging. right?">button</a> should trigger a popover on click.</p>

                        <h4>對話視窗中的工具提示</h4>
                        <p><a href="#" class="tooltip-test" title="Tooltip">This link</a> and <a href="#" class="tooltip-test" title="Tooltip">that link</a> should have tooltips on hover.</p>

                        <hr>

                        <h4>當文字超出範圍顯示捲軸</h4>
                        <p>We set a fixed <code>max-height</code> on the <code>.modal-body</code>. Watch it overflow with all this extra lorem ipsum text we've included.</p>
                        <p>Cras mattis consectetur purus sit amet fermentum. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Morbi leo risus, porta ac consectetur ac, vestibulum at eros.</p>
                        <p>Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor auctor.</p>
                        <p>Aenean lacinia bibendum nulla sed consectetur. Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Donec sed odio dui. Donec ullamcorper nulla non metus auctor fringilla.</p>
                        <p>Cras mattis consectetur purus sit amet fermentum. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Morbi leo risus, porta ac consectetur ac, vestibulum at eros.</p>
                        <p>Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor auctor.</p>
                        <p>Aenean lacinia bibendum nulla sed consectetur. Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Donec sed odio dui. Donec ullamcorper nulla non metus auctor fringilla.</p>
                    </div>
                    <div class="modal-footer">
                        <button class="btn" data-dismiss="modal">關閉</button>
                        <button class="btn btn-primary">儲存變更</button>
                    </div>
                </div>
                <div class="bs-docs-example" style="padding-bottom: 24px;">
                    <a data-toggle="modal" href="#myModal" class="btn btn-primary btn-large">執行範例對話視窗</a>
                </div>
                <pre class="prettyprint linenums">
&lt!-- Button to trigger modal --&gt;
&lt;a href="#myModal" role="button" class="btn" data-toggle="modal"&gt;執行範例對話視窗&lt;/a&gt;

&lt!-- Modal --&gt;
&lt;div id="myModal" class="modal hide fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true"&gt;
  &lt;div class="modal-header"&gt;
    &lt;button type="button" class="close" data-dismiss="modal" aria-hidden="true"&gt;&times;&lt;/button&gt;
    &lt;h3 id="myModalLabel"&gt;對話視窗標題&lt;/h3&gt;
  &lt;/div&gt;
  &lt;div class="modal-body"&gt;
    &lt;p&gt;一個好的本體&hellip;&lt;/p&gt;
  &lt;/div&gt;
  &lt;div class="modal-footer"&gt;
    &lt;button class="btn" data-dismiss="modal" aria-hidden="true"&gt;關閉&lt;/button&gt;
    &lt;button class="btn btn-primary"&gt;儲存變更&lt;/button&gt;
  &lt;/div&gt;
&lt;/div&gt;
</pre>


                <hr class="bs-docs-separator">


                <h2>使用方式</h2>

                <h3>經由 data 屬性</h3>
                <p>要啟用一個對話視窗不需要撰寫 JavaScript。在主要控制元素上，例如，按鈕，設置 <code>data-toggle="modal"</code>，然後再設置 <code>data-target="#foo"</code> 或 <code>href="#foo"</code> 用以指向某個對話視窗進行切換。</p>
                <pre class="prettyprint linenums">&lt;button type="button" data-toggle="modal" data-target="#myModal"&gt;執行對話視窗&lt;/button&gt;</pre>

                <h3>經由 JavaScript</h3>
                <p>透過一行 JavaScript 來呼叫 id 為 <code>myModal</code> 的對話視窗。</p>
                <pre class="prettyprint linenums">$('#myModal').modal(options)</pre>

                <h3>選項</h3>
                <p>上述程式碼裡的 Options 可以經由 data 屬性或 JavaScript 來傳遞。使用 data 屬性，將選項名稱附加於 <code>data-</code> 之後，就像 <code>data-backdrop=""</code> 一樣。</p>
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th style="width: 100px;">名稱</th>
                            <th style="width: 50px;">型別</th>
                            <th style="width: 50px;">預設</th>
                            <th>說明</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>backdrop</td>
                            <td>boolean</td>
                            <td>true</td>
                            <td>包含 modal-backdrop 元素。另外，指定 <code>static</code> 背景下，在對話視窗上點擊不會關閉。</td>
                        </tr>
                        <tr>
                            <td>keyboard</td>
                            <td>boolean</td>
                            <td>true</td>
                            <td>當鍵盤 Esc 按鈕被按下關閉對話視窗。</td>
                        </tr>
                        <tr>
                            <td>show</td>
                            <td>boolean</td>
                            <td>true</td>
                            <td>當完成初始化立即呈現對話視窗。</td>
                        </tr>
                        <tr>
                            <td>remote</td>
                            <td>path</td>
                            <td>false</td>
                            <td>
                                <p>如果有提供遠端 URL，內容將會經由 jQuery 的 <code>load</code> 方法載入和注入到 <code>.modal-body</code> 類別元素中。如果你是使用 data api的話，你可能或使用 <code>href</code> 標記來指定遠端資源。例如以下範例所示：</p>
                                <pre class="prettyprint linenums"><code>&lt;a data-toggle="modal" href="remote.html" data-target="#modal"&gt;點擊我&lt;/a&gt;</code></pre>
                            </td>
                        </tr>
                    </tbody>
                </table>

                <h3>方法</h3>
                <h4>.modal(options)</h4>
                <p>讓你的內容變成一個對話視窗。接受一個選擇性選項 <code>object</code>。</p>
                <pre class="prettyprint linenums">
$('#myModal').modal({
  keyboard: false
})
</pre>
                <h4>.modal('toggle')</h4>
                <p>手動切換對話視窗。</p>
                <pre class="prettyprint linenums">$('#myModal').modal('toggle')</pre>
                <h4>.modal('show')</h4>
                <p>手動開啟對話視窗。</p>
                <pre class="prettyprint linenums">$('#myModal').modal('show')</pre>
                <h4>.modal('hide')</h4>
                <p>手動隱藏對話視窗。</p>
                <pre class="prettyprint linenums">$('#myModal').modal('hide')</pre>
                <h3>事件</h3>
                <p>Bootstrap 對話視窗類別有公開一些事件允許監聽。</p>
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th style="width: 150px;">事件</th>
                            <th>說明</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>show</td>
                            <td>當 <code>show</code> 執行個體的方法被呼叫此事件會立即觸發。</td>
                        </tr>
                        <tr>
                            <td>shown</td>
                            <td>當對話視窗呈現完成至使用者面前（會等待 CSS 轉場效果完成）此事件會被觸發。</td>
                        </tr>
                        <tr>
                            <td>hide</td>
                            <td>當 <code>hide</code> 執行個體的方法被呼叫此事件會立即觸發。</td>
                        </tr>
                        <tr>
                            <td>hidden</td>
                            <td>當對話視窗完從使用者面前完成隱藏（會等待 CSS 轉場效果完成）此事件會被觸發。</td>
                        </tr>
                    </tbody>
                </table>
                <pre class="prettyprint linenums">
$('#myModal').on('hidden', function () {
  // do something…
})
</pre>
            </section>



            <!-- Dropdowns
        ================================================== -->
            <section id="dropdowns">
                <div class="page-header">
                    <h1>下拉式選單 <small>bootstrap-dropdown.js</small></h1>
                </div>


                <h2>範例</h2>
                <p>透過此外掛可以將下拉式選單加入到任何元件中，包含巡覽列、頁籤和 pill。</p>

                <h3>在巡覽列中</h3>
                <div class="bs-docs-example">
                    <div id="navbar-example" class="navbar navbar-static">
                        <div class="navbar-inner">
                            <div class="container" style="width: auto;">
                                <a class="brand" href="#">專案名稱</a>
                                <ul class="nav" role="navigation">
                                    <li class="dropdown">
                                        <a id="drop1" href="#" role="button" class="dropdown-toggle" data-toggle="dropdown">下拉式選單 <b class="caret"></b></a>
                                        <ul class="dropdown-menu" role="menu" aria-labelledby="drop1">
                                            <li role="presentation"><a role="menuitem" tabindex="-1" href="http://google.com">Action</a></li>
                                            <li role="presentation"><a role="menuitem" tabindex="-1" href="#anotherAction">Another action</a></li>
                                            <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Something else here</a></li>
                                            <li role="presentation" class="divider"></li>
                                            <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Separated link</a></li>
                                        </ul>
                                    </li>
                                    <li class="dropdown">
                                        <a href="#" id="drop2" role="button" class="dropdown-toggle" data-toggle="dropdown">下拉式選單 2 <b class="caret"></b></a>
                                        <ul class="dropdown-menu" role="menu" aria-labelledby="drop2">
                                            <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Action</a></li>
                                            <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Another action</a></li>
                                            <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Something else here</a></li>
                                            <li role="presentation" class="divider"></li>
                                            <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Separated link</a></li>
                                        </ul>
                                    </li>
                                </ul>
                                <ul class="nav pull-right">
                                    <li id="fat-menu" class="dropdown">
                                        <a href="#" id="drop3" role="button" class="dropdown-toggle" data-toggle="dropdown">下拉式選單 3 <b class="caret"></b></a>
                                        <ul class="dropdown-menu" role="menu" aria-labelledby="drop3">
                                            <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Action</a></li>
                                            <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Another action</a></li>
                                            <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Something else here</a></li>
                                            <li role="presentation" class="divider"></li>
                                            <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Separated link</a></li>
                                        </ul>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <!-- /navbar-example -->
                </div>

                <h3>在頁籤中</h3>
                <div class="bs-docs-example">
                    <ul class="nav nav-pills">
                        <li class="active"><a href="#">正規連結</a></li>
                        <li class="dropdown">
                            <a class="dropdown-toggle" id="drop4" role="button" data-toggle="dropdown" href="#">下拉式選單 <b class="caret"></b></a>
                            <ul id="menu1" class="dropdown-menu" role="menu" aria-labelledby="drop4">
                                <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Action</a></li>
                                <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Another action</a></li>
                                <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Something else here</a></li>
                                <li role="presentation" class="divider"></li>
                                <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Separated link</a></li>
                            </ul>
                        </li>
                        <li class="dropdown">
                            <a class="dropdown-toggle" id="drop5" role="button" data-toggle="dropdown" href="#">下拉式選單 2 <b class="caret"></b></a>
                            <ul id="menu2" class="dropdown-menu" role="menu" aria-labelledby="drop5">
                                <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Action</a></li>
                                <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Another action</a></li>
                                <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Something else here</a></li>
                                <li role="presentation" class="divider"></li>
                                <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Separated link</a></li>
                            </ul>
                        </li>
                        <li class="dropdown">
                            <a class="dropdown-toggle" id="drop5" role="button" data-toggle="dropdown" href="#">下拉式選單 3 <b class="caret"></b></a>
                            <ul id="menu3" class="dropdown-menu" role="menu" aria-labelledby="drop5">
                                <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Action</a></li>
                                <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Another action</a></li>
                                <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Something else here</a></li>
                                <li role="presentation" class="divider"></li>
                                <li role="presentation"><a role="menuitem" tabindex="-1" href="#">Separated link</a></li>
                            </ul>
                        </li>
                    </ul>
                    <!-- /tabs -->
                </div>


                <hr class="bs-docs-separator">


                <h2>使用方式</h2>

                <h3>經由 data 屬性</h3>
                <p>在連結和按鈕上加入 <code>data-toggle="dropdown"</code> 以切換下拉式選單。</p>
                <pre class="prettyprint linenums">
&lt;div class="dropdown"&gt;
  &lt;a class="dropdown-toggle" data-toggle="dropdown" href="#"&gt;Dropdown trigger&lt;/a&gt;
  &lt;ul class="dropdown-menu" role="menu" aria-labelledby="dLabel"&gt;
    ...
  &lt;/ul&gt;
&lt;/div&gt;
</pre>
                <p>為完整保留 URL，請使用 <code>data-target</code> 屬性替代 <code>href="#"</code>。</p>
                <pre class="prettyprint linenums">
&lt;div class="dropdown"&gt;
  &lt;a class="dropdown-toggle" id="dLabel" role="button" data-toggle="dropdown" data-target="#" href="/page.html"&gt;
    Dropdown
    &lt;b class="caret"&gt;&lt;/b&gt;
  &lt;/a&gt;
  &lt;ul class="dropdown-menu" role="menu" aria-labelledby="dLabel"&gt;
    ...
  &lt;/ul&gt;
&lt;/div&gt;
</pre>

                <h3>經由 JavaScript</h3>
                <p>透過 JavaScript 呼叫下拉式選單：</p>
                <pre class="prettyprint linenums">$('.dropdown-toggle').dropdown()</pre>

                <h3>選項</h3>
                <p><em>無</em></p>

                <h3>方法</h3>
                <h4>$().dropdown('toggle')</h4>
                <p>可透過程式 API 對巡覽列或頁籤巡覽切換下拉式選單。</p>
            </section>



            <!-- ScrollSpy
        ================================================== -->
            <section id="scrollspy">
                <div class="page-header">
                    <h1>滑動監視 <small>bootstrap-scrollspy.js</small></h1>
                </div>


                <h2>在巡覽列的範例</h2>
                <p>滑動監視外掛會自動依據滑動位置來更新巡覽列裡的項目。滑動下面區域使其低於巡覽列，然後觀察 active 類別的變化。下拉式選單的子項目會跟著變化高亮度呈現。</p>
                <div class="bs-docs-example">
                    <div id="navbarExample" class="navbar navbar-static">
                        <div class="navbar-inner">
                            <div class="container" style="width: auto;">
                                <a class="brand" href="#">Project Name</a>
                                <ul class="nav">
                                    <li><a href="#fat">@@fat</a></li>
                                    <li><a href="#mdo">@@mdo</a></li>
                                    <li class="dropdown">
                                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">Dropdown <b class="caret"></b></a>
                                        <ul class="dropdown-menu">
                                            <li><a href="#one">one</a></li>
                                            <li><a href="#two">two</a></li>
                                            <li class="divider"></li>
                                            <li><a href="#three">three</a></li>
                                        </ul>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div data-spy="scroll" data-target="#navbarExample" data-offset="0" class="scrollspy-example">
                        <h4 id="fat">@@fat</h4>
                        <p>Ad leggings keytar, brunch id art party dolor labore. Pitchfork yr enim lo-fi before they sold out qui. Tumblr farm-to-table bicycle rights whatever. Anim keffiyeh carles cardigan. Velit seitan mcsweeney's photo booth 3 wolf moon irure. Cosby sweater lomo jean shorts, williamsburg hoodie minim qui you probably haven't heard of them et cardigan trust fund culpa biodiesel wes anderson aesthetic. Nihil tattooed accusamus, cred irony biodiesel keffiyeh artisan ullamco consequat.</p>
                        <h4 id="mdo">@@mdo</h4>
                        <p>Veniam marfa mustache skateboard, adipisicing fugiat velit pitchfork beard. Freegan beard aliqua cupidatat mcsweeney's vero. Cupidatat four loko nisi, ea helvetica nulla carles. Tattooed cosby sweater food truck, mcsweeney's quis non freegan vinyl. Lo-fi wes anderson +1 sartorial. Carles non aesthetic exercitation quis gentrify. Brooklyn adipisicing craft beer vice keytar deserunt.</p>
                        <h4 id="one">one</h4>
                        <p>Occaecat commodo aliqua delectus. Fap craft beer deserunt skateboard ea. Lomo bicycle rights adipisicing banh mi, velit ea sunt next level locavore single-origin coffee in magna veniam. High life id vinyl, echo park consequat quis aliquip banh mi pitchfork. Vero VHS est adipisicing. Consectetur nisi DIY minim messenger bag. Cred ex in, sustainable delectus consectetur fanny pack iphone.</p>
                        <h4 id="two">two</h4>
                        <p>In incididunt echo park, officia deserunt mcsweeney's proident master cleanse thundercats sapiente veniam. Excepteur VHS elit, proident shoreditch +1 biodiesel laborum craft beer. Single-origin coffee wayfarers irure four loko, cupidatat terry richardson master cleanse. Assumenda you probably haven't heard of them art party fanny pack, tattooed nulla cardigan tempor ad. Proident wolf nesciunt sartorial keffiyeh eu banh mi sustainable. Elit wolf voluptate, lo-fi ea portland before they sold out four loko. Locavore enim nostrud mlkshk brooklyn nesciunt.</p>
                        <h4 id="three">three</h4>
                        <p>Ad leggings keytar, brunch id art party dolor labore. Pitchfork yr enim lo-fi before they sold out qui. Tumblr farm-to-table bicycle rights whatever. Anim keffiyeh carles cardigan. Velit seitan mcsweeney's photo booth 3 wolf moon irure. Cosby sweater lomo jean shorts, williamsburg hoodie minim qui you probably haven't heard of them et cardigan trust fund culpa biodiesel wes anderson aesthetic. Nihil tattooed accusamus, cred irony biodiesel keffiyeh artisan ullamco consequat.</p>
                        <p>
                            Keytar twee blog, culpa messenger bag marfa whatever delectus food truck. Sapiente synth id assumenda. Locavore sed helvetica cliche irony, thundercats you probably haven't heard of them consequat hoodie gluten-free lo-fi fap aliquip. Labore elit placeat before they sold out, terry richardson proident brunch nesciunt quis cosby sweater pariatur keffiyeh ut helvetica artisan. Cardigan craft beer seitan readymade velit. VHS chambray laboris tempor veniam. Anim mollit minim commodo ullamco thundercats.
                        </p>
                    </div>
                </div>
                <p><span class="label label-info">譯者註</span>：active 類別的變化必須開啟開發者工具來觀察。當滑動接觸到內容的標題（@@fat 或 @@mdo）時，滑動監視外掛會動態為對應巡覽列裡的 <code>&lt;li&gt;</code> 加入 active 類別，以呈現高亮度效果。例如，本說明文件左方巡覽列即是使用滑動監視外掛達到此效果。</p>


                <hr class="bs-docs-separator">


                <h2>使用方式</h2>

                <h3>經由 data 屬性</h3>
                <p>很簡單就能加入滑動監視行為到你的頂層巡覽列，只需加入 <code>data-spy="scroll"</code> 到你想監視的元素上（大部分情況是加到 body 上），然後將 <code>data-target=".navbar"</code> 加到想巡覽的部分。你也會想使用滑動監視在 <code>.nav</code> 元件上。</p>
                <pre class="prettyprint linenums">&lt;body data-spy="scroll" data-target=".navbar"&gt;...&lt;/body&gt;</pre>

                <h3>經由 JavaScript</h3>
                <p>透過 JavaScript 呼叫滑動監視：</p>
                <pre class="prettyprint linenums">$('#navbar').scrollspy()</pre>

                <div class="alert alert-info">
                    <strong>注意！</strong>巡覽列的連結必須指定對應的目標 id。例如，<code>&lt;a href="#home"&gt;home&lt;/a&gt;</code> 連結必須和 DOM 某一元素互相對應，像是 <code>&lt;div id="home"&gt;&lt;/div&gt;</code>。
                </div>

                <h3>方法</h3>
                <h4>.scrollspy('refresh')</h4>
                <p>當使用滑動監視的 DOM 元素有新增或移除操作時，你需要去呼叫 refresh 方法，如下所示：</p>
                <pre class="prettyprint linenums">
$('[data-spy="scroll"]').each(function () {
  var $spy = $(this).scrollspy('refresh')
});
</pre>

                <h3>選項</h3>
                <p>選項能透過 data 屬性或 JavaScript 來傳遞。data 屬性，將選項名稱附加至 <code>data-</code> 後面，例如，<code>data-offset=""</code>。</p>
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th style="width: 100px;">名稱</th>
                            <th style="width: 100px;">型別</th>
                            <th style="width: 50px;">預設</th>
                            <th>說明</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>offset</td>
                            <td>number</td>
                            <td>10</td>
                            <td>計算滑動位置時從頂端要位移的像素。</td>
                        </tr>
                    </tbody>
                </table>

                <h3>事件</h3>
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th style="width: 150px;">事件</th>
                            <th>說明</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>activate</td>
                            <td>當一個項目被滑動監視設置 activate 類別時，此事件會被觸發。</td>
                        </tr>
                    </tbody>
                </table>
            </section>



            <!-- Tabs
        ================================================== -->
            <section id="tabs">
                <div class="page-header">
                    <h1>可切換的頁籤 <small>bootstrap-tab.js</small></h1>
                </div>


                <h2>頁籤範例</h2>
                <p>快速加入動態的頁籤功能到視窗內以切換本地內容，甚至經由下拉式選單。</p>
                <div class="bs-docs-example">
                    <ul id="myTab" class="nav nav-tabs">
                        <li class="active"><a href="#home" data-toggle="tab">Home</a></li>
                        <li><a href="#profile" data-toggle="tab">Profile</a></li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown">Dropdown <b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li><a href="#dropdown1" data-toggle="tab">@@fat</a></li>
                                <li><a href="#dropdown2" data-toggle="tab">@@mdo</a></li>
                            </ul>
                        </li>
                    </ul>
                    <div id="myTabContent" class="tab-content">
                        <div class="tab-pane fade in active" id="home">
                            <p>Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua, retro synth master cleanse. Mustache cliche tempor, williamsburg carles vegan helvetica. Reprehenderit butcher retro keffiyeh dreamcatcher synth. Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.</p>
                        </div>
                        <div class="tab-pane fade" id="profile">
                            <p>Food truck fixie locavore, accusamus mcsweeney's marfa nulla single-origin coffee squid. Exercitation +1 labore velit, blog sartorial PBR leggings next level wes anderson artisan four loko farm-to-table craft beer twee. Qui photo booth letterpress, commodo enim craft beer mlkshk aliquip jean shorts ullamco ad vinyl cillum PBR. Homo nostrud organic, assumenda labore aesthetic magna delectus mollit. Keytar helvetica VHS salvia yr, vero magna velit sapiente labore stumptown. Vegan fanny pack odio cillum wes anderson 8-bit, sustainable jean shorts beard ut DIY ethical culpa terry richardson biodiesel. Art party scenester stumptown, tumblr butcher vero sint qui sapiente accusamus tattooed echo park.</p>
                        </div>
                        <div class="tab-pane fade" id="dropdown1">
                            <p>Etsy mixtape wayfarers, ethical wes anderson tofu before they sold out mcsweeney's organic lomo retro fanny pack lo-fi farm-to-table readymade. Messenger bag gentrify pitchfork tattooed craft beer, iphone skateboard locavore carles etsy salvia banksy hoodie helvetica. DIY synth PBR banksy irony. Leggings gentrify squid 8-bit cred pitchfork. Williamsburg banh mi whatever gluten-free, carles pitchfork biodiesel fixie etsy retro mlkshk vice blog. Scenester cred you probably haven't heard of them, vinyl craft beer blog stumptown. Pitchfork sustainable tofu synth chambray yr.</p>
                        </div>
                        <div class="tab-pane fade" id="dropdown2">
                            <p>Trust fund seitan letterpress, keytar raw denim keffiyeh etsy art party before they sold out master cleanse gluten-free squid scenester freegan cosby sweater. Fanny pack portland seitan DIY, art party locavore wolf cliche high life echo park Austin. Cred vinyl keffiyeh DIY salvia PBR, banh mi before they sold out farm-to-table VHS viral locavore cosby sweater. Lomo wolf viral, mustache readymade thundercats keffiyeh craft beer marfa ethical. Wolf salvia freegan, sartorial keffiyeh echo park vegan.</p>
                        </div>
                    </div>
                </div>


                <hr class="bs-docs-separator">


                <h2>使用方式</h2>
                <p>啟用頁籤經由 JavaScript（每一個頁籤需要個別啟用）：</p>
                <pre class="prettyprint linenums">
$('#myTab a').click(function (e) {
  e.preventDefault();
  $(this).tab('show');
})</pre>
                <p>你有數種方試來個別啟用頁籤：</p>
                <pre class="prettyprint linenums">
$('#myTab a[href="#profile"]').tab('show'); // 透過 name 來啟用
$('#myTab a:first').tab('show'); // 選擇第一個（:first）來啟用
$('#myTab a:last').tab('show'); // 選擇最後一個（:last）來啟用
$('#myTab li:eq(2) a').tab('show'); // 選擇第三個當頁籤（索引由 0 開始）
</pre>

                <h3>標記</h3>
                <p>在元素上指定 <code>data-toggle="tab"</code> 或 <code>data-toggle="pill"</code> 即可啟用頁籤或 pill 巡覽而不必撰寫任何 JavaScript。在頁籤的 <code>ul</code> 設置 <code>nav</code> 與 <code>nav-tabs</code> 類別即可套用 Bootstrap 頁籤樣式。</p>
                <pre class="prettyprint linenums">
&lt;ul class="nav nav-tabs"&gt;
  &lt;li&gt;&lt;a href="#home" data-toggle="tab"&gt;Home&lt;/a&gt;&lt;/li&gt;
  &lt;li&gt;&lt;a href="#profile" data-toggle="tab"&gt;Profile&lt;/a&gt;&lt;/li&gt;
  &lt;li&gt;&lt;a href="#messages" data-toggle="tab"&gt;Messages&lt;/a&gt;&lt;/li&gt;
  &lt;li&gt;&lt;a href="#settings" data-toggle="tab"&gt;Settings&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;</pre>

                <h3>方法</h3>
                <h4>$().tab</h4>
                <p>啟用一個頁籤元素和內容容器。頁籤應該包含 <code>data-garget</code> 或 <code>href</code> 屬性且指向 DOM 中某個容器節點。</p>
                <pre class="prettyprint linenums">
&lt;ul class="nav nav-tabs" id="myTab"&gt;
  &lt;li class="active"&gt;&lt;a href="#home"&gt;Home&lt;/a&gt;&lt;/li&gt;
  &lt;li&gt;&lt;a href="#profile"&gt;Profile&lt;/a&gt;&lt;/li&gt;
  &lt;li&gt;&lt;a href="#messages"&gt;Messages&lt;/a&gt;&lt;/li&gt;
  &lt;li&gt;&lt;a href="#settings"&gt;Settings&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;

&lt;div class="tab-content"&gt;
  &lt;div class="tab-pane active" id="home"&gt;...&lt;/div&gt;
  &lt;div class="tab-pane" id="profile"&gt;...&lt;/div&gt;
  &lt;div class="tab-pane" id="messages"&gt;...&lt;/div&gt;
  &lt;div class="tab-pane" id="settings"&gt;...&lt;/div&gt;
&lt;/div&gt;

&lt;script&gt;
  $(function () {
    $('#myTab a:last').tab('show');
  })
&lt;/script&gt;
</pre>
                <p><span class="label label-info">譯者註</span>：注意範例中每個 <code>href="#id-name"</code> 對應至 <code>&lt;div id="name"&gt;</code> 的關係。</p>

                <h3>事件</h3>
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th style="width: 150px;">事件</th>
                            <th>說明</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>show</td>
                            <td>此事件在頁籤呈現時觸發，但是在新頁籤呈現完成之前。使用 <code>event.target</code> 指向要啟用的頁籤，使用 <code>event.relatedTarget</code> 指向前一個啟用的頁籤（如果有的話）。</td>
                        </tr>
                        <tr>
                            <td>shown</td>
                            <td>此事件在頁籤已經完整呈現之後觸發。使用 <code>event.target</code> 指向要啟用的頁籤，使用 <code>event.relatedTarget</code> 指向前一個啟用的頁籤（如果有的話）。</td>
                        </tr>
                    </tbody>
                </table>
                <pre class="prettyprint linenums">
$('a[data-toggle="tab"]').on('shown', function (e) {
  e.target // activated tab
  e.relatedTarget // previous tab
})
</pre>
            </section>


            <!-- Tooltips
        ================================================== -->
            <section id="tooltips">
                <div class="page-header">
                    <h1>工具提示 <small>bootstrap-tooltip.js</small></h1>
                </div>


                <h2>範例</h2>
                <p>取自 Jason Frame 所撰寫優秀 jQuery.tipsy 外掛得到的靈感；工具提示是一個更新版本，它不依賴圖片，使用 CSS3 的動畫和 data- 屬性來對標題進行本地儲存。</p>
                <p><span class="label label-info">譯者註</span>：本地儲存意思是，將標題的描述放入 <code>title="描述…"</code> 屬性內。</p>
                <p>出於性能原因，工具提示和彈出提示 data- API 必須自行宣告，意思是，<strong>你必須自行初始化它們</strong>。</p>
                <p>將滑鼠移至連結將可看到工具提示：</p>
                <div class="bs-docs-example tooltip-demo">
                    <p class="muted" style="margin-bottom: 0;">
                        Tight pants next level keffiyeh <a href="#" data-toggle="tooltip" title="Default tooltip">you probably</a> haven't heard of them. Photo booth beard raw denim letterpress vegan messenger bag stumptown. Farm-to-table seitan, mcsweeney's fixie sustainable quinoa 8-bit american apparel <a href="#" data-toggle="tooltip" title="Another tooltip">have a</a> terry richardson vinyl chambray. Beard stumptown, cardigans banh mi lomo thundercats. Tofu biodiesel williamsburg marfa, four loko mcsweeney's cleanse vegan chambray. A really ironic artisan <a href="#" data-toggle="tooltip" title="A much longer tooltip belongs right here to demonstrate the max-width we apply.">whatever keytar</a>, scenester farm-to-table banksy Austin <a href="#" data-toggle="tooltip" title="The last tip!">twitter handle</a> freegan cred raw denim single-origin coffee viral.
                    </p>
                </div>

                <h3>四種方向</h3>
                <div class="bs-docs-example tooltip-demo">
                    <ul class="bs-docs-tooltip-examples">
                        <li><a href="#" data-toggle="tooltip" data-placement="top" title="Tooltip on top">上方的工具提示</a></li>
                        <li><a href="#" data-toggle="tooltip" data-placement="right" title="Tooltip on right">右方的工具提示</a></li>
                        <li><a href="#" data-toggle="tooltip" data-placement="bottom" title="Tooltip on bottom">下方的工具提示</a></li>
                        <li><a href="#" data-toggle="tooltip" data-placement="left" title="Tooltip on left">左方的工具提示</a></li>
                    </ul>
                </div>
                <p><span class="label label-info">譯者註</span>：設置 <code>data-placement</code> 類別併指定 top、right、bottom 或 left 其中任一值。</p>


                <h3>輸入框群組使用工具提示</h3>
                <p>在 Bootstrap 的輸入框群組使用工具提示和彈出提示，你要設置 <code>container</code> 選項（文件下面說明）來避免不必要的副作用。</p>

                <hr class="bs-docs-separator">


                <h2>使用方式</h2>
                <p>經由 JavaScript 來觸發工具提示：</p>
                <pre class="prettyprint linenums">$('#example').tooltip(options)</pre>

                <h3>選項</h3>
                <p>選項能透過 data 屬性或 JavaScript 來傳遞。data 屬性，將選項名稱附加至 <code>data-</code> 後面，例如，<code>data-animation=""</code>。</p>
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th style="width: 100px;">名稱</th>
                            <th style="width: 100px;">型別</th>
                            <th style="width: 50px;">預設</th>
                            <th>說明</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>animation</td>
                            <td>boolean</td>
                            <td>true</td>
                            <td>為工具提示加入一個 CSS 淡入轉換的效果。</td>
                        </tr>
                        <tr>
                            <td>html</td>
                            <td>boolean</td>
                            <td>false</td>
                            <td>是否允許插入 HTML 到工具提示裡。如果為 false，jQuery 使用 <code>text</code> 方法來插入內容到 DOM 中。使用 <code>text</code> 你必須担心關於 XSS 功擊。<span class="label label-info">譯者註</span>：<a href="http://api.jquery.com/text/" target="_blank" title="jQuery .text() 方法官方說明。">jQuery .text() 方法</a>。</td>
                        </tr>
                        <tr>
                            <td>placement</td>
                            <td>string | function</td>
                            <td>'top'</td>
                            <td>工具提示的定位位置 - top | bottom | left | right。</td>
                        </tr>
                        <tr>
                            <td>selector</td>
                            <td>string</td>
                            <td>false</td>
                            <td>如果提供 selector，將符合條件的一或多個元件啟用工具提示。</td>
                        </tr>
                        <tr>
                            <td>title</td>
                            <td>string | function</td>
                            <td>''</td>
                            <td>如果 title 屬性不存在，使用此值做為預設標題。</td>
                        </tr>
                        <tr>
                            <td>trigger</td>
                            <td>string</td>
                            <td>'hover focus'</td>
                            <td>工具提示觸發方式 - click | hover | focus | manual。注意，你傳遞多個觸發器、空間分隔、觸發類型的情況。<br />
                                <br />
                                <span class="label label-info">譯者註</span>：click 是點擊觸發；hover 是滑鼠移至觸發；focus 是取得焦點觸發；manual 是手動控制觸發。</td>
                        </tr>
                        <tr>
                            <td>delay</td>
                            <td>number | object</td>
                            <td>0</td>
                            <td>
                                <p>呈現或隱藏工具提示的延遲時間（毫秒），注意，不要設置到 manual 類型觸發器。</p>
                                <p>如果提供數字是合法的，延遲設置會同時套用到 hide / show 上。</p>
                                <p>物件建構式：<code>delay: { show: 500, hide: 100 }</code></p>
                            </td>
                        </tr>
                        <tr>
                            <td>container</td>
                            <td>string | false</td>
                            <td>false</td>
                            <td>
                                <p>附加工具提示到指定的元素 <code>container: 'body'</code></p>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <div class="alert alert-info">
                    <strong>注意！</strong>
                    可以針對單獨的工具提示指定單獨的 data 屬性。
                </div>

                <h3>標記</h3>
                <pre class="prettyprint linenums">&lt;a href="#" data-toggle="tooltip" title="first tooltip"&gt;hover over me&lt;/a&gt;</pre>

                <h3>方法</h3>
                <h4>$().tooltip(options)</h4>
                <p>在一組元素上附加工具提示的處理常式。</p>
                <h4>.tooltip('show')</h4>
                <p>呈現某個元素的工具提示。</p>
                <pre class="prettyprint linenums">$('#element').tooltip('show')</pre>
                <h4>.tooltip('hide')</h4>
                <p>隱藏某個元素的工具提示。</p>
                <pre class="prettyprint linenums">$('#element').tooltip('hide')</pre>
                <h4>.tooltip('toggle')</h4>
                <p>切換工具提示為呈現或隱藏。</p>
                <pre class="prettyprint linenums">$('#element').tooltip('toggle')</pre>
                <h4>.tooltip('destroy')</h4>
                <p>隱藏與刪除某個元素的工具提示。</p>
                <pre class="prettyprint linenums">$('#element').tooltip('destroy')</pre>
            </section>



            <!-- Popovers
      ================================================== -->
            <section id="popovers">
                <div class="page-header">
                    <h1>彈出提示 <small>bootstrap-popover.js</small></h1>
                </div>

                <h2>範例</h2>
                <p>此與 iPad 類似的功能，為任意元素加入一個小覆蓋層以加入額外資訊。<del>將滑鼠移至下面按鈕以觸發彈出提示。</del><strong>需要包含 <a href="#tooltips">工具提示</a> 外掛。</strong></p>
                <p><span class="label label-info">譯者註</span>：舊版說明文件的範例是滑鼠移過按鈕（下面紅色大按鈕）時會呈現彈出提示。但目前筆者翻譯 Bootstrap Version 2.3.2 這個版本的文件範例已改為 click 行為來觸發。應是原作者改寫文件時沒有發現所留下的筆誤。這邊還是保留其翻譯文，但加上刪除線。</p>

                <h3>靜態彈出提示</h3>
                <p>有四個方向可選擇：top、right、bottom 和 left 來對齊。</p>
                <div class="bs-docs-example bs-docs-example-popover">
                    <div class="popover top">
                        <div class="arrow"></div>
                        <h3 class="popover-title">Popover top</h3>
                        <div class="popover-content">
                            <p>Sed posuere consectetur est at lobortis. Aenean eu leo quam. Pellentesque ornare sem lacinia quam venenatis vestibulum.</p>
                        </div>
                    </div>

                    <div class="popover right">
                        <div class="arrow"></div>
                        <h3 class="popover-title">Popover right</h3>
                        <div class="popover-content">
                            <p>Sed posuere consectetur est at lobortis. Aenean eu leo quam. Pellentesque ornare sem lacinia quam venenatis vestibulum.</p>
                        </div>
                    </div>

                    <div class="popover bottom">
                        <div class="arrow"></div>
                        <h3 class="popover-title">Popover bottom</h3>
                        <div class="popover-content">
                            <p>Sed posuere consectetur est at lobortis. Aenean eu leo quam. Pellentesque ornare sem lacinia quam venenatis vestibulum.</p>
                        </div>
                    </div>

                    <div class="popover left">
                        <div class="arrow"></div>
                        <h3 class="popover-title">Popover left</h3>
                        <div class="popover-content">
                            <p>Sed posuere consectetur est at lobortis. Aenean eu leo quam. Pellentesque ornare sem lacinia quam venenatis vestibulum.</p>
                        </div>
                    </div>

                    <div class="clearfix"></div>
                </div>
                <p>當彈出提示在 data 屬性內從 JavaScript 和內容產生彈出提示時不需要標記。</p>

                <h3>Live demo</h3>
                <div class="bs-docs-example" style="padding-bottom: 24px;">
                    <a href="#" class="btn btn-large btn-danger" data-toggle="popover" title="A Title" data-content="And here's some amazing content. It's very engaging. right?">點擊以切換彈出提示</a>
                </div>

                <h4>四種方向</h4>
                <div class="bs-docs-example tooltip-demo">
                    <ul class="bs-docs-tooltip-examples">
                        <li><a href="#" class="btn" data-toggle="popover" data-placement="top" data-content="Vivamus sagittis lacus vel augue laoreet rutrum faucibus." title="Popover on top">Popover on top</a></li>
                        <li><a href="#" class="btn" data-toggle="popover" data-placement="right" data-content="Vivamus sagittis lacus vel augue laoreet rutrum faucibus." title="Popover on right">Popover on right</a></li>
                        <li><a href="#" class="btn" data-toggle="popover" data-placement="bottom" data-content="Vivamus sagittis lacus vel augue laoreet rutrum faucibus." title="Popover on bottom">Popover on bottom</a></li>
                        <li><a href="#" class="btn" data-toggle="popover" data-placement="left" data-content="Vivamus sagittis lacus vel augue laoreet rutrum faucibus." title="Popover on left">Popover on left</a></li>
                    </ul>
                </div>


                <hr class="bs-docs-separator">


                <h2>使用方式</h2>
                <p>經由 JavaScript 啟用彈出提示：</p>
                <pre class="prettyprint linenums">$('#example').popover(options)</pre>

                <h3>選項</h3>
                <p>選項能透過 data 屬性或 JavaScript 來傳遞。data 屬性，將選項名稱附加至 <code>data-</code> 後面，例如，<code>data-animation=""</code>。</p>
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th style="width: 100px;">名稱</th>
                            <th style="width: 100px;">型別</th>
                            <th style="width: 50px;">預設</th>
                            <th>說明</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>animation</td>
                            <td>boolean</td>
                            <td>true</td>
                            <td>為彈出提示加入一個 CSS 淡入轉換的效果。</td>
                        </tr>
                        <tr>
                            <td>html</td>
                            <td>boolean</td>
                            <td>false</td>
                            <td>是否允許插入 HTML 到工具提示裡。如果為 false，jQuery 使用 <code>text</code> 方法來插入內容到 DOM 中。使用 <code>text</code> 你必須担心關於 XSS 功擊。</td>
                        </tr>
                        <tr>
                            <td>placement</td>
                            <td>string | function</td>
                            <td>'right'</td>
                            <td>彈出提示的定位位置 - top | bottom | left | right。</td>
                        </tr>
                        <tr>
                            <td>selector</td>
                            <td>string</td>
                            <td>false</td>
                            <td>如果提供 selector，將符合條件的一或多個元件啟用彈出提示。</td>
                        </tr>
                        <tr>
                            <td>trigger</td>
                            <td>string</td>
                            <td>'click'</td>
                            <td>彈出提示觸發方式 - click | hover | focus | manual。</td>
                        </tr>
                        <tr>
                            <td>title</td>
                            <td>string | function</td>
                            <td>''</td>
                            <td>如果 title 屬性不存在，使用此值做為預設標題。</td>
                        </tr>
                        <tr>
                            <td>content</td>
                            <td>string | function</td>
                            <td>''</td>
                            <td>如果 data-content 屬性不存在，使用此值做為預設內容。</td>
                        </tr>
                        <tr>
                            <td>delay</td>
                            <td>number | object</td>
                            <td>0</td>
                            <td>
                                <p>呈現或隱藏工具提示的延遲時間（毫秒），注意，不要設置到 manual 類型觸發器。</p>
                                <p>如果提供數字是合法的，延遲設置會同時套用到 hide / show 上。</p>
                                <p>物件建構式：<code>delay: { show: 500, hide: 100 }</code></p>
                            </td>
                        </tr>
                        <tr>
                            <td>container</td>
                            <td>string | false</td>
                            <td>false</td>
                            <td>
                                <p>附加彈出提示到指定的元素 <code>container: 'body'</code></p>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <div class="alert alert-info">
                    <strong>注意！</strong>可以針對單獨的彈出提示指定單獨的 data 屬性。
                </div>

                <h3>標記</h3>
                <p>出於性能原因，工具提示和彈出提示 data- API 必須自行宣告。如果你想要使用它們僅需要指定一個 selector 選項。</p>

                <h3>方法</h3>
                <h4>$().popover(options)</h4>
                <p>在一組元素上初始化彈出提示。</p>
                <h4>.popover('show')</h4>
                <p>呈現某個元素的彈出提示。</p>
                <pre class="prettyprint linenums">$('#element').popover('show')</pre>
                <h4>.popover('hide')</h4>
                <p>隱藏某個元素的彈出提示。</p>
                <pre class="prettyprint linenums">$('#element').popover('hide')</pre>
                <h4>.popover('toggle')</h4>
                <p>切換彈出提示為呈現或隱藏。</p>
                <pre class="prettyprint linenums">$('#element').popover('toggle')</pre>
                <h4>.popover('destroy')</h4>
                <p>隱藏與刪除某個元素的彈出提示。</p>
                <pre class="prettyprint linenums">$('#element').popover('destroy')</pre>
            </section>



            <!-- Alert
      ================================================== -->
            <section id="alerts">
                <div class="page-header">
                    <h1>警告訊息 <small>bootstrap-alert.js</small></h1>
                </div>


                <h2>警告視窗範例</h2>
                <p>
                    利用此外掛對所有警告訊息加入取消功能。
          Add dismiss functionality to all alert messages with this plugin.
                </p>
                <div class="bs-docs-example">
                    <div class="alert fade in">
                        <button type="button" class="close" data-dismiss="alert">&times;</button>
                        <strong>Holy guacamole!</strong> Best check yo self, you're not looking too good.
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="bs-docs-example"&gt;
  &lt;div class="alert fade in"&gt;
    &lt;button type="button" class="close" data-dismiss="alert"&gt;&times;&lt;/button&gt;
    &lt;strong&gt;Holy guacamole!&lt;/strong&gt; Best check yo self, you're not looking too good.
  &lt;/div&gt;
&lt;/div&gt;
</pre>

                <div class="bs-docs-example">
                    <div class="alert alert-block alert-error fade in">
                        <button type="button" class="close" data-dismiss="alert">&times;</button>
                        <h4 class="alert-heading">Oh snap! You got an error!</h4>
                        <p>Change this and that and try again. Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit. Cras mattis consectetur purus sit amet fermentum.</p>
                        <p>
                            <a class="btn btn-danger" href="#">Take this action</a> <a class="btn" href="#">Or do this</a>
                        </p>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="bs-docs-example"&gt;
  &lt;div class="alert alert-block alert-error fade in"&gt;
    &lt;button type="button" class="close" data-dismiss="alert"&gt;&times;&lt;/button&gt;
    &lt;h4 class="alert-heading"&gt;Oh snap! You got an error!&lt;/h4&gt;
    &lt;p&gt;Change this and that and try again. Duis mollis, est non commodo luctus, 
nisi erat porttitor ligula, eget lacinia odio sem nec elit. Cras mattis 
consectetur purus sit amet fermentum.&lt;/p&gt;
    &lt;p&gt;
      &lt;a class="btn btn-danger" href="#"&gt;Take this action&lt;/a&gt; &lt;a class="btn" href="#"&gt;Or do this&lt;/a&gt;
    &lt;/p&gt;
  &lt;/div&gt;
&lt;/div&gt;
</pre>
                <p><span class="label label-info">譯者註</span>：取消功能是最右邊的「X」。</p>


                <hr class="bs-docs-separator">


                <h2>使用方式</h2>
                <p>經由 JavaScript 來啟用警告視窗的取消功能：</p>
                <pre class="prettyprint linenums">$(".alert").alert()</pre>

                <h3>標記</h3>
                <p>僅需要加入 <code>data-dismiss="alert"</code> 到你的關閉按鈕，即可自動賦予警告視窗閉關的功能。</p>
                <pre class="prettyprint linenums">&lt;a class="close" data-dismiss="alert" href="#"&gt;&amp;times;&lt;/a&gt;</pre>

                <h3>方法</h3>
                <h4>$().alert()</h4>
                <p>賦予所有警告視窗關閉功能。如果希望警告視窗在關閉時有動畫效果，請確認它們已設置好 <code>.fade</code> 和 <code>.in</code> 類別。</p>
                <h4>.alert('close')</h4>
                <p>關閉警告視窗。</p>
                <pre class="prettyprint linenums">$(".alert").alert('close')</pre>


                <h3>事件</h3>
                <p>Bootstrap 警告視窗類別有公開一些事件允許監聽。</p>
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th style="width: 150px;">事件</th>
                            <th>說明</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>close</td>
                            <td>當 <code>close</code> 執行個體方法被呼叫此事件立即觸發。</td>
                        </tr>
                        <tr>
                            <td>closed</td>
                            <td>當警告視窗關閉（會等待 CSS 轉場效果完成）此事件會被觸發。</td>
                        </tr>
                    </tbody>
                </table>
                <pre class="prettyprint linenums">
$('#my-alert').bind('closed', function () {
  // do something…
})
</pre>
            </section>



            <!-- Buttons
          ================================================== -->
            <section id="buttons">
                <div class="page-header">
                    <h1>按鈕 <small>bootstrap-button.js</small></h1>
                </div>

                <h2>使用範例</h2>
                <p>讓按鈕可以做更多事。控制按鈕的狀態或建立複合元件（像是工具列）的按鈕群組。</p>

                <h4>有狀態的</h4>
                <p>加入 <code>data-loading-text="Loading..."</code> 使按鈕呈現載入中的狀態。</p>
                <div class="bs-docs-example" style="padding-bottom: 24px;">
                    <button type="button" id="fat-btn" data-loading-text="loading..." class="btn btn-primary">
                        Loading state
                    </button>
                </div>
                <pre class="prettyprint linenums">&lt;button type="button" class="btn btn-primary" data-loading-text="Loading..."&gt;Loading state&lt;/button&gt;</pre>

                <h4>單一切換</h4>
                <p>加入 <code>data-toggle="button"</code> 以啟用單一按鈕的切換。</p>
                <p><span class="label label-info">譯者註</span>：像一個電子開關。</p>
                <div class="bs-docs-example" style="padding-bottom: 24px;">
                    <button type="button" class="btn btn-primary" data-toggle="button">單一切換</button>
                </div>
                <pre class="prettyprint linenums">&lt;button type="button" class="btn btn-primary" data-toggle="button"&gt;Single Toggle&lt;/button&gt;</pre>

                <h4>Checkbox</h4>
                <p>在 btn-group 加入 <code>data-toggle="buttons-checkbox"</code> 以呈現可切換 checkbox 樣式。</p>
                <p><span class="label label-info">譯者註</span>：複選狀態。</p>
                <div class="bs-docs-example" style="padding-bottom: 24px;">
                    <div class="btn-group" data-toggle="buttons-checkbox">
                        <button type="button" class="btn btn-primary">Left</button>
                        <button type="button" class="btn btn-primary">Middle</button>
                        <button type="button" class="btn btn-primary">Right</button>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="btn-group" data-toggle="buttons-checkbox"&gt;
  &lt;button type="button" class="btn btn-primary"&gt;Left&lt;/button&gt;
  &lt;button type="button" class="btn btn-primary"&gt;Middle&lt;/button&gt;
  &lt;button type="button" class="btn btn-primary"&gt;Right&lt;/button&gt;
&lt;/div&gt;
</pre>

                <h4>Radio</h4>
                <p>在 btn-group 加入 <code>data-toggle="buttons-radio"</code> 以呈現可切換的 radio 樣式。</p>
                <p><span class="label label-info">譯者註</span>：單選狀態。</p>
                <div class="bs-docs-example" style="padding-bottom: 24px;">
                    <div class="btn-group" data-toggle="buttons-radio">
                        <button type="button" class="btn btn-primary">Left</button>
                        <button type="button" class="btn btn-primary">Middle</button>
                        <button type="button" class="btn btn-primary">Right</button>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="btn-group" data-toggle="buttons-radio"&gt;
  &lt;button type="button" class="btn btn-primary"&gt;Left&lt;/button&gt;
  &lt;button type="button" class="btn btn-primary"&gt;Middle&lt;/button&gt;
  &lt;button type="button" class="btn btn-primary"&gt;Right&lt;/button&gt;
&lt;/div&gt;
</pre>


                <hr class="bs-docs-separator">


                <h2>使用方式</h2>
                <p>經由 JavaScript 啟用按鈕：</p>
                <pre class="prettyprint linenums">$('.nav-tabs').button()</pre>

                <h3>標記</h3>
                <p>data 屬性是按鈕外掛不可或缺的一部分。查閱下面的範例程式碼和各種標記類別。</p>

                <h3>選項</h3>
                <p><em>無</em></p>

                <h3>方法</h3>
                <h4>$().button('toggle')</h4>
                <p>切換按下的狀態。賦予按鈕被啟用時應有的外觀樣式。</p>
                <div class="alert alert-info">
                    <strong>注意！</strong>你也可以使用 <code>data-toggle</code> 屬性自動啟用可切換狀態。
                </div>
                <pre class="prettyprint linenums">&lt;button type="button" class="btn" data-toggle="button" &gt;…&lt;/button&gt;</pre>
                <h4>$().button('loading')</h4>
                <p>
                    設置按鈕為載入狀態 - 這會將禁用按鈕和更改文字為 loading。按鈕文字應該使用 data 屬性 <code>data-loading-text</code> 設置在按鈕元素上。
                </p>
                <pre class="prettyprint linenums">&lt;button type="button" class="btn" data-loading-text="勇者，載入中..." &gt;...&lt;/button&gt;</pre>
                <div class="alert alert-info">
                    <strong>注意！</strong>
                    <a href="https://github.com/twitter/bootstrap/issues/793">Firefox 跨頁載入時保持禁用的狀態</a>。變通方案是在按鈕上使用 <code>autocomplete="off"</code>。
                </div>
                <h4>$().button('reset')</h4>
                <p>重新設置按鈕狀態 - 這會還原按鈕文字。</p>
                <h4>$().button(string)</h4>
                <p>重新設置按鈕狀態 - 這會將按鈕文字更改為定義的文字。</p>
                <pre class="prettyprint linenums">&lt;button type="button" class="btn" data-complete-text="finished!" &gt;...&lt;/button&gt;
&lt;script&gt;
  $('.btn').button('complete')
&lt;/script&gt;
</pre>
            </section>



            <!-- Collapse
          ================================================== -->
            <section id="collapse">
                <div class="page-header">
                    <h1>折疊效果 <small>bootstrap-collapse.js</small></h1>
                </div>

                <h3>關於</h3>
                <p>取得可折疊元件，像是手風琴或巡覽的基礎樣式和彈性的支援。</p>
                <p><span class="label label-info">譯者註</span>：accordion 是手風琴，西方一種常用樂器，延伸意思是<strong>可折疊</strong>。讀者可以想成東方的<strong>扇子</strong>。</p>
                <p class="muted"><strong>*</strong> 需包含 Transition 外掛。</p>

                <h2>手風琴範例</h2>
                <p>使用折疊外掛，我們建置一個簡單手風琴樣式小工具：</p>

                <div class="bs-docs-example">
                    <div class="accordion" id="accordion2">
                        <div class="accordion-group">
                            <div class="accordion-heading">
                                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion2" href="#collapseOne">Collapsible Group Item #1
                                </a>
                            </div>
                            <div id="collapseOne" class="accordion-body collapse in">
                                <div class="accordion-inner">
                                    Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
                                </div>
                            </div>
                        </div>
                        <div class="accordion-group">
                            <div class="accordion-heading">
                                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion2" href="#collapseTwo">Collapsible Group Item #2
                                </a>
                            </div>
                            <div id="collapseTwo" class="accordion-body collapse">
                                <div class="accordion-inner">
                                    Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
                                </div>
                            </div>
                        </div>
                        <div class="accordion-group">
                            <div class="accordion-heading">
                                <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion2" href="#collapseThree">Collapsible Group Item #3
                                </a>
                            </div>
                            <div id="collapseThree" class="accordion-body collapse">
                                <div class="accordion-inner">
                                    Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div class="accordion" id="accordion2"&gt;
  &lt;div class="accordion-group"&gt;
    &lt;div class="accordion-heading"&gt;
      &lt;a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion2" href="#collapseOne"&gt;
        Collapsible Group Item #1
      &lt;/a&gt;
    &lt;/div&gt;
    &lt;div id="collapseOne" class="accordion-body collapse in"&gt;
      &lt;div class="accordion-inner"&gt;
        Anim pariatur cliche...
      &lt;/div&gt;
    &lt;/div&gt;
  &lt;/div&gt;
  &lt;div class="accordion-group"&gt;
    &lt;div class="accordion-heading"&gt;
      &lt;a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion2" href="#collapseTwo"&gt;
        Collapsible Group Item #2
      &lt;/a&gt;
    &lt;/div&gt;
    &lt;div id="collapseTwo" class="accordion-body collapse"&gt;
      &lt;div class="accordion-inner"&gt;
        Anim pariatur cliche...
      &lt;/div&gt;
    &lt;/div&gt;
  &lt;/div&gt;
&lt;/div&gt;
...
</pre>
                <p>你也可以不使用手風琴標記來使用此外掛。使用一個按鈕來切換與折疊另一個元素。</p>
                <pre class="prettyprint linenums">
&lt;button type="button" class="btn btn-danger" data-toggle="collapse" data-target="#demo"&gt;
  simple collapsible
&lt;/button&gt;

&lt;div id="demo" class="collapse in"&gt; … &lt;/div&gt;
</pre>


                <hr class="bs-docs-separator">


                <h2>使用方式</h2>

                <h3>經由 data 屬性</h3>
                <p>僅需的加入 <code>data-toggle="collapse"</code> 和 <code>data-target</code> 到元素上就能自動指派折疊元素的控制權。<code>data-target</code> 屬採接受一個 CSS 選擇器，以選取元素套用折疊樣式。另外，一定要加入 <code>collapse</code> 類別到可折疊元素上。如果要預設某折疊元素是開啟的，還要額外加入 <code>in</code> 類別。</p>
                <p>若要加入手風琴樣式的群組管理到可折疊控制項，需要加入 data 屬性 <code>data-parent="#selector"</code>。請參考上面範例。</p>
                <p><span class="label label-info">譯者註</span>：參考範例中 <code>&lt;a&gt;</code> 元素的 <code>data-parent="#accordion2"</code> 屬性設置，它對應的是外層的 <code>&lt;div&gt;</code> 的 <code>id="accordion2"</code>。</p>

                <h3>經由 JavaScript</h3>
                <p>可手動啟用可折疊效果：</p>
                <pre class="prettyprint linenums">$(".collapse").collapse()</pre>

                <h3>選項</h3>
                <p>
                    選項能透過 data 屬性或 JavaScript 來傳遞。data 屬性，將選項名稱附加至 <code>data-</code> 後面，例如，<code>data-parent=""</code>。
                </p>
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th style="width: 100px;">名稱</th>
                            <th style="width: 50px;">型別</th>
                            <th style="width: 50px;">預設</th>
                            <th>說明</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>parent</td>
                            <td>selector</td>
                            <td>false</td>
                            <td>如果指定了選擇器，那麼在呈現此折疊項目時，其他所有被選取的元素集合的折疊效果為關閉效果（與手風琴行為類似）。</td>
                        </tr>
                        <tr>
                            <td>toggle</td>
                            <td>boolean</td>
                            <td>true</td>
                            <td>呼叫時切換可折疊元素的折疊效果。</td>
                        </tr>
                    </tbody>
                </table>


                <h3>方法</h3>
                <h4>.collapse(options)</h4>
                <p>將你的內容轉換為一個可折疊元素。接受一個選擇性參數 <code>object</code>。</p>
                <pre class="prettyprint linenums">
$('#myCollapsible').collapse({
  toggle: false
})
</pre>
                <h4>.collapse('toggle')</h4>
                <p>切換可折疊元素的呈現或隱藏。</p>
                <h4>.collapse('show')</h4>
                <p>呈現可折疊元素。</p>
                <h4>.collapse('hide')</h4>
                <p>隱藏可折疊元素。</p>

                <h3>事件</h3>
                <p>Bootstrap 折疊功能有公開一些事件允許監聽。</p>
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th style="width: 150px;">事件</th>
                            <th>說明</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>show</td>
                            <td>當 <code>show</code> 執行個體方法被呼叫此事件立即觸發。</td>
                        </tr>
                        <tr>
                            <td>shown</td>
                            <td>當折疊效果呈現完成至使用者面前（會等待 CSS 轉場效果完成）此事件會被觸發。</td>
                        </tr>
                        <tr>
                            <td>hide</td>
                            <td>當 <code>hide</code> 執行個體方法被呼叫此事件立即觸發。</td>
                        </tr>
                        <tr>
                            <td>hidden</td>
                            <td>當折疊效果從使用者面前隱藏完成（會等待 CSS 轉場效果完成）此事件會被觸發。</td>
                        </tr>
                    </tbody>
                </table>
                <pre class="prettyprint linenums">
$('#myCollapsible').on('hidden', function () {
  // do something…
})</pre>
            </section>



            <!-- Carousel
          ================================================== -->
            <section id="carousel">
                <div class="page-header">
                    <h1>輪播效果 <small>bootstrap-carousel.js</small></h1>
                </div>

                <h2>輪播範例</h2>
                <p>下面幻燈片效果呈示通用外掛和類似迴圈的輪播元素的元件。</p>
                <div class="bs-docs-example">
                    <div id="myCarousel" class="carousel slide">
                        <ol class="carousel-indicators">
                            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                            <li data-target="#myCarousel" data-slide-to="1"></li>
                            <li data-target="#myCarousel" data-slide-to="2"></li>
                        </ol>
                        <div class="carousel-inner">
                            <div class="item active">
                                <img src="~/Images/bootstrap/bootstrap-mdo-sfmoma-01.jpg" alt="">
                                <div class="carousel-caption">
                                    <h4>First Thumbnail label</h4>
                                    <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                                </div>
                            </div>
                            <div class="item">
                                <img src="~/Images/bootstrap/bootstrap-mdo-sfmoma-02.jpg" alt="" />
                                <div class="carousel-caption">
                                    <h4>Second Thumbnail label</h4>
                                    <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                                </div>
                            </div>
                            <div class="item">
                                <img src="~/Images/bootstrap/bootstrap-mdo-sfmoma-03.jpg" alt="" />
                                <div class="carousel-caption">
                                    <h4>Third Thumbnail label</h4>
                                    <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                                </div>
                            </div>
                        </div>
                        <a class="left carousel-control" href="#myCarousel" data-slide="prev">&lsaquo;</a>
                        <a class="right carousel-control" href="#myCarousel" data-slide="next">&rsaquo;</a>
                    </div>
                </div>
                <pre class="prettyprint linenums">
&lt;div id="myCarousel" class="carousel slide"&gt;
  &lt;ol class="carousel-indicators"&gt
    &lt;li data-target="#myCarousel" data-slide-to="0" class="active"&gt&lt;/li&gt
    &lt;li data-target="#myCarousel" data-slide-to="1"&gt&lt;/li&gt
    &lt;li data-target="#myCarousel" data-slide-to="2"&gt&lt;/li&gt
  &lt;/ol&gt
  &lt;!-- Carousel items --&gt;
  &lt;div class="carousel-inner"&gt;
    &lt;div class="active item"&gt;…&lt;/div&gt;
    &lt;div class="item"&gt;…&lt;/div&gt;
    &lt;div class="item"&gt;…&lt;/div&gt;
  &lt;/div&gt;
  &lt;!-- Carousel nav --&gt;
  &lt;a class="carousel-control left" href="#myCarousel" data-slide="prev"&gt;&amp;lsaquo;&lt;/a&gt;
  &lt;a class="carousel-control right" href="#myCarousel" data-slide="next"&gt;&amp;rsaquo;&lt;/a&gt;
&lt;/div&gt;
</pre>

                <div class="alert alert-warning">
                    <strong>注意！</strong>實作此輪播時，記得將範例中的圖片替換為你需要的圖片。
                </div>
                <p><span class="label label-info">譯者註</span>：言外之意，複製貼上的人太多？</p>


                <hr class="bs-docs-separator">


                <h2>使用方式</h2>

                <h3>經由 data 屬性</h3>
                <p>使用 data 屬性很容易去控制輪播的位置。<code>data-slide</code> 接受 <code>prev</code> 或 <code>next</code> 為關鍵字，這會改變幻燈片的位置。另外，使用 <code>data-slide-to</code> 可以傳遞幻燈片索引值給輪播外掛，例如，<code>data-slide-to="2"</code> 就可以直接播放指定索引值的幻燈片。注意，索引值由 <code>0</code> 開始。</p>

                <h3>經由 JavaScript</h3>
                <p>手動呼叫輪播：</p>
                <pre class="prettyprint linenums">$('.carousel').carousel()</pre>

                <h3>選項</h3>
                <p>選項能透過 data 屬性或 JavaScript 來傳遞。data 屬性，將選項名稱附加至 <code>data-</code> 後面，例如，<code>data-interval=""</code>。</p>
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th style="width: 100px;">名稱</th>
                            <th style="width: 50px;">型別</th>
                            <th style="width: 50px;">預設</th>
                            <th>說明</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>interval</td>
                            <td>number</td>
                            <td>5000</td>
                            <td>在自動輪播的過程中，每張幻燈片所呈現的時間。如果為 false，將不會自動輪播。<br />
                                <br />
                                <span class="label label-info">譯者註</span>：單位為毫秒。</td>
                        </tr>
                        <tr>
                            <td>pause</td>
                            <td>string</td>
                            <td>"hover"</td>
                            <td>當滑鼠移至輪播區域時暫停輪播效果，滑鼠離開輪播區域時重新輪播效果。</td>
                        </tr>
                    </tbody>
                </table>

                <h3>方法</h3>
                <h4>.carousel(options)</h4>
                <p>輪播的初始化有一個選擇性選項 <code>object</code> 和自動開始輪播。</p>
                <pre class="prettyprint linenums">
$('.carousel').carousel({
  interval: 2000
})
</pre>
                <h4>.carousel('cycle')</h4>
                <p>由左向右循環播放。</p>
                <h4>.carousel('pause')</h4>
                <p>停止循環播放。</p>
                <h4>.carousel(number)</h4>
                <p>循環播放到指定畫面（以 0 為基礎，類似陣列）。</p>
                <h4>.carousel('prev')</h4>
                <p>回到上一個畫面。</p>
                <h4>.carousel('next')</h4>
                <p>移至下一個畫面。</p>

                <h3>事件</h3>
                <p>Bootstrap 輪播效果類別有公開一些事件允許監聽。</p>
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th style="width: 150px;">事件</th>
                            <th>說明</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>slide</td>
                            <td>當 <code>slide</code> 執行個體方法被呼叫此事件立即觸發。</td>
                        </tr>
                        <tr>
                            <td>slid</td>
                            <td>當輪播效果完成幻燈片的切換此事件會被觸發。</td>
                        </tr>
                    </tbody>
                </table>
            </section>



            <!-- Typeahead
          ================================================== -->
            <section id="typeahead">
                <div class="page-header">
                    <h1>輸入提示 <small>bootstrap-typeahead.js</small></h1>
                </div>


                <h2>範例</h2>
                <p>一個簡單且易於擴充的外掛，讓你快速為任何輸入框建立優雅的提示。</p>
                <div class="bs-docs-example" style="background-color: #f5f5f5;">
                    <input type="text" class="span3" style="margin: 0 auto;" data-provide="typeahead" data-items="4" data-source='["Alabama","Alaska","Arizona","Arkansas","California","Colorado","Connecticut","Delaware","Florida","Georgia","Hawaii","Idaho","Illinois","Indiana","Iowa","Kansas","Kentucky","Louisiana","Maine","Maryland","Massachusetts","Michigan","Minnesota","Mississippi","Missouri","Montana","Nebraska","Nevada","New Hampshire","New Jersey","New Mexico","New York","North Dakota","North Carolina","Ohio","Oklahoma","Oregon","Pennsylvania","Rhode Island","South Carolina","South Dakota","Tennessee","Texas","Utah","Vermont","Virginia","Washington","West Virginia","Wisconsin","Wyoming", "陳傳興Bruce翻譯"]'>
                </div>
                <pre class="prettyprint linenums">&lt;input type="text" data-provide="typeahead"&gt;</pre>
                <p><span class="label label-info">譯者註</span>：此範例有設置 <code>data-source</code> 屬性（下面說明），讀者可以試著個別輸入 <code>a-z</code> 會有自動完成的提示。<code>data-source</code> 內容設置為中文也沒有問題。</p>
                <p>你也許需要設置 <code>autocomplete="off"</code> 以預防瀏覽器預設選單覆蓋 Bootstrap 輸入提示選單。</p>

                <hr class="bs-docs-separator">


                <h2>使用方式</h2>

                <h3>經由 data 屬性</h3>
                <p>經由 data 屬性去註冊輸入提示功能到元素上，如同上面範例一樣。</p>

                <h3>經由 JavaScript</h3>
                <p>手動呼叫輸入提示：</p>
                <pre class="prettyprint linenums">$('.typeahead').typeahead()</pre>

                <h3>選項</h3>
                <p>選項能透過 data 屬性或 JavaScript 來傳遞。data 屬性，將選項名稱附加至 <code>data-</code> 後面，例如，<code>data-source=""</code>。</p>
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th style="width: 100px;">名稱</th>
                            <th style="width: 50px;">型別</th>
                            <th style="width: 100px;">預設</th>
                            <th>說明</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>source</td>
                            <td>array, function</td>
                            <td>[ ]</td>
                            <td>用於查詢的資料來源。可能是一組陣列或字串或函式。函數必須傳遞兩個參數，輸入欄位的 <code>query</code> 值和 <code>process</code> 回呼（callback）函式。函式可能使用非同步來呼叫直接回傳資源來源，或使用同步呼叫，透過 <code>process</code> 回呼函式單一參數。</td>
                        </tr>
                        <tr>
                            <td>items</td>
                            <td>number</td>
                            <td>8</td>
                            <td>下拉式選單呈現最大項目數。</td>
                        </tr>
                        <tr>
                            <td>minLength</td>
                            <td>number</td>
                            <td>1</td>
                            <td>觸發自動完成提示所需小最字元數。</td>
                        </tr>
                        <tr>
                            <td>matcher</td>
                            <td>function</td>
                            <td>case insensitive</td>
                            <td>此方法用於決定某個查詢是否符合某個項目。它接受一個參數 <code>item</code>，表示需要測試的查詢項目。透過 <code>this.query</code> 可以取得現在查詢字串。如果查詢結果符合，回傳 Boolean 值 <code>true</code>。</td>
                        </tr>
                        <tr>
                            <td>sorter</td>
                            <td>function</td>
                            <td>exact match,<br>
                                case sensitive,<br>
                                case insensitive</td>
                            <td>此方法用於排序自動完成提示的結果。它接受一個參數 <code>item</code>，參數的作用範圍在輸入提示的執行個體內。使用 <code>this.query</code> 參考現在的查詢字串。</td>
                        </tr>
                        <tr>
                            <td>updater</td>
                            <td>function</td>
                            <td>returns selected item</td>
                            <td>此方法用於回傳被選擇的項目。它接受一個參數 <code>item</code>，參數的作用範圍在輸入提示的執行個體內。</td>
                        </tr>
                        <tr>
                            <td>highlighter</td>
                            <td>function</td>
                            <td>highlights all default matches</td>
                            <td>此方法用來高亮度提示自動完成的結果。它接受一個參數 <code>item</code>，參數的作用範圍在輸入提示的執行個體內。它應該回傳 html。</td>
                        </tr>
                    </tbody>
                </table>

                <h3>方法</h3>
                <h4>.typeahead(options)</h4>
                <p>初始化輸入框成為輸入提示樣式。</p>
            </section>



            <!-- Affix
          ================================================== -->
            <section id="affix">
                <div class="page-header">
                    <h1>附加巡覽 <small>bootstrap-affix.js</small></h1>
                </div>

                <h2>範例</h2>
                <p>本文件左邊就是一個附加巡覽外掛的展示。</p>
                <p><span class="label label-info">譯者註</span>：本文件最上方是主巡覽最，除首頁外，其他教學文件頁都有左邊附加巡覽（或稱子巡覽、次巡覽）。</p>

                <hr class="bs-docs-separator">

                <h2>使用方式</h2>

                <h3>經由 data 屬性</h3>
                <p>加入附加巡覽行到任何元素是簡單的，僅需要加入 <code>data-spy="affix"</code> 到你想監聽的元素上。然後使用偏移量來定義何時切換開關元素的釘選。</p>

                <pre class="prettyprint linenums">&lt;div data-spy="affix" data-offset-top="200"&gt;...&lt;/div&gt;</pre>

                <div class="alert alert-info">
                    <strong>注意！</strong>
                    你必須管理釘選元素的位置和它直接父元素的行為。位置使用 <code>affix</code>、<code>affix-top</code> 和 <code>affix-bottom</code> 來控制。記得檢查潛在的可折疊父元素當附加巡覽衝突時，它會從頁面的正常流動中刪除內容。
                </div>

                <h3>經由 JavaScript</h3>
                <p>經由 JavaScript 呼叫附加巡覽外掛：</p>
                <pre class="prettyprint linenums">$('#navbar').affix()</pre>

                <h3>選項</h3>
                <p>選項能透過 data 屬性或 JavaScript 來傳遞。data 屬性，將選項名稱附加至 <code>data-</code> 後面，例如，<code>data-offset-top="200"</code>。</p>
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th style="width: 100px;">名稱</th>
                            <th style="width: 100px;">型別</th>
                            <th style="width: 50px;">預設</th>
                            <th>說明</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>offset</td>
                            <td>number | function | object</td>
                            <td>10</td>
                            <td>捲軸移動時，會從螢幕的像素去計算偏移的位置。如果提供一個數字，那麼偏移會直接套用到 top 和 left。監聽單一方向或多個唯一偏移，僅需提供 <code>offset: { x: 10 }</code> 物件。當你需要動態地提供一個偏移量時，請使用函數。</td>
                        </tr>
                    </tbody>
                </table>
            </section>
        </div>
    </div>
</div>