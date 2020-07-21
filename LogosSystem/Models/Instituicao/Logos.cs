using LogosSystem.Models.Pessoas.Alunos;
using LogosSystem.Models.Pessoas.Professores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogosSystem.Models.Instituicao
{
    public class Logos
    {
        public string Nome { get; set; }
        public List<Aluno> Alunos { get; set; }
        public List<Professor> Professores { get; set; }
    }
}