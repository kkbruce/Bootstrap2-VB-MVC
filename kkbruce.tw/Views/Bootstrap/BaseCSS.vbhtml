﻿@Code
    ViewData("Title") = "基礎CSS"
    ViewData("Description") = "介紹 Bootstrap 裡基本HTML元素樣式和CSS擴充類別。CSS增強部分含有佈局、程式碼、表格、表單、按鈕、圖片、Icons等。"
    ViewData("Keywords") = "Bootstrap CSS, CSS佈局, CSS程式碼, CSS表格, CSS表單, CSS按鈕, CSS圖片, CSS Icons"
End Code

@section navbar
    @Html.Partial("_NavBar")
End Section

<header class="jumbotron subhead" id="overview">
    <div class="container">
        <h1>基礎 CSS</h1>
        <p class="lead">基本 HTML 元素樣式和擴充類別增強。</p>
    </div>
</header>

<div class="container">
    <!-- Docs nav
    ================================================== -->
    <div class="row">
        <nav class="span3 bs-docs-sidebar">
            <ul class="nav nav-list bs-docs-sidenav">
                <li><a href="#typography"><i class="icon-chevron-right"></i> 佈局</a></li>
                <li><a href="#code"><i class="icon-chevron-right"></i> 程式碼</a></li>
                <li><a href="#tables"><i class="icon-chevron-right"></i> 表格</a></li>
                <li><a href="#forms"><i class="icon-chevron-right"></i> 表單</a></li>
                <li><a href="#buttons"><i class="icon-chevron-right"></i> 按鈕</a></li>
                <li><a href="#images"><i class="icon-chevron-right"></i> 圖片</a></li>
                <li><a href="#icons"><i class="icon-chevron-right"></i> Icons（Glyphicons提供）</a></li>
            </ul>
        </nav>
        <div class="span9">
            <nav>
                目前位置：@Html.MvcSiteMap().SiteMapPath()
            </nav>

            <!-- Typography
            ================================================== -->
            <section id="typography">
                <div class="page-header">
                    <h1>佈局</h1>
                </div>

                <h2 id="headings">標題</h2>
                <p>所有 HTML 標題元素，從 <code>&lt;h1&gt;</code> 到 <code>&lt;h6&gt;</code> 都是可用的。</p>
                <div class="bs-docs-example">
                    <h1>h1. Heading 1</h1>
                    <h2>h2. Heading 2</h2>
                    <h3>h3. Heading 3</h3>
                    <h4>h4. Heading 4</h4>
                    <h5>h5. Heading 5</h5>
                    <h6>h6. Heading 6</h6>
                </div>

                <h2 id="body-copy">Body設置</h2>
                <p>Bootstrap 全域預設值中 <code>font-size</code> 是 <strong>14px</strong>，<code>line-height</code> 是 <strong>20px</strong>。這些預設值設置在 <code>&lt;body&gt;</code> 和所有段落（paragraphs，即 p 元素）上。另外，<code>&lt;p&gt;</code> 還定義二分之一行高（預設是 10px）和底部邊距（bottom margin）。</p>
                <div class="bs-docs-example">
                    <p>Nullam quis risus eget urna mollis ornare vel eu leo. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nullam id dolor id nibh ultricies vehicula.</p>
                    <p>Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec ullamcorper nulla non metus auctor fringilla. Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit. Donec ullamcorper nulla non metus auctor fringilla.</p>
                    <p>Maecenas sed diam eget risus varius blandit sit amet non magna. Donec id elit non mi porta gravida at eget metus. Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit.</p>
                    <p>葡萄美酒夜光杯，欲飲琵琶馬上催。醉臥沙場君莫笑，古來征戰幾人回。</p>
                    <p>漢皇重色思傾國，御宇多年求不得。楊家有女初長成，養在深閨人未識。天生麗質難自棄，一朝選在君王側。回眸一笑百媚生，六宮粉無顏色。春寒賜浴華清池，溫泉水滑洗凝脂。侍兒扶起嬌無力，正是新承恩澤時。雲鬢花顏金步搖，芙蓉帳暖度春宵。春宵苦短日高起從此君王不早朝。承歡侍宴無閒暇，春從春游夜專夜。後宮佳麗三千人，三千寵愛在一身。金屋妝成嬌侍夜，玉樓宴罷醉和春。姊妹弟皆列土，可憐光彩生門戶。遂令天下父母心，不重生男重生女。驪宮高處入青雲，仙樂風飄處處聞。緩歌謾舞凝絲竹，盡日君王看不足漁陽鼙鼓動地來，驚破霓裳羽衣曲。九重城闕煙塵生，千乘萬騎西南行。翠華搖搖行復止，西出都門百餘里。…</p>
                    <p>煙籠寒水月籠沙，夜泊秦淮近酒家。商女不知亡國恨，隔江猶唱後庭花。</p>
                </div>
                <pre class="prettyprint">&lt;p&gt;...&lt;/p&gt;</pre>
                <p><span class="label label-info">譯著註</span>：範例中特別加入“<strong>中文</strong>”，這是英文和中文在閱讀的感受上所有不同，讀者可以依照設計網站內容（中文或英文）調整預設值。例如，加入<strong>中文字型、字型大小</strong>的設置等。</p>

                <h3>突出 body 設置</h3>
                <p>段落加入 <code>.lead</code> 可以讓段落突出呈現。</p>
                <div class="bs-docs-example">
                    <p class="lead">Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor auctor. Duis mollis, est non commodo luctus.</p>
                    <p class="lead">月落烏啼霜滿天，江楓漁火對愁眠。姑蘇城外寒山寺，夜半鐘聲到客船。</p>
                </div>
                <pre class="prettyprint">&lt;p class="lead"&gt;...&lt;/p&gt;</pre>

                <h3>建置於Less</h3>
                <p>在 <strong>variables.less</strong> 文件中定義了兩個 LESS 變數來決定佈局尺寸：<code>@@baseFontSize</code> 和 <code>@@baseLineHeight</code>，第一個變數定義 font-size 基準，第二個變數定義 line-height 基準。我們使用這些變數和一些簡單的數學去建立其他所有頁面元素的 margin、padding、line-height。自定義這些變數可以改變 Bootstrap 預設樣式。</p>


                <hr class="bs-docs-separator">


                <h2 id="emphasis">強調</h2>
                <p>使用 HTML 預設的強調的標籤，並給於少量的樣式。</p>

                <h3><code>&lt;small&gt;</code></h3>
                <p>不需要強調的 inline 或 block 的文字，<small>可使用 small 標籤。</small></p>
                <div class="bs-docs-example">
                    <p><small>This line of text is meant to be treated as fine print.</small></p>
                    <p><small>朱雀橋邊野草花，烏衣巷口夕陽斜。舊時王謝堂前燕，飛入尋常百姓家。</small></p>
                </div>
                <pre class="prettyprint">
&lt;p&gt;
  &lt;small&gt;This line of text is meant to be treated as fine print.&lt;/small&gt;
&lt;/p&gt;
</pre>

                <h3>粗體</h3>
                <p>用 font-weight 的方式加粗字體以強調一段文字。</p>
                <div class="bs-docs-example">
                    <p>The following snippet of text is <strong>rendered as bold text</strong>.</p>
                    <p>紗窗日落漸黃昏，<strong>金屋無人見淚痕。</strong>寂寞空庭春欲晚，梨花滿地不開門。</p>
                </div>
                <pre class="prettyprint">&lt;strong&gt;rendered as bold text&lt;/strong&gt;</pre>

                <h3>斜體</h3>
                <p>用斜體字來強調一段文字。</p>
                <div class="bs-docs-example">
                    <p>The following snippet of text is <em>rendered as italicized text</em>.</p>
                    <p>更深月色半人家，北斗闌干南斗斜。<em>今夜偏知春氣暖，蟲聲新透綠窗紗。</em></p>
                </div>
                <pre class="prettyprint">&lt;em&gt;rendered as italicized text&lt;/em&gt;</pre>
                
                <p><span class="label label-info">注意！</span>在 HTML5 中可自由使用 <code>&lt;b&gt;</code> 和 <code>&lt;i&gt;</code>。<code>&lt;b&gt;</code> 加粗字體或短語並不賦予重要含義，<code>&lt;i&gt;</code> 被用來表示發言、技術術語等。</p>

                <p><span class="label label-info">譯者註</span>：在中文環境裡使用斜體不會有比較好閱讀體驗，一般會透過 <code>font-style: normal;</code> 取消斜體樣式，另外設置顏色或粗體來強調。雖然閱讀起來都是粗體，不過在 HTML 語意上的強調等級不同。以上的 <code>strong</code> 與 <code>em</code> 被筆者 @Html.ActionLink("異動", "About", Nothing, Nothing, Nothing, "editcss", Nothing, Nothing) 過。</p>

                <h3>對齊類別</h3>
                <p>以下是簡易將文字進行對齊的類別。</p>
                <div class="bs-docs-example">
                    <p class="text-left">左邊對齊文字。</p>
                    <p class="text-center">中間對齊文字。</p>
                    <p class="text-right">右邊對齊文字。</p>
                </div>
                <pre class="prettyprint linenums">
&lt;p class="text-left"&gt;左邊對齊文字。&lt;/p&gt;
&lt;p class="text-center"&gt;中間對齊文字。&lt;/p&gt;
&lt;p class="text-right"&gt;右邊對齊文字。&lt;/p&gt;
</pre>

                <h3>強調類別</h3>
                <p>這此類別透過顏色來表示強調。</p>
                <div class="bs-docs-example">
                    <p class="muted">Fusce dapibus, tellus ac cursus commodo, tortor mauris nibh.</p>
                    <p class="text-warning">Etiam porta sem malesuada magna mollis euismod.</p>
                    <p class="text-error">Donec ullamcorper nulla non metus auctor fringilla.</p>
                    <p class="text-info">Aenean eu leo quam. Pellentesque ornare sem lacinia quam venenatis.</p>
                    <p class="text-success">Duis mollis, est non commodo luctus, nisi erat porttitor ligula.</p>
                </div>
