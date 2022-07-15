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
            var turma = new AlunosModel();
            turma.Turma = new List<Aluno>()
            {
                { new Aluno(){ Id = 1,Nome = "Willian",Sobrenome = "Sant Anna",Status = "Reprovado"}},
                { new Aluno(){ Id = 2,Nome = "Thiago",Sobrenome = "Machado",Status = "Aprovado"}},
                { new Aluno(){ Id = 3,Nome = "Rodrigo",Sobrenome = "Brago",Status = "Aprovado"}},
                { new Aluno(){ Id = 4,Nome = "Caroline",Sobrenome = "da Silva",Status = "Recuperação"}}
            };
            return View(turma);
        }
        public IActionResult Notas()
        {
            var materia = new AlunosModel();
            materia.Materias = new List<Materia>()
            {
                { new Materia(){ Descricao = "Português",PrimeiroSemestre = 5,SegundoSemestre = 6.5,TerceiroSemestre = 6.5, QuartoSemestre = 0, Status = "Reprovado" }},
                { new Materia(){ Descricao = "Matemática",PrimeiroSemestre = 10,SegundoSemestre = 8,TerceiroSemestre = 8, QuartoSemestre = 8, Status = "Aprovado" }},
                { new Materia(){ Descricao = "Ciências",PrimeiroSemestre = 6,SegundoSemestre = 7.5,TerceiroSemestre = 8, QuartoSemestre = 8, Status = "Aprovado" }},
                { new Materia(){ Descricao = "Português",PrimeiroSemestre = 8,SegundoSemestre = 9,TerceiroSemestre = 10, QuartoSemestre = 7.5, Status = "Aprovado" }}
            };
            return View(materia);
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