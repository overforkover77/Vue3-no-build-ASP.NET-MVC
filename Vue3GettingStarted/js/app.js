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

    /* Lifecycle hooks
    All lifecycle hooks are called with their this context pointing to the current active instance invoking it. 
    Note this means you should avoid using arrow functions when declaring lifecycle hooks, 
    as you won't be able to access the component instance via this if you do so.
    https://vuejs.org/guide/essentials/lifecycle.html
    https://vuejs.org/api/options-lifecycle
    */
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
