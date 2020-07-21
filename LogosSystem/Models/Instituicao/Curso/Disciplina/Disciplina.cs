using LogosSystem.Models.Pessoas.Alunos;
using LogosSystem.Models.Pessoas.Professores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogosSystem.Models.Instituicao.Curso.Disciplinas
{
    public class Disciplina
    {
        public int DisciplinaID { get; set; }
        public string Nome { get; set; }
        public string Decricao { get; set; }
        public Professor Professor { get; set; }
        public List<Aluno> Alunos { get; set; }
        public int CursoID { get; set; }
    }
}