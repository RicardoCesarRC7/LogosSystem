using LogosSystem.Models.Igrejas;
using LogosSystem.Models.Instituicao.Curso.Disciplinas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogosSystem.Models.Pessoas.Alunos
{
    public class Aluno : Pessoa
    {
        public int AlunoID { get; set; }
        public string Status { get; set; }
        public Igreja Igreja { get; set; }
        public List<CargoAluno> Cargos { get; set; }
        public string IgrejaMembroDezAnos { get; set; }
        public string Curso { get; set; }
        public DateTime DataBatismo { get; set; }
        public bool LecionaEBD { get; set; }
        public bool DirigeCulto { get; set; }
        public bool Prega { get; set; }
        public string OutrosCargos { get; set; }

        public List<Nota> Notas { get; set; }
        public double Faltas { get; set; }
        public int CursoID { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
    }
}