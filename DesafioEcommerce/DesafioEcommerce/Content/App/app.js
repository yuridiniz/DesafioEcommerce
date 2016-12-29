window.app = angular.module('app', ['ngRoute', 'ngAnimate']);

window.app.run(function ($rootScope) {
    $rootScope.loading = false;
    $rootScope.redirectMessage = [];
    $rootScope.currentMessage = [];
    
    /*
    * Adiciona mensagem para ser exibido no redirect da pagina
    */
    $rootScope.addRedirectMessage = function (success, msg) {
        if (!(msg instanceof Array))
            msg = [msg]

        for (var i = 0; i < msg.length; i++) {
            var msgObject = {};
            msgObject.success = success;
            msgObject.text = msg[i];

            $rootScope.redirectMessage.push(msgObject)
        }
    }

    /*
    * Exibe mensagem para o usuário
    */
    $rootScope.addMessage = function (success, msg) {
        if (!(msg instanceof Array))
            msg = [msg];

        for (var i = 0; i < msg.length; i++) {
            var msgObject = {};
            msgObject.success = success;
            msgObject.text = msg[i];

            $rootScope.currentMessage.push(msgObject);
        }
    }

    /*
    * Apaga as mensagens exibida ao usuário
    */
    $rootScope.clearAllMessage = function () {
        $rootScope.currentMessage = [];
        $rootScope.redirectMessage = [];
    }

    $rootScope.$on("$routeChangeSuccess", function () {
        $rootScope.currentMessage = $rootScope.redirectMessage;
        $rootScope.redirectMessage = null;
    })

})

window.app.config(function ($routeProvider, $locationProvider) {

    $routeProvider.when('/', {
        templateUrl: 'Home/Produtos',
        controller: 'HomeCtrl',
    }).when('/buy/:productId', {
        templateUrl: 'Home/Buy',
        controller: 'BuyCtrl',
    })

    $routeProvider.otherwise({ redirectTo: '/' });
});