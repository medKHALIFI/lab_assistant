﻿function checkStreetviewForLocation(longitude, latitude) { var service = new google.maps.StreetViewService(); service.getPanoramaByLocation(new google.maps.LatLng(latitude, longitude), 50, setStreetviewStatus); }