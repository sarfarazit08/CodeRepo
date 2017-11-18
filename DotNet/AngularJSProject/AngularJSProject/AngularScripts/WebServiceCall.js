/// <reference path="../angular.js" />

var myApp = angular
    .module("myModule", [])
    .controller("myController", function ($scope,$http) {
        $http.get('WebServices/EmployeeService.asmx/getAllEmployee')
            .then(function(response) {
                $scope.employees= response.data;
            })

});
