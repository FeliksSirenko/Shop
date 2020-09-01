<template>
  <div class="catalog">
    <main class="main">
      <div class="container">
        <h1 class="title">{{ title }}</h1> 
        <ul class="product-list">
          <li class="product-item">
            <div class="product-img">
              <a href="">
                <img :src=product[0].photoData.seoLinkF alt="Product">            
              </a>
            </div>
            <div class="product-info">
              <a href="#" class="product-name">{{product[0].markName}}</a>
              <div class="price-holder">
                <span class="price">{{product[0].USD}}</span>
                <span class="price-main">{{product[0].UAH}}</span>
              </div>
              <div class="product-info">
                <ul>
                  <li><i class=""></i><span>{{product[0].autoData.race}}</span></li>
                  <li><i class=""></i><span>{{product[0].locationCityName}}</span></li>
                  <li><i class=""></i><span>{{product[0].autoData.fuelName}}</span></li>
                  <li><i class=""></i><span>{{product[0].autoData.gearboxName}}</span></li>
                </ul>
                <div class="description-block">
                  <span class="description">{{product[0].autoData.description}}</span>
                </div>
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
    product: [{
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
    }], 
    info: null,
    errorMsg: ""
  }),
  mounted() {
    axios
      .get('https://api.coindesk.com/v1/bpi/currentprice.json')
      .then(response => (this.info = response))
      .catch(error => {
        this.errorMsg = error
        this.info = "Error"
      });
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

.product-item {
  display: flex;
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
.product-list {
  text-align: left;
}
</style>
