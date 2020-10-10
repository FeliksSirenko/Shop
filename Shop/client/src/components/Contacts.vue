<template>
  <div class="map">
    Map  
  </div>
</template>

<script>
import MarkerClusterer from '@google/markerclusterer';
import gmapsInit from '../utils/gmaps';
import Locations from '../utils/location.js'

const mcOptions = {
  styles: [{
      height: 53,
      url: "http://localhost:8080/img/marker.04de65b7.svg",
      width: 53
    },
    {
      height: 56,
      url: "https://developers.google.com/maps/documentation/javascript/examples/markerclusterer/m2.png",
      width: 56
    },
    {
      height: 66,
      url: "https://developers.google.com/maps/documentation/javascript/examples/markerclusterer/m3.png",
      width: 66
    },
    {
      height: 78,
      url: "https://developers.google.com/maps/documentation/javascript/examples/markerclusterer/m4.png",
      width: 78
    },
    {
      height: 90,
      url: "https://developers.google.com/maps/documentation/javascript/examples/markerclusterer/m5.png",
      width: 90
    }
  ]
}

export default {
  name: 'Map',
  data: () => ({
    locations: Locations
  }),
  async mounted() {
    try {
      const google = await gmapsInit();
      const geocoder = new google.maps.Geocoder();
      const map = new google.maps.Map(this.$el);
      geocoder.geocode({ address: `Austria` }, (results, status) => {
        if (status !== `OK` || !results[0]) {
          throw new Error(status);
        }
        map.setCenter(results[0].geometry.location);
        map.fitBounds(results[0].geometry.viewport);
      });
      const markerClickHandler = (marker) => {
        map.setZoom(13);
        map.setCenter(marker.getPosition());
      };
      const markers = this.locations
        .map((location) => {
          const marker = new google.maps.Marker({ ...location, map });
          marker.addListener(`click`, () => markerClickHandler(marker));
          return marker;
        });
      // eslint-disable-next-line no-new
      new MarkerClusterer(map, markers,  mcOptions );
    } catch (error) {
      // eslint-disable-next-line no-console
      console.error(error);
    }
  },
};
</script>


<style scoped>
.map {
  width: 500px;
  height: 500px;
  border: 2px solid darkblue;
  margin: auto;
}
</style>
