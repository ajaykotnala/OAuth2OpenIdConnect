(function (angular) {
    'use strict';

    angular.module('app').controller('WelcomeController', WelcomeController);

    function WelcomeController($scope) {
        $scope.message = "This message is coming from Controller";
    }
})(angular);