<pre class="prettyprint linenums">
&lt;p class="muted"&gt;Fusce dapibus, tellus ac cursus commodo, tortor mauris nibh.&lt;/p&gt;
&lt;p class="text-warning"&gt;Etiam porta sem malesuada magna mollis euismod.&lt;/p&gt;
&lt;p class="text-error"&gt;Donec ullamcorper nulla non metus auctor fringilla.&lt;/p&gt;
&lt;p class="text-info"&gt;Aenean eu leo quam. Pellentesque ornare sem lacinia quam venenatis.&lt;/p&gt;
&lt;p class="text-success"&gt;Duis mollis, est non commodo luctus, nisi erat porttitor ligula.&lt;/p&gt;
</pre>


                <hr class="bs-docs-separator">


                <h2 id="abbreviations">縮寫</h2>
                <p>當滑鼠停留在縮寫或縮寫詞上時會顯示完整內容，Bootstrap 增強 HTML <code>&lt;abbr&gt;</code> 元素的樣式。縮寫元素帶有 <code>title</code> 屬性，外觀會帶有淡的虛底線，滑鼠移至縮寫詞上面時會帶有問號指標。</p>

                <h3><code>&lt;abbr&gt;</code></h3>
                <p>想看完整的內容，可以把滑鼠停留在縮寫詞上，但必須包含 <code>title</code> 屬性。</p>
                <div class="bs-docs-example">
                    <p>An abbreviation of the word attribute is
                        <abbr title="attribute">attr</abbr>.</p>
                </div>
                <pre class="prettyprint">&lt;abbr title="attribute"&gt;attr&lt;/abbr&gt;</pre>

                <h3><code>&lt;abbr class="initialism"&gt;</code></h3>
                <p>加入 <code>.initialism</code> 類別到縮寫裡，使用更小一些的 font-size。</p>
                <div class="bs-docs-example">
                    <p>
                        <abbr title="HyperText Markup Language" class="initialism">HTML</abbr>
                        is the best thing since sliced bread.</p>
                </div>
                <pre class="prettyprint">&lt;abbr title="HyperText Markup Language" class="initialism"&gt;HTML&lt;/abbr&gt;</pre>


                <hr class="bs-docs-separator">


                <h2 id="addresses">地址</h2>
                <p>讓連絡資訊以最接近日常使用格式呈現。</p>

                <h3><code>&lt;address&gt;</code></h3>
                <p>在每行結尾加入 <code>&lt;br&gt;</code> 以保留格式。</p>
                <div class="bs-docs-example">
                    <address>
                        <strong>Twitter, Inc.</strong><br>
                        795 Folsom Ave, Suite 600<br>
                        San Francisco, CA 94107<br>
                        <abbr title="Phone">P:</abbr>
                        (123) 456-7890
                    </address>
                    <address>
                        <strong>Full Name</strong><br>
                        <a href="mailto:#">first.last@example.com</a>
                    </address>
                    <address>
                        <strong>新竹金剛熊安親家教班</strong><br>
                        新竹市XXXX街<br>
                        XX巷XX弄XX號<br>
                        電話：（03）888-8888
                    </address>
                    <address>
                        <strong>電子郵件</strong><br>
                        <a href="mailto:#">first.last@example.com</a><br />
                        網頁：<a href="http://blog.kkbruce.net/2012/05/blog-post.html" target="_blank">金剛熊介紹</a>
                    </address>
                </div>
                <pre class="prettyprint linenums">
&lt;address&gt;
  &lt;strong&gt;Twitter, Inc.&lt;/strong&gt;&lt;br&gt;
  795 Folsom Ave, Suite 600&lt;br&gt;
  San Francisco, CA 94107&lt;br&gt;
  &lt;abbr title="Phone"&gt;P:&lt;/abbr&gt; (123) 456-7890
&lt;/address&gt;

&lt;address&gt;
  &lt;strong&gt;Full Name&lt;/strong&gt;&lt;br&gt;
  &lt;a href="mailto:#"&gt;first.last@example.com&lt;/a&gt;
&lt;/address&gt;
</pre>

                <hr class="bs-docs-separator">

                <h2 id="blockquotes">引用</h2>
                <p>在你的文件中引用其他來源的內容。</p>

                <h3>預設引用</h3>
                <p>將任何
                    <abbr title="HyperText Markup Language">HTML</abbr>
                    包含其中即為引用。直接的引用建議用 <code>&lt;p&gt;</code>。</p>
                <p><span class="label label-info">譯著註</span>：<code>&lt;blockquote&gt;</code> 通常是整段、較長內容的引用。<code>&lt;q&gt;</code> 則是短句的引用。另外，<code>&lt;blockquote&gt;</code> 會以新的段落方式呈現，<code>&lt;q&gt;</code> 則是行內元素，合適在一句話裡帶過。</p>
                <div class="bs-docs-example">
                    <blockquote>
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.</p>
                    </blockquote>
                    <blockquote>
                        <p>少小離家老大回，鄉音無改鬢毛催。兒童相見不相識，笑問客從何處來。</p>
                    </blockquote>
                </div>
<pre class="prettyprint linenums">
&lt;blockquote&gt;
  &lt;p&gt;Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.&lt;/p&gt;
&lt;/blockquote&gt;
</pre>

                <h3>引用選項</h3>
                <p>在標準引用裡，可以很簡單的改變風格和內容。</p>

                <h4>命名來源</h4>
                <p>加入 <code>&lt;small&gt;</code> 標籤來注明引用來源，來源名稱可以放在 <code>&lt;cite&gt;</code> 標籤裡。</p>
                <p><span class="label label-info">譯著註</span>：<code>&lt;q&gt;</code> 使用 cite 屬性。<code>&lt;cite&gt;</code> 標籤的 title 屬性與 <code>&lt;q&gt;</code> 的 cite 屬性可以是來源網址。</p>
                <div class="bs-docs-example">
                    <blockquote>
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.</p>
                        <small>Someone famous in <cite title="Source Title">Source Title</cite></small>
                    </blockquote>
                    <blockquote>
                        <p>少小離家老大回，鄉音無改鬢毛催。兒童相見不相識，笑問客從何處來。</p>
                        <small>回鄉偶書，作者：<cite title="賀知章">賀知章</cite></small>
                    </blockquote>
                </div>
<pre class="prettyprint linenums">
&lt;blockquote&gt;
  &lt;p&gt;Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.&lt;/p&gt;
  &lt;small&gt;Someone famous &lt;cite title="Source Title"&gt;Source Title&lt;/cite&gt;&lt;/small&gt;
&lt;/blockquote&gt;
</pre>

                <h4>替代呈現</h4>
                <p>使用 <code>.pull-right</code> 類別，可以呈現浮動、右邊對齊的引用。</p>
                <div class="bs-docs-example" style="overflow: hidden;">
                    <blockquote class="pull-right">
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.</p>
                        <small>Someone famous in <cite title="Source Title">Source Title</cite></small>
                    </blockquote>
                    <blockquote class="pull-right">
                        <p>少小離家老大回，鄉音無改鬢毛催。兒童相見不相識，笑問客從何處來。</p>
                        <small>回鄉偶書，作者：<cite title="賀知章">賀知章</cite></small>
                    </blockquote>
                </div>
<pre class="prettyprint linenums">
&lt;blockquote class="pull-right"&gt;
  ...
&lt;/blockquote&gt;
</pre>


                <hr class="bs-docs-separator">


                <!-- Lists -->
                <h2 id="lists">清單</h2>

                <h3>無序清單</h3>
                <p>清單中的順序<em>不是</em>明顯重要的。</p>
                <div class="bs-docs-example">
                    <ul>
                        <li>Lorem ipsum dolor sit amet</li>
                        <li>Consectetur adipiscing elit</li>
                        <li>Integer molestie lorem at massa</li>
                        <li>Facilisis in pretium nisl aliquet</li>
                        <li>Nulla volutpat aliquam velit
                <ul>
                    <li>Phasellus iaculis neque</li>
                    <li>Purus sodales ultricies</li>
                    <li>Vestibulum laoreet porttitor sem</li>
                    <li>Ac tristique libero volutpat at</li>
                </ul>
                        </li>
                        <li>Faucibus porta lacus fringilla vel</li>
                        <li>Aenean sit amet erat nunc</li>
                        <li>Eget porttitor lorem</li>
                    </ul>
                </div>
<pre class="prettyprint linenums">
&lt;ul&gt;
  &lt;li&gt;...&lt;/li&gt;
&lt;/ul&gt;
</pre>

                <h3>有序清單</h3>
                <p>清單中的序順<em>是</em>明顯且重要的。</p>
                <div class="bs-docs-example">
                    <ol>
                        <li>Lorem ipsum dolor sit amet</li>
                        <li>Consectetur adipiscing elit</li>
                        <li>Integer molestie lorem at massa</li>
                        <li>Facilisis in pretium nisl aliquet</li>
                        <li>Nulla volutpat aliquam velit</li>
                        <li>Faucibus porta lacus fringilla vel</li>
                        <li>Aenean sit amet erat nunc</li>
                        <li>Eget porttitor lorem</li>
                    </ol>
                </div>
<pre class="prettyprint linenums">
&lt;ol&gt;
  &lt;li&gt;...&lt;/li&gt;
&lt;/ol&gt;
</pre>

                <h3>unstyled 類別</h3>
                <p>移除預設的 <code>list-style</code> 且左邊列出清單項目（只對直接子節點有效）。</p>
                <div class="bs-docs-example">
                    <ul class="unstyled">
                        <li>Lorem ipsum dolor sit amet</li>
                        <li>Consectetur adipiscing elit</li>
                        <li>Integer molestie lorem at massa</li>
                        <li>Facilisis in pretium nisl aliquet</li>
                        <li>Nulla volutpat aliquam velit
              <ul>
                  <li>Phasellus iaculis neque</li>
                  <li>Purus sodales ultricies</li>
                  <li>Vestibulum laoreet porttitor sem</li>
                  <li>Ac tristique libero volutpat at</li>
              </ul>
                        </li>
                        <li>Faucibus porta lacus fringilla vel</li>
                        <li>Aenean sit amet erat nunc</li>
                        <li>Eget porttitor lorem</li>
                    </ul>
                </div>
<pre class="prettyprint linenums">
&lt;ul class="unstyled"&gt;
  &lt;li&gt;...&lt;/li&gt;
&lt;/ul&gt;
</pre>

                <h3>Inline 類別</h3>
                <p>使用 <code>inline-block</code> 讓清單項目成為一列，同時每項都有一些邊距（Padding）。</p>
                <div class="bs-docs-example">
                    <ul class="inline">
                        <li>Lorem ipsum</li>
                        <li>Phasellus iaculis</li>
                        <li>Nulla volutpat</li>
                    </ul>
                </div>
<pre class="prettyprint linenums">
&lt;ul class="inline"&gt;
  &lt;li&gt;...&lt;/li&gt;
&lt;/ul&gt;
</pre>

                <h3>描述</h3>
                <p>一個術語的清單和相關的描述。</p>
                <div class="bs-docs-example">
                    <dl>
                        <dt>Description lists</dt>
                        <dd>A description list is perfect for defining terms.</dd>
                        <dt>Euismod</dt>
                        <dd>Vestibulum id ligula porta felis euismod semper eget lacinia odio sem nec elit.</dd>
                        <dd>Donec id elit non mi porta gravida at eget metus.</dd>
                        <dt>Malesuada porta</dt>
                        <dd>Etiam porta sem malesuada magna mollis euismod.</dd>
                    </dl>
                </div>
<pre class="prettyprint linenums">
&lt;dl&gt;
  &lt;dt&gt;...&lt;/dt&gt;
  &lt;dd&gt;...&lt;/dd&gt;
&lt;/dl&gt;
</pre>

                <h4>水平描述</h4>
                <p>讓 <code>&lt;dl&gt;</code> 中術語與描述以一條條水平方式呈現。</p>
                <div class="bs-docs-example">
                    <dl class="dl-horizontal">
                        <dt>Description lists</dt>
                        <dd>A description list is perfect for defining terms.</dd>
                        <dt>Euismod</dt>
                        <dd>Vestibulum id ligula porta felis euismod semper eget lacinia odio sem nec elit.</dd>
                        <dd>Donec id elit non mi porta gravida at eget metus.</dd>
                        <dt>Malesuada porta</dt>
                        <dd>Etiam porta sem malesuada magna mollis euismod.</dd>
                        <dt>Felis euismod semper eget lacinia</dt>
                        <dd>Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus.</dd>
                    </dl>
                </div>
<pre class="prettyprint linenums">
&lt;dl class="dl-horizontal"&gt;
  &lt;dt&gt;...&lt;/dt&gt;
  &lt;dd&gt;...&lt;/dd&gt;
&lt;/dl&gt;
</pre>
                <p>
                    <span class="label label-info">注意！</span>在 .dl-horizontal 類別透過加入 <code>text-overflow</code> 讓水平描述清單將過長無法在左列中完全呈現的列名截去一部分。而在較窄的可視寬度中，會改變回預設垂直佈局方式。
                </p>
            </section>

            <!-- Code
            ================================================== -->
            <section id="code">
                <div class="page-header">
                    <h1>程式碼</h1>
                </div>

                <h2>行內程式碼</h2>
                <p>在 <code>&lt;code&gt;</code> 標籤內包含一小段程式碼。</p>
                <div class="bs-docs-example">
                    For example, <code>&lt;section&gt;</code> should be wrapped as inline.
                </div>
                <pre class="prettyprint linenums">
