@Code
    ViewData("Title") = "Computed Properties"
End Code

<main aria-labelledby="title">
    <h2 id="title">@ViewData("Title")</h2>
    <h3>@ViewData("Message")</h3>


    <div id="app">

        <h3>Basic Example</h3>
        <p>
            Has published books:
            <br />
            <span>Expression: {{ author.books.length > 0 ? 'Yes' : 'No' }}</span>
            <br />
            <span>Computed: {{ publishedBooksMessage }}</span>
            <br />
            <span># Books: {{ author.books.length }}</span>

        </p>

        <h3>Computed Caching vs Methods</h3>
        <p>CalculatedBooksMessage: {{ calculateBooksMessage() }}</p>
        <p>Now: {{ now }}</p>


        <h3>Writable Computed</h3>
        <p>
            <span>{{firstName}}</span>
            <br />
            <span>{{lastName}}</span>
            <br />
            <span>{{fullName}}</span>
            <br />
            <button @@click="ChangeFullName">Change Full Name</button>
        </p>

    </div>


</main>

@Section scripts

    <script type="module">
        import { createApp } from 'vue'

        const app = createApp({
            data() {
                return {
                    author: {
                        name: 'John Doe',
                        books: [
                            'Vue 2 - Advanced Guide',
                            'Vue 3 - Basic Guide',
                            'Vue 4 - The Mystery'
                        ]
                    },
                    firstName: 'John',
                    lastName: 'Doe'
                }
            },
            computed: {
                // A computed property will only re-evaluate when some of its reactive dependencies have changed.

                // a computed getter
                publishedBooksMessage() {
                    // 'this' points to the component instance.
                    return this.author.books.length > 0 ? 'Yes' : 'No'
                },
                now() {
                    return Date.now()
                },

                // Writable Computed.
                fullName: {
                    // getter
                    get() {
                        return this.firstName + ' ' + this.lastName
                    },
                    // setter
                    set(newValue) {
                        // Note: we are using destructuring assignment syntax here.
                        [this.firstName, this.lastName] = newValue.split(' ')
                    }
                }
            },
            methods: {
                // In comparison, a method invocation will always run the function whenever a re-render happens.
                calculateBooksMessage() {
                    return this.author.books.length > 0 ? 'Yes' : 'No'
                },

                ChangeFullName() {
                    this.fullName = "TestFirst TestLast"
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
