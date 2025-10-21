using Microsoft.AspNetCore.Mvc;

namespace Academico.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Aula()
        {
            return View();
        }
    }
}
