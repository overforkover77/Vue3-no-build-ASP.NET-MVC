@Code
    ViewData("Title") = "Form Input Bindings"
End Code

<main aria-labelledby="title">
    <h2 id="title">@ViewData("Title")</h2>
    <h3>@ViewData("Message")</h3>

    <div id="app">

        <h3>Basic Usage</h3>
        <p>
            Message is: {{message}}
            <br />
            <input v-model="message" placeholder="edit me" />
        </p>
        <hr />

        <h3>Multiline text</h3>
        <span>Multiline message is:</span>
        <p style="white-space: pre-line;">{{message}}</p>
        <textarea v-model="message" placeholder="add multiple lines"></textarea>
        <hr />

        <h3>Checkbox</h3>
        <p>
            <input type="checkbox" id="checkbox" v-model="checked" />
            <br />
            <label for="checkbox">{{ checked }}</label>
        </p>
        <hr />

        <h3>Multiple Checkboxes</h3>
        <p>
            <div>Checked names: {{ checkedNames }}</div>

            <input type="checkbox" id="jack" value="Jack" v-model="checkedNames" />
            <label for="jack">Jack</label>

            <input type="checkbox" id="john" value="John" v-model="checkedNames" />
            <label for="john">John</label>

            <input type="checkbox" id="mike" value="Mike" v-model="checkedNames" />
            <label for="mike">Mike</label>
        </p>
        <hr />

        <h3>Radio</h3>
        <div>Picked: {{ picked }}</div>
        <p>
            <input type="radio" id="one" value="One" v-model="picked" />
            <label for="one">One</label>

            <input type="radio" id="two" value="Two" v-model="picked" />
            <label for="two">Two</label>
        </p>
        <hr />

        <h3>Single Select</h3>
        <div>Selected: {{ selected }}</div>
        <p>
            <select v-model="selected">
                <option disabled value="">Please select one</option>
                <option>A</option>
                <option>B</option>
                <option>C</option>
            </select>
        </p>
        <hr />

        <h3>Muliple Select (bound to array)</h3>
        <div>Selected: {{ selectedMultiple }}</div>
        <p>
            <select v-model="selectedMultiple" multiple>
                <option disabled value="">Please select one</option>
                <option>A</option>
                <option>B</option>
                <option>C</option>
            </select>
        </p>

        <h3>Select option dynamically rendered</h3>
        <p>
            <select v-model="selectedDynamicRender">
                <option v-for="option in options" :value="option.value">
                    {{ option.text }}
                </option>
            </select>
        </p>
        <div>Selected: {{ selectedDynamicRender }}</div>
        <hr />

        <h3>Value Bindings</h3>
        <p>
            <input type="checkbox" v-model="toggle" true-value="yes" false-value="no" />
        </p>
        <div>Value: {{ toggle }}</div>
        <hr />

        <h3>Value Bindings (Dynamic)</h3>
        <p>
            <input type="checkbox" v-model="toggleDynamic" :true-value="dynamicTrueValue" :false-value="dynamicFalseValue" />
        </p>
        <div>Value: {{ toggleDynamic }}</div>
        <hr />


        <h3>Radio</h3>
        <p>
            <input type="radio" v-model="pick" :value="first" />first
            <br />
            <input type="radio" v-model="pick" :value="second" />second
            <br />
            <div>Value: {{ pick }}</div>
        </p>
        <hr />

        <h3>Select Options</h3>
        <p>
            <select v-model="selectedOption">
                <option :value="{number: 123}">123</option>
            </select>
            <div>Selected (Option): {{ selectedOption }}</div>
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
                    message: "I am the message!",
                    checked: true,
                    checkedNames: [],
                    picked: [],
                    selected: "",
                    selectedMultiple: [],
                    selectedDynamicRender: 'A',
                    options: [
                        { text: 'One', value: 'A' },
                        { text: 'Two', value: 'B' },
                        { text: 'Three', value: 'C' }
                    ],
                    toggle: "",
                    toggleDynamic: "",
                    dynamicTrueValue: "yes yes yes",
                    dynamicFalseValue: "no no no",
                    pick: "",
                    selectedOption: ""
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