For example, &lt;code&gt;&amp;lt;section&amp;gt;&lt;/code&gt; should be wrapped as inline.
</pre>

                <h2>基本區塊</h2>
                <p>使用 <code>&lt;pre&gt;</code> 呈現多行程式碼。為了能正確呈現，請務必將程式碼中的角括號（&lt; 與 &gt;）進行轉義。</p>
                <p><span class="label label-info">譯著註</span>：&lt; 轉義為 &amp;lt;；&gt; 轉義為 &amp;gt;。</p>
                <div class="bs-docs-example">
                    <pre>&lt;p&gt;Sample text here...&lt;/p&gt;</pre>
                </div>
                <pre class="prettyprint linenums" style="margin-bottom: 9px;">
&lt;pre&gt;
  &amp;lt;p&amp;gt;Sample text here...&amp;lt;/p&amp;gt;
&lt;/pre&gt;
</pre>
                <p><span class="label label-info">注意！</span> 因為 <code>&lt;pre&gt;</code> 標籤裡 Tab 會被計算進去，保持程式碼盡可能靠左側（<span class="label label-info">譯著註</span>不進行縮排。）。</p>
                <p>你也選擇加入 <code>.pre-scrollable</code> 類別，它會把該區塊設置為最大高度 350px 且帶有一個滑動的 Y 軸。</p>
            </section>

            <!-- Tables
            ================================================== -->
            <section id="tables">
                <div class="page-header">
                    <h1>表格</h1>
                </div>

                <h2>預設樣式</h2>
                <p>為任何 <code>&lt;table&gt;</code> 增加基本類別 <code>.table</code>，會有少量的邊距（padding）和水平分隔線等基本樣式。</p>
                <div class="bs-docs-example">
                    <table class="table">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>First Name</th>
                                <th>Last Name</th>
                                <th>Username</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>1</td>
                                <td>Mark</td>
                                <td>Otto</td>
                                <td>@@mdo</td>
                            </tr>
                            <tr>
                                <td>2</td>
                                <td>Jacob</td>
                                <td>Thornton</td>
                                <td>@@fat</td>
                            </tr>
                            <tr>
                                <td>3</td>
                                <td>Larry</td>
                                <td>the Bird</td>
                                <td>@@twitter</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
<pre class="prettyprint linenums">
&lt;table class="table"&gt;
  …
&lt;/table&gt;
</pre>

                <hr class="bs-docs-separator">

                <h2>選擇性類別</h2>
                <p>在 <code>.table</code> 基本類別後面可選擇性加入以下類別。</p>

                <h3><code>.table-striped</code></h3>
                <p><code>&lt;tbody&gt;</code> 元素經由 <code>:nth-child</code> CSS 選擇器（IE7-8不支援）為表格加入跟斑馬條紋（zebra-striping）樣式。</p>
                <div class="bs-docs-example">
                    <table class="table table-striped">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>First Name</th>
                                <th>Last Name</th>
                                <th>Username</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>1</td>
                                <td>Mark</td>
                                <td>Otto</td>
                                <td>@@mdo</td>
                            </tr>
                            <tr>
                                <td>2</td>
                                <td>Jacob</td>
                                <td>Thornton</td>
                                <td>@@fat</td>
                            </tr>
                            <tr>
                                <td>3</td>
                                <td>Larry</td>
                                <td>the Bird</td>
                                <td>@@twitter</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
<pre class="prettyprint linenums" style="margin-bottom: 18px;">
&lt;table class="table table-striped"&gt;
  …
&lt;/table&gt;
</pre>

                <h3><code>.table-bordered</code></h3>
                <p>為表格加入邊框與圓角。</p>
                <div class="bs-docs-example">
                    <table class="table table-bordered">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>First Name</th>
                                <th>Last Name</th>
                                <th>Username</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td rowspan="2">1</td>
                                <td>Mark</td>
                                <td>Otto</td>
                                <td>@@mdo</td>
                            </tr>
                            <tr>
                                <td>Mark</td>
                                <td>Otto</td>
                                <td>@@TwBootstrap</td>
                            </tr>
                            <tr>
                                <td>2</td>
                                <td>Jacob</td>
                                <td>Thornton</td>
                                <td>@@fat</td>
                            </tr>
                            <tr>
                                <td>3</td>
                                <td colspan="2">Larry the Bird</td>
                                <td>@@twitter</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
<pre class="prettyprint linenums">
&lt;table class="table table-bordered"&gt;
  …
&lt;/table&gt;
</pre>

                <h3><code>.table-hover</code></h3>
                <p>為 <code>&lt;tbody&gt;</code> 裡的每一行設置滑鼠移至時的樣式。</p>
                <div class="bs-docs-example">
                    <table class="table table-hover">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>First Name</th>
                                <th>Last Name</th>
                                <th>Username</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>1</td>
                                <td>Mark</td>
                                <td>Otto</td>
                                <td>@@mdo</td>
                            </tr>
                            <tr>
                                <td>2</td>
                                <td>Jacob</td>
                                <td>Thornton</td>
                                <td>@@fat</td>
                            </tr>
                            <tr>
                                <td>3</td>
                                <td colspan="2">Larry the Bird</td>
                                <td>@@twitter</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
<pre class="prettyprint linenums" style="margin-bottom: 18px;">
&lt;table class="table table-hover"&gt;
  …
&lt;/table&gt;
</pre>

                <h3><code>.table-condensed</code></h3>
                <p>將表格裡每格（cell）的邊距（padding）減半，讓表格更緊湊。</p>
                <div class="bs-docs-example">
                    <table class="table table-condensed">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>First Name</th>
                                <th>Last Name</th>
                                <th>Username</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>1</td>
                                <td>Mark</td>
                                <td>Otto</td>
                                <td>@@mdo</td>
                            </tr>
                            <tr>
                                <td>2</td>
                                <td>Jacob</td>
                                <td>Thornton</td>
                                <td>@@fat</td>
                            </tr>
                            <tr>
                                <td>3</td>
                                <td colspan="2">Larry the Bird</td>
                                <td>@@twitter</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
<pre class="prettyprint linenums" style="margin-bottom: 18px;">
&lt;table class="table table-condensed"&gt;
  …
&lt;/table&gt;
</pre>

                <hr class="bs-docs-separator">

                <h2>選擇性行（row）類別</h2>
                <p>選擇情境類別，為表格增加顏色。</p>
                <table class="table table-bordered table-striped">
                    <colgroup>
                        <col class="span1">
                        <col class="span7">
                    </colgroup>
                    <thead>
                        <tr>
                            <th>類別</th>
                            <th>說明</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                                <code>.success</code>
                            </td>
                            <td>指示成功或積極的行動。</td>
                        </tr>
                        <tr>
                            <td>
                                <code>.error</code>
                            </td>
                            <td>指示危險或潛在的不利的行動。</td>
                        </tr>
                        <tr>
                            <td>
                                <code>.warning</code>
                            </td>
                            <td>指示可能需要注意的警告。</td>
                        </tr>
                        <tr>
                            <td>
                                <code>.info</code>
                            </td>
                            <td>作為預設樣式的替代樣式。</td>
                        </tr>
                    </tbody>
                </table>
                <div class="bs-docs-example">
                    <table class="table">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Product</th>
                                <th>Payment Taken</th>
                                <th>Status</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr class="success">
                                <td>1</td>
                                <td>TB - Monthly</td>
                                <td>01/04/2012</td>
                                <td>Approved</td>
                            </tr>
                            <tr class="error">
                                <td>2</td>
                                <td>TB - Monthly</td>
                                <td>02/04/2012</td>
                                <td>Declined</td>
                            </tr>
                            <tr class="warning">
                                <td>3</td>
                                <td>TB - Monthly</td>
                                <td>03/04/2012</td>
                                <td>Pending</td>
                            </tr>
                            <tr class="info">
                                <td>4</td>
                                <td>TB - Monthly</td>
                                <td>04/04/2012</td>
                                <td>Call in to confirm</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
<pre class="prettyprint linenums">
...
  &lt;tr class="success"&gt;
    &lt;td&gt;1&lt;/td&gt;
    &lt;td&gt;TB - Monthly&lt;/td&gt;
    &lt;td&gt;01/04/2012&lt;/td&gt;
    &lt;td&gt;Approved&lt;/td&gt;
  &lt;/tr&gt;
...
</pre>

                <hr class="bs-docs-separator">

                <h2>支援的 table 標籤</h2>
                <p>
                    以下列出支援的 table 的 HTML 元素和應該如何使用它。
                </p>
                <table class="table table-bordered table-striped">
                    <colgroup>
                        <col class="span1">
                        <col class="span7">
                    </colgroup>
                    <thead>
                        <tr>
                            <th>標籤</th>
                            <th>說明</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                                <code>&lt;table&gt;</code>
                            </td>
                            <td>包含以表格格式呈現資料的元素。
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <code>&lt;thead&gt;</code>
                            </td>
                            <td>包含表格表頭（<code>&lt;tr&gt;</code>）的容器。<br />
                                <span class="label label-info">譯著註</span>：表頭有以行為表頭與以列為頭表。
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <code>&lt;tbody&gt;</code>
                            </td>
                            <td>包含表格內容（<code>&lt;tr&gt;</code>）的容器。
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <code>&lt;tr&gt;</code>
                            </td>
                            <td>包含表格（cell）內容（<code>&lt;td&gt;</code> 或 <code>&lt;th&gt;</code>）的容器。
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <code>&lt;td&gt;</code>
                            </td>
                            <td>預設的表格（cell）。
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <code>&lt;th&gt;</code>
                            </td>
                            <td>指出每列（或每行，相依於放置的位置）對應的標籤（label）。
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <code>&lt;caption&gt;</code>
                            </td>
                            <td>用於表格的說明或總結，對螢幕閱讀器特別有用。
                            </td>
                        </tr>
                    </tbody>
                </table>
<pre class="prettyprint linenums">
&lt;table&gt;
  &lt;caption&gt;...&lt;/caption&gt;
  &lt;thead&gt;
    &lt;tr&gt;
      &lt;th&gt;...&lt;/th&gt;
      &lt;th&gt;...&lt;/th&gt;
    &lt;/tr&gt;
  &lt;/thead&gt;
  &lt;tbody&gt;
    &lt;tr&gt;
      &lt;td&gt;...&lt;/td&gt;
      &lt;td&gt;...&lt;/td&gt;
    &lt;/tr&gt;
  &lt;/tbody&gt;
&lt;/table&gt;
</pre>
            </section>

            <!-- Forms
            ================================================== -->
            <section id="forms">
                <div class="page-header">
                    <h1>表單</h1>
                </div>

                <h2>預設樣式</h2>
                <p>不需要對 <code>&lt;form&gt;</code> 加入任何類別或大量修改標籤，每個單獨的表單控制項都已經有預設樣式。預設是堆疊且表單控制項的標籤（label）會左邊對齊。</p>
                <form class="bs-docs-example">
                    <fieldset>
                        <legend>Legend</legend>
                        <label>標籤（Label）名稱</label>
                        <input type="text" placeholder="隨意輸入…">
                        <span class="help-block">範例，區塊的輔助說明文字。</span>
                        <label class="checkbox">
                            <input type="checkbox">
                            勾選我
                        </label>
                        <button type="submit" class="btn">送出</button>
                    </fieldset>
                </form>
