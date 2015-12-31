(function () {
    "use strict";

    angular
        .module("Grolty.Finances")
        .controller("transationsController", transationsController);

    transationsController.$inject = ["$location" , "transactionService"]; 

    function transationsController($location, transactionService) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = "transationsController";
        vm.transactions = [];

        activate();

        function activate()
        {
            vm.transactions = transactionService.getTransactions();
        }
    }
})();
