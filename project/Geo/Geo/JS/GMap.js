﻿function initialize() {
	geocoder = new google.maps.Geocoder();
	var latlng = new google.maps.LatLng(0, 0);
	var mapOptions = {
		zoom: 1,
		center: latlng,
		mapTypeId: google.maps.MapTypeId.ROADMAP
	};
	map = new google.maps.Map(document.getElementById("map"), mapOptions);
}

function codeAddress() {
	var address = document.getElementById("address").value;
	geocoder.geocode({ 'address': address }, function (results, status) {
		if (status == google.maps.GeocoderStatus.OK) {
			map.setCenter(results[0].geometry.location);
			var marker = new google.maps.Marker({
				map: map,
				position: results[0].geometry.location
			});
		} else {
			alert("Geocode was not successful for the following reason: " + status);
		}
	});
}