﻿$('#buttonTest').click(function () {
    window.location.href = 'https://localhost:44383/Home/LoginView'
});

$(document).ready(function () {
    $(function () {
        $('[data-toggle="tooltip"]').tooltip();
    });

    $(function () {
        $('.card').matchHeight({ property: 'min-height' });
    });

    //$('.data-mask').mask('##/##/####');

    $('#logoHomeLink').click(function () {
        window.location.href = getMainUrl() + '/Home';
    });

    $('#alunoLink').click(function () {
        window.location.href = getMainUrl() + '/Aluno';
    });

    $('#professorLink').click(function () {
        window.location.href = getMainUrl() + '/Professor';
    });

    $('#professoresDrop').click(function () {
        window.location.href = getMainUrl() + '/Professor';
    });

    $('#cursosLink').click(function () {
        window.location.href = getMainUrl() + '/Cursos';
    });

    $('.carousel').carousel({
        interval: 2000
    });
});



var getMainUrl = function () {
    if (window.location.host.includes('localhost')) {
        return '';
    }
};