(function () {
    "use strict";

    angular.module("Grolty.Finances.Transactions")
        .controller("TransactionsController", transactionsController);

    transactionsController.$inject = ["$location", "TransactionsService"];

    function transactionsController($location, transactionService) {
        var vm = this;
        vm.model = {
            transactions:  []
                };

        
        activate();

        function activate()
        {
            vm.model.transactions = transactionService.getTransactions();
        }
    }
})();
