function initialize() {
	geocoder = new google.maps.Geocoder();
	var latlng = new google.maps.LatLng(0, 0);
	var mapOptions = {
		zoom: 2,
		center: latlng,
		mapTypeId: google.maps.MapTypeId.ROADMAP
	};
	map = new google.maps.Map(document.getElementById("map"), mapOptions);
}

function codeAddress() 
{
	var address = document.getElementById("address").value;
	geocoder.geocode({ 'address': address }, function (results, status) {
		if (status == google.maps.GeocoderStatus.OK) {
			map.setCenter(results[0].geometry.location);
			var marker = new google.maps.Marker({
				map: map,
				position: results[0].geometry.location
			});
		} else {
			//alert("Geocode was not successful for the following reason: " + status);
		}
	});
}
function setMarkerByAdres(address) {
	geocoder.geocode({ 'address': address }, function (results, status) {
		if (status == google.maps.GeocoderStatus.OK) {
			map.setCenter(results[0].geometry.location);
			var marker = new google.maps.Marker({
				map: map,
				position: results[0].geometry.location
			});
		} else {
			//alert("Geocode was not successful for the following reason: " + status);
		}
	});
}
function multiCodeAddress() 
{
	showLoader();
	alert("This can take several minutes");
	var adresses = document.getElementById("adressesValue").value;
	var adressList = adresses.split(',');
	for (var i = 0; i < adressList.length; i++) 
	{
		var temapdress = adressList[i];
		setMarkerByAdres(temapdress);
		sleep(300);
	}
	hideLoader(); 
}
function sleep(milliseconds) {
	var start = new Date().getTime();
	for (var i = 0; i < 1e7; i++) {
		if ((new Date().getTime() - start) > milliseconds) {
			break;
		}
	}
}

function initLoader() {
	if (!spinner) {
		spinner = new Spinner({ length: 5, width: 3, radius: 7 }).spin(document.getElementById('_loader'));
	}
}
function showLoader() {
	initLoader();
	var loader = document.getElementById('_loader');
	loader.style.top = document.body.scrollTop + 100;
	loader.style.left = getWindowWidth() / 2;
	loader.style.display = '';
}
function hideLoader() {
	var loader = document.getElementById('_loader');
	loader.style.display = 'none';
	loader.style.left = getWindowWidth() + 1000;
}

function getWindowWidth() {
	return document.compatMode == 'CSS1Compat' && !window.opera ? document.documentElement.clientWidth : document.body.clientWidth;
}