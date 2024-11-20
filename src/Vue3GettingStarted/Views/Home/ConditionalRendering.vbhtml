@Code
    ViewData("Title") = "Conditional Rendering"
End Code

<main aria-labelledby="title">
    <h2 id="title">@ViewData("Title")</h2>
    <h3>@ViewData("Message")</h3>


    <div id="app">

        <h3>v-if</h3>
        <p>
            <h1 v-if="awesome">Vue is awesome!</h1>
        </p>
        <hr />

        <h3>v-else</h3>
        <p>
            <button @@click="awesome = !awesome">Toggle</button>
            <h1 v-if="awesome">Vue is awesome!</h1>
            <h1 v-else>Oh no 😢</h1>
        </p>
        <hr />

        <h3>v-else-if</h3>
        <p>
            <button @@click="type = 'A'">A</button>
            <button @@click="type = 'B'">B</button>
            <button @@click="type = 'C'">C</button>
            <button @@click="type = '???'">???</button>

            <div v-if="type==='A'">A</div>
            <div v-else-if="type==='B'">B</div>
            <div v-else-if="type==='C'">C</div>
            <div v-else>Not A/B/C</div>

        </p>
        <hr />

        <h3>v-if on &lt;template&gt;</h3>
        <p>
            The final rendered result will not include the &lt;template&gt; element.

            <template v-if="ok">
                <h1>Title</h1>
                <p>Paragraph 1</p>
                <p>Paragraph 2</p>
            </template>
        </p>
        <hr />

        <h3>v-show</h3>
        <p>
            The difference is that an element with v-show will always be rendered and remain in the DOM; v-show only toggles the display CSS property of the element.
           <h1 v-show="ok">Hello!</h1>
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
                    awesome: true,
                    type: 'A',
                    ok: true
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
    </script>

End Section
