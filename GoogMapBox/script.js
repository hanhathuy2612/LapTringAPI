mapboxgl.accessToken = 'pk.eyJ1IjoiaGFuaGF0aHV5MjYxMiIsImEiOiJja21lbGtkNmIweHR2MnJuOG04azZheXJvIn0.QxGRYVzd9lullcRe8T2W4w';
navigator.geolocation.getCurrentPosition(successLocation, errorLocation, { enableHighAccuracy: true });

function successLocation(position) {
    console.log(position);
    setUpMap([position.coords.longitude, position.coords.latitude]);
}

function errorLocation() {
    setUpMap([-2.24, 53.48])
}

function setUpMap(center) {
    const map = new mapboxgl.Map({
        container: 'map',
        style: 'mapbox://styles/mapbox/streets-v11',
        center: center,
        zoom: 15
    });
    const nav = new mapboxgl.NavigationControl();
    map.addControl(nav);


    map.addControl(
        new MapboxDirections({
            accessToken: mapboxgl.accessToken
        }),
        'top-left'
    );
}