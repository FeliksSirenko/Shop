<template>
  <div id="app">
    <Header title="Header"/> 
    <router-view></router-view>
  </div>
</template>

<script>
import Header from './components/Header.vue'

export default {
  name: 'App',
  components: {
    Header,
    // Catalog,
    // Map
  },
}
</script>

<style>
*,
*:before,
*:after {
  box-sizing: border-box;
}
body {
  min-width: 320px;
  width: 100%;
  margin: 0;
  padding: 0;
  font-size: 14px;
  line-height: 1.4;
  color: #000;
}
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #2c3e50;
  margin-top: 60px;
}
.container {
  width: 1100px;
  max-width: 100%;
  padding: 0 20px;
  margin: 0 auto;
}
.title {
  text-align: center;
  margin: 20px 0 40px;
}
.ic-marker {
  display: inline-flex;
  width: 18px;
  height: 18px;
  background: url(./assets/marker.svg);
  margin-right: 10px;
}
.btn {
  width: 100%;
  line-height: 16px;
  white-space: nowrap;
  cursor: pointer;
  display: inline-flex;
  border-radius: 5px;
  font-weight: 400;
  -webkit-appearance: none;
  align-items: center;
  justify-content: center;
  transition: all .2s linear;
  width: auto;
  padding: 10px 20px;
}
.btn-default {
  font-size: 18px;
  border-color: #79be00;
  background-color: #79be00;
  color: #ffffff;
}
</style>
