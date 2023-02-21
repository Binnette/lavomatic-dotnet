/* global L */

var lav = lav || {};
lav.map = lav.map || {};
(function (lm) {

    var map = L.map("map").setView([45.187778, 5.726945], 13);
    var getDtoLaundriesUrl = "/odata/DtoLaundries";
    var getLaundriesUrl = "/odata/Laundries";

    lm.Init = function() {
        L.tileLayer("http://{s}.tile.osm.org/{z}/{x}/{y}.png",
            {
                attribution: "&copy; <a href='http://osm.org/copyright'>OpenStreetMap</a> contributors"
            })
            .addTo(map);
    };

    var onLaundryClick = function (e) {
        var laundry = e.target.options;
        lav.pnl.showLaundry(laundry);
    };

    var addLaundriesToMap = function(laundries) {
        var count = laundries.length;
        for (var i = 0; i < count; i++) {
            var laundry = laundries[i];
            var options = {
                title: laundry.Na,
                laundryId: laundry.Id,
                laundryNa: laundry.Na,
                laundryHo: laundry.Ho,
                laundryCh: laundry.Ch
        };
            var marker = L.marker([laundry.La, laundry.Lo], options);
            marker.on("click", onLaundryClick);
            marker.addTo(map);
        }
    };

    var parseGetLaundriesJson = function(data) {
        addLaundriesToMap(data.value);
    };

    var getLaundriesFromServer = function (onGetLaundriesComplete) {
        // TODO get Map lat lon
        var params = {};
        $.getJSON(getDtoLaundriesUrl, params, onGetLaundriesComplete);
    };

    lm.Refresh = function () {
        //Get laundries, than add laundries to map
        getLaundriesFromServer(parseGetLaundriesJson);
    }


})(lav.map);

lav.pnl = lav.pnl || {};
(function (lp) {

    lp.showLaundry = function (laundry) {
        laundry.laundryNa = laundry.laundryNa.length > 0 ? laundry.laundryNa : "Laverie sans nom";
        laundry.laundryHo = laundry.laundryHo.length > 0 ? laundry.laundryHo : "Horaires non renseignés";
        $("#laundryName").html(laundry.laundryNa);
        $("#laundryHo").html(laundry.laundryHo);
        var ch = "Non";
        if (laundry.laundryCh === null) {
            ch = "Accès <abbr title='Personnes à Mobilité Réduite'>PMR</abbr> non renseigné";
        } else if (laundry.laundryCh) {
            ch = "Oui";
        }
        $("#laundryCh").html(ch);
        $("#welcome").hide();
        $("#work").show();
        // Todo get more informations

    }

})(lav.pnl);

(function() {
    lav.map.Init();
    lav.map.Refresh();
})();