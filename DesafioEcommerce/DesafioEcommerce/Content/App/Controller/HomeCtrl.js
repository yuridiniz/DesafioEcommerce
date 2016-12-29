window.app.controller('HomeCtrl', ['$scope', '$rootScope', '$location', '$http', function ($scope, $rootScope, $location, $http) {
    $scope.pageTitle = "HomeCtrl"
    $scope.listProducts = [];
    getProducts();

    /*
    * Obtém todos os produtos a venda
    */
    function getProducts() {
        $rootScope.loading = true

        $http.get("api/products").then(function (result) {
            $rootScope.loading = false
            $scope.listProducts = result.data
        })
    }

}]);