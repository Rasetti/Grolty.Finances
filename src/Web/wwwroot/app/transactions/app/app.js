(function () {
    "use strict";

    angular.module
        (
            "Grolty.Finances.Transactions",
            [
                "ui.router"
            ]
        )
        .config(
        [
            "$stateProvider",
            function($stateProvider)
            {
                $stateProvider
                    .state("transactions", {
                        templateUrl: "app/transactions/app/transactions.html",
                        url: "/",
                        controller: "TransactionsController",
                        controllerAs: "vm",
                        params: {}
                    });
            }
        ]);
})();