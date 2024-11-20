@Code
    ViewData("Title") = "Home Page"
End Code

<main>
    <section class="row" aria-labelledby="aspnetTitle">
        <h1 id="title">MVC + Vue3 with SFC-ish files</h1>
        <p class="lead">Attempt to make MVC + Vue work with SFC like files.</p>
        <p><a href="https://dev.to/mducharm/no-transpiler-no-problem-integrating-vue-with-asp-net-razor-pages-5ca3" class="btn btn-primary btn-md">https://dev.to/mducharm/no-transpiler-no-problem-integrating-vue-with-asp-net-razor-pages-5ca3</a></p>
        <p><a href="https://github.com/mducharm/RazorPagesWithVue?tab=readme-ov-file" class="btn btn-primary btn-md">https://github.com/mducharm/RazorPagesWithVue?tab=readme-ov-file</a></p>
    </section>

</main>

<div id="app">
    <coffee-maker></coffee-maker>
</div>

@Section VueComponents {
    @Html.Partial("~/Views/Shared/VueComponents/_ProgressBar.vbhtml")
    @Html.Partial("~/Views/Shared/VueComponents/_CoffeeMaker.vbhtml")
End Section

@Section scripts

    <script type="module">
        import { createApp } from 'vue'

        const app = createApp({

            components: {
                //ButtonCounter,
                CoffeeMaker
            },

            data() {
                return {
                }
            },
            methods: {

            },
            mounted() {
                console.log('app:mounted - start');
                console.log('app:mounted - end');
            }
        })

        app.config.errorHandler = (err) => {
            /* handle error */
            alert(err)
        }

        app.mount('#app')
    </script>

End Section
