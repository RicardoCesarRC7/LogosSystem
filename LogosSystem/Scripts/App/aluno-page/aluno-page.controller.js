angular
    .module('logosSystemApp')
    .controller('AlunoPageController', AlunoPageController);

function AlunoPageController($scope) {

    var self = this;
    self.alunos = [];

    self.getAlunos = function () {

        self.alunos = [
            { Nome: 'Ricardo Pereira', Igreja: 'Igreja Batista Esperança em Tatuapé', Idade: 22 },
            { Nome: 'Joao Henrique', Igreja: 'Igreja Pentecostal', Idade: 22 },
            { Nome: 'Maria Clara', Igreja: 'Igreja Batista Betel', Idade: 22 }
        ];

        return self.alunos;
    }

    self.init = function () {

        self.getAlunos();
    }

}