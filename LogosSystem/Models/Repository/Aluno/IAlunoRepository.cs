using LogosSystem.Models.Base;
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
        BaseResponse SaveAluno(Aluno novoAluno);
        BaseResponse UpdateAluno(Aluno thisAluno);
        BaseResponse RemoveAluno(Aluno aluno);
    }
}