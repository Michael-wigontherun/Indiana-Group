// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
var map;
var lat;
var lng;

lat = 47.16559;
lng = -123.02193;

function initMap() {
    map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: lat, lng: lng },
        zoom: 12
    });
}
// Write your JavaScript code.
