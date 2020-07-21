angular
    .module('logosSystemApp')
    .controller('HomePageController', HomePageController);

function HomePageController($scope) {

    var self = this;

    self.agenda = [];
    self.lastLengthAgenda = 0;

    self.alunos = [];
    self.professores = [];
    self.diretores = [];

    self.init = function () {
        self.getAgenda();
        self.getAlunos();
        self.getProfessores();
        self.getDiretoria();
    }

    self.getAgenda = function () {

        let agenda = [
            {
                Titulo: 'Contatar Professores',
                Descricao: 'Contatar os professores funcionou',
                DataCriacao: '2 dias'
            },
            {
                Titulo: 'Teste funfou',
                Descricao: 'Contatar os professores funcionou',
                DataCriacao: '2 dias',
                IsNovoLembrete: false
            },
            {
                Titulo: 'Teste 2 funfou',
                Descricao: 'Contatar os professores funcionou',
                DataCriacao: '2 dias',
                IsNovoLembrete: false
            },
            {
                Titulo: 'Contatar funfou 2',
                Descricao: 'Contatar os professores funcionou',
                DataCriacao: '2 dias',
                IsNovoLembrete: false
            }
        ];

        self.agenda = agenda;
        self.lastLengthAgenda = agenda.length;
    }

    self.getAlunos = function () {

        let alunos = [
            {
                Nome: "Ricardo"
            },
            {
                Nome: "Joel"
            },
            {
                Nome: "Maria Clara"
            },
            {
                Nome: "Renan"
            },
            {
                Nome: "Osvaldo"
            },
            {
                Nome: "Caputti"
            },
            {
                Nome: "Joao Neto"
            }
        ];

        self.alunos = alunos;
    }

    self.getProfessores = function () {

        let professores = [
            {
                Nome: "Ricardo"
            },
            {
                Nome: "Joel"
            },
            {
                Nome: "Maria Clara"
            },
            {
                Nome: "Renan"
            },
            {
                Nome: "Osvaldo"
            },
            {
                Nome: "Caputti"
            },
            {
                Nome: "Joao Neto"
            }
        ];

        self.professores = professores;
    }

    self.getDiretoria = function () {

        let diretores = [
            {
                Nome: "Wagner Amaral"
            },
            {
                Nome: "Joseph Arthur"
            },
            {
                Nome: "Thiago Moreira"
            },
            {
                Nome: "Ricardo Pereira"
            },
            {
                Nome: "Messias Santos"
            }
        ];

        self.diretores = diretores;
    }

    self.salvarAgenda = function () {

        $.each(self.agenda, function (index, item) {
            item.IsNovoLembrete = false;
        });

        $('#salvarAgenda').hide();
    }

    self.adicionarLembrete = function (lembrete) {

        if (lembrete != null) {

            lembrete.IsNovoLembrete = true;

            self.agenda.push(angular.copy(lembrete));
        }
    }
}