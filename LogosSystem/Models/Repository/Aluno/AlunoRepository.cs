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
                                   PrimeiroNome = aluno.PrimeiroNome,
                                   SegundoNome = aluno.SegundoNome,
                                   NomeCompleto = aluno.PrimeiroNome + " " + aluno.SegundoNome,
                                   Idade = aluno.Idade.HasValue ? aluno.Idade.Value : 0,
                                   IgrejaMembroDezAnos = aluno.Igreja
                               }).ToList();

            return listaAlunos;
        }


    }
}