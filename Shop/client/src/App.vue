<template>
  <div id="app">
    <!-- <img alt="Vue logo" src="./assets/logo.png"> -->
    <Catalog title="Catalog page"/>
  </div>
</template>

<script>
import Catalog from './components/Catalog.vue'

export default {
  name: 'App',
  components: {
    Catalog
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
  margin-top: 60px;
}
.container {
  width: 1200px;
  max-width: 100%;
  padding: 0 20px;
  margin: 0 auto;
}
.title {
  text-align: center;
  margin: 20px 0 40px;
}
</style>
