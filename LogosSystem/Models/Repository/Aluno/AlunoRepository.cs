using LogosSystem.Models.Repository.Database;
using LogosSystem.Models.Pessoas.Alunos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogosSystem.Models.Repository.AlunoRespository
{
    public class AlunoRepository : IAlunoRepository
    {
        private logossystemEntities _logosContext;

        public AlunoRepository()
        {
            _logosContext = new logossystemEntities();
        }

        public List<Aluno> GetAlunos()
        {

            List<Aluno> listaAlunos = (from aluno in _logosContext.aluno
                               select new Aluno
                               {
                                   AlunoID = aluno.Aluno_ID,
                                   PrimeiroNome = aluno.Primeiro_Nome,
                                   SegundoNome = aluno.Segundo_Nome,
                                   NomeCompleto = aluno.Primeiro_Nome + " " + aluno.Segundo_Nome,
                                   Idade = aluno.Idade
                               }).ToList();

            return listaAlunos;
        }


    }
}