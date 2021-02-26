<template>
  <div class="iteration">
    <!-- <h1>What iteration is it?  This one dumbass {{thing}}</h1> -->
    <h1>
        <span style="color: blue">W</span>
        <span style="color: red">h</span>
        <span style="color: brown">A</span>
        <span style="color: green">t</span>
        <span style="color: yellow"> I</span>
        <span style="color: black">t</span>
        <span style="color: blue">e</span>
        <span style="color: purple">r</span>
        <span style="color: green">a</span>
        <span style="color: grey">t</span>
        <span style="color: blue">i</span>
        <span style="color: black">o</span>
        <span style="color: green">n</span>
        <span style="color: purple"> I</span>
        <span style="color: pink">s</span>
        <span style="color: red"> I</span>
        <span style="color: black">t</span>
        <span style="color: blue">?</span>
        {{thing}}
    </h1>
  </div>
</template>

<script lang="ts">
import { Vue } from "vue-property-decorator";

export default class Iteration extends Vue {
    private thing: number = (Math.floor(Math.random() * 200) + 1);
}
</script>

<p>
  <span style='color: blue'>G</span>
  <span style='color: red'>o</span>
  <span style='color: yellow'>o</span>
  <span style='color: blue'>g</span>
  <span style='color: green'>l</span>
  <span style='color: red'>e</span>
</p>