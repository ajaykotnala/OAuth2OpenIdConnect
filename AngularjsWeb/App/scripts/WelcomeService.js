(function (angular) {
    'use strict';

    angular
        .module('app')
        .factory('WelcomeService', ['$q', '$http', 'tokenContainer', WelcomeService]);

    //angular.module('app').config([
    //    '$httpProvider', function($httpProvider) {
    //        //Reset headers to avoid OPTIONS request (aka preflight)
    //        $httpProvider.defaults.headers.common = {};
    //        $httpProvider.defaults.headers.get = {};
    //        $httpProvider.defaults.headers.post = {};
    //        $httpProvider.defaults.headers.put = {};
    //        $httpProvider.defaults.headers.patch = {};
    //    }
    //]);

    function WelcomeService($q, $http, tokenContainer) {

        var config = {
            headers: {
                'Authorization': 'Bearer' + tokenContainer.getToken().token,
                'Accept': 'application/json;'
            }
        };


        var endpoint = "http://localhost:53120/";
        var service = {
            get: get
        };
        return service;


        function get() {
            var deferred = $q.defer();
            $http.get(endpoint + "consumer", config)
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