(function () {
    "use strict";

    angular.module("app").factory("tokenContainer", [tokenContainer]);

    function tokenContainer() {

        var container = {
            token: ""
        };

        var setToken = function (token) {
            container.token = token;
        };
        var service = {
            getToken: getToken
        };

        return service;


        function getToken() {
            if (container.token === "") {
                if (localStorage.getItem("access_token") === null) {
                    var url = "https://localhost:44300/identity/connect/authorize?" +
                        "client_id=tripgalleryimplicit&" +
                        "redirect_uri=" + encodeURI(window.location.protocol + "//" + window.location.host + "/callback.html") + "&" +
                        "response_type=token&" +
                        "scope=gallerymanagement";

                    // redirect to the STS
                    window.location = url;

                } else {
                    setToken(localStorage["access_token"]);
                }

            };

            // return value to call when calling the API 
            //return {
            //    getToken: getToken
            //};

            return container;
        };


    }
})(angular);