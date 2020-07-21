using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogosSystem.Models.Instituicao.Curso.Disciplinas
{
    public class Nota
    {
        public int NotaID { get; set; }
        public string Tipo { get; set; }
        public double NotaValor { get; set; }
        public int AlunoID { get; set; }
        public int DisciplinaID { get; set; }
    }
}