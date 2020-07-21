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
        private IAlunoRepository _alunoRepository;

        public HomeController()
        {
            _alunoRepository = new AlunoRepository();
        }

        public ActionResult Index()
        {
            ViewBag.helloUser = GetSalutation(DateTime.Now.Hour);

            return View();
        }

        public ActionResult Aluno()
        {
            return View();
        }

        public ActionResult Professor()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult LoginView()
        {
            return View();
        }

        public JsonResult GetAlunos()
        {
            var listaAlunos = _alunoRepository.GetAlunos();

            return Json(listaAlunos);
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