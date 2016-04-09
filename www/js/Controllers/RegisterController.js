RegisterController.$inject = ['$scope','RegisterService'];

$scope.data = {}


function RegisterController ($scope, RegisterService){
	RegisterService.Register($scope.data)
}