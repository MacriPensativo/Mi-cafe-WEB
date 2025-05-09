using Microsoft.AspNetCore.Mvc;

namespace JC_PDWA2025.Controllers
{
    public class ContactoController : Controller
    {
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(string nombre, string email, string mensaje)
        {

            TempData["Mensaje"] = "Tu mensaje se ha enviado correctamente!";

            return RedirectToAction("Contacto");
        }
    }
}
