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
                    $scope.user = data;
                }
            );
    }
});

toDoApp.controller('ToDoListDetailsController', function ($scope, $http, Lists, $routeParams, $location) {
    var listId = $routeParams.listId;
    init();
    function init() {
        Lists.GetList(listId)
            .then(
                function (data) {
                    $scope.list = data;
                }
            );
    }
});