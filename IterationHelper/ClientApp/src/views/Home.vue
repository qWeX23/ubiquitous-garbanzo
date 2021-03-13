<template>
    <v-layout row wrap>
        <v-card style="width: 100%;" flat>
            <v-container fill-height class="home">
                <!-- <img alt="Vue logo" src="../assets/logo.png" /> -->
                <!-- <HelloWorld msg="Welcome to Your Vue.js + TypeScript App" /> -->
                <!-- <v-btn
                text="Remember..." /> -->
                <iteration />
                <home-content />

            </v-container>
        </v-card>
    </v-layout>
</template>

<script lang="ts">
    import { Component, Vue } from "vue-property-decorator";
    import HomeContent from '../components/HomeContent.vue';
    import Iteration from '../components/Iteration.vue'

    @Component({
        components: {
            HomeContent,
            Iteration
        }
    })

    export default class Home extends Vue {

    }
</script>
