(function () {
    "use strict";

    angular.module("Grolty.Finances.Transactions")
        .controller("TransactionsController", transactionsController);

    transactionsController.$inject = ["$location", "TransactionsService"];

    function transactionsController($location, transactionsService) {
        var vm = this;
        vm.model = {
            transactions:  []
                };

        
        activate();

        function activate()
        {
            transactionsService.getTransactions().then(function () {
                vm.model.transactions = transactionsService.transactions;
            });
        }
    }
})();
