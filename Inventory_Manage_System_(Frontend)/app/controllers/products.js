app.controller("products", function ($scope, $http, ajax) {
  ajax.get("https://localhost:44367/api/product/all", success, error);
  function success(response) {
    $scope.products = response.data;
  }
  function error(error) {

  }

});
