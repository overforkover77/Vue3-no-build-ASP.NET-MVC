@Code
    ViewData("Title") = "Watchers"
End Code

<main aria-labelledby="title">
    <h2 id="title">@ViewData("Title")</h2>
    <h3>@ViewData("Message")</h3>

    <div id="app">

        <h3>Basic Example</h3>
        <p>
            Ask a yes/no question:
            <input v-model="question" :disabled="loading" />
        </p>
        <p>{{ answer }}</p>
        <hr />

    </div>
</main>

@Section scripts

    <script type="module">
        import { createApp } from 'vue'

        const app = createApp({
            data() {
                return {
                    question: '',
                    answer: 'Questions usually contain a question mark. ;)',
                    loading: false
                }
            },
            computed: {
            },
            watch: {
                //whenever question changes, this function will run
                question(newQuestion, oldQuestion) {
                    if (newQuestion.includes('?')) {
                        this.getAnswer()
                    }
                }
            },
            methods: {
                async getAnswer() {
                    this.loading = true
                    this.answer = 'Thinking...'
                    try {
                        const res = await fetch('https://yesno.wtf/api')
                        this.answer = (await res.json()).answer
                    } catch (error) {
                        this.answer = 'Error! Count not reach the API. ' + error
                    } finally {
                        this.loading = false
                    }
                }
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
