using log4net;
using LogosSystem.Models.Repository.AlunoRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogosSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly ILog _log;

        public HomeController(ILog log, IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
            _log = log;
        }

        public ActionResult Index()
        {
            ViewBag.helloUser = GetSalutation(DateTime.Now.Hour);

            return View();
        }

        public ActionResult LoginView()
        {
            return View();
        }

        private string GetSalutation(int hora)
        {
            string cumprimento = null;

            if (hora >= 0 && hora < 13)
            {
                cumprimento = "Bom dia";
            }
            else if (hora >= 13 && hora < 18)
            {
                cumprimento = "Boa tarde";
            }
            else
            {
                cumprimento = "Boa noite";
            }

            return cumprimento;
        }
    }
}