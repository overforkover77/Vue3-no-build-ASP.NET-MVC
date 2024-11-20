@Code
    ViewData("Title") = "Component Basics"
End Code

<main aria-labelledby="title">
    <h2 id="title">@ViewData("Title")</h2>
    <h3>@ViewData("Message")</h3>

    <div id="app">

        <h3>Using a Component</h3>
        <button-counter></button-counter>
        <button-counter></button-counter>
        <hr />

        <h3>Passing Props</h3>
        <div :style="{fontSize: postFontSize + 'em'}">
            <blog-post v-for="post in posts" :key="post.id" :title="post.title" @@enlarge-text="postFontSize += 0.1"></blog-post>
        </div>
        <hr />

        <h3>Slots</h3>
        <p>
            <alert-box>
                Something bad happened.
            </alert-box>
        </p>
        <hr />
    </div>
</main>

@Section scripts

    <script type="module">
        import { createApp } from 'vue'
        import AlertBox from '@Url.Content("~/js/ComponentBasics/AlertBox.js")'
        import BlogPost from '@Url.Content("~/js/ComponentBasics/BlogPost.js")'
        import ButtonCounter from '@Url.Content("~/js/ComponentBasics/ButtonCounter.js")'

        const app = createApp({
            data() {
                return {
                    posts: [
                        {id: 1, title: 'My journey with Vue'},
                        {id: 2, title: 'Blogging with Vue'},
                        {id: 3, title: 'Why Vue is so fun'}
                    ],
                    postFontSize: 1
                }
            },

            components: {
                AlertBox,
                BlogPost,
                ButtonCounter
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
