using LogosSystem.Models.Base;
using LogosSystem.Models.Pessoas.Professores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogosSystem.Models.Repository.Professores
{
    public interface IProfessorRepository
    {
        List<Professor> GetProfessores();
        BaseResponse SaveProfessor(Professor prof);
        BaseResponse UpdateProfessor(Professor prof);
        BaseResponse RemoveProfessor(Professor prof);
    }
}