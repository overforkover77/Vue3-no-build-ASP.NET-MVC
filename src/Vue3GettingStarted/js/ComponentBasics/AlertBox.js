export default {

    data() {
        return {
        }
    },
    template:
    `
    <div class="alert-box" style="border:1px solid red;">
        <strong>This is an Error for Demo Purposes</strong>
        <div>
            <slot />
        </div>
    </div>
    `
}