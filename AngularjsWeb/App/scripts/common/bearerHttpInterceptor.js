(function(angular) {
    'use strict';

    angular.module('app').factory('BearerAuthInterceptor', function ($window, $q) {
        return {
            request: function (config) {
                config.headers = config.headers || {};
                if ($window.localStorage.getItem('access_token')) {
                    // may also use sessionStorage
                    config.headers.Authorization = 'Bearer ' + $window.localStorage.getItem('access_token');
                }
                return config || $q.when(config);
            },
            response: function (response) {
                if (response.status === 401) {
                    //  Redirect user to login page / signup Page.
                }
                return response || $q.when(response);
            }
        };
    });

    // Register the previously created AuthInterceptor.
    angular.module('app').config(function ($httpProvider) {
        $httpProvider.interceptors.push('BearerAuthInterceptor');
    });

})(angular);