(function () {
    "use strict";

    angular.module
        (
            "Grolty.Finances",
            [
                "ngResource",
                "ui.router",
                "Grolty.Finances.Transactions"
            ]
        )
        .config(
        [
            "$stateProvider", "$urlRouterProvider",
            function ($stateProvider, $urlRouterProvider)
            {
                $urlRouterProvider.otherwise("/");
                $stateProvider.state({
                    name: "Grolty.Finances.Transactions",
                    url: "/transactions",
                    abstract: true
                });
            }
        ]);
})();