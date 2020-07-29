angular
    .module('logosSystemApp')
    .controller('CursosPageController', CursosPageController);

function CursosPageController($scope) {

	var self = this;

	self.cursos = [
        { Nome: 'Ricardo Pereira', Igreja: 'Igreja Batista Esperança em Tatuapé', Idade: 22 },
        { Nome: 'Joao Henrique', Igreja: 'Igreja Pentecostal', Idade: 22 },
        { Nome: 'Maria Clara', Igreja: 'Igreja Batista Betel', Idade: 22 }
	];

	self.getCursos = function () {

		return cursos;
	}

	self.init = function () {

		$('.container').css('padding-left', '0');
		$('.container').css('padding-right', '0');

		self.getCursos();

	}

}