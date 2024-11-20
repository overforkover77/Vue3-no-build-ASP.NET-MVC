<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
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
                    <li>@Html.ActionLink("Reactivity", "Reactivity", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    <li>@Html.ActionLink("Computed Properties", "ComputedProperties", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    <li>@Html.ActionLink("Conditional Rendering", "ConditionalRendering", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    <li>@Html.ActionLink("List Rendering", "ListRendering", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    <li>@Html.ActionLink("Form Input Bindings", "FormInputBindings", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    <li>@Html.ActionLink("Lifecycle Hooks", "LifecycleHooks", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    <li>@Html.ActionLink("Watchers", "Watchers", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    <li>@Html.ActionLink("ComponentBasics", "Component Basics", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    @*<li>@Html.ActionLink("Contact", "Contact", "Home", New With {.area = ""}, New With {.class = "nav-link"})</li>*@
                </ul>
            </div>
        </div>
    </nav>
    <div class="container body-content">
        <div id="xxxvue-app">
            @RenderBody()
        </div>
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
        </footer>
    </div>

    <script src="https://unpkg.com/vue@3/dist/vue.global.js"></script>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")

    <script type="importmap">
        {
          "imports": {
            "vue": "https://unpkg.com/vue@3/dist/vue.esm-browser.js"
          }
        }
    </script>

    @*@RenderSection("VueComponents", required:=False)*@

    @RenderSection("scripts", required:=False)



    @*<script type="module">
            import { createApp } from 'vue'

            const app = createApp({
                data() {
                    return {
                        count: 0,
                        rawHtml: '<span style="color: red;">This should be red.</span>',
                        isButtonDisabled: true,
                        objectOfAttrs: {
                            id: 'container',
                            class: 'wrapper',
                            style: 'background-color:green; color:white;',
                            title: 'this is a title'
                        },
                        seen: true,
                        url: "https://sdiinnovations.com",
                        doSomething() { alert('doSomthing() called'); }
                    }
                },
                methods: {
                    increment() {
                        this.count++
                    }
                },
                mounted() {
                    console.log('event:mounted - start');

                    console.log(this.count);
                    this.count = 2

                    // methods can be called in lifecycle hooks, or other methods!
                    this.increment()

                    console.log('event:mounted - end');
                }
            })

            app.config.errorHandler = (err) => {
                /* handle error */
                alert(err)
            }

            app.mount('#vue-app')
        </script>*@




    @*<script type="module">
        import { createApp } from 'vue'

        const app = createApp({
            data() {
                return {
                }
            },
            computed: {
            },
            methods: {
            },
            created() {
            },
            mounted() {
            },
            unmounted() {
            }
        })

        app.config.errorHandler = (err) => {
            /* handle error */
            alert(err)
        }

        app.mount('#app')
    </script>*@

</body>
</html>
