@Code
    ViewData("Title") = "List Rendering"
End Code

<main aria-labelledby="title">
    <h2 id="title">@ViewData("Title")</h2>
    <h3>@ViewData("Message")</h3>


    <div id="app">

        <h3>v-for</h3>
        <p>
            <ul>
                <li v-for="item in items">
                    {{item.message}}
                </li>
            </ul>

            <ul>
                <li v-for="(item, index) in items">
                    {{parentMessage}} - {{index}} - {{item.message}}
                </li>
            </ul>

            <h4>With destructuring</h4>
            <ul>
                <li v-for="({message}) in items">
                    {{message}}
                </li>
            </ul>

            <h4>With index alias</h4>
            <ul>
                <li v-for="({message}, index) in items">
                    {{message}} {{index}}
                </li>
            </ul>

            <h4>Nested with scopes</h4>
            <ul>
                <li v-for="item in items">
                    <span v-for="childItem in item.children">
                        {{ item.message }} {{ childItem }}
                    </span>
                </li>
            </ul>

        </p>
        <hr />

        <h3>v-for with an Object</h3>
        <p>
            <ul>
                <li v-for="value in myObject">
                    {{ value }}
                </li>
            </ul>

            <h4>With property key</h4>
            <ul>
                <li v-for="(value, key) in myObject">
                    {{key }}: {{ value }}
                </li>
            </ul>

            <h4>With property key & index</h4>
            <ul>
                <li v-for="(value, key, index) in myObject">
                    {{ index }}: {{ key }}: {{ value }}
                </li>
            </ul>
        </p>

        <h3>v-for with a Range</h3>
        <p>
            <span v-for="n in 10">{{n}}</span>
        </p>

        <h3>v-for with template</h3>
        <p>

            <ul>
                <template v-for="item in items">
                    <li>{{ item.message }}</li>
                    <li class="divider" role="presentation">------------------</li>
                </template>
            </ul>
            
        </p>

        <h3>Maintaining Status with 'key'</h3>
        <p>
            <div v-for="item in items" :key="item.id">
                {{ item.id }} {{ item.message }}
            </div>

            <template v-for="item in items" :key="item.id">
                <li>{{ item.id }} {{ item.message }}</li>
            </template>

        </p>

        <h3>v-for with a Component</h3>
        <p>
            TODO: 
        </p>
        <hr />

    </div>

    <div id="app2">

        <h3>Array Change Direction</h3>
        <p>

            <h4>Displaying Filtered/Sorted Results</h4>
            <ul>
                <li v-for="n in evenNumbers">{{ n }}</li>
            </ul>

            <h4>Via method</h4>
            <ul v-for="numbers in sets">
                <li v-for="n in even(numbers)">{{ n }}</li>
            </ul>

        </p>

    </div>

</main>

@Section scripts

    <script type="module">
        import { createApp } from 'vue'

        const app = createApp({
            data() {
                return {
                    parentMessage: 'Parent',
                    items: [
                        { id: 1, message: 'Foo' },
                        { id: 2, message: 'Bar' }
                    ],
                    myObject: {
                        title: 'How to do lists in Vue',
                        author: 'John Doe',
                        publishedAt: '2016-04-10'
                    }
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

    <script type="module">
        import { createApp } from 'vue'

        const app2 = createApp({
            data() {
                return {
                    numbers: [1, 2, 3, 4, 5],
                    sets: [[1, 2, 3, 4, 5], [6, 7, 8, 9, 10]]
                }
            },
            computed: {
                evenNumbers() {
                    return this.numbers.filter(n => n % 2 === 0)
                }
            },
            methods: {
                even(numbersToFilter) {
                    return numbersToFilter.filter(number => number % 2 === 0)
                }
            },
            created() {
            },
            mounted() {
            },
            unmounted() {
            }
        })

        app2.config.errorHandler = (err) => {
            /* handle error */
            alert(err)
        }

        app2.mount('#app2')
    </script>

End Section