<pre class="prettyprint linenums">
&lt;form&gt;
  &lt;fieldset&gt;
    &lt;legend&gt;Legend&lt;/legend&gt;
    &lt;label&gt;標籤（Label）名稱&lt;/label&gt;
    &lt;input type="text" placeholder="隨意輸入…"&gt;
    &lt;span class="help-block"&gt;範例，區塊的輔助說明文字。&lt;/span&gt;
    &lt;label class="checkbox"&gt;
      &lt;input type="checkbox"&gt; 勾選我
    &lt;/label&gt;
    &lt;button type="submit" class="btn"&gt;送出&lt;/button&gt;
  &lt;/fieldset&gt;
&lt;/form&gt;
</pre>

                <hr class="bs-docs-separator">

                <h2>選擇性佈局</h2>
                <p>Bootstrap 包含 3 個一般情況選擇性表單佈局。</p>

                <h3>搜尋表單</h3>
                <p>為表單加入 <code>.form-search</code> 類別，並為 <code>&lt;input&gt;</code> 加入 <code>.search-query</code> 類別，可將輸入框呈現為圓角形狀。</p>
                <p><span class="label label-info">譯著註</span>：輸入框指 input 元素 type 屬性為可輸入方面屬性。例如，type="file" 就不是可輸入屬性。</p>
                <form class="bs-docs-example form-search">
                    <input type="text" class="input-medium search-query">
                    <button type="submit" class="btn">搜尋</button>
                </form>
                <pre class="prettyprint linenums">
&lt;form class="form-search"&gt;
  &lt;input type="text" class="input-medium search-query"&gt;
  &lt;button type="submit" class="btn"&gt;搜尋&lt;/button&gt;
&lt;/form&gt;
</pre>

                <h3>行內表單</h3>
                <p>為表單加入 <code>.form-inline</code> 類別，會得到一個緊湊佈局的表單，其中標籤向左對齊、控制項為行內區塊（inline-block）。</p>
                <form class="bs-docs-example form-inline">
                    <input type="text" class="input-small" placeholder="Email">
                    <input type="password" class="input-small" placeholder="密碼">
                    <label class="checkbox">
                        <input type="checkbox">
                        記住我
                    </label>
                    <button type="submit" class="btn">登入</button>
                </form>
<pre class="prettyprint linenums">
&lt;form class="form-inline"&gt;
  &lt;input type="text" class="input-small" placeholder="Email"&gt;
  &lt;input type="password" class="input-small" placeholder="密碼"&gt;
  &lt;label class="checkbox"&gt;
    &lt;input type="checkbox"&gt; 記住我
  &lt;/label&gt;
  &lt;button type="submit" class="btn"&gt;登入&lt;/button&gt;
&lt;/form&gt;
</pre>

                <h3>水平表單</h3>
                <p>右邊對齊標籤（label）和左邊浮動控制項以排列在同一行。這需要對預設表單標記進行一些修改。</p>
                <ul>
                    <li>加入 <code>.form-horizontal</code> 類別到表單。</li>
                    <li>將標籤（label）和控制項包含在 <code>.control-group</code> 類別裡。</li>
                    <li>加入 <code>.control-label</code> 到 label 元素。</li>
                    <li>將任何相關連的控制項包含在 <code>.controls</code> 類別裡，以確保正確的對齊。</li>
                </ul>
                <form class="bs-docs-example form-horizontal">
                    <div class="control-group">
                        <label class="control-label" for="inputEmail">Email</label>
                        <div class="controls">
                            <input type="text" id="inputEmail" placeholder="Email">
                        </div>
                    </div>
                    <div class="control-group">
                        <label class="control-label" for="inputPassword">密碼</label>
                        <div class="controls">
                            <input type="password" id="inputPassword" placeholder="密碼">
                        </div>
                    </div>
                    <div class="control-group">
                        <div class="controls">
                            <label class="checkbox">
                                <input type="checkbox">
                                記住我
                            </label>
                            <button type="submit" class="btn">登入</button>
                        </div>
                    </div>
                </form>
<pre class="prettyprint linenums">
&lt;form class="form-horizontal"&gt;
  &lt;div class="control-group"&gt;
    &lt;label class="control-label" for="inputEmail"&gt;Email&lt;/label&gt;
    &lt;div class="controls"&gt;
      &lt;input type="text" id="inputEmail" placeholder="Email"&gt;
    &lt;/div&gt;
  &lt;/div&gt;
  &lt;div class="control-group"&gt;
    &lt;label class="control-label" for="inputPassword"&gt;密碼&lt;/label&gt;
    &lt;div class="controls"&gt;
      &lt;input type="password" id="inputPassword" placeholder="密碼"&gt;
    &lt;/div&gt;
  &lt;/div&gt;
  &lt;div class="control-group"&gt;
    &lt;div class="controls"&gt;
      &lt;label class="checkbox"&gt;
        &lt;input type="checkbox"&gt; 記住我
      &lt;/label&gt;
      &lt;button type="submit" class="btn"&gt;登入&lt;/button&gt;
    &lt;/div&gt;
  &lt;/div&gt;
&lt;/form&gt;
</pre>

                <hr class="bs-docs-separator">

                <h2>支援的表單控制項</h2>
                <p>在表單佈局範例中包含支援標準表單控制項。</p>

                <h3>Input 元素</h3>
                <p>最常用的表單控制項、文字輸入欄位。包含所有 HTML5 支援型別：text、password、datetime、datetime-local、date、month、time、week、number、email、url、search、tel和color。</p>
                <p>任何時候都需要指定 <code>type</code> 屬性。</p>
                <form class="bs-docs-example form-inline">
                    <input type="text" placeholder="文字輸入">
                </form>
                <pre class="prettyprint linenums">
&lt;input type="text" placeholder="文字輸入"&gt;
</pre>

                <h3>Textarea 元素</h3>
                <p>表單控制項裡支援多行文字輸入元素。根據需求可修改 <code>rows</code> 屬性。</p>
                <form class="bs-docs-example form-inline">
                    <textarea rows="3"></textarea>
                </form>
                <pre class="prettyprint linenums">
&lt;textarea rows="3"&gt;&lt;/textarea&gt;
</pre>

                <h3>Checkboxe 和 radio 元素</h3>
                <p>Checkboxe 是用於一個清單裡選擇一個或多個選項（即複選）。radio 是在許多選項中選擇一個選項（即單選）。</p>
                <h4>預設樣式（堆疊）</h4>
                <form class="bs-docs-example">
                    <label class="checkbox">
                        <input type="checkbox" value="">
                        Option one is this and that&mdash;be sure to include why it's great
                    </label>
                    <br>
                    <label class="radio">
                        <input type="radio" name="optionsRadios" id="optionsRadios1" value="option1" checked>
                        Option one is this and that&mdash;be sure to include why it's great
                    </label>
                    <label class="radio">
                        <input type="radio" name="optionsRadios" id="optionsRadios2" value="option2">
                        Option two can be something else and selecting it will deselect option one
                    </label>
                </form>
<pre class="prettyprint linenums">
&lt;label class="checkbox"&gt;
  &lt;input type="checkbox" value=""&gt;
  Option one is this and that&mdash;be sure to include why it's great
&lt;/label&gt;

&lt;label class="radio"&gt;
  &lt;input type="radio" name="optionsRadios" id="optionsRadios1" value="option1" checked&gt;
  Option one is this and that&mdash;be sure to include why it's great
&lt;/label&gt;
&lt;label class="radio"&gt;
  &lt;input type="radio" name="optionsRadios" id="optionsRadios2" value="option2"&gt;
  Option two can be something else and selecting it will deselect option one
&lt;/label&gt;
</pre>

                <h4>行內 checkboxe 元素</h4>
                <p>
                    為 Checkboxe 元素或 radio 元素加入 <code>.inline</code> 類別，讓它們呈現在同一行。
                </p>
                <form class="bs-docs-example">
                    <label class="checkbox inline">
                        <input type="checkbox" id="inlineCheckbox1" value="option1">
                        1
                    </label>
                    <label class="checkbox inline">
                        <input type="checkbox" id="inlineCheckbox2" value="option2">
                        2
                    </label>
                    <label class="checkbox inline">
                        <input type="checkbox" id="inlineCheckbox3" value="option3">
                        3
                    </label>
                </form>
<pre class="prettyprint linenums">
&lt;label class="checkbox inline"&gt;
  &lt;input type="checkbox" id="inlineCheckbox1" value="option1"&gt; 1
&lt;/label&gt;
&lt;label class="checkbox inline"&gt;
  &lt;input type="checkbox" id="inlineCheckbox2" value="option2"&gt; 2
&lt;/label&gt;
&lt;label class="checkbox inline"&gt;
  &lt;input type="checkbox" id="inlineCheckbox3" value="option3"&gt; 3
&lt;/label&gt;
</pre>

                <h3>Select 元素</h3>
                <p>可使用預設選項或指定 <code>multiple="multiple"</code> 屬性一次呈現多個選項。</p>
                <form class="bs-docs-example">
                    <select>
                        <option>1</option>
                        <option>2</option>
                        <option>3</option>
                        <option>4</option>
                        <option>5</option>
                    </select>
                    <br>
                    <select multiple="multiple">
                        <option>1</option>
                        <option>2</option>
                        <option>3</option>
                        <option>4</option>
                        <option>5</option>
                    </select>
                </form>
<pre class="prettyprint linenums">
&lt;select&gt;
  &lt;option&gt;1&lt;/option&gt;
  &lt;option&gt;2&lt;/option&gt;
  &lt;option&gt;3&lt;/option&gt;
  &lt;option&gt;4&lt;/option&gt;
  &lt;option&gt;5&lt;/option&gt;
&lt;/select&gt;

&lt;select multiple="multiple"&gt;
  &lt;option&gt;1&lt;/option&gt;
  &lt;option&gt;2&lt;/option&gt;
  &lt;option&gt;3&lt;/option&gt;
  &lt;option&gt;4&lt;/option&gt;
  &lt;option&gt;5&lt;/option&gt;
&lt;/select&gt;
</pre>

                <hr class="bs-docs-separator">

                <h2>擴充表單控制項</h2>
                <p>除了現在主流瀏覽器的控制項，Bootstrap 還包含了一些有用的表單元件。</p>

                <h3>前綴和附加 input 元素</h3>
                <p>在任何文字輸入框或按鈕之前或之後加入文字或按鈕。注意，<code>select</code> 元素不支援。</p>

                <h4>預設選項</h4>
                <p>將 <code>.add-on</code> 和 <code>input</code> 配合使用，可以將文字放到輸入框之前或後面。</p>
                <form class="bs-docs-example">
                    <div class="input-prepend">
                        <span class="add-on">@@</span>
                        <input class="span2" id="prependedInput" type="text" placeholder="Username">
                    </div>
                    <br>
                    <div class="input-append">
                        <input class="span2" id="appendedInput" type="text">
                        <span class="add-on">.00</span>
                    </div>
                </form>
<pre class="prettyprint linenums">
&lt;div class="input-prepend"&gt;
  &lt;span class="add-on"&gt;@@&lt;/span&gt;
  &lt;input class="span2" id="prependedInput" type="text" placeholder="Username"&gt;
&lt;/div&gt;
&lt;div class="input-append"&gt;
  &lt;input class="span2" id="appendedInput" type="text"&gt;
  &lt;span class="add-on"&gt;.00&lt;/span&gt;
