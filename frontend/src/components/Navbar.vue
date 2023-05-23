<!-- eslint-disable vue/multi-word-component-names -->
<template>
  <Nav>
    <div class="menu-item"><a href="#">Home</a></div>
    <Dropdown title="Insumos" :items="insumos" />
    <Dropdown title="Prensas" :items="prensa" />
    <div class="menu-item"><a href="#">Contato</a></div>
  </Nav>

</template>

<script>
import Dropdown from './Dropdown.vue'

export default {
  // eslint-disable-next-line vue/multi-word-component-names
  name: 'navbar',

  components: {
    // eslint-disable-next-line vue/no-unused-components
    Dropdown
  },
  data () {
    return {
      insumos: [
        {
          title: '9mm',
          link: '#'
        },
        {
          title: '.357Mag',
          link: '#'
        },
        {
          title: '7.62x51',
          link: '#'
        }
      ],
      prensa: [
        {
          title: 'Lee',
          link: '#'
        },
        {
          title: 'Dillon',
          link: '#'
        }
      ]
    }
  }
}
</script>

<style>
nav{
  display: flex;
  align-items: center;
  justify-content: center;
}

nav .menu-item{
  color: #FFF;
  padding: 8px 100px;
  position: relative;
  text-align: center;
  border-bottom: 3px solid transparent;
  display: flex;
  transition: 0.4s;
}

nav .menu-item.active, nav .menu-item:hover{
  background-color: #444;
  border-bottom-color: #FF5858;
  border-radius: 0px 0px 16px 16px;
}

nav .menu-item a{
  color: inherit;
  text-decoration: none;

}
</style>
