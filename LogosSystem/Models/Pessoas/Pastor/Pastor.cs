using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogosSystem.Models.Pessoas.Pastor
{
    public class Pastor : Pessoa
    {
        public int PastorID { get; set; }
        public string Igreja { get; set; }
    }
}