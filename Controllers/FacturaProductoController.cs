using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaFacturacion.DB;
using SistemaFacturacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacion.Controllers
{
    public class FacturaProductoController : Controller
    {
        private readonly ApplicationDbContext _context;
        public int? numFact;
        public FacturaProductoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            var applicationDbContext = _context.FacturaProducto.Where(p => p.numeroFactura == id).Include(p => p.Productos);
            var factura = _context.Facturas.Find(id);
            ViewBag.facturaAnulada = Convert.ToString(factura.anulada);
            TempData["numeroFactura"] = id;
            numFact = id;
            ViewBag.numFactura = id;
            return View(await applicationDbContext.ToListAsync());
        }

        public IActionResult Create(int? id)
        {
            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Productos.Where(p => p.activo == "S"))
            {
                listItems.Add(new SelectListItem() { Text = $"{item.nombre} | {item.descripcion}", Value = $"{item.codigoProducto}" });
            }

            TempData["numeroFactura"] = Convert.ToString(id);
            ViewData["codigoProducto"] = new SelectList(listItems, "Value", "Text");

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("numeroFactura,codigoProducto,precioUnitario,cantidad")] FacturaProducto detalle)
        {
            if (ModelState.IsValid)
            {
                Producto producto = _context.Productos.Find(detalle.codigoProducto);
                detalle.precioUnitario = producto.precio;

                if (detalle.cantidad <= producto.existencia)
                {
                    _context.FacturaProducto.Add(detalle);
                    _context.SaveChanges();

                    producto.existencia = producto.existencia - detalle.cantidad;
                    _context.Productos.Update(producto);
                    _context.SaveChanges();

                    Factura factura = _context.Facturas.Find(detalle.numeroFactura);
                    factura.totalFactura = (detalle.precioUnitario * detalle.cantidad) + factura.totalFactura;
                    _context.Facturas.Update(factura);
                    _context.SaveChanges();

                    return RedirectToAction("Index", "FacturaProducto", new { id = detalle.numeroFactura });

                }
                else
                {
                    ViewBag.Message = String.Format($"La existencia es menor a la cantidad solicitada | Existencia: {producto.existencia}");
                }
            }

            TempData["numeroFactura"] = Convert.ToString(detalle.numeroFactura);
            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Productos.Where(p => p.activo == "S"))
            {
                listItems.Add(new SelectListItem() { Text = $"{item.nombre} | {item.descripcion}", Value = $"{item.codigoProducto}" });
            }

            ViewData["codigoProducto"] = new SelectList(listItems, "Value", "Text");
            return View();
        }

        public async Task<IActionResult> Edit(int? numeroFactura, int? codigoProducto)
        {
            if (numeroFactura == null || codigoProducto == null)
            {
                return NotFound();
            }

            var detalle = await _context.FacturaProducto.FindAsync(numeroFactura, codigoProducto);

            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Productos)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.nombre} | {item.descripcion}", Value = $"{item.codigoProducto}" });
            }

            TempData["numeroFactura"] = numeroFactura;
            TempData["codigoProducto"] = codigoProducto;
            ViewData["codigoProducto"] = new SelectList(listItems, "Value", "Text");

            return View(detalle);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? numeroFactura, int? codigoProducto, int cantidad)
        {
            TempData["numeroFactura"] = numeroFactura;
            FacturaProducto detalleDB = _context.FacturaProducto.Find(numeroFactura, codigoProducto);
            Producto productoDB = _context.Productos.Find(codigoProducto);
            Factura factura = _context.Facturas.Find(numeroFactura);

            if (ModelState.IsValid)
            {
                var existenciaCompleta = detalleDB.cantidad + productoDB.existencia;
                if (cantidad <= existenciaCompleta)
                {
                    factura.totalFactura = factura.totalFactura - (detalleDB.cantidad * productoDB.precio);
                    factura.totalFactura = factura.totalFactura + (cantidad * productoDB.precio);
                    _context.Facturas.Update(factura);
                    _context.SaveChanges();

                    detalleDB.precioUnitario = productoDB.precio;
                    detalleDB.cantidad = cantidad;
                    _context.FacturaProducto.Update(detalleDB);
                    _context.SaveChanges();

                    productoDB.existencia = existenciaCompleta - cantidad;
                    _context.Productos.Update(productoDB);
                    _context.SaveChanges();

                    return RedirectToAction("Index", "FacturaProducto", new { id = numeroFactura });
                }
                else
                {
                    ViewBag.Message = String.Format($"Puede elegir un limite de {existenciaCompleta} productos");
                }
            }

            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Productos)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.nombre} | {item.descripcion}", Value = $"{item.codigoProducto}" });
            }

            ViewData["codigoProducto"] = new SelectList(listItems, "Value", "Text");

            return View();
        }


        public IActionResult Delete(int? numeroFactura, int? codigoProducto)
        {
            if (numeroFactura == null || codigoProducto == null)
            {
                return NotFound();
            }
            TempData["numeroFactura"] = Convert.ToString(numeroFactura);

            var detalle = _context.FacturaProducto.Find(numeroFactura, codigoProducto);

            return View(detalle);
        }


        public async Task<IActionResult> ConfirmacionEliminar(int? numeroFactura, int? codigoProducto)
        {
            TempData["numeroFactura"] = Convert.ToString(numeroFactura);
            try
            {
                var producto = _context.Productos.Find(codigoProducto);
                var factura = _context.Facturas.Find(numeroFactura);
                var detalle = _context.FacturaProducto.Find(numeroFactura, codigoProducto);
                
                factura.totalFactura = factura.totalFactura - (detalle.cantidad * producto.precio);
                _context.Facturas.Update(factura);
                _context.SaveChanges();

                producto.existencia = producto.existencia + detalle.cantidad;
                _context.Productos.Update(producto);
                _context.SaveChanges();

                _context.FacturaProducto.Remove(detalle);
                
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "FacturaProducto", new { id = detalle.numeroFactura });
            }
            catch (Exception e)
            {
                return RedirectToAction("HttpError404", new { erro = e });
            }
        }

    }
}
