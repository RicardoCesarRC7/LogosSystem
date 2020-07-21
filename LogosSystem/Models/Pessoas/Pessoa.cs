using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogosSystem.Models.Pessoas
{
    public class Pessoa
    {
        public int PessoaID { get; set; }
        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }
        public string NomeCompleto { get; set; }
        public Localizacao Localizacao { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Nacionalidade { get; set; }
        public string LocalNascimento { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public string Filiacao { get; set; }
        public string EnderecoComercial { get; set; }
        public string TelefoneComercial { get; set; }
        public string Profissao { get; set; }
        public string EstadoCivil { get; set; }
        public string EstadoCivilAntigo { get; set; }
        public int QttFilhos { get; set; }
        public string Conjuge { get; set; }
        public bool Tabaco { get; set; }
        public bool BebidaAlcoolica { get; set; }
        public bool Toxicos { get; set; }
        public bool SociedadeSecreta { get; set; }
        public bool EnsinoFundamental { get; set; }
        public bool EnsinoMedio { get; set; }
        public bool EnsinoSuperior { get; set; }
        public string OutrosCursos { get; set; }
    }
}