@Code
    ViewData("Title") = "Class & Style Bindings"
End Code

<main aria-labelledby="title">
    <h2 id="title">@ViewData("Title")</h2>
    <h3>@ViewData("Message")</h3>


    <div id="app">

        <h3>Binding HTML Classes</h3>
        <p>
            
          <div class="static" :class="{active: isActive, 'text-danger': hasError}">Inline</div>
          <div class="static" :class="classObject">As object</div>
          <div :class="classObjectComputed">Computed Property</div>

        </p>

        <h3>Binding to Arrays</h3>
        <p>
            <div :class="[activeClass, errorClass]">Inline</div>
            <div :class="[isActive ? activeClass : '', errorClass]">Ternary Expression</div>
            <div :class="[{ [activeClass]: isActive}, errorClass]">Object Syntax</div>

        </p>

        <h4>With Components</h4>
        <p>
            TODO:
        </p>

    </div>

        <div id="app2">

        <h3>Binding Inline Styles</h3>
        <h4>Binding to Objects</h4>
        <p>
            <div :style="{ color: activeColor, fontSize: fontSize + 'px'}">Test 1</div>
            <div :style="{ 'font-size': fontSize + 'px'}">kebab-cased</div>
            <div :style="styleObject">Bind to style object directly</div>
        </p>

        <h4>Binding to Arrays</h4>
        <p>
            <div :style="[baseStyles, overridingStyles]">Inline</div>
            <div :style="{ display: ['-webkit-box', '-ms-flexbox', 'flex'] }">Auto-prefixing, Multiple value</div>
        </p>

    </div>


</main>

@Section scripts

    <script type="module">
        import { createApp } from 'vue'

        const app = createApp({
            data() {
                return {
                    isActive: true,
                    hasError: true,
                    classObject: {
                        active: true,
                        'text-danger': true
                    },
                    error: {
                        type: 'fatal'
                    },
                    activeClass: 'active',
                    errorClass: 'text-danger'
                }
            },
            computed: {
                classObjectComputed() {
                    return {
                        active: this.isActive && !this.error,
                        'text-danger': this.error && this.error.type === 'fatal'
                    }
                }
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
                    activeColor: 'red',
                    fontSize: 30,
                    styleObject: {
                        color: 'red',
                        fontSize: '13px'
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

        app2.config.errorHandler = (err) => {
            /* handle error */
            alert(err)
        }

        app2.mount('#app2')
    </script>

End Section
