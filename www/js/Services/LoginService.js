/*** Created by Mane on 03/04/2016.*/


angular.module('NoticeBoard')

  .service('AuthService', function($q, $http, USER_ROLES) {
    var LOCAL_TOKEN_KEY = 'yourTokenKey';
    var username = '';
    var isAuthenticated = false;
    var role = '';
    var authToken;

    function loadUserCredentials() {
      var token = window.localStorage.getItem(LOCAL_TOKEN_KEY);
      if (token) {
        useCredentials(token);
      }
    }

    function storeUserCredentials(token) {
      window.localStorage.setItem(LOCAL_TOKEN_KEY, token);
      useCredentials(token);
    }

    function useCredentials(token) {
      username = token.split('.')[0];
      isAuthenticated = true;
      authToken = token;

      if (username.length = 5) {
        role = USER_ROLES.admin
      }
      if (username.length = 8) {
        role = USER_ROLES.public
      }

      // Set the token as header for your requests!
      $http.defaults.headers.common['X-Auth-Token'] = token;
    }

    function destroyUserCredentials() {
      authToken = undefined;
      username = '';
      isAuthenticated = false;
      $http.defaults.headers.common['X-Auth-Token'] = undefined;
      window.localStorage.removeItem(LOCAL_TOKEN_KEY);
    }

    var login = function(name, pw) {
      return $q(function(resolve, reject) {
        if ((name == 'admin' && pw == '1') || (name == 'user' && pw == '1')) {
          // Make a request and receive your auth token from your server
          storeUserCredentials(name + '.yourServerToken');
          resolve('Login success.');
        } else {
          reject('Login Failed.');
        }
      });
    };

    var logout = function() {
      destroyUserCredentials();
    };

    var isAuthorized = function(authorizedRoles) {
      if (!angular.isArray(authorizedRoles)) {
        authorizedRoles = [authorizedRoles];
      }
      return (isAuthenticated && authorizedRoles.indexOf(role) !== -1);
    };

    loadUserCredentials();

    return {
      login: login,
      logout: logout,
      isAuthorized: isAuthorized,
      isAuthenticated: function() {return isAuthenticated;},
      username: function() {return username;},
      role: function() {return role;}
    };
  })




















/*
NoticeBoardServices.factory('LoginService', ['$http', 'url', 'web', function ($http, url, web) {
  function LoginService (){
    function Login(data){
      web.call(url.webService)
    }
  }
}])


angular.module('NoticeBoard.logInServices', [])

var users = [{
  userName: 'Mane',
  passWord: 'mane1'
}, {
  userName: 'Sne',
  passWord: 'Sne1'
},{
  userName: 'Kaelo',
  passWord: 'Kaelo1'
}]

function LoginService (){
  this.Login = function(input){
    for(user in users)
    {
      if(user.userName == input.userName && user.passWord == input.passWord){
        return user;
      } else{
        return null;
      }
    }
  }
}


.service('LoginService', function($q) {
    var response {
        loginUser: function(data) {
            var deferred = $q.defer();
            var promise = deferred.promise;

             $http.post("http://localhost:8000/api/user/signupInstagram", data).success(function(data, status) {

                           console.log(data);

                           response = data;

                          });
                }, function(error) {
                    console.log("Error -> " + error);
                     response = error;

                });
            promise.success = function(fn) {

                promise.then(fn);
                return promise;
            }
            promise.error = function(fn) {
                promise.then(null, fn);
                return promise;
            }
            return response;
        }
    }
})

*/
