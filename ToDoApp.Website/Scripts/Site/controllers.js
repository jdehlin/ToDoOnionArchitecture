'use strict';

/* Controllers */

toDoApp.controller('UsersListController', function ($scope, $http, Users, $location) {
    $scope.users = [];
    init();
    function init() {
        Users.GetUsers()
            .then(
                function (data) {
                    $scope.users = data;
                }
            );
    }
});

toDoApp.controller('ToDoListsController', function ($scope, $http, Users, $routeParams, $location) {
    var userId = $routeParams.userId;
    init();
    function init() {
        Users.GetUser(userId)
            .then(
                function (data) {
                    console.log(data)
                    $scope.user = data;
                }
            );
    }
});