@Code
    ViewData("Title") = "Reactivity Fundamentals"
End Code

<main aria-labelledby="title">
    <h2 id="title">@ViewData("Title")</h2>
    <h3>@ViewData("Message")</h3>


    <div id="app">

        <span>Count: {{ count }}</span>
        <br />
        <button @@click="increment">Increment</button>
        
        <h3>Deep Reactivity</h3>
        <span>Count: {{ obj.nested.count }}</span>
        <br />
        <div>Count: {{ obj.nested.arr }}</div>
        <button @@click="mutateDeeply">Mutate Deeply</button>

    </div>


</main>

@Section scripts

    <script type="module">
        import { createApp } from 'vue'
        import { nextTick } from 'vue'
        import { debounce } from 'lodash-es'

        const app2 = createApp({
            data() {
                return {
                    count: 0,
                    obj: {
                        nested: { count: 0 },
                        arr: ['foo', 'bar']
                    }
                }
            },
            methods: {
                async increment() {
                    this.count++
                    await nextTick
                    // Now the DOM is updated
                },
                mutateDeeply() {
                    // these will work as expected.
                    this.obj.nested.count++
                    this.obj.arr.push('baz')
                },
                // Debouncing with Lodash
                click: debounce(function () {
                    // ... respond to click ...
                    console.log('responding to click.')
                }, 500)
            },
            created() {
                // each instance now has its own copy of debounced handler
                this.douncedClick = _.debounce(this.click, 500)
            },
            mounted() {
                // methods can be called in lifecycle hooks, or other methods!
                this.increment()
            },
            unmounted() {
                // also a good idea to cancel the timer
                // when the component is removed
                this.debouncedClick.cancel()
            }
        })

        app2.config.errorHandler = (err) => {
            /* handle error */
            alert(err)
        }

        app2.mount('#app')
    </script>

End Section
