using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaFacturacion.DB;
using SistemaFacturacion.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SistemaFacturacion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            return View();
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

        
        [HttpPost("Login")]
        public async Task<IActionResult> validate(string usuario, string password)
        {
            var val = from a in _context.Usuarios where usuario == a.user && password == a.password select a.nombre ;
            if (val.Any()!)
            {
                var claims = new List<Claim>(); // creamos un listado de peticion
                claims.Add(new Claim("username", val.First())); // guardamos el nombre de quien se logea
                claims.Add(new Claim(ClaimTypes.NameIdentifier, val.First())); //guardamos el tipo de peticion 
                var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme); // asignamos esa peticicon a un esquema de cookies
                var claimprincipal = new ClaimsPrincipal(claimIdentity); // la volvemos peticion principal


                await HttpContext.SignInAsync(claimprincipal); // cremos la cookie de autentificacion
                

                return RedirectToAction("Index", "Usuarios"); // redireccion a un pagina 
            }
            else
            {
                return RedirectToAction("HttpError404"); // si el usuario no es valido envia un badrequest como respuesta
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(); //elimina la cookie creada 
            return RedirectToAction("Index", "Home"); // regresa a una pagina especifica 
        }

        public ActionResult HttpError404(Exception erro)
        {
            TempData["Error"] = erro.Message;
            return View();
        }
    }
}
