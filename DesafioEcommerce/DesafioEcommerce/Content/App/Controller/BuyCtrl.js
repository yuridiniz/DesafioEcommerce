window.app.controller('BuyCtrl', ['$scope', '$rootScope', '$location', '$http', '$routeParams', function ($scope, $rootScope, $location, $http, $routeParams) {
    $scope.brands = []
    $scope.expMonth = []
    $scope.expYear = []
    $scope.product = {};
    $scope.creditCard = {};
    $scope.sendCreditCardInformation = sendCreditCardInformation
    getProduct();
    getBrands();
    populateExpMonth();
    populateExpYear();

    /*
    * Obtém produto por Id
    */
    function getProduct() {
        $http.get("api/products/" + $routeParams.productId).then(function (result) {
            $scope.product = result.data
        })
    }

    /*
    * Obtém as bandeiras
    */
    function getBrands() {
        $http.get("api/brands").then(function (result) {
            $scope.brands = result.data
        })
    }

    /*
    * Preenche a lista de meses
    */
    function populateExpMonth() {
        for (var i = 1; i <= 12; i++) {
            var textI = i < 10 ? ("0" + i) : (i + "");
            $scope.expMonth.push({ Id: i, Value: textI })
        }
    }

    /*
    * Preenche a lista de anos
    */
    function populateExpYear() {
        var date = new Date();
        var currentYear = date.getFullYear()

        for (var i = 1; i <= 20; i++) {
            date.setFullYear(currentYear + i);
            var txtYear = date.getFullYear().toString().substring(2);
            $scope.expYear.push({ Id: txtYear, Value: txtYear })
        }
    }

    /*
    * Envia as informações de cartão de crédito
    */
    function sendCreditCardInformation() {
        $rootScope.clearAllMessage();
        $rootScope.loading = true;

        $scope.creditCard.ProductId = $routeParams.productId;
        $http.post("api/transaction", JSON.stringify($scope.creditCard)).then(function (result) {
            $rootScope.loading = false;

            if (result.data.Success == true) {
                $rootScope.addRedirectMessage(true, result.data.Messages);
                window.location = "#!/"
            } else {
                $rootScope.addMessage(false, result.data.Messages);
            }

        }, function (result) {
            if (result.status == 500) {
                $rootScope.addMessage(false, "Ocorreu um erro no processamento, verifique as informações e tente novamente");
            } else {
                $rootScope.addMessage(false, "Ocorreu um erro no processamento, verifique sua internet e tente novamente");
            }
            $rootScope.loading = false;
        })
    }

}]);

