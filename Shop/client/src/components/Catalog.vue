<template>
  <div class="catalog">
    <main class="main">
      <div class="container">
        <h1 class="title">{{ title }}</h1> 
        <ul class="product-list">
          <li class="product-item" v-for="(product, index) in products" :key="index">
            <div class="product-img">
              <a href="">
                <img :src=product.photoData.seoLinkF alt="Product">            
              </a>
            </div>
            <div class="product-info-holder">
              <a href="#" class="product-name">{{product.markName}}</a> 
              <div class="product-lacation">
                <i class="ic-marker"></i>
                <span>{{product.locationCityName}}</span>
              </div>             
              <div class="product-info">
                <ul>
                  <li><span>{{product.autoData.race}}</span></li>
                  <li><span>{{product.autoData.fuelName}}</span></li>
                  <li><span>{{product.autoData.gearboxName}}</span></li>
                  <li><span>{{product.autoData.year}}</span></li>
                </ul>
                <div class="description-block">
                  <span class="description">{{product.autoData.description}}</span>
                </div>
              </div>
              <div class="price-holder">
                <span class="price">{{product.USD}}$</span>
                <span class="price-main">{{product.UAH}} грн</span>
              </div> 
              <div class="btn-holder">
                <div class="btn btn-default">Перезвонить</div>
              </div>                           
            </div>
          </li>         
        </ul>
      </div> 
      <div>{{ info }}</div>
      <div>{{errorMsg}}</div>
    </main>  
  </div>
</template>

<script>
import Vue from 'vue'
import axios from 'axios'
import VueAxios from 'vue-axios'

