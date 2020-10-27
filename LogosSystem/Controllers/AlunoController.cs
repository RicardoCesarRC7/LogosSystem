using log4net;
using LogosSystem.Models.Pessoas.Alunos;
using LogosSystem.Models.Repository.AlunoRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogosSystem.Controllers
{
    public class AlunoController : Controller
    {
        private readonly ILog _log;
        private readonly IAlunoRepository _alunoRepository;

        public AlunoController(ILog log, IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
            _log = log;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public List<Aluno> GetAlunos()
        {
            var listaAlunos = _alunoRepository.GetAlunos();

            return listaAlunos;
        }
    }
}