&lt;/div&gt;
</pre>

                <h4>組合</h4>
                <p>在輸入框前後各使用一個 <code>.add-on</code> 類別的實體。</p>
                <form class="bs-docs-example form-inline">
                    <div class="input-prepend input-append">
                        <span class="add-on">$</span>
                        <input class="span2" id="appendedPrependedInput" type="text">
                        <span class="add-on">.00</span>
                    </div>
                </form>
<pre class="prettyprint linenums">
&lt;div class="input-prepend input-append"&gt;
  &lt;span class="add-on"&gt;$&lt;/span&gt;
  &lt;input class="span2" id="appendedPrependedInput" type="text"&gt;
  &lt;span class="add-on"&gt;.00&lt;/span&gt;
&lt;/div&gt;
</pre>

                <h4>按鈕替代文字</h4>
                <p>替代 <code>&lt;span&gt;</code> 的文字，使用 <code>.btn</code> 來附加一個（或兩個）按鈕到輸入框之前或後面。</p>
                <form class="bs-docs-example">
                    <div class="input-append">
                        <input class="span2" id="appendedInputButton" type="text">
                        <button class="btn" type="button">Go!</button>
                    </div>
                </form>
<pre class="prettyprint linenums">
&lt;div class="input-append"&gt;
  &lt;input class="span2" id="appendedInputButton" type="text"&gt;
  &lt;button class="btn" type="button"&gt;Go!&lt;/button&gt;
&lt;/div&gt;
</pre>
                <form class="bs-docs-example">
                    <div class="input-append">
                        <input class="span2" id="appendedInputButtons" type="text">
                        <button class="btn" type="button">Search</button>
                        <button class="btn" type="button">Options</button>
                    </div>
                </form>
<pre class="prettyprint linenums">
&lt;div class="input-append"&gt;
  &lt;input class="span2" id="appendedInputButtons" type="text"&gt;
  &lt;button class="btn" type="button"&gt;Search&lt;/button&gt;
  &lt;button class="btn" type="button"&gt;Options&lt;/button&gt;
&lt;/div&gt;
</pre>

                <h4>下拉式按鈕</h4>
                <p></p>
                <form class="bs-docs-example">
                    <div class="input-append">
                        <input class="span2" id="appendedDropdownButton" type="text">
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
                    </div>
                    <!-- /input-append -->
                </form>
<pre class="prettyprint linenums">
&lt;div class="input-append"&gt;
  &lt;input class="span2" id="appendedDropdownButton" type="text"&gt;
  &lt;div class="btn-group"&gt;
    &lt;button class="btn dropdown-toggle" data-toggle="dropdown"&gt;
      Action
      &lt;span class="caret"&gt;&lt;/span&gt;
    &lt;/button&gt;
    &lt;ul class="dropdown-menu"&gt;
      ...
    &lt;/ul&gt;
  &lt;/div&gt;
&lt;/div&gt;
</pre>

                <form class="bs-docs-example">
                    <div class="input-prepend">
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
                        <input class="span2" id="prependedDropdownButton" type="text">
                    </div>
                    <!-- /input-prepend -->
                </form>
<pre class="prettyprint linenums">
&lt;div class="input-prepend"&gt;
  &lt;div class="btn-group"&gt;
    &lt;button class="btn dropdown-toggle" data-toggle="dropdown"&gt;
      Action
      &lt;span class="caret"&gt;&lt;/span&gt;
    &lt;/button&gt;
    &lt;ul class="dropdown-menu"&gt;
      ...
    &lt;/ul&gt;
  &lt;/div&gt;
  &lt;input class="span2" id="prependedDropdownButton" type="text"&gt;
&lt;/div&gt;
</pre>

                <form class="bs-docs-example">
                    <div class="input-prepend input-append">
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
                        <input class="span2" id="appendedPrependedDropdownButton" type="text">
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
                    </div>
                    <!-- /input-prepend input-append -->
                </form>
<pre class="prettyprint linenums">
&lt;div class="input-prepend input-append"&gt;
  &lt;div class="btn-group"&gt;
    &lt;button class="btn dropdown-toggle" data-toggle="dropdown"&gt;
      Action
      &lt;span class="caret"&gt;&lt;/span&gt;
    &lt;/button&gt;
    &lt;ul class="dropdown-menu"&gt;
      ...
    &lt;/ul&gt;
  &lt;/div&gt;
  &lt;input class="span2" id="appendedPrependedDropdownButton" type="text"&gt;
  &lt;div class="btn-group"&gt;
    &lt;button class="btn dropdown-toggle" data-toggle="dropdown"&gt;
      Action
      &lt;span class="caret"&gt;&lt;/span&gt;
    &lt;/button&gt;
    &lt;ul class="dropdown-menu"&gt;
      ...
    &lt;/ul&gt;
  &lt;/div&gt;
&lt;/div&gt;
</pre>

                <h4>分段下拉式群組</h4>
                <form class="bs-docs-example">
                    <div class="input-prepend">
                        <div class="btn-group">
                            <button class="btn" tabindex="-1">Action</button>
                            <button class="btn dropdown-toggle" data-toggle="dropdown" tabindex="-1">
                                <span class="caret"></span>
                            </button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                        <input type="text">
                    </div>
                    <div class="input-append">
                        <input type="text">
                        <div class="btn-group">
                            <button class="btn" tabindex="-1">Action</button>
                            <button class="btn dropdown-toggle" data-toggle="dropdown" tabindex="-1">
                                <span class="caret"></span>
                            </button>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li class="divider"></li>
                                <li><a href="#">Separated link</a></li>
                            </ul>
                        </div>
                    </div>
                </form>
<pre class="prettyprint linenums">
&lt;form&gt;
  &lt;div class="input-prepend"&gt;
    &lt;div class="btn-group"&gt;...&lt;/div&gt;
    &lt;input type="text"&gt;
  &lt;/div&gt;
  &lt;div class="input-append"&gt;
    &lt;input type="text"&gt;
    &lt;div class="btn-group"&gt;...&lt;/div&gt;
  &lt;/div&gt;
&lt;/form&gt;
</pre>

                <h4>搜尋表單</h4>
                <form class="bs-docs-example form-search">
                    <div class="input-append">
                        <input type="text" class="span2 search-query">
                        <button type="submit" class="btn">Search</button>
                    </div>
                    <div class="input-prepend">
                        <button type="submit" class="btn">Search</button>
                        <input type="text" class="span2 search-query">
                    </div>
                </form>
<pre class="prettyprint linenums">
&lt;form class="form-search"&gt;
  &lt;div class="input-append"&gt;
    &lt;input type="text" class="span2 search-query"&gt;
    &lt;button type="submit" class="btn"&gt;Search&lt;/button&gt;
  &lt;/div&gt;
  &lt;div class="input-prepend"&gt;
    &lt;button type="submit" class="btn"&gt;Search&lt;/button&gt;
    &lt;input type="text" class="span2 search-query"&gt;
  &lt;/div&gt;
&lt;/form&gt;
</pre>

                <h3>控制項尺寸</h3>
                <p>使用相對尺寸的屬性類別，例如，<code>.input-large</code> 或使用 <code>.span*</code> 類別調整輸入框到網格列的尺寸。</p>

                <h4>區塊 input 元素</h4>
                <p>讓任何 <code>&lt;input&gt;</code> 或 <code>&lt;textarea&gt;</code> 元素呈現為一個區塊元素。</p>
                <form class="bs-docs-example" style="padding-bottom: 15px;">
                    <div class="controls">
                        <input class="input-block-level" type="text" placeholder=".input-block-level">
                    </div>
                </form>
                <pre class="prettyprint linenums">
&lt;input class="input-block-level" type="text" placeholder=".input-block-level"&gt;
</pre>

                <h4>相對尺寸</h4>
                <form class="bs-docs-example" style="padding-bottom: 15px;">
                    <div class="controls docs-input-sizes">
                        <input class="input-mini" type="text" placeholder=".input-mini">
                        <input class="input-small" type="text" placeholder=".input-small">
                        <input class="input-medium" type="text" placeholder=".input-medium">
                        <input class="input-large" type="text" placeholder=".input-large">
                        <input class="input-xlarge" type="text" placeholder=".input-xlarge">
                        <input class="input-xxlarge" type="text" placeholder=".input-xxlarge">
                    </div>
                </form>
<pre class="prettyprint linenums">
&lt;input class="input-mini" type="text" placeholder=".input-mini"&gt;
&lt;input class="input-small" type="text" placeholder=".input-small"&gt;
&lt;input class="input-medium" type="text" placeholder=".input-medium"&gt;
&lt;input class="input-large" type="text" placeholder=".input-large"&gt;
&lt;input class="input-xlarge" type="text" placeholder=".input-xlarge"&gt;
&lt;input class="input-xxlarge" type="text" placeholder=".input-xxlarge"&gt;
</pre>
                <p>
                    <span class="label label-info">注意！</span>在未來版本，我們將會修改這些類別的使用方式，讓它們與按鈕尺寸的呈現方式一樣。例如，<code>.input-large</code> 會加大輸入框的 padding 與 font-size。
                </p>

                <h4>網格尺寸</h4>
                <p>對輸入框使用 <code>.span1</code> 到 <code>.span12</code> 的指定方式，可以將輸入框的尺寸縮放與網格一樣。</p>
                <form class="bs-docs-example" style="padding-bottom: 15px;">
                    <div class="controls docs-input-sizes">
                        <input class="span1" type="text" placeholder=".span1">
                        <input class="span2" type="text" placeholder=".span2">
                        <input class="span3" type="text" placeholder=".span3">
                        <select class="span1">
                            <option>1</option>
                            <option>2</option>
                            <option>3</option>
                            <option>4</option>
                            <option>5</option>
                        </select>
                        <select class="span2">
                            <option>1</option>
                            <option>2</option>
                            <option>3</option>
                            <option>4</option>
                            <option>5</option>
                        </select>
                        <select class="span3">
                            <option>1</option>
                            <option>2</option>
                            <option>3</option>
                            <option>4</option>
                            <option>5</option>
                        </select>
                    </div>
                </form>
<pre class="prettyprint linenums">
&lt;input class="span1" type="text" placeholder=".span1"&gt;
&lt;input class="span2" type="text" placeholder=".span2"&gt;
&lt;input class="span3" type="text" placeholder=".span3"&gt;
&lt;select class="span1"&gt;
  ...
&lt;/select&gt;
&lt;select class="span2"&gt;
  ...
&lt;/select&gt;
&lt;select class="span3"&gt;
  ...
&lt;/select&gt;
</pre>

                <p>每行有多個輸入框的情況，<strong>使用 <code>.controls-row</code> 類別為輸入框增加合適的空間。</strong>透過浮動讓輸入框減少一些空白，設置合適的 margin 並取消浮動。</p>
                <form class="bs-docs-example" style="padding-bottom: 15px;">
                    <div class="controls">
                        <input class="span5" type="text" placeholder=".span5">
                    </div>
                    <div class="controls controls-row">
                        <input class="span4" type="text" placeholder=".span4">
                        <input class="span1" type="text" placeholder=".span1">
                    </div>
                    <div class="controls controls-row">
                        <input class="span3" type="text" placeholder=".span3">
                        <input class="span2" type="text" placeholder=".span2">
                    </div>
                    <div class="controls controls-row">
                        <input class="span2" type="text" placeholder=".span2">
                        <input class="span3" type="text" placeholder=".span3">
                    </div>
                    <div class="controls controls-row">
                        <input class="span1" type="text" placeholder=".span1">
                        <input class="span4" type="text" placeholder=".span4">
                    </div>
                </form>
<pre class="prettyprint linenums">
&lt;div class="controls"&gt;
  &lt;input class="span5" type="text" placeholder=".span5"&gt;
