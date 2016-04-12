(function(angular) {
    "use strict";

    var app = angular.module('app', [
       'ui.router'
    ]);

    /* jshint ignore:start */
    //app.run(function ($state) { }); /* Required to force the first state to be displayed. */
    ///* jshint ignore:end */

    app.config(function($stateProvider, $urlRouterProvider) {

        $urlRouterProvider.otherwise("/welcome");

        $stateProvider
            .state('welcome', {
                url: '/welcome',
                templateUrl: 'App/templates/welcome.html',
                controller: 'WelcomeController'
            });
    });
})(angular);