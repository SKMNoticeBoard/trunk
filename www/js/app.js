// angular.module is a global place for creating, registering and retrieving Angular modules
// 'NoticeBoard' is the name of this angular module example (also set in a <body> attribute in index.html)
// the 2nd parameter is an array of 'requires'
var LoginServices = angular.module('NoticeBoard.services', []);
var NoticeBoard = angular.module('NoticeBoard', ['ionic','NoticeBoard.services'])
.run(function($ionicPlatform) {
  $ionicPlatform.ready(function() {
    if(window.cordova && window.cordova.plugins.Keyboard) {
      cordova.plugins.Keyboard.hideKeyboardAccessoryBar(true);
      cordova.plugins.Keyboard.disableScroll(true);
    }
    if(window.StatusBar) {
      StatusBar.styleDefault();
    }
  });
})

.config(function($stateProvider, $urlRouterProvider) {
  $stateProvider
    .state('home', {
      url: '/',
      templateUrl: 'Views/Home.html'
    })
    .state('login', {
      url: '/login',
      templateUrl: 'Views/Partials/login.html',
      controller: 'LoginController'
    })
  $urlRouterProvider.otherwise('/home');
});
