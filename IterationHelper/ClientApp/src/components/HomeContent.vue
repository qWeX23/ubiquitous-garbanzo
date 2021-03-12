<template>
    <v-row justify="center" class="pa-6">
    <v-dialog
        v-model="dialog"
        width="750"
    >
        <template v-slot:activator="{ on, attrs }">
                <v-btn
                    color="error"
                    v-bind="attrs"
                    v-on="on"
                    >
                    Remember...
                </v-btn>
        </template>
            <v-card style="width: 100%;" flat>
                <v-container>
                    <v-img 
                        lazy-src="../assets/monkee_meme.jpg"
                        src="../assets/monkee_meme.jpg"
                        class="test"
                    >
                    </v-img>
                </v-container>
            </v-card>
  </v-dialog>
    </v-row>
</template>

<script lang='ts'>
    import {Component, Vue} from "vue-property-decorator";

    @Component
    export default class HomeContent extends Vue {

    }

</script>

<style>
    /* .test {
        height: auto;
        width : 100%;
    } */
</style>