/**
 * Created by Mane on 03/04/2016.
 */
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
  this.SignIn = function(input){
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

