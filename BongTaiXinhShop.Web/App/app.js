/// <reference path="../assets/admin/libs/angular/angular.min.js" />

(function () {
    angular.modul('btsShop', []).config(config);

    config.$inject=['$stateProvider','$urlRouterProvider']


    function config($stateProvider, $urlRouterProviderLV2022) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/App/components/Home/homeView.html",
            controller:"HomeController"

        })
    }
})