using LogosSystem.Models.Repository.Database;
using LogosSystem.Models.Pessoas.Alunos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LogosSystem.Models.Base;

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

        public BaseResponse UpdateAluno(Aluno thisAluno)
        {
            BaseResponse response = new BaseResponse();

            if (thisAluno != null && thisAluno.AlunoID != 0)
            {
                aluno alunoDB = _logosContext.aluno.Where(a => a.Aluno_ID == thisAluno.AlunoID).FirstOrDefault();

                if (alunoDB != null)
                {
                    alunoDB.Primeiro_Nome = thisAluno.PrimeiroNome;
                    alunoDB.Segundo_Nome = thisAluno.SegundoNome;
                    alunoDB.Data_Nascimento = thisAluno.DataNascimento;
                    alunoDB.Email = thisAluno.Email;
                    alunoDB.Area_Ensino = thisAluno.AreaEnsino;
                    alunoDB.Telefone = thisAluno.Telefone;
                    alunoDB.Celular = thisAluno.Celular;
                    alunoDB.RG = thisAluno.RG;
                    alunoDB.CPF = thisAluno.CPF;
                    alunoDB.Nacao_ID = thisAluno.Nacionalidade;
                    alunoDB.Testemunho = thisAluno.Testemunho;
                    alunoDB.Igreja_Membro_Ha_Dez_Anos = thisAluno.IgrejaMembroDezAnos;
                    alunoDB.Data_Batismo = thisAluno.DataBatismo;
                    alunoDB.CidadeNascimento = thisAluno.LocalNascimento;
                    alunoDB.Idade = thisAluno.Idade;
                    alunoDB.Sexo = thisAluno.Sexo;
                    alunoDB.Pai_Nome = thisAluno.NomePai;
                    alunoDB.Mae_Nome = thisAluno.NomeMae;
                    alunoDB.EnderecoComercial = thisAluno.EnderecoComercial;
                    alunoDB.TelefoneComercial = thisAluno.TelefoneComercial;
                    alunoDB.Profissao = thisAluno.Profissao;
                    alunoDB.Estado_Civil = thisAluno.EstadoCivil;
                    alunoDB.Estado_Civil_Antigo = thisAluno.EstadoCivilAntigo;
                    alunoDB.Filhos_Qtt = thisAluno.QttFilhos;
                    alunoDB.Conjuge_Nome = thisAluno.Conjuge;
                    alunoDB.Is_Ativo = thisAluno.IsAtivo;
                    alunoDB.Leciona_EBD = thisAluno.LecionaEBD;
                    alunoDB.Dirige_Culto = thisAluno.DirigeCulto;
                    alunoDB.Prega = thisAluno.Prega;
                    alunoDB.Has_Tabaco = thisAluno.Tabaco;
                    alunoDB.Has_Toxicos = thisAluno.Toxicos;
                    alunoDB.Is_Sociedade_Secreta = thisAluno.SociedadeSecreta;
                    alunoDB.Has_Ensino_Fundamental = thisAluno.EnsinoFundamental;
                    alunoDB.Has_Ensino_Medio = thisAluno.EnsinoMedio;
                    alunoDB.Has_Ensino_Superior = thisAluno.EnsinoSuperior;
                    alunoDB.Outros_Cursos = thisAluno.OutrosCursos;

                    _logosContext.SaveChanges();

                    response.Success = true;
                    response.Description = "Aluno atualizado com sucesso!";
                }
            }
            else
            {
                response.Success = false;
                response.Description = "Este aluno não existe em nossa base de dados!";
            }

            return response;
        }

        public BaseResponse SaveAluno(Aluno novoAluno)
        {
            BaseResponse response = new BaseResponse();

            if (novoAluno != null)
            {
                aluno alunoDB = new aluno();

                alunoDB.Primeiro_Nome = novoAluno.PrimeiroNome;
                alunoDB.Segundo_Nome = novoAluno.SegundoNome;
                alunoDB.Data_Nascimento = novoAluno.DataNascimento;
                alunoDB.Email = novoAluno.Email;
                alunoDB.Area_Ensino = novoAluno.AreaEnsino;
                alunoDB.Telefone = novoAluno.Telefone;
                alunoDB.Celular = novoAluno.Celular;
                alunoDB.RG = novoAluno.RG;
                alunoDB.CPF = novoAluno.CPF;
                alunoDB.Nacao_ID = novoAluno.Nacionalidade;
                alunoDB.Testemunho = novoAluno.Testemunho;
                alunoDB.Igreja_Membro_Ha_Dez_Anos = novoAluno.IgrejaMembroDezAnos;
                alunoDB.Data_Batismo = novoAluno.DataBatismo;
                alunoDB.CidadeNascimento = novoAluno.LocalNascimento;
                alunoDB.Idade = novoAluno.Idade;
                alunoDB.Sexo = novoAluno.Sexo;
                alunoDB.Pai_Nome = novoAluno.NomePai;
                alunoDB.Mae_Nome = novoAluno.NomeMae;
                alunoDB.EnderecoComercial = novoAluno.EnderecoComercial;
                alunoDB.TelefoneComercial = novoAluno.TelefoneComercial;
                alunoDB.Profissao = novoAluno.Profissao;
                alunoDB.Estado_Civil = novoAluno.EstadoCivil;
                alunoDB.Estado_Civil_Antigo = novoAluno.EstadoCivilAntigo;
                alunoDB.Filhos_Qtt = novoAluno.QttFilhos;
                alunoDB.Conjuge_Nome = novoAluno.Conjuge;
                alunoDB.Is_Ativo = novoAluno.IsAtivo;
                alunoDB.Leciona_EBD = novoAluno.LecionaEBD;
                alunoDB.Dirige_Culto = novoAluno.DirigeCulto;
                alunoDB.Prega = novoAluno.Prega;
                alunoDB.Has_Tabaco = novoAluno.Tabaco;
                alunoDB.Has_Toxicos = novoAluno.Toxicos;
                alunoDB.Is_Sociedade_Secreta = novoAluno.SociedadeSecreta;
                alunoDB.Has_Ensino_Fundamental = novoAluno.EnsinoFundamental;
                alunoDB.Has_Ensino_Medio = novoAluno.EnsinoMedio;
                alunoDB.Has_Ensino_Superior = novoAluno.EnsinoSuperior;
                alunoDB.Outros_Cursos = novoAluno.OutrosCursos;

                _logosContext.aluno.Add(alunoDB);
                _logosContext.SaveChanges();

                response.Success = true;
                response.Description = "Aluno adicionado com sucesso!";
            }

            return response;
        }
    }
}