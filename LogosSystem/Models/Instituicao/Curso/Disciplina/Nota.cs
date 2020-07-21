using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogosSystem.Models.Instituicao.Curso.Disciplina
{
    public class Nota
    {
        public int NotaID { get; set; }
        public string Tipo { get; set; }
        public double Valor { get; set; }
    }
}