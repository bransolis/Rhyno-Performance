using Microsoft.AspNetCore.Mvc;

namespace RhynoPerformance.Controllers
{

    // Más adelantese conecta con Identity para validar al usuario Y SE redirige a su panel según el rol.
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string correo, string contrasena)
        {
            TempData["Aviso"] = "Pantalla de prueba: el inicio de sesión se conectará con la base de datos más adelante.";
            return RedirectToAction(nameof(Login));
        }
    }
}