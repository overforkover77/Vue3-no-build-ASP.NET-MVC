<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    @RenderSection("Head", required:=False)
</head>
<body>
    <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark">
        <div class="container">
            @Html.ActionLink("Application name", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            <button type="button" class="navbar-toggler" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" title="Toggle navigation" aria-controls="navbarSupportedContent"
                    aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse d-sm-inline-flex justify-content-between">
                <ul class="navbar-nav flex-grow-1">
                    <li>@Html.ActionLink("Home", "Index", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    <li>@Html.ActionLink("About", "About", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    <li>@Html.ActionLink("Contact", "Contact", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                </ul>
            </div>
        </div>
    </nav>
    <div id="vueAppTemplate" class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
        </footer>
    </div>



    @*<script src="https://unpkg.com/vue@3/dist/vue.global.js" asp-fallback-src="/js/vendor/vue-2.5.16.min.js" crossorigin="anonymous"></script>*@
    <script src="https://unpkg.com/vue@2.5.16/dist/vue.min.js" asp-fallback-src="/js/vendor/vue-2.5.16.min.js" crossorigin="anonymous"></script>
    <script src="~/js/site.js" asp-append-version="true"></script>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)

    @*https://www.giftoasis.com/blog/asp-net-core/vue/using-vue-with-asp-net-razor-can-be-great*@
    @*https://stackoverflow.com/a/48707179*@
    <script type="text/javascript">
        var app = new Vue({
            el: '#vueAppTemplate',
            mixins: mixinArray,    //defined in site.js
            data: {
                appMessage: 'Hello World',
                errorMessage: '',
                //add more data properties here
            },
            methods: {
                //add methods here
            }
        });
    </script>


</body>
</html>
