angular
    .module('logosSystemApp')
    .controller('CursosPageController', CursosPageController);

function CursosPageController($scope) {

	var self = this;

	self.cursos = [
        { Id: 1, Nome: 'Teologia Ministerial'},
        { Id: 2, Nome: 'Educação Cristã'},
        { Id: 3, Nome: 'Música Sacra'},
        { Id: 4, Nome: 'Master of Ministry'},
        { Id: 5, Nome: 'Pós-graduação em Exposição Bíblica'},
        { Id: 6, Nome: 'Pós-Graduação em Aconselhamento Bíblico'}
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