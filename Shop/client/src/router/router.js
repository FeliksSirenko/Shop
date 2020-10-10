import Vue from 'vue'
import Router from 'vue-router'
import Home from '@/components/Home'
import Catalog from '@/components/Catalog'
import User from '@/components/User'
import Contacts from '@/components/Contacts'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Home',
      component: Home
    },
    {
      // path: '/user/:id',
      path: '/user',
      name: 'User',
      component: User
    },
    {
      path: '/contacts',
      name: 'Contacts',
      component: Contacts
    },
    {
      path: '/catalog',
      name: 'Catalog',
      component: Catalog,
      // children: [
      //   {
      //     path: 'child',
      //     component: FirstRouteChild
      //   }
      // ]
    }
  ]
})