&lt;/div&gt;
&lt;div class="controls controls-row"&gt;
  &lt;input class="span4" type="text" placeholder=".span4"&gt;
  &lt;input class="span1" type="text" placeholder=".span1"&gt;
&lt;/div&gt;
...
</pre>

                <h3>不可編輯輸入框</h3>
                <p>表單中呈現不可編輯的資料，不需要使用實際表單控制項。</p>
                <form class="bs-docs-example">
                    <span class="input-xlarge uneditable-input">一些值…</span>
                </form>
                <pre class="prettyprint linenums">
&lt;span class="input-xlarge uneditable-input"&gt;一些值&lt;/span&gt;
</pre>
                <p><span class="label label-info">譯著註</span>：例如，使用者來源IP資料，會員編號等。</p>

                <h3>表單動作</h3>
                <p>將一組動作（按鈕）放在表單尾部。當它們放在 <code>.form-actions</code> 中時，這些按鈕會自動縮排並和其他表單控制項對齊。</p>
                <form class="bs-docs-example">
                    <div class="form-actions">
                        <button type="submit" class="btn btn-primary">儲存修改</button>
                        <button type="button" class="btn">取消</button>
                    </div>
                </form>
                <pre class="prettyprint linenums">
&lt;div class="form-actions"&gt;
  &lt;button type="submit" class="btn btn-primary"&gt;儲存修改&lt;/button&gt;
  &lt;button type="button" class="btn"&gt;取消&lt;/button&gt;
&lt;/div&gt;
</pre>

                <h3>輔助文字</h3>
                <p>在表單控制項周圍可以放置行內或區塊元素來呈現輔助文字。</p>
                <h4>行內輔助</h4>
                <form class="bs-docs-example form-inline">
                    <input type="text">
                    <span class="help-inline">行內輔助文字</span>
                </form>
                <pre class="prettyprint linenums">
&lt;input type="text"&gt;&lt;span class="help-inline"&gt;行內輔助文字&lt;/span&gt;
</pre>

                <h4>區塊輔助</h4>
                <form class="bs-docs-example form-inline">
                    <input type="text">
                    <span class="help-block">如果輔助文字過長時，可以採用區塊來呈現。</span>
                </form>
                <pre class="prettyprint linenums">
&lt;input type="text"&gt;&lt;span class="help-block"&gt;如果輔助文字過長時，可以採用區塊來呈現。&lt;/span&gt;
</pre>

                <hr class="bs-docs-separator">

                <h2>表單控制項狀態</h2>
                <p>改變表單控制項和標籤的回饋狀態，以提供回饋給使用者或訪客。</p>

                <h3>輸入框焦點</h3>
                <p>我們為一些表單控制項移除預設的 <code>outline</code> 樣式，並對它們的 <code>:focus</code> 虛擬類別設置了 <code>box-shadow</code> 樣式。</p>
                <form class="bs-docs-example form-inline">
                    <input class="input-xlarge focused" id="focusedInput" type="text" value="This is focused...">
                </form>
                <pre class="prettyprint linenums">
&lt;input class="input-xlarge" id="focusedInput" type="text" value="This is focused..."&gt;
</pre>

                <h3>無效輸入框</h3>
                <p>透過 <code>:invalid</code> 引發瀏覽器預設輸入框樣式。如果欄位是必填的，可以指定 <code>type</code> 和 <code>required</code> 屬性，以及指定 <code>pattern</code> 屬性（如果合適的話）。</p>
                <p>由於 Internet Explorer 7-9 不支援 CSS 虛擬類別，因此無法使用。</p>
                <form class="bs-docs-example form-inline">
                    <input class="span3" type="email" placeholder="test@example.com" required>
                </form>
                <pre class="prettyprint linenums">
&lt;input class="span3" type="email" required&gt;
</pre>

                <h3>禁止輸入的輸入框</h3>
                <p>加入 <code>disabled</code> 屬性可以防止使用者輸入並呈現些許不同的外觀。</p>
                <form class="bs-docs-example form-inline">
                    <input class="input-xlarge" id="disabledInput" type="text" placeholder="Disabled input here…" disabled>
                </form>
                <pre class="prettyprint linenums">
&lt;input class="input-xlarge" id="disabledInput" type="text" placeholder="Disabled input here..." disabled&gt;
</pre>

                <h3>驗證狀態</h3>
                <p>Bootstrap 包含了 error、warning、info 和 success 等驗證訊息樣式。為 <code>.control-group</code> 類別加入合適的屬性。</p>

                <form class="bs-docs-example form-horizontal">
                    <div class="control-group warning">
                        <label class="control-label" for="inputWarning">Input with warning</label>
                        <div class="controls">
                            <input type="text" id="inputWarning">
                            <span class="help-inline">Something may have gone wrong</span>
                        </div>
                    </div>
                    <div class="control-group error">
                        <label class="control-label" for="inputError">Input with error</label>
                        <div class="controls">
                            <input type="text" id="inputError">
                            <span class="help-inline">Please correct the error</span>
                        </div>
                    </div>
                    <div class="control-group info">
                        <label class="control-label" for="inputInfo">Input with info</label>
                        <div class="controls">
                            <input type="text" id="inputInfo">
                            <span class="help-inline">Username is taken</span>
                        </div>
                    </div>
                    <div class="control-group success">
                        <label class="control-label" for="inputSuccess">Input with success</label>
                        <div class="controls">
                            <input type="text" id="inputSuccess">
                            <span class="help-inline">Woohoo!</span>
                        </div>
                    </div>
                </form>
<pre class="prettyprint linenums">
&lt;div class="control-group warning"&gt;
  &lt;label class="control-label" for="inputWarning"&gt;Input with warning&lt;/label&gt;
  &lt;div class="controls"&gt;
    &lt;input type="text" id="inputWarning"&gt;
    &lt;span class="help-inline"&gt;Something may have gone wrong&lt;/span&gt;
  &lt;/div&gt;
&lt;/div&gt;

&lt;div class="control-group error"&gt;
  &lt;label class="control-label" for="inputError"&gt;Input with error&lt;/label&gt;
  &lt;div class="controls"&gt;
    &lt;input type="text" id="inputError"&gt;
    &lt;span class="help-inline"&gt;Please correct the error&lt;/span&gt;
  &lt;/div&gt;
&lt;/div&gt;

&lt;div class="control-group info"&gt;
  &lt;label class="control-label" for="inputInfo"&gt;Input with info&lt;/label&gt;
  &lt;div class="controls"&gt;
    &lt;input type="text" id="inputInfo"&gt;
    &lt;span class="help-inline"&gt;Username is already taken&lt;/span&gt;
  &lt;/div&gt;
&lt;/div&gt;

&lt;div class="control-group success"&gt;
  &lt;label class="control-label" for="inputSuccess"&gt;Input with success&lt;/label&gt;
  &lt;div class="controls"&gt;
    &lt;input type="text" id="inputSuccess"&gt;
    &lt;span class="help-inline"&gt;Woohoo!&lt;/span&gt;
  &lt;/div&gt;
&lt;/div&gt;
</pre>
            </section>

            <!-- Buttons
            ================================================== -->
            <section id="buttons">
                <div class="page-header">
                    <h1>按鈕</h1>
                </div>

                <h2>預設按鈕</h2>
                <p>任何設置 <code>.btn</code> 類別的元素都會呈現為按鈕樣式。不管如何，通常只會使用在 <code>&lt;a&gt;</code> 和 <code>&lt;button&gt;</code> 元素，以求有更好的呈現效果。</p>
                <table class="table table-bordered table-striped">
                    <thead>
                        <tr>
                            <th>按鈕</th>
                            <th>class=""</th>
                            <th>說明</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                                <button type="button" class="btn">預設</button></td>
                            <td><code>btn</code></td>
                            <td>標準灰階漸層按鈕</td>
                        </tr>
                        <tr>
                            <td>
                                <button type="button" class="btn btn-primary">主要</button></td>
                            <td><code>btn btn-primary</code></td>
                            <td>提供額外視覺感，可在一系列按鈕中識別出主要動作</td>
                        </tr>
                        <tr>
                            <td>
                                <button type="button" class="btn btn-info">資訊</button></td>
                            <td><code>btn btn-info</code></td>
                            <td>替代預設樣式。</td>
                        </tr>
                        <tr>
                            <td>
                                <button type="button" class="btn btn-success">成功</button></td>
                            <td><code>btn btn-success</code></td>
                            <td>指出成功或肯定的動作</td>
                        </tr>
                        <tr>
                            <td>
                                <button type="button" class="btn btn-warning">警告</button></td>
                            <td><code>btn btn-warning</code></td>
                            <td>指出應該注意或謹慎此動作</td>
                        </tr>
                        <tr>
                            <td>
                                <button type="button" class="btn btn-danger">危險</button></td>
                            <td><code>btn btn-danger</code></td>
                            <td>指出此動作是危險或存在危險</td>
                        </tr>
                        <tr>
                            <td>
                                <button type="button" class="btn btn-inverse">相反</button></td>
                            <td><code>btn btn-inverse</code></td>
                            <td>備用的深灰色按鈕，沒有任何語義或用途</td>
                        </tr>
                        <tr>
                            <td>
                                <button type="button" class="btn btn-link">連結</button></td>
                            <td><code>btn btn-link</code></td>
                            <td>簡化按鈕，讓它看起來看連結，但又保持按鈕的行為</td>
                        </tr>
                    </tbody>
                </table>

                <h4>跨瀏覽器相容性</h4>
                <p>IE9 不支援背景漸層與圓角，所以我們移除了。IE9 jankifies 取消 <code>button</code> 元素，呈現文字為灰色且帶有很令人不快的陰影，我們實在無法修正它。</p>


                <h2>按鈕尺寸</h2>
                <p>想要更大或更小的按鈕？加入 <code>.btn-large</code>、<code>.btn-small</code> 或 <code>.btn-mini</code> 即可改改尺寸。</p>
                <div class="bs-docs-example">
                    <p>
                        <button type="button" class="btn btn-large btn-primary">更大的按鈕</button>
                        <button type="button" class="btn btn-large">更大的按鈕</button>
                    </p>
                    <p>
                        <button type="button" class="btn btn-primary">預設的按鈕</button>
                        <button type="button" class="btn">預設的按鈕</button>
                    </p>
                    <p>
                        <button type="button" class="btn btn-small btn-primary">更小的按鈕</button>
                        <button type="button" class="btn btn-small">更小的按鈕</button>
                    </p>
                    <p>
                        <button type="button" class="btn btn-mini btn-primary">很小的按鈕</button>
                        <button type="button" class="btn btn-mini">很小的按鈕</button>
                    </p>
                </div>
<pre class="prettyprint linenums">
&lt;p&gt;
  &lt;button class="btn btn-large btn-primary" type="button"&gt;更大的按鈕&lt;/button&gt;
  &lt;button class="btn btn-large" type="button"&gt;更大的按鈕&lt;/button&gt;
&lt;/p&gt;
&lt;p&gt;
  &lt;button class="btn btn-primary" type="button"&gt;預設的按鈕&lt;/button&gt;
  &lt;button class="btn" type="button"&gt;預設的按鈕&lt;/button&gt;
&lt;/p&gt;
&lt;p&gt;
  &lt;button class="btn btn-small btn-primary" type="button"&gt;更小的按鈕&lt;/button&gt;
  &lt;button class="btn btn-small" type="button"&gt;更小的按鈕&lt;/button&gt;
&lt;/p&gt;
&lt;p&gt;
  &lt;button class="btn btn-mini btn-primary" type="button"&gt;很小的按鈕&lt;/button&gt;
  &lt;button class="btn btn-mini" type="button"&gt;很小的按鈕&lt;/button&gt;
