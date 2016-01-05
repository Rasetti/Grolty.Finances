(function () {
    "use strict";

    angular.module("Grolty.Finances.Transactions")
        .factory("TransactionsService", transactionsService);
      
    transactionsService.$inject = ["$resource"];

    function transactionsService($resource)
    {
        var service = {
            getTransactions: getTransactions,
            transactions: []
        };
        return service;

        function getTransactions()
        {
            var transactions = $resource("/api/transactions");
            transactions.query().$promise.then(function (response) {
                service.transactions = response;
            });
        }

    }

})();