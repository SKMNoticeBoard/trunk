NoticeBoard.controller('LoginController',function($scope, LoginService){
  $scope.Login = function (data){
    LoginService.Login(data);
  }
})

