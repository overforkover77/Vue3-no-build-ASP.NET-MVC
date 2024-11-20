<!-- _CoffeeMaker.cshtml -->
<script type="text/html" id="coffee-maker">
    <div>
        <div class="row">
            <div class="col-sm">
                <img @@click="startMakingCoffee"
                     src="@Url.Content("~/Content/Images/coffee-machine.png")"
                     alt="Coffee Machine"
                     class="coffee-machine">
                <progress-bar :percent="percent"></progress-bar>
            </div>
        </div>
        <img v-for="n in numberOfCoffeesMade"
             :key="n"
             src="@Url.Content("~/Content/Images/coffee.png")"
             alt="Coffee"
             class="coffee">
    </div>
</script>

<script>
    const CoffeeMaker = {
        //app.component("coffee-maker", {
        template: "#coffee-maker",
        components: { ProgressBar },
        data() {
            return {
                percent: 0,
                numberOfCoffeesMade: 0,
                interval: null
            }
        },
        computed: {
            //progressBarWidth() {
            //    return this.ProgressBar.progressBarValue + '%';
            //    //return `${this.progressBarValue}%`
            //}
        },
        methods: {
            startMakingCoffee() {
                console.log('start:startMakingCoffee')

                if (this.interval) {
                    console.log('interval exists, clearInterval')
                    clearInterval(this.interval);
                }

                this.percent = 0;

                this.interval = setInterval(() => {
                    if (this.percent >= 100) {
                        console.log('percent > 100: ' + this.percent)
                        this.numberOfCoffeesMade++;
                        console.log('-- clearInterval')
                        clearInterval(this.interval);
                    } else {
                        console.log('still brewing: ' + this.percent)
                        this.percent += 5;
                    }
                }, 25);

                console.log('end:startMakingCoffee')
            }
        }
        //});
    };
</script>

<style>
    .coffee-machine,
    .progress {
        width: 150px;
    }

    .coffee {
        width: 50px;
    }
</style>