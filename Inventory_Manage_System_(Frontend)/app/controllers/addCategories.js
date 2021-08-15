app.controller("addCategories",function($scope,$http,ajax){
    ajax.get("https://localhost:44367/api/Product",success,error);
    function success(response){
      $scope.addCategories=response.data;
    }
    function error(error){

    }

});