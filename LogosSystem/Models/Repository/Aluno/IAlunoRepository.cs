using LogosSystem.Models.Pessoas.Alunos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogosSystem.Models.Repository.AlunoRespository
{
    public interface IAlunoRepository
    {
        List<Aluno> GetAlunos();
    }
}