&lt;/p&gt;
</pre>
                <p>透過設置 <code>.btn-block</code> 類別，能讓按鈕變成區塊元素，同時會填滿整個父元素。</p>
                <div class="bs-docs-example">
                    <div class="well" style="max-width: 400px; margin: 0 auto 10px;">
                        <button type="button" class="btn btn-large btn-block btn-primary">區塊按鈕</button>
                        <button type="button" class="btn btn-large btn-block">區塊按鈕</button>
                    </div>
                </div>
<pre class="prettyprint linenums">
&lt;button class="btn btn-large btn-block btn-primary" type="button"&gt;區塊按鈕&lt;/button&gt;
&lt;button class="btn btn-large btn-block" type="button"&gt;區塊按鈕&lt;/button&gt;
</pre>


                <h2>禁止狀態</h2>
                <p>讓顏色淡出 50%，讓按鈕看起來無法點擊。</p>

                <h3>連結元素</h3>
                <p>加入 <code>.disabled</code> 類別到 <code>&lt;a&gt;</code> 元素。</p>
                <p class="bs-docs-example">
                    <a href="#" class="btn btn-large btn-primary disabled">Primary link</a>
                    <a href="#" class="btn btn-large disabled">Link</a>
                </p>
<pre class="prettyprint linenums">
&lt;a href="#" class="btn btn-large btn-primary disabled"&gt;Primary link&lt;/a&gt;
&lt;a href="#" class="btn btn-large disabled"&gt;Link&lt;/a&gt;
</pre>
                <p>
                    <span class="label label-info">注意！</span> 我們把 <code>.disabled</code> 當成一個工具類別，和常見的 <code>.active</code> 類別一樣，因此不需要添加前綴。另外，此類別只是為了美觀，你必須自行撰寫 JavaScript 來取消連結的行為。
                </p>

                <h3>按鈕元素</h3>
                <p>加入 <code>.disabled</code> 類別到 <code>&lt;button&gt;</code> 元素。</p>
                <p class="bs-docs-example">
                    <button type="button" class="btn btn-large btn-primary disabled" disabled="disabled">Primary button</button>
                    <button type="button" class="btn btn-large" disabled>Button</button>
                </p>
<pre class="prettyprint linenums">
&lt;button type="button" class="btn btn-large btn-primary disabled" disabled="disabled"&gt;Primary button&lt;/button&gt;
&lt;button type="button" class="btn btn-large" disabled&gt;Button&lt;/button&gt;
</pre>

                <h2>一個類別，多個標籤</h2>
                <p>可以為 <code>&lt;a&gt;</code>、<code>&lt;button&gt;</code> 或 <code>&lt;input&gt;</code> 元素加入 <code>.btn</code> 類別。</p>
                <form class="bs-docs-example">
                    <a class="btn" href="">Link</a>
                    <button class="btn" type="submit">Button</button>
                    <input class="btn" type="button" value="Input">
                    <input class="btn" type="submit" value="Submit">
                </form>
                <pre class="prettyprint linenums">
&lt;a class="btn" href=""&gt;Link&lt;/a&gt;
&lt;button class="btn" type="submit"&gt;Button&lt;/button&gt;
&lt;input class="btn" type="button" value="Input"&gt;
&lt;input class="btn" type="submit" value="Submit"&gt;
</pre>
                <p>最佳實作，依據你的整體環境，嘗試找出合適的元素，以確保它們在跨瀏覽器之間的呈現。如果你有一個 <code>input</code> 元素，那麼你的按鈕可以使用 <code>&lt;input type="submit"&gt;</code>。</p>
            </section>

            <!-- Images
            ================================================== -->
            <section id="images">
                <div class="page-header">
                    <h1>圖片</h1>
                </div>

                <p>為 <code>&lt;img&gt;</code> 元素加入對應的類別，可以很容易在任何專案裡設置圖片樣式。</p>
                <div class="bs-docs-example bs-docs-example-images">
                    <img data-src="holder.js/140x140" class="img-rounded">
                    <img data-src="holder.js/140x140" class="img-circle">
                    <img data-src="holder.js/140x140" class="img-polaroid">
                </div>
<pre class="prettyprint linenums">
&lt;img src="..." class="img-rounded"&gt;
&lt;img src="..." class="img-circle"&gt;
&lt;img src="..." class="img-polaroid"&gt;
</pre>
                <p><span class="label label-info">注意！</span> 由於 IE7-8 不支援 <code>border-radius</code>，因此 <code>.img-rounded</code> 和 <code>.img-circle</code> 在 IE7-8 無法使用。</p>
            </section>

            <!-- Icons
            ================================================== -->
            <section id="icons">
                <div class="page-header">
                    <h1>Icons <small>由 <a href="http://glyphicons.com" target="_blank">Glyphicons</a> 提供</small></h1>
                </div>

                <h2>Icon 速記符號表</h2>
                <p>140 張 icon 均提供深灰色（預設）與白色。由 <a href="http://glyphicons.com" target="_blank">Glyphicons</a> 提供。</p>
                <ul class="the-icons clearfix">
                    <li><i class="icon-glass"></i>icon-glass</li>
                    <li><i class="icon-music"></i>icon-music</li>
                    <li><i class="icon-search"></i>icon-search</li>
                    <li><i class="icon-envelope"></i>icon-envelope</li>
                    <li><i class="icon-heart"></i>icon-heart</li>
                    <li><i class="icon-star"></i>icon-star</li>
                    <li><i class="icon-star-empty"></i>icon-star-empty</li>
                    <li><i class="icon-user"></i>icon-user</li>
                    <li><i class="icon-film"></i>icon-film</li>
                    <li><i class="icon-th-large"></i>icon-th-large</li>
                    <li><i class="icon-th"></i>icon-th</li>
                    <li><i class="icon-th-list"></i>icon-th-list</li>
                    <li><i class="icon-ok"></i>icon-ok</li>
                    <li><i class="icon-remove"></i>icon-remove</li>
                    <li><i class="icon-zoom-in"></i>icon-zoom-in</li>
                    <li><i class="icon-zoom-out"></i>icon-zoom-out</li>
                    <li><i class="icon-off"></i>icon-off</li>
                    <li><i class="icon-signal"></i>icon-signal</li>
                    <li><i class="icon-cog"></i>icon-cog</li>
                    <li><i class="icon-trash"></i>icon-trash</li>
                    <li><i class="icon-home"></i>icon-home</li>
                    <li><i class="icon-file"></i>icon-file</li>
                    <li><i class="icon-time"></i>icon-time</li>
                    <li><i class="icon-road"></i>icon-road</li>
                    <li><i class="icon-download-alt"></i>icon-download-alt</li>
                    <li><i class="icon-download"></i>icon-download</li>
                    <li><i class="icon-upload"></i>icon-upload</li>
                    <li><i class="icon-inbox"></i>icon-inbox</li>

                    <li><i class="icon-play-circle"></i>icon-play-circle</li>
                    <li><i class="icon-repeat"></i>icon-repeat</li>
                    <li><i class="icon-refresh"></i>icon-refresh</li>
                    <li><i class="icon-list-alt"></i>icon-list-alt</li>
                    <li><i class="icon-lock"></i>icon-lock</li>
                    <li><i class="icon-flag"></i>icon-flag</li>
                    <li><i class="icon-headphones"></i>icon-headphones</li>
                    <li><i class="icon-volume-off"></i>icon-volume-off</li>
                    <li><i class="icon-volume-down"></i>icon-volume-down</li>
                    <li><i class="icon-volume-up"></i>icon-volume-up</li>
                    <li><i class="icon-qrcode"></i>icon-qrcode</li>
                    <li><i class="icon-barcode"></i>icon-barcode</li>
                    <li><i class="icon-tag"></i>icon-tag</li>
                    <li><i class="icon-tags"></i>icon-tags</li>
                    <li><i class="icon-book"></i>icon-book</li>
                    <li><i class="icon-bookmark"></i>icon-bookmark</li>
                    <li><i class="icon-print"></i>icon-print</li>
                    <li><i class="icon-camera"></i>icon-camera</li>
                    <li><i class="icon-font"></i>icon-font</li>
                    <li><i class="icon-bold"></i>icon-bold</li>
                    <li><i class="icon-italic"></i>icon-italic</li>
                    <li><i class="icon-text-height"></i>icon-text-height</li>
                    <li><i class="icon-text-width"></i>icon-text-width</li>
                    <li><i class="icon-align-left"></i>icon-align-left</li>
                    <li><i class="icon-align-center"></i>icon-align-center</li>
                    <li><i class="icon-align-right"></i>icon-align-right</li>
                    <li><i class="icon-align-justify"></i>icon-align-justify</li>
                    <li><i class="icon-list"></i>icon-list</li>

                    <li><i class="icon-indent-left"></i>icon-indent-left</li>
                    <li><i class="icon-indent-right"></i>icon-indent-right</li>
                    <li><i class="icon-facetime-video"></i>icon-facetime-video</li>
                    <li><i class="icon-picture"></i>icon-picture</li>
                    <li><i class="icon-pencil"></i>icon-pencil</li>
                    <li><i class="icon-map-marker"></i>icon-map-marker</li>
                    <li><i class="icon-adjust"></i>icon-adjust</li>
                    <li><i class="icon-tint"></i>icon-tint</li>
                    <li><i class="icon-edit"></i>icon-edit</li>
                    <li><i class="icon-share"></i>icon-share</li>
                    <li><i class="icon-check"></i>icon-check</li>
                    <li><i class="icon-move"></i>icon-move</li>
                    <li><i class="icon-step-backward"></i>icon-step-backward</li>
                    <li><i class="icon-fast-backward"></i>icon-fast-backward</li>
                    <li><i class="icon-backward"></i>icon-backward</li>
                    <li><i class="icon-play"></i>icon-play</li>
                    <li><i class="icon-pause"></i>icon-pause</li>
                    <li><i class="icon-stop"></i>icon-stop</li>
                    <li><i class="icon-forward"></i>icon-forward</li>
                    <li><i class="icon-fast-forward"></i>icon-fast-forward</li>
                    <li><i class="icon-step-forward"></i>icon-step-forward</li>
                    <li><i class="icon-eject"></i>icon-eject</li>
                    <li><i class="icon-chevron-left"></i>icon-chevron-left</li>
                    <li><i class="icon-chevron-right"></i>icon-chevron-right</li>
                    <li><i class="icon-plus-sign"></i>icon-plus-sign</li>
                    <li><i class="icon-minus-sign"></i>icon-minus-sign</li>
                    <li><i class="icon-remove-sign"></i>icon-remove-sign</li>
                    <li><i class="icon-ok-sign"></i>icon-ok-sign</li>

                    <li><i class="icon-question-sign"></i>icon-question-sign</li>
                    <li><i class="icon-info-sign"></i>icon-info-sign</li>
                    <li><i class="icon-screenshot"></i>icon-screenshot</li>
                    <li><i class="icon-remove-circle"></i>icon-remove-circle</li>
                    <li><i class="icon-ok-circle"></i>icon-ok-circle</li>
                    <li><i class="icon-ban-circle"></i>icon-ban-circle</li>
                    <li><i class="icon-arrow-left"></i>icon-arrow-left</li>
                    <li><i class="icon-arrow-right"></i>icon-arrow-right</li>
                    <li><i class="icon-arrow-up"></i>icon-arrow-up</li>
                    <li><i class="icon-arrow-down"></i>icon-arrow-down</li>
                    <li><i class="icon-share-alt"></i>icon-share-alt</li>
                    <li><i class="icon-resize-full"></i>icon-resize-full</li>
                    <li><i class="icon-resize-small"></i>icon-resize-small</li>
                    <li><i class="icon-plus"></i>icon-plus</li>
                    <li><i class="icon-minus"></i>icon-minus</li>
                    <li><i class="icon-asterisk"></i>icon-asterisk</li>
                    <li><i class="icon-exclamation-sign"></i>icon-exclamation-sign</li>
                    <li><i class="icon-gift"></i>icon-gift</li>
                    <li><i class="icon-leaf"></i>icon-leaf</li>
                    <li><i class="icon-fire"></i>icon-fire</li>
                    <li><i class="icon-eye-open"></i>icon-eye-open</li>
                    <li><i class="icon-eye-close"></i>icon-eye-close</li>
                    <li><i class="icon-warning-sign"></i>icon-warning-sign</li>
                    <li><i class="icon-plane"></i>icon-plane</li>
                    <li><i class="icon-calendar"></i>icon-calendar</li>
                    <li><i class="icon-random"></i>icon-random</li>
                    <li><i class="icon-comment"></i>icon-comment</li>
                    <li><i class="icon-magnet"></i>icon-magnet</li>

                    <li><i class="icon-chevron-up"></i>icon-chevron-up</li>
                    <li><i class="icon-chevron-down"></i>icon-chevron-down</li>
                    <li><i class="icon-retweet"></i>icon-retweet</li>
                    <li><i class="icon-shopping-cart"></i>icon-shopping-cart</li>
                    <li><i class="icon-folder-close"></i>icon-folder-close</li>
                    <li><i class="icon-folder-open"></i>icon-folder-open</li>
                    <li><i class="icon-resize-vertical"></i>icon-resize-vertical</li>
                    <li><i class="icon-resize-horizontal"></i>icon-resize-horizontal</li>
                    <li><i class="icon-hdd"></i>icon-hdd</li>
                    <li><i class="icon-bullhorn"></i>icon-bullhorn</li>
                    <li><i class="icon-bell"></i>icon-bell</li>
                    <li><i class="icon-certificate"></i>icon-certificate</li>
                    <li><i class="icon-thumbs-up"></i>icon-thumbs-up</li>
                    <li><i class="icon-thumbs-down"></i>icon-thumbs-down</li>
                    <li><i class="icon-hand-right"></i>icon-hand-right</li>
                    <li><i class="icon-hand-left"></i>icon-hand-left</li>
                    <li><i class="icon-hand-up"></i>icon-hand-up</li>
                    <li><i class="icon-hand-down"></i>icon-hand-down</li>
                    <li><i class="icon-circle-arrow-right"></i>icon-circle-arrow-right</li>
                    <li><i class="icon-circle-arrow-left"></i>icon-circle-arrow-left</li>
                    <li><i class="icon-circle-arrow-up"></i>icon-circle-arrow-up</li>
                    <li><i class="icon-circle-arrow-down"></i>icon-circle-arrow-down</li>
                    <li><i class="icon-globe"></i>icon-globe</li>
                    <li><i class="icon-wrench"></i>icon-wrench</li>
                    <li><i class="icon-tasks"></i>icon-tasks</li>
                    <li><i class="icon-filter"></i>icon-filter</li>
                    <li><i class="icon-briefcase"></i>icon-briefcase</li>
                    <li><i class="icon-fullscreen"></i>icon-fullscreen</li>
                </ul>

                <h3>Glyphicons 歸屬</h3>
                <p><a href="http://glyphicons.com/">Glyphicons</a> Halflings 一般不是免費的，但經過 Bootstrap 和 Glyphicons 作者之間協調，允許開發人員不需支付任何免費即可使用。作為對作者的感謝，希望你在使用的時候加個 <a href="http://glyphicons.com/">Glyphicons</a> 的連結。</p>

                <hr class="bs-docs-separator">

                <h2>如何使用</h2>
                <p>所有 icon 都需要依賴一個 <code>&lt;i&gt;</code> 標籤和一個唯一的類別，類別前綴為 <code>icon-</code>。使用時，把類似下面的程式碼放置任何需要的地方：</p>
