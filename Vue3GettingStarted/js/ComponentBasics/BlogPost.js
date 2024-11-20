export default {
    props: ['title'],
    emits: ['enlarge-text'],

    data() {
        return {
        }
    },

    template:
    `
    <div class="blog-post"></div>
    <h4>{{title}}</h4>
    <button @click="$emit('enlarge-text')">Enlarge text</button>
    `
}