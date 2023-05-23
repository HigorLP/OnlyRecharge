<template>
  <div id="app">
    <header>
      <Navbar />
    </header>
  </div>
  <router-view/>
</template>

<script>
import Navbar from './components/Navbar.vue'
export default {
  name: 'app',
  components: {
    Navbar
  }
}
</script>

<style>
*{
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

body{
  font-family: 'Poppins', sans-serif;
}

header{
  width: 100vw;
  background-color: #222;
  padding: 15px;
}
</style>
