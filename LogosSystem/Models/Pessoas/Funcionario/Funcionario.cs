using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogosSystem.Models.Pessoas.Funcionario
{
    public class Funcionario : Pessoa
    {
        public int FuncionarioID { get; set; }
        public int Funcao { get; set; }
        public int FuncaoID { get; set; }
    }
}