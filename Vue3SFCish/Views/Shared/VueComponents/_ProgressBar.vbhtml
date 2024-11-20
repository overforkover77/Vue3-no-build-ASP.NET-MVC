﻿<!-- _ProgressBar.cshtml -->
<script type="text/html" id="progress-bar">
        <div class="progress">
            <div 
                class="progress-bar no-transition bg-warning" 
                role="progressbar" 
                :style="{ width: progressBarWidth }" 
                :aria-valuenow="percent" 
                aria-valuemin="0" 
                aria-valuemax="100">
            </div>
        </div>
</script>

<script>
    const ProgressBar = {
    //Vue.component("progress-bar", {
        template: "#progress-bar",
        props: {
            percent: {
                type: Number,
                default: 0
            }
        },
        computed: {
            progressBarWidth() {
                return this.percent + '%';
                //return `${this.percent}%`
            }
        },
    //});
    };
</script>

<style>
    .no-transition {
        -webkit-transition: none !important;
        -moz-transition: none !important;
        -o-transition: none !important;
        -ms-transition: none !important;
        transition: none !important;
    }
</style>