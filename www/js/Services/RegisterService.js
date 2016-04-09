
var app = angular.module('NoticeBoard.RegisterServices', []);

app.service('AuthService', function ($q, $http, $cordovaOauth, $ionicPopup) {
     var register = {
          'loginInstagram': function() {
            var d = $q.defer();

            $cordovaOauth.instagram('42e2f60b94e1487db4617a48a7000453', [], {})
                .then(function(result) {
                     console.log("Response Object -> " + JSON.stringify(result));


                    // save the access token
                    var data = { instagram_access_token: result.access_token };

                          $http.post("http://localhost:8000/api/user/signupInstagram", data).success(function(data, status) {
                           console.log(data);
                          });   
                }, function(error) {
                    console.log("Error -> " + error);
                });

               return d.promise;

        }
     };

     return self;
});