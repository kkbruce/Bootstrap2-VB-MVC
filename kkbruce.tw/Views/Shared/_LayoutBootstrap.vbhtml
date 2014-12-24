<!DOCTYPE html>
<html lang="zh-tw">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewData("Title") - Bootstrap 2中文教學 - KKBruce</title>
    <meta name="author" content="陳傳興, Bruce">
    <meta name="description" content="@ViewData("Description")">
    <meta name="keywords" content="@ViewData("Keywords")">

    @RenderSection("OtherMeta", required:=false)

    <!-- Bootstrap Style -->
    @Styles.Render("~/Content/bootstrap/css")

    <!-- Use HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
      <script src="~/Scripts/bootstrap/html5shiv.js"></script>
    <![endif]-->
    <link rel="apple-touch-icon-precomposed" sizes="144x144" href="~/Images/bootstrap/ico/apple-touch-icon-144-precomposed.png">
    <link rel="apple-touch-icon-precomposed" sizes="114x114" href="~/Images/bootstrap/ico/apple-touch-icon-114-precomposed.png">
    <link rel="apple-touch-icon-precomposed" sizes="72x72" href="~/Images/bootstrap/ico/apple-touch-icon-72-precomposed.png">
    <link rel="apple-touch-icon-precomposed" href="~/Images/bootstrap/ico/apple-touch-icon-57-precomposed.png">
    <link rel="shortcut icon" href="~/Images/bootstrap/ico/favicon.png">
    <!-- Google 分析 -->
    <script>
        (function (i, s, o, g, r, a, m) {
            i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                (i[r].q = i[r].q || []).push(arguments)
            }, i[r].l = 1 * new Date(); a = s.createElement(o),
            m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
        })(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');

        ga('create', '{your number}', '{your domain');
        ga('send', 'pageview');
    </script>
</head>
<body data-spy="scroll" data-target=".bs-docs-sidebar">

    @RenderSection("navbar", required:=False)
    
    @RenderBody()

    <!-- Footer
    ================================================== -->
    <footer class="footer">
        <div class="container">
            <p>因為有世界大愛由 <a href="http://twitter.com/mdo" target="_blank">@@mdo</a> 和 <a href="http://twitter.com/fat" target="_blank">@@fat</a> 設計與建置，並由<a href="http://kkbruce.tw">陳傳興</a>翻譯。</p>
            <p>程式碼依 <a href="http://www.apache.org/licenses/LICENSE-2.0" target="_blank">Apache License v2.0</a> 授權，英文文件依 <a href="http://creativecommons.org/licenses/by/3.0/">CC BY 3.0</a> 授權發佈。</p>
            <p><a href="http://glyphicons.com">Glyphicons Free</a> 依 <a href="http://creativecommons.org/licenses/by/3.0/">CC BY 3.0</a> 授權使用。</p>
            <ul class="footer-links">
                <li class="muted">&middot;</li>
                <li><a href="http://blog.getbootstrap.com">Blog</a></li>
                <li class="muted">&middot;</li>
                <li><a href="https://github.com/twitter/bootstrap/issues?state=open">Issues</a></li>
                <li class="muted">&middot;</li>
                <li><a href="https://github.com/twitter/bootstrap/blob/master/CHANGELOG.md">Changelog</a></li>
            </ul>
        </div>
    </footer>

    <script src="http://platform.twitter.com/widgets.js" async></script>

    @Scripts.Render("~/bundles/jqueryonline")
    <script>
        if (typeof jQuery == 'undefined') {
            var e = document.createElement('script');
            e.src = '@Url.Content("~/Scripts/jquery-2.0.2.min.js")';
            e.type = 'text/javascript';
            document.getElementsByTagName("head")[0].appendChild(e);
        }
    </script>
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
