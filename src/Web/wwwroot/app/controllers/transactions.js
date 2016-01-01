(function () {
    "use strict";

    angular
        .module("Grolty.Finances")
        .controller("transationsController", transationsController);

    transationsController.$inject = ["$location" , "transactionService"]; 

    function transationsController($location, transactionService) {
        /* jshint validthis:true */
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
