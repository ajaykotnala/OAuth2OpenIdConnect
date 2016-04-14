(function (angular) {
    'use strict';

    angular
        .module('app')
        .factory('WelcomeService', WelcomeService);

    function WelcomeService($q, $http) {
        var endpoint = "http://localhost:53120/";
        var service = {
            get: get
        };
        return service;


        function get() {
            var deferred = $q.defer();
            $http.get(endpoint + "consumer")
           .success(function (response) {
               deferred.resolve(response);
           }).error(function (error) {
               //notify service need to inject here.
               deferred.reject(error);
           });
            return deferred.promise;
            //$http.get(endpoint + "consumer").then
            //.success(function (response) {
            //    deferred.resolve(response);
            //}).error(function (error) {
            //    //notify service need to inject here.
            //    deferred.reject(error);
            //});
            //return deferred.promise;
        }
    }

})(angular);