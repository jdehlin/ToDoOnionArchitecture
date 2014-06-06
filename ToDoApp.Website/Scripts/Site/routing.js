toDoApp.config(function ($routeProvider) {
    $routeProvider
        .when('/users', {
            templateUrl: 'Partials/UsersList',
            controller: 'UsersListController'
        })
        .when('/users/:userId', {
            templateUrl: 'Partials/ToDoLists',
            controller: 'ToDoListsController'
        })
        .when('/lists/:listId', {
            templateUrl: 'Partials/ToDoList',
            controller: 'ToDoListDetailsController'
        })
        .otherwise({
            redirectTo: '/users'
        });
});