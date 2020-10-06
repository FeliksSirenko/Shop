<template>
   <li class="product-item" > 
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
</template>

<script>

export default {
  props: {
    product: {
      type: Object,
      required: true
    }
  }
}
</script>>

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
