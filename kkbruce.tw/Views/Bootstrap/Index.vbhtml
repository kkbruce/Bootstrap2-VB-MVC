@Code
    ViewData("Title") = "首頁"
    ViewData("Description") = "Bootstrap 是一簡潔，直覺，強大的前端框架，讓網頁開發更快速更簡單。提供基礎已設計CSS類別、12列的網格系統、快速佈局、嚮應式設計、豐富重覆使用的元件、快速Data屬性與JavaScript設置。由陳傳興(Bruce)進行正體中文化翻譯。"
    ViewData("Keywords") = "Bootstrap, 中文教學, 中文文件, 中文手冊, 嚮應式CSS, 網格系統, 元件, JavaScript外掛, 佈局"
End Code

@section navbar
    @Html.Partial("_NavBar")
End Section

<div class="jumbotron masthead">
    <div class="container">
        <h1>Bootstrap</h1>
        <p>簡潔，直覺，強大的前端框架，讓網頁開發更快速更簡單。</p>
        <p>
            @Html.ActionLink("下載 Bootstrap", "Customize", Nothing, Nothing, Nothing, "download", Nothing, New With {.class = "btn btn-primary btn-larg"})
        </p>
        <ul class="masthead-links">
            <li>
                <a href="http://github.com/twitter/bootstrap">GitHub專案</a>
            </li>
            <li>
                @Html.ActionLink("範例", "GettingStarted", Nothing, Nothing, Nothing, "examples", Nothing, Nothing)
            </li>
            <li>
                @Html.ActionLink("延伸", "Extend")
            </li>
            <li>
                Version 2.3.2
            </li>
        </ul>
    </div>
</div>

<div class="bs-docs-social">
    <div class="container">
        <ul class="bs-docs-social-buttons">
            <li>
              <iframe class="github-btn" src="http://ghbtns.com/github-btn.html?user=twitter&repo=bootstrap&type=watch&count=true" allowtransparency="true" frameborder="0" scrolling="0" width="100px" height="20px"></iframe>
            </li>
            <li>
              <iframe class="github-btn" src="http://ghbtns.com/github-btn.html?user=twitter&repo=bootstrap&type=fork&count=true" allowtransparency="true" frameborder="0" scrolling="0" width="102px" height="20px"></iframe>
            </li>
            <li class="follow-btn">
              <a href="https://twitter.com/twbootstrap" class="twitter-follow-button" data-link-color="#0069D6" data-show-count="true">Follow @@twbootstrap</a>
            </li>
            <li class="tweet-btn">
              <a href="https://twitter.com/share" class="twitter-share-button" data-url="http://twitter.github.com/bootstrap/" data-count="horizontal" data-via="twbootstrap" data-related="mdo:Creator of Twitter Bootstrap">Tweet</a>
            </li>
        </ul>
    </div>
</div>

<div class="container">

    <div class="marketing">

        <h1>介紹 Bootstrap。</h1>
        <p class="marketing-byline">需要為愛上Bootstrap找理由？就在眼前。</p>

        <div class="row-fluid">
            <div class="span4">
                <img class="marketing-img" src="~/Images/bootstrap/bs-docs-twitter-github.png" alt="Twitter與Github圖示">
                <h2>人人為我，我為人人。</h2>
                <p>由 <a href="http://twitter.com/mdo">@@mdo</a> 和 <a href="http://twitter.com/fat">@@fat</a> 在Twitter時建立，Bootstrap 使用 <a href="http://lesscss.org">LESS CSS</a> 並用 <a href="http://nodejs.org">Node</a> 編輯，托管於 <a href="http://github.com">GitHub</a> 以方便大家使用與建構更的網頁應用。</p>
            </div>
            <div class="span4">
                <img class="marketing-img" src="~/Images/bootstrap/bs-docs-responsive-illustrations.png" alt="嚮應式展示圖">
                <h2>任何人都可以使用。</h2>
                <p>Bootstrap不是只有好看，它在目前主流桌面瀏覽器上有極佳的表現（包含IE7！）。在平板電腦與智慧型手機瀏覽器經由 @Html.ActionLink("嚮應式CSS", "Scaffolding", Nothing, Nothing, Nothing, "responsive", Nothing, Nothing) 一樣不錯。</p>
            </div>
            <div class="span4">
                <img class="marketing-img" src="~/Images/bootstrap/bs-docs-bootstrap-features.png" alt="網格系統圖示">
                <h2>豐富的特色。</h2>
                <p>12列嚮應式 @Html.ActionLink("網格", "Scaffolding", Nothing, Nothing, Nothing, "gridSystem", Nothing, Nothing)、豐富的元件、@Html.ActionLink("JavaScript外掛", "JavaScript")、佈局、表單控制項、還有 @Html.ActionLink("基於網頁客製化", "Customize")工具。</p>
            </div>
        </div>

        <hr class="soften">

        <h1>基於Bootstrap建立的網站。</h1>
        <p class="marketing-byline">更多基於Bootstrap建立的網站，請 <a href="http://builtwithbootstrap.tumblr.com/" target="_blank">瀏覽非官方Tumblr</a> 或 @Html.ActionLink("瀏覽以下範例", "GettingStarted", Nothing, Nothing, Nothing, "examples", Nothing, Nothing)。</p>
        <div class="row-fluid">
            <ul class="thumbnails example-sites">
                <li class="span3">
                    <a class="thumbnail" href="http://soundready.fm/" target="_blank">
                        <img src="~/Images/bootstrap/example-sites/soundready.png" alt="SoundReady.fm">
                    </a>
                </li>
                <li class="span3">
                    <a class="thumbnail" href="http://kippt.com/" target="_blank">
                        <img src="~/Images/bootstrap/example-sites/kippt.png" alt="Kippt">
                    </a>
                </li>
                <li class="span3">
                    <a class="thumbnail" href="http://www.gathercontent.com/" target="_blank">
                        <img src="~/Images/bootstrap/example-sites/gathercontent.png" alt="Gather Content">
                    </a>
                </li>
                <li class="span3">
                    <a class="thumbnail" href="http://www.jshint.com/" target="_blank">
                        <img src="~/Images/bootstrap/example-sites/jshint.png" alt="JS Hint">
                    </a>
                </li>
            </ul>
        </div>
    </div>
</div>