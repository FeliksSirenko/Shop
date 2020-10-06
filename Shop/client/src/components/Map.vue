<template>
  <div class="map">
      Map
  </div>
</template>

<script>
import MarkerClusterer from '@google/markerclusterer';
import gmapsInit from '../utils/gmaps';
import Locations from '../utils/location.js'

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
      new MarkerClusterer(map, markers, {
        imagePath: `https://developers.google.com/maps/documentation/javascript/examples/markerclusterer/m`,
      });
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