<pre class="prettyprint linenums">
&lt;i class="icon-search"&gt;&lt;/i&gt;
</pre>
                <p>也可以使用相反色（白色）的 icon，需要額外加入一個類別。我們將具體呈現這些類別在巡覽列和下拉式連結時滑鼠移至和活動時的效果。</p>
<pre class="prettyprint linenums">
&lt;i class="icon-search icon-white"&gt;&lt;/i&gt;
</pre>
                <p>
                    <span class="label label-info">注意！</span>當在文字旁使用這些 icon 時，例如，按鈕或巡覽連結，務必在 <code>&lt;i&gt;</code> 標籤後面加入一個空格，這樣才能確保有合適的間距。
                </p>

                <hr class="bs-docs-separator">

                <h2>Icon 範例</h2>
                <p>這些 icon 可以使用在按鈕、工具列的按鈕群組、巡覽列或輸入框的前綴。</p>

                <h4>按鈕</h4>

                <h5>按鈕工具列的按鈕群組</h5>
                <div class="bs-docs-example">
                    <div class="btn-toolbar">
                        <div class="btn-group">
                            <a class="btn" href="#"><i class="icon-align-left"></i></a>
                            <a class="btn" href="#"><i class="icon-align-center"></i></a>
                            <a class="btn" href="#"><i class="icon-align-right"></i></a>
                            <a class="btn" href="#"><i class="icon-align-justify"></i></a>
                        </div>
                    </div>
                </div>
<pre class="prettyprint linenums">
&lt;div class="btn-toolbar"&gt;
  &lt;div class="btn-group"&gt;
    &lt;a class="btn" href="#"&gt;&lt;i class="icon-align-left"&gt;&lt;/i&gt;&lt;/a&gt;
    &lt;a class="btn" href="#"&gt;&lt;i class="icon-align-center"&gt;&lt;/i&gt;&lt;/a&gt;
    &lt;a class="btn" href="#"&gt;&lt;i class="icon-align-right"&gt;&lt;/i&gt;&lt;/a&gt;
    &lt;a class="btn" href="#"&gt;&lt;i class="icon-align-justify"&gt;&lt;/i&gt;&lt;/a&gt;
  &lt;/div&gt;
&lt;/div&gt;
</pre>

                <h5>下拉式按鈕群組</h5>
                <div class="bs-docs-example">
                    <div class="btn-group">
                        <a class="btn btn-primary" href="#"><i class="icon-user icon-white"></i>User</a>
                        <a class="btn btn-primary dropdown-toggle" data-toggle="dropdown" href="#"><span class="caret"></span></a>
                        <ul class="dropdown-menu">
                            <li><a href="#"><i class="icon-pencil"></i>Edit</a></li>
                            <li><a href="#"><i class="icon-trash"></i>Delete</a></li>
                            <li><a href="#"><i class="icon-ban-circle"></i>Ban</a></li>
                            <li class="divider"></li>
                            <li><a href="#"><i class="i"></i>Make admin</a></li>
                        </ul>
                    </div>
                </div>
<pre class="prettyprint linenums">
&lt;div class="btn-group"&gt;
  &lt;a class="btn btn-primary" href="#"&gt;&lt;i class="icon-user icon-white"&gt;&lt;/i&gt; User&lt;/a&gt;
  &lt;a class="btn btn-primary dropdown-toggle" data-toggle="dropdown" href="#"&gt;&lt;span class="caret"&gt;&lt;/span&gt;&lt;/a&gt;
  &lt;ul class="dropdown-menu"&gt;
    &lt;li&gt;&lt;a href="#"&gt;&lt;i class="icon-pencil"&gt;&lt;/i&gt; Edit&lt;/a&gt;&lt;/li&gt;
    &lt;li&gt;&lt;a href="#"&gt;&lt;i class="icon-trash"&gt;&lt;/i&gt; Delete&lt;/a&gt;&lt;/li&gt;
    &lt;li&gt;&lt;a href="#"&gt;&lt;i class="icon-ban-circle"&gt;&lt;/i&gt; Ban&lt;/a&gt;&lt;/li&gt;
    &lt;li class="divider"&gt;&lt;/li&gt;
    &lt;li&gt;&lt;a href="#"&gt;&lt;i class="i"&gt;&lt;/i&gt; Make admin&lt;/a&gt;&lt;/li&gt;
  &lt;/ul&gt;
&lt;/div&gt;
</pre>

                <h5>按鈕尺寸</h5>
                <div class="bs-docs-example">
                    <a class="btn btn-large" href="#"><i class="icon-star"></i>Star</a>
                    <a class="btn btn-small" href="#"><i class="icon-star"></i>Star</a>
                    <a class="btn btn-mini" href="#"><i class="icon-star"></i>Star</a>
                </div>
                <pre class="prettyprint linenums">
&lt;a class="btn btn-large" href="#"&gt;&lt;i class="icon-star"&gt;&lt;/i&gt; Star&lt;/a&gt;
&lt;a class="btn btn-small" href="#"&gt;&lt;i class="icon-star"&gt;&lt;/i&gt; Star&lt;/a&gt;
&lt;a class="btn btn-mini" href="#"&gt;&lt;i class="icon-star"&gt;&lt;/i&gt; Star&lt;/a&gt;
</pre>

                <h4>巡覽列</h4>
                <div class="bs-docs-example">
                    <div class="well" style="padding: 8px 0; margin-bottom: 0;">
                        <ul class="nav nav-list">
                            <li class="active"><a href="#"><i class="icon-home icon-white"></i>Home</a></li>
                            <li><a href="#"><i class="icon-book"></i>Library</a></li>
                            <li><a href="#"><i class="icon-pencil"></i>Applications</a></li>
                            <li><a href="#"><i class="i"></i>Misc</a></li>
                        </ul>
                    </div>
                </div>
<pre class="prettyprint linenums">
&lt;ul class="nav nav-list"&gt;
  &lt;li class="active"&gt;&lt;a href="#"&gt;&lt;i class="icon-home icon-white"&gt;&lt;/i&gt; Home&lt;/a&gt;&lt;/li&gt;
  &lt;li&gt;&lt;a href="#"&gt;&lt;i class="icon-book"&gt;&lt;/i&gt; Library&lt;/a&gt;&lt;/li&gt;
  &lt;li&gt;&lt;a href="#"&gt;&lt;i class="icon-pencil"&gt;&lt;/i&gt; Applications&lt;/a&gt;&lt;/li&gt;
  &lt;li&gt;&lt;a href="#"&gt;&lt;i class="i"&gt;&lt;/i&gt; Misc&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;
</pre>

                <h4>表單欄位</h4>
                <form class="bs-docs-example form-horizontal">
                    <div class="control-group">
                        <label class="control-label" for="inputIcon">Email address</label>
                        <div class="controls">
                            <div class="input-prepend">
                                <span class="add-on"><i class="icon-envelope"></i></span>
                                <input class="span2" id="inputIcon" type="text">
                            </div>
                        </div>
                    </div>
                </form>
<pre class="prettyprint linenums">
&lt;div class="control-group"&gt;
  &lt;label class="control-label" for="inputIcon"&gt;Email address&lt;/label&gt;
  &lt;div class="controls"&gt;
    &lt;div class="input-prepend"&gt;
      &lt;span class="add-on"&gt;&lt;i class="icon-envelope"&gt;&lt;/i&gt;&lt;/span&gt;
      &lt;input class="span2" id="inputIcon" type="text"&gt;
    &lt;/div&gt;
  &lt;/div&gt;
&lt;/div&gt;
</pre>
            </section>
        </div>
    </div>
</div>