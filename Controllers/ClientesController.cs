using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaFacturacion.DB;
using SistemaFacturacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacion.Controllers
{
    [Authorize]
    public class ClientesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Cliente> listaCliente = _context.Clientes;
            return View(listaCliente);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var cliente = _context.Clientes.Find(id);
            if (id.HasValue == false)
            {
                return NotFound();
            }
            else
            {
                return View(cliente);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Update(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Delete(int? id)
        {
            var cliente = _context.Clientes.Find(id);
            if (id.HasValue == false)
            {
                return RedirectToAction("HttpError404");
            }
            else
            {
                return View(cliente);
            }
        }

        public async Task<IActionResult> ConfirmacionEliminar(int? id)
        {
            try
            {
                var cliente = _context.Clientes.Find(id);
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("HttpError404");
            }
        }

        public ActionResult HttpError404(Exception erro)
        {
            TempData["Error"] = erro.Message;
            return View();
        }

    }
}
