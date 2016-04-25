RegisterController.$inject = ['$scope','RegisterService'];



function RegisterController ($scope, RegisterService){
	RegisterService.Register($scope.data)
}
