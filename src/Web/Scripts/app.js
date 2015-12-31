(function () {
    "use strict";

    angular.module
        (
            "Grolty.Finances",
            [
                // Angular modules 
                "ngRoute",
                "ngResource",
                "ui.router"
            ]
        )
        .config(
        [
            "$provide", "$httpProvider", "$stateProvider", "$urlRouterProvider",
            function($provide, $httpProvider, $stateProvider, $urlRouterProvider)
            {
                //!Route!
                $urlRouterProvider.otherwise("/");
                $stateProvider
                    .state("home", {
                        templateUrl: "transactions.html",
                        url: "/",
                        controller: "transactionsController",
                        controllerAs: "vm",
                        params: {}
                    });
            }
        ]);
})();