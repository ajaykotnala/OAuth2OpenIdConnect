(function (angular) {
    "use strict";

    var app = angular.module('app', [
       'ui.router',
       'ui.router.default'
    ]);

    /* jshint ignore:start */
    //app.run(function ($state) { }); /* Required to force the first state to be displayed. */
    ///* jshint ignore:end */

    app.config(function ($stateProvider, $urlRouterProvider) {

        $urlRouterProvider.otherwise("/welcome");

        $stateProvider
            .state('welcome', {
                url: '/welcome',
                templateUrl: 'App/templates/welcome.html',
                controller: 'WelcomeController',
                resolve: {
                    ApiEmployee: function (WelcomeService) {
                        "ngInject";
                        return WelcomeService.get();
                    }
                }
            });
    });
})(angular);