@Code
    ViewData("Title") = "Home Page"
End Code

<main>
    <section class="row" aria-labelledby="aspnetTitle">
        <h1 id="title">Vue 3</h1>
        <p class="lead">Attempt to integrate Vue 3 into MVC app based on Vue documentation.</p>
        <p><a href="https://vuejs.org/guide/introduction" class="d-block">https://vuejs.org/guide/introduction</a></p>
    </section>

    @*<div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Getting started</h2>
                <p>
                    ASP.NET MVC gives you a powerful, patterns-based way to build dynamic websites that
                    enables a clean separation of concerns and gives you full control over markup
                    for enjoyable, agile development.
                </p>
                <p><a class="btn btn-outline-dark" href="https://go.microsoft.com/fwlink/?LinkId=301865">Learn more &raquo;</a></p>
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle">Get more libraries</h2>
                <p>NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.</p>
                <p><a class="btn btn-outline-dark" href="https://go.microsoft.com/fwlink/?LinkId=301866">Learn more &raquo;</a></p>
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="hostingTitle">Web Hosting</h2>
                <p>You can easily find a web hosting company that offers the right mix of features and price for your applications.</p>
                <p><a class="btn btn-outline-dark" href="https://go.microsoft.com/fwlink/?LinkId=301867">Learn more &raquo;</a></p>
            </section>
        </div>*@

    <hr />

    <div id="vue-app">


        {{ message }}

        <hr />

        <button @@click="count++">{{ count }}</button>

        <h2>Template Syntax</h2>

        {{rawHtml}}
        <br />
        <span v-html="rawHtml"></span>
        <br />
        <div :id="count"></div>

        <hr />

        <button :disabled="isButtonDisabled">Button</button>

        <hr />

        <div v-bind="objectOfAttrs">object of attributes</div>

        <hr />
        v-if<br />
        <p v-if="seen">Now you see me</p>

        <hr />
        <a :href="url" target="_blank">SDI</a>

        <hr />

        <a @@click="doSomething()">Do something</a>
        <br />
        <a v-on:click="doSomething" href="#">Do something2</a>

        <hr />
        Dynamic Attributes
        <br />
        <a v-bind:['data-url']="url">Dynamic Arguments</a>
        <br />
        <a :['data-url']="url">Dynamic Arguments</a>

        <hr />
        <coffee-maker></coffee-maker>

    </div>

</main>

@Section scripts


    <script type="module">
        import { createApp } from 'vue'

        const app = createApp({

            components: {
            },

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
    </script>

End Section

@*@Section VueComponents {
    @Html.Partial("~/Views/Shared/_CoffeeMaker.vbhtml")
    @Html.Partial("/Views/Shared/_ProgressBar.vbhtml")
End Section*@