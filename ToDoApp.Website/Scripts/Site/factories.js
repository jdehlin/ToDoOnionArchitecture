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