using LogosSystem.Models.Pessoas.Alunos;
using LogosSystem.Models.Pessoas.Professores;
using LogosSystem.Models.Instituicao.Curso.Disciplinas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogosSystem.Models.Instituicao.Curso
{
    public class Curso
    {
        public int CursoID { get; set; }
        public string Nome { get; set; }
        public string Decricao { get; set; }
        public List<Aluno> Alunos { get; set; }
        public List<Professor> Professores { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
    }
}