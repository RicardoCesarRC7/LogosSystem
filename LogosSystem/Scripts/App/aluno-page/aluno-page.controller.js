angular
    .module('logosSystemApp')
    .controller('AlunoPageController', AlunoPageController);

function AlunoPageController($scope, $http) {

    var self = this;

    self.alunos = [];

    self.isLoading = true;

    self.getAlunos = function () {

        self.isLoading = true;

        //self.alunos = [
        //    { Nome: 'Ricardo Pereira', Igreja: 'Igreja Batista Esperança em Tatuapé', Idade: 22 },
        //    { Nome: 'Joao Henrique', Igreja: 'Igreja Pentecostal', Idade: 22 },
        //    { Nome: 'Maria Clara', Igreja: 'Igreja Batista Betel', Idade: 22 }
        //];

        $http({
            method: 'GET',
            url: window.location.protocol + '//' + window.location.host + window.location.pathname + '/GetAlunos'
        }).then(function success(response) {

            if (response != null && response.length > 0) {

                self.alunos = response;
            }
        });

        self.isLoading = false;
    }

    self.init = function () {

        self.getAlunos();
    }

}