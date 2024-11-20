@Code
    ViewData("Title") = "Event Handling"
End Code

<main aria-labelledby="title">
    <h2 id="title">@ViewData("Title")</h2>
    <h3>@ViewData("Message")</h3>

    <div id="app">

        <h3>Inline Handlers</h3>
        <p>
            <button @@click="count++">Add 1</button>
            Count is: {{count}}
        </p>

        <h3>Method Handlers</h3>
        <p>
            <button @@click="greet">Greet</button>
        </p>

        <h3>Calling Methods in Inline Handlers</h3>
        <p>
            <button @@click="say('hello')">Say hello</button>
            <button @@click="say('bye')">Say bye</button>
        </p>

        <h3>Accessing Event Argument in Inline Handlers</h3>
        <p>
            <!-- using $ event special variable -->
            <button @@click="warn('Form cannot be submitted yet.', $event)">Submit</button>

            <!-- using inline arrow function -->
            <button @@click="(event) => warn('Form cannot be submitted yet.', event)">Submit</button>
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
                    count: 0,
                    name: 'Vue.js'
                }
            },
            computed: {
            },
            methods: {
                greet(event) {
                    // `this` inside methods poinst to the current active instance.
                    alert(`Hello ${this.name}!`)
                    // `event` is the native DOM event
                    if (event) {
                        alert(event.target.tagName)
                    }
                },
                say(message) {
                    alert(message)
                },
                warn(message, event) {
                    // now we have access to the native event
                    if (event) {
                        event.preventDefault()
                    }
                    alert(message)
                }
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
    </script>

End Section
