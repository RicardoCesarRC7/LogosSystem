using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LogosSystem.Models.Pessoas;

namespace LogosSystem.Models.Pessoas.Diretor
{
    public class Diretor : Pessoa
    {
        public int DiretorID { get; set; }
        public int Posicao { get; set; }
    }
}