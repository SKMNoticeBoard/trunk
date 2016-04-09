/**
 * Created by Mane on 03/04/2016.
 */
LogInController.$inject = ['$scope','logInService'];
function LogInController ($scope, logInService){
  var logIn = {}
  logIn.fields = {
    UserName : '',
    PassWord : ''
  }

  logIn.SignIn = function(input){
    logInService.SignIn(input)
  }
}

