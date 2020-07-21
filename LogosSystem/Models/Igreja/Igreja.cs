using LogosSystem.Models.Pessoas.Pastor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogosSystem.Models.Igrejas
{
    public class Igreja
    {
        public int IgrejaID { get; set; }
        public string Nome { get; set; }
        public string Denominacao { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public List<Pastor> Pastor { get; set; }
    }
}