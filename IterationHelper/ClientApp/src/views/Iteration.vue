<template>
  <div class="iteration">
    <!-- <div v-if="isLoaded"> -->
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
        {{iterationNumber}}
    </h1>
  <!-- </div> -->
  </div>
</template>

<script lang='ts'>
import { Component, Vue } from 'vue-property-decorator';
import IterationService from '../services/IterationService';

@Component
export default class Iteration extends Vue {
  iterationNumber = 0;

    created() {
      this.getIteration();
      console.log('Iteration Number ', this.iterationNumber);
    }
    getIteration(): void {
        IterationService.getIterationNumber().then(result => {
          this.iterationNumber = result;
        })
    }
}
</script>
