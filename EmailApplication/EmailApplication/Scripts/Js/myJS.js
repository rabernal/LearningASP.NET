
window.onload = function () {
    alert("olllll");
    var dx = 2, dy = 2, r = 20, x = r, y = r;
    //var canv = document.getElementById("myCanvas");
    var ctx = canvas.getContext("2d");

    function draw() {
        ctx.clearRect(0, 0, ctx.canvas.width, ctx.canvas.height);
        ctx.beginPath();
        ctx.fillStyle = "red";
        ctx.arc(x, y, r, 0, Math.PI * 2, true);
        ctx.closePath();
        ctx.fill();
    }
    //<canvas id="canvas" width="400" height="450"></canvas>

    setInterval(function () { draw(); step(); }, 20);

    function step() {
        if (x > ctx.canvas.width - r || x < r) dx *= -1;
        if (y > ctx.canvas.height - r || y < r) dy *= -1;
        x += dx;
        y += dy;
    }

    
    // this will get the geoloaction
    var geoLocator = this.navigator.geolocation;
    var positionOptions = { enableHighAccuracy: true, timeout: 45000 };
    var watcher = geoLocator.watchPosition(successPosition, errorPosition, positionOptions);
    // the geolocation was pass to the getCurrentPosition method then pass on to the function callbacks. 
    geoLocator.getCurrentPosition(successPosition, errorPosition, positionOptions);
    var mygoogle = document.getElementById("myScript");
    var google = "http://maps.google.com/maps/api/js?sensor=true";
    function successPosition(pos) {
        var userLatlng = new Mygoogle.maps.LatLng(pos.coords.latitude, pos.coords.longitude);
        var options = {
            zoom: 3,
            center: userLatlng,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };
        var userMap = new google.maps.Map(document.getElementById("map"), options);

        new google.maps.Marker({
            map: userMap,
            Position: userLatlng
        });

        var circle = new google.maps.Circle({
            center: userLatlng,
            radius: pos.coords.accuracy,
            map: userMap,
            fillColor: '#ffd200',
            fillOpacity: 0.5,
            strokeColor: '#000000',
            strokeOpacity: 0.7
        });
        mapObject.fitBounds(circle.getBounds());
    }

    //function successPosition(pos) {
    //    var sp = document.createElement("p");
    //    sp.innerText = "Latitude: " + pos.coords.latitude + "Longitude: " + pos.coords.longitude;
    //    document.getElementById("geoResults").appendChild(sp);
    //    geoLocator.clearWatch(watcher);
    //}
    function errorPosition(err) {
        var sp = document.createElement("p");
        sp.innerText = "error: " + err.message; + "code: " + err.code;
        document.getElementById("geoResults").appendChild(sp);
    }
    function changeScreen() {
        document.getElementById("outputing").innerText = this.value;
    }

    document.getElementById("myRange").addEventListener("change", changeScreen);
}

