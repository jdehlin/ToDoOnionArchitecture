'use strict';

/* Services */

toDoApp.factory('Users', function ($http, $q) {
    return {
        GetUsers: function () {
            var deferred = $q.defer();
            $http.get('/Api/Users' + '?json=true')
                .success(function (data, status, headers, config) {
                    deferred.resolve(data);
                });
            return deferred.promise;
        },
        GetUser: function (userId) {
            var deferred = $q.defer();
            $http.get('/Api/Users/' + userId + '?json=true')
                .success(function (data, status, headers, config) {
                    deferred.resolve(data);
                });
            return deferred.promise;
        }
    }
});

toDoApp.factory('Lists', function ($http, $q) {
    return {
        GetList: function (listId) {
            var deferred = $q.defer();
            $http.get('/Api/Lists/' + listId + '?json=true')
                .success(function (data, status, headers, config) {
                    deferred.resolve(data);
                });
            return deferred.promise;
        }
    }
});