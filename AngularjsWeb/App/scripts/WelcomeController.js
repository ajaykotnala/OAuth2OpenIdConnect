(function (angular) {
    'use strict';

    angular.module('app').controller('WelcomeController', WelcomeController);

    function WelcomeController($scope, ApiEmployee) {
        
        $scope.title = "Employee Details";
        //$scope.employees = {
        //    name: 'Ajay',
        //    address: 'Whitefields-Hyderabad, India.'
        //};
        
        $scope.ApiEmployee = ApiEmployee; 
    }
})(angular);