/// <reference path="js/angular.min.js" />
/// <reference path="js/angular-route.min.js" />

var app = angular
    .module("myModule", ["ngRoute"])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider
            .when("/home", {
                templateUrl: "Templates/home.html",
                controller: "homeController"
            })
            .when("/courses", {
                templateUrl: "Templates/courses.html",
                controller: "coursesController"
            })
            .when("/students", {
                templateUrl: "Templates/students.html",
                controller: "studentsController"
            })

        $locationProvider.html5Mode(true);
    })

    .controller("homeController", function ($scope) {
        $scope.message = "Home Page";
    })

    .controller("coursesController", function ($scope) {
        $scope.courses = ["C#", "VB.NET", "ASP.NET", "SQL Server", "AngularJS", "JavaScript", "Python",
            "Java",
            "C++",
            "Ruby",
            "Drupal",
            "Unix"];
    })

    .controller("studentsController", function ($scope, $http) {
        $scope.students = ["Mark", "Monica", "Margerie", "Sophie", "Tyrion", "Rob", "Ned"];
    })