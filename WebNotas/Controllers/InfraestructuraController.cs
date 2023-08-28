using Microsoft.AspNetCore.Mvc;

namespace WebNotas.Controllers
{
    public class InfraestructuraController : Controller
    {
        public IActionResult Index()
        {
            return View("Folleto");
        }
        public IActionResult Folleto()
        {
            return View();
        }
        public IActionResult Primero() 
        {
            ViewData["Año"] = "Primer año";
            return View("Materias");
        }
        public IActionResult Segundo()
        {
            ViewData["Año"] = "Segundo año";
            return View("Materias");
        }
        public IActionResult Tercero()
        {
            ViewData["Año"] = "Tercer año";
            return View("Materias");
        }
    }
}
