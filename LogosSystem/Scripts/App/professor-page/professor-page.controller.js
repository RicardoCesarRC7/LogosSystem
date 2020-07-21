angular
    .module('logosSystemApp')
    .controller('ProfessorPageController', ProfessorPageController);

function ProfessorPageController($scope) {

    var self = $scope;

    var professores = [
        { Nome: 'Ricardo Pereira', Igreja: 'Igreja Batista Esperança em Tatuapé', Idade: 22 },
        { Nome: 'Joao Henrique', Igreja: 'Igreja Pentecostal', Idade: 22 },
        { Nome: 'Maria Clara', Igreja: 'Igreja Batista Betel', Idade: 22 }
    ];

    self.getProfessores = function () {  

        return professores;
    }

    self.init = function () {

        self.getProfessores();

    }

}