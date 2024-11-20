@Code
    ViewData("Title") = "Home Page"
End Code

@section Head
    <style>
        .buttonWrap { margin-top: 20px }
    </style>
End Section

<main>
    <section class="row" aria-labelledby="aspnetTitle">
        <h1 id="title">Vue 2</h1>
        <p class="lead">Using 'mix-ins' from Razor views into Vue app set in _Layout</p>
        <p>
            <a href="https://www.giftoasis.com/blog/asp-net-core/vue/using-vue-with-asp-net-razor-can-be-great" class="d-block">https://www.giftoasis.com/blog/asp-net-core/vue/using-vue-with-asp-net-razor-can-be-great</a>
            <a href="https://stackoverflow.com/a/48707179" class="d-block">https://stackoverflow.com/a/48707179</a>
        </p>
    </section>

    <div class="row">
        <h1>Simple Demo</h1>

        Message from vue: <span v-text="appMessage"></span><br />

        <div class="buttonWrap">
            <button type="button" v-if="displayButton1">Button 1</button>
            <button type="button" v-if="displayButton2">Button 2</button>
        </div>

        <div class="buttonWrap">
            Button 1 Visibility: <button type="button" v-on:click="displayButton1=!displayButton1">Toggle 1</button><br />
            Button 2 Visibility: <button type="button" v-on:click="displayButton2=!displayButton2">Toggle 2</button><br />
        </div>

    </div>

</main>


@section Scripts

<script type="text/javascript">
        //Note that these are regular javascript variables not Vue properties 
        //so they are not reactive.
        var pageMixin = {
            data: function () {
                return {
                    //These are reactive.  Changing them will change whether 
                    //the related button is displayed
                    displayButton1: true,
                    displayButton2: false
                };
            },
            methods: {
                //vue methods can be added here
            }
        };

        mixinArray.push(pageMixin);
    </script>

End Section