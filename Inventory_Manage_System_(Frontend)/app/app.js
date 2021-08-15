var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider", "$locationProvider", function ($routeProvider, $locationProvider) {

    $routeProvider
        .when("/", {
            templateUrl: "views/index.html"
        })
        .when("/products", {
            templateUrl: "views/pages/products.html",
            controller: 'products'
        })
        .when("/addproduct", {
            templateUrl: "views/pages/addproduct.html",
            controller: 'addproduct'
        })
        .when("/addCategories", {
            templateUrl: "views/pages/addCategories.html",
            controller: 'addCategories'
        })
        .when("/Categories", {
            templateUrl: "views/pages/Categories.html",
            controller: 'Categories'
        })
        .otherwise({
            redirectTo: "/"
        });
    //$locationProvider.html5Mode(true);
    //$locationProvider.hashPrefix('');
    //if(window.history && window.history.pushState){
    //$locationProvider.html5Mode(true);
    //}

}]);
