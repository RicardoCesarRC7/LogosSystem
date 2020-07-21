using LogosSystem.Models.Instituicao.Curso;
using LogosSystem.Models.Instituicao.Curso.Disciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogosSystem.Models.Pessoas.Professores
{
    public class Professor : Pessoa
    {
        public int ProfessorID { get; set; }
        public List<Curso> Cursos { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
        public string Area { get; set; }
    }
}