angular
    .module('logosSystemApp')
    .controller('CursosPageController', CursosPageController);

function CursosPageController($scope) {

	var self = this;

    self.cursos = [];
    self.turmas = [];

    self.getCursos = function () {

        self.cursos = [
            { Id: 1, Nome: 'Teologia Ministerial' },
            { Id: 2, Nome: 'Educação Cristã' },
            { Id: 3, Nome: 'Música Sacra' },
            { Id: 4, Nome: 'Master of Ministry' },
            { Id: 5, Nome: 'Pós-graduação em Exposição Bíblica' },
            { Id: 6, Nome: 'Pós-Graduação em Aconselhamento Bíblico' }
        ];
    }

    self.getTurmas = function () {

        self.turmas = [
            {
                Id: 1,
                CursoId: 1,
                NomeCurso: 'Teologia Ministerial',
                Disciplinas: [
                    { DisciplinaId: 1, Nome: 'Teologia Sistemática', Professor: 'Wagner Amaral', TemProfessores: false, Alunos: []},
                    { DisciplinaId: 2, Nome: 'Aconselhamento', Professor: 'Carlos Bacoccina', TemProfessores: false, Alunos: []},
                    { DisciplinaId: 3, Nome: 'Teologia do Antigo Testamento', Professor: 'Pedro Santos', TemProfessores: false, Alunos: []}
                ],
                Semestre: '1º Semestre',
                Periodo: '1º Ano e 2º Ano',
                Alunos: [
                    {
                        AlunoId: 1,
                        PrimeiroNome: 'Ricardo',
                        SegundoNome: 'Pereira',
                    },
                    {
                        AlunoId: 2,
                        PrimeiroNome: 'Joao',
                        SegundoNome: 'Ricardo',
                    },
                    {
                        AlunoId: 3,
                        PrimeiroNome: 'Alessandro',
                        SegundoNome: 'Santos',
                    }
                ]
            },
            {
                Id: 2,
                CursoId: 2,
                NomeCurso: 'Música Sacra',
                Disciplinas: [
                    { DisciplinaId: 1, Nome: 'Teologia Sistemática', Professor: 'Wagner Amaral', TemProfessores: false, Alunos: [] },
                    { DisciplinaId: 2, Nome: 'Aconselhamento', Professor: 'Carlos Bacoccina', TemProfessores: false, Alunos: [] },
                    { DisciplinaId: 3, Nome: 'Teologia do Antigo Testamento', Professor: 'Pedro Santos', TemProfessores: false, Alunos: [] }
                ],
                Semestre: '1º Semestre',
                Periodo: '1º Ano e 2º Ano',
                Alunos: [
                    {
                        AlunoId: 1,
                        PrimeiroNome: 'Ricardo',
                        SegundoNome: 'Pereira',
                    },
                    {
                        AlunoId: 2,
                        PrimeiroNome: 'Joao',
                        SegundoNome: 'Ricardo',
                    },
                    {
                        AlunoId: 3,
                        PrimeiroNome: 'Alessandro',
                        SegundoNome: 'Santos',
                    }
                ]
            },
            {
                Id: 3,
                CursoId: 3,
                NomeCurso: 'Exposição Bíblica',
                DataInicio: '02/02/2020',
                Disciplinas: [
                    { DisciplinaId: 1, Nome: 'Teologia Sistemática', Professor: 'Wagner Amaral', TemProfessores: false },
                    { DisciplinaId: 2, Nome: 'Aconselhamento', Professor: 'Carlos Bacoccina', TemProfessores: false },
                    { DisciplinaId: 3, Nome: 'Teologia do Antigo Testamento', Professor: 'Pedro Santos', TemProfessores: false }
                ],
                Semestre: '1º Semestre',
                Periodo: '1º Ano e 2º Ano',
                Alunos: [
                    {
                        AlunoId: 1,
                        PrimeiroNome: 'Ricardo',
                        SegundoNome: 'Pereira',
                        IsAvulso: false
                    },
                    {
                        AlunoId: 2,
                        PrimeiroNome: 'Joao',
                        SegundoNome: 'Ricardo',
                        IsAvulso: false
                    },
                    {
                        AlunoId: 3,
                        PrimeiroNome: 'Alessandro',
                        SegundoNome: 'Santos',
                        IsAvulso: false
                    },
                    {
                        AlunoId: 4,
                        PrimeiroNome: 'Joana',
                        SegundoNome: 'Santos',
                        IsAvulso: true
                    }
                ]
            }
        ];
    }

	self.init = function () {

		$('.container').css('padding-left', '0');
		$('.container').css('padding-right', '0');

        self.getCursos();
        self.getTurmas();
	}

}