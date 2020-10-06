using LogosSystem.Models.Base;
using LogosSystem.Models.Pessoas.Professores;
using LogosSystem.Models.Repository.Database;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogosSystem.Models.Repository.Professores
{
    public class ProfessorRepository : IProfessorRepository
    {
        private logossystemEntities _logosContext;

        public ProfessorRepository(logossystemEntities logosContext)
        {
            _logosContext = logosContext;
        }

        public List<Professor> GetProfessores()
        {
            List<Professor> professores = new List<Professor>();

            professores = (from prof in _logosContext.professor
                                       select new Professor
                                       {
                                           ProfessorID = prof.Professor_ID,
                                           PrimeiroNome = prof.Primeiro_Nome,
                                           SegundoNome = prof.Segundo_Nome,
                                           NomeCompleto = prof.Primeiro_Nome + " " + prof.Segundo_Nome,
                                           Idade = prof.Idade
                                       }).ToList();

            return professores;
        }

        public BaseResponse SaveProfessor(Professor prof)
        {
            BaseResponse response = new BaseResponse();

            if (prof != null)
            {
                professor professorDB = new professor();

                professorDB.Primeiro_Nome = prof.PrimeiroNome;
                professorDB.Segundo_Nome = prof.SegundoNome;
                professorDB.Data_Nascimento = prof.DataNascimento;
                professorDB.Email = prof.Email;
                professorDB.Area_Ensino = prof.Area;
                professorDB.Telefone = prof.Telefone;
                professorDB.TelefoneComercial = prof.TelefoneComercial;
                professorDB.Celular = prof.Celular;
                professorDB.RG = prof.RG;
                professorDB.CPF = prof.CPF;
                professorDB.Nacao_ID = prof.Nacionalidade;
                professorDB.CidadeNascimento = prof.LocalNascimento;
                professorDB.Sexo = prof.Sexo;
                professorDB.EnderecoComercial = prof.EnderecoComercial;
                professorDB.Profissao = prof.Profissao;
                professorDB.Estado_Civil = prof.EstadoCivil;
                professorDB.Estado_Civil_Antigo = prof.EstadoCivilAntigo;
                professorDB.Filhos_Qtt = prof.QttFilhos;
                professorDB.Conjuge_Nome = prof.Conjuge;
                professorDB.Has_Tabaco = prof.Tabaco;
                professorDB.Has_Toxicos = prof.Toxicos;
                professorDB.Is_Sociedade_Secreta = prof.SociedadeSecreta;
                professorDB.Has_Ensino_Fundamental = prof.EnsinoFundamental;
                professorDB.Has_Ensino_Medio = prof.EnsinoMedio;
                professorDB.Has_Ensino_Superior = prof.EnsinoSuperior;
                professorDB.Outros_Cursos = prof.OutrosCursos;
                professorDB.Is_Ativo = prof.IsAtivo;

                if (prof.Cursos != null && prof.Cursos.Any())
                {
                    professor_cursos cursoProfessorDB = null;

                    foreach (var curso in prof.Cursos)
                    {
                        cursoProfessorDB = new professor_cursos();

                        cursoProfessorDB.Curso_ID = curso.CursoID;
                        cursoProfessorDB.Professor_ID = professorDB.Professor_ID;
                    }
                }

                _logosContext.SaveChanges();
            }

            return response;
        }

        public BaseResponse UpdateProfessor(Professor prof)
        {
            BaseResponse response = new BaseResponse();

            return response;
        }

        public BaseResponse RemoveProfessor(Professor prof)
        {
            BaseResponse response = new BaseResponse();

            return response;
        }
    }
}