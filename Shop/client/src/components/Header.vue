<template>
  <div>
    <header class="header">
      <div class="container">
        <ul class="nav-list">
          <li>
            <router-link to="/">Home</router-link>
          </li>
          <li>
            <router-link to="/user">User</router-link>
          </li>
          <li>
            <router-link to="/catalog">Catalog</router-link>
          </li>
          <li>
            <router-link to="/contacts">Contacts</router-link>
          </li>
        </ul>
        </div>      
    </header>
  </div>
</template>

<script>
export default {
  name: 'Header',
}
</script>>
<style scoped>
  .nav-list {
    display: flex;
    flex-wrap: wrap;
    list-style: none;
    font-size: 18px;
    line-height: 20px;
    font-weight: 600;
    padding: 20px 0;
  }
  .nav-list li {
    margin-right: 30px;
  }
  .nav-list a {
    text-decoration: none;
    color:#010101;
    transition: .25s linear;
  }
  .nav-list a:hover {
    color: #256799;
  }
  .nav-list .router-link-exact-active {
    color: #256799;
    cursor: default;
  }
  .container {
    width: 100%;
    max-width: 1300px;
    padding: 0 20px;
    margin: 0 auto;
  }
</style>