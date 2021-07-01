using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaFacturacion.DB;
using SistemaFacturacion.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaFacturacion.Controllers
{
    public class FacturasController : Controller
    {
        private readonly ApplicationDbContext _context;
        

        public FacturasController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var aplicationDbContext = _context.Facturas.Include(p => p.Cliente);
            return View(await aplicationDbContext.ToListAsync());
        }

        public IActionResult Create()
        {
            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Clientes)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.nombres} {item.apellidos}", Value = $"{item.codigoCliente}" });
            }

            ViewData["codigoCliente"] = new SelectList(listItems, "Value", "Text");

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("numeroFactura,fecha,totalFactura,anulada,codigoCliente")] Factura factura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(factura);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Clientes)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.nombres} {item.apellidos}", Value = $"{item.codigoCliente}" });
            }

            ViewData["codigoCliente"] = new SelectList(listItems, "Value", "Text");
            return View();
        }

       public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.Facturas.FindAsync(id);

            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Clientes)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.nombres} {item.apellidos}", Value = $"{item.codigoCliente}" });
            }

            ViewData["codigoCliente"] = new SelectList(listItems, "Value", "Text");

            return View(factura);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Factura factura)
        {
            if (ModelState.IsValid)
            {
                _context.Update(factura);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Clientes)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.nombres} {item.apellidos}", Value = $"{item.codigoCliente}" });
            }

            ViewData["codigoCliente"] = new SelectList(listItems, "Value", "Text");

            return View();
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.Facturas.FindAsync(id);
            var cliente = await _context.Clientes.FindAsync(factura.codigoCliente);

            ViewBag.Cliente = cliente.nombres;
            return View(factura);
        }


        public async Task<IActionResult> ConfirmacionEliminar(int? id)
        {
            try
            {
                var persona = _context.Facturas.Find(id);
                _context.Facturas.Remove(persona);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("HttpError404", new { erro = e });
            }
        }

        public async Task<IActionResult> VerDetalleFactura(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura = await _context.Facturas.FindAsync(id);

            return RedirectToAction("Index", "FacturaProducto", new { id = factura.numeroFactura });
        }
    }
}


