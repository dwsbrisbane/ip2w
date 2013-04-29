//This is the main entry point between the Application and the Index.html
angular.module('ip2w', ['ui.bootstrap']);
var TabsDemoCtrl = function ($scope) {
    $scope.panes = [
      { title: "Dynamic Title 1", content: "Dynamic content 1" },
      { title: "Dynamic Title 2", content: "Dynamic content 2" }
    ];
};