Vue.use(VueAxios, axios)
export default {
  name: 'Catalog',
  props: {
    title: String
  },
  data: () => ({
    products: [{
      locationCityName: "Днепропетровск",                                                   // Город
      auctionPossible: false,                                                               // Торг 
      addDate: "2017-04-24 23:02:06",                                                       // Дата и время добавления 
      updateDate: "2017-04-24 23:02:06",                                                    // Дата и время обновления 
      expireDate: "2017-07-24 23:02:06",                                                    // Дата и время истечения
      USD: 33500,                                                                           // Стоимость в доларах США
      UAH: 880380,                                                                          // Стоимость в гривнах
      levelData: {
        level: 10,                                                                          // Уровень топа
        label: 3,                                                                           // Метка
        hotType: "срочно",                                                                  // Метка "TOP" или "Срочно"
        expireDate: "2017-05-04 23:02:07"                                                   // Дата и время истечения метки "тор" "Срочно"
      },
      autoData: {                                                                           // Характеристики машины
        description: "Итак. Пришло время в срочном порядке продать свой любимый автомобиль. " +"\r\nПокупал его в августе 2013 года. \r\nПолностью обслужен на о",                  // Описание
        version: "",
        year: 2013,                                                                         // Год выпуска
        autoId: 19050985,                                                                   // id объявления
        statusId: 0,                                                                        //  - 
        withVideo: false,                                                                   // Наличие видео                               
        race: "60 тыс. км",                                                                 // Пробег
        raceInt: 60,                                                                        // - 
        fuelName: "Дизель",                                                                 // Тип топлива
        gearboxName: "Автомат",                                                             // Тип привода
        isSold: false,                                                                      // Этот параметр показывает или машына продана или нет
        categoryId: 1,                                                                      // Тип транспорта                                                                         
      },
      markName: "Volvo",                                                                    // Марка автомобиля
      markId: 85,                                                                           // id марки автомобиля
      modelName: "XC90",                                                                    // Модель автомобиля
      modelId: 824,                                                                         // id Модели автомобиля
      photoData: {                                                                          // Фотографии
        count: 15,                                                                          // Количество фотографий
        seoLinkM: "https://cdn.riastatic.com/photosnew/auto/photo/volvo_xc90__181949196m.jpg",
        seoLinkSX: "https://cdn.riastatic.com/photosnew/auto/photo/volvo_xc90__181949196sx.jpg",
        seoLinkB: "https://cdn.riastatic.com/photosnew/auto/photo/volvo_xc90__181949196b.jpg",
        seoLinkF: "https://cdn.riastatic.com/photosnew/auto/photo/volvo_xc90__181949196f.jpg"
      },
      linkToView: "/auto_volvo_xc90_19050985.html",                                         // Линк на объявление
      title: "Volvo XC90",                                                                  // Название
      stateData: {                                     
        name: "Днепропетровск",                                                             // Город
        regionName: "Днепропетровская",                                                     // Область
        linkToCatalog: "/city/dnepropetrovsk/",
        stateId: 11                                                                         // id Города
      },  
    } ,{
      locationCityName: "Харьков",                                                   // Город
      auctionPossible: false,                                                               // Торг 
      addDate: "2017-04-24 23:02:06",                                                       // Дата и время добавления 
      updateDate: "2017-04-24 23:02:06",                                                    // Дата и время обновления 
      expireDate: "2017-07-24 23:02:06",                                                    // Дата и время истечения
      USD: 33500,                                                                           // Стоимость в доларах США
      UAH: 880380,                                                                          // Стоимость в гривнах
      levelData: {
        level: 10,                                                                          // Уровень топа
        label: 3,                                                                           // Метка
        hotType: "срочно",                                                                  // Метка "TOP" или "Срочно"
        expireDate: "2017-05-04 23:02:07"                                                   // Дата и время истечения метки "тор" "Срочно"
      },
      autoData: {                                                                           // Характеристики машины
        description: "Итак. Пришло время в срочном порядке продать свой любимый автомобиль.", // Описание
        version: "",
        year: 2019,                                                                         // Год выпуска
        autoId: 19050985,                                                                   // id объявления
        statusId: 0,                                                                        //  - 
        withVideo: false,                                                                   // Наличие видео                               
        race: "10 тыс. км",                                                                 // Пробег
        raceInt: 10,                                                                        // - 
        fuelName: "Дизтопливо 2.0 л",                                                                 // Тип топлива
        gearboxName: "Механическая",                                                             // Тип привода
        isSold: false,                                                                      // Этот параметр показывает или машына продана или нет
        categoryId: 1,                                                                      // Тип транспорта                                                                         
      },
      markName: "Ford Ranger 2019",                                                                    // Марка автомобиля
      markId: 85,                                                                           // id марки автомобиля
      modelName: "XC90",                                                                    // Модель автомобиля
      modelId: 824,                                                                         // id Модели автомобиля
      photoData: {                                                                          // Фотографии
        count: 15,                                                                          // Количество фотографий
        seoLinkM: "https://cdn.riastatic.com/photosnew/auto/photo/volvo_xc90__181949196m.jpg",
        seoLinkSX: "https://cdn.riastatic.com/photosnew/auto/photo/volvo_xc90__181949196sx.jpg",
        seoLinkB: "https://cdn.riastatic.com/photosnew/auto/photo/volvo_xc90__181949196b.jpg",
        seoLinkF: "https://cdn.riastatic.com/photosnew/auto/photo/volvo_xc90__181949196f.jpg"
      },
      linkToView: "/auto_volvo_xc90_19050985.html",                                         // Линк на объявление
      title: "Volvo XC90",                                                                  // Название
      stateData: {                                     
        name: "Днепропетровск",                                                             // Город
        regionName: "Днепропетровская",                                                     // Область
        linkToCatalog: "/city/dnepropetrovsk/",
        stateId: 11                                                                         // id Города
      },  
    }], 
    info: null,
    errorMsg: "",
    loading: true,
  }),
  mounted() {
    axios
      .get('https://api.coindesk.com/v1/bpi/currentprice.json')
      .then(response => (this.info = response))
      .catch(error => console.log(error)).finally(() => (this.loading = false));
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

.product-item {
  display: flex;
  padding-bottom: 20px;
}
.product-item:not(:last-of-type) {
  border-bottom: 4px solid #f0f2fa;
  margin-bottom: 20px;
}
.product-img {
  width: 300px;
  margin-right:20px;
  display: inline-flex;
}
img {
  display: block;
  width: auto;
  max-width: 100%;
  max-height: 100%;
}
.product-info-holder {
  width: calc(100% - 320px);
}
.product-list {
  text-align: left;
}
.product-name {
  font-size: 20px;
  margin: 0 0 10px;
  color: #256799;
  text-decoration: none;
  display: inline-flex;
  border-bottom: 1px solid transparent;
  text-decoration-skip-ink: none;
  transition: border-bottom-color .2s;
}
.product-name:hover {
  text-decoration: none;
  border-bottom-color: #256799;
}
.price-holder {
  font-size: 18px;
  margin-bottom: 10px;
  line-height: 20px;
}
.price {
  display: inline-flex;
  margin-right: 20px;
  font-size: 16px;
  line-height: 20px;
  color: #666;
}
.product-info ul {
  display: flex;
  flex-wrap: wrap; 
  padding: 0;
  margin: 0;
}
.product-info li {
  width: 50%;
  padding: 0 10px 10px 16px;
  max-width: 300px;
  list-style: none;
  display: flex;
  position: relative;
}
.product-info {
  max-width: 500px;
}
.product-info li:before {
  content: "";
  position: absolute;
  left: 0;
  background: #256799;
  width: 6px;
  height: 6px;
  top: 6px;
}
.description-block {
  margin: 10px 0;
}
.product-lacation {
  margin: 0 0 10px;
  padding: 0;
  display: flex;
  align-items: center;
  line-height: 18px;
}

</style>
