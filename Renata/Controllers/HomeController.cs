using Aula28.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Aula28.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var turma = new TurmaModel();
            turma.Alunos = new List<Aluno>()
            {
                { new Aluno(){ Id = 1,Nome = "Willian",Sobrenome = "Sant Anna",Status = "Reprovado"}},
                { new Aluno(){ Id = 2,Nome = "Thiago",Sobrenome = "Machado",Status = "Aprovado"}},
                { new Aluno(){ Id = 3,Nome = "Rodrigo",Sobrenome = "Brago",Status = "Aprovado"}},
                { new Aluno(){ Id = 4,Nome = "Caroline",Sobrenome = "da Silva",Status = "Recuperação"}}

            };

            return View(turma);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}