(function () {
    "use strict";

    angular.module("Grolty.Finances")
        .factory("TransactionsService", transactionsService);
      
    transactionsService.$inject = ["$resource", "$q", "$window", "$http"];

    function transactionsService($resource, $q, $window, $http)
    {

        var apiUrl = "/api/transaction";
        var service = {
            getTransactions: getTransactions,
            transactions: []
        };
        return service;

        function getTransactions() {
          
            return $http({
                method: "GET",
                url: apiUrl + "Expenses",
                headers: { 'X-Requested-With': "XMLHttpRequest" }
            }).then(function (response) {
                service.transactions = response.data.transactions;
            });
        }

    }

})();