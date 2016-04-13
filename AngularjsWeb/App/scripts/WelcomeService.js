(function(angular) {
    'use strict';

    angular
        .module('app.services.aws')
        .factory('WelcomeService', WelcomeService);

    function WelcomeService($q, $http) {
        var endpoint = "api/Employee/";
        var service = {
            get: get
        };
        return service;


        function get() {
            var deferred = $q.defer();
            $http.get(endpoint + "List").then
            .success(function (response) {
                deferred.resolve(response);
            }).error(function (error) {
                //notify service need to inject here.
                deferred.reject(error);
            });
            return deferred.promise;
        }
    }

})(angular);