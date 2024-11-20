@Code
    ViewData("Title") = "Lifecycle Hooks"
End Code

<main aria-labelledby="title">
    <h2 id="title">@ViewData("Title")</h2>
    <h3>@ViewData("Message")</h3>

    <div id="app">

        <h3>???</h3>
        <p>
        </p>
        <hr />

    </div>
</main>

@Section scripts

    <script type="module">
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
                console.log(`the component is now created.`)
            },
            mounted() {
                console.log(`the component is now mounted.`)
            },
            updated() {
                console.log(`the component is updated.`)
            },
            unmounted() {
                console.log(`the component is now unmounted.`)
            }
        })

        app.config.errorHandler = (err) => {
            /* handle error */
            alert(err)
        }

        app.mount('#app')
    </script>

End Section
