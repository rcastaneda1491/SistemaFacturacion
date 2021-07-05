using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaFacturacion.DB;
using SistemaFacturacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacion.Controllers
{
    [Authorize]
    public class ReporteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReporteController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ReporteVentasProductosNombre(int? codigoProducto)
        {
            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Productos)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.nombre} | {item.descripcion} ", Value = $"{item.codigoProducto}" });
            }

            ViewData["codigoProducto"] = new SelectList(listItems, "Value", "Text");

            var list = await _context.ReporteProductos.FromSqlRaw("SP_Productos_Nombre @CodigoProducto", new SqlParameter("@CodigoProducto", codigoProducto)).ToListAsync();

            return View(list);
        }

        public async Task<IActionResult> ReporteVentasProductoFecha(string fechaInicio, string fechaFinal)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@FechaInicio", Convert.ToDateTime( fechaInicio)),
                new SqlParameter("@FechaFinal", Convert.ToDateTime(fechaFinal))
            };

            var list = await _context.ReporteProductos.FromSqlRaw("SP_Productos_Fecha @FechaInicio, @FechaFinal", parameters.ToArray()).ToListAsync();

            return View(list);
        }

        public async Task<IActionResult> ReporteVentasProductoNombreFecha(string fechaInicio, string fechaFinal, int? codigoProducto)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@FechaInicio", Convert.ToDateTime( fechaInicio)),
                new SqlParameter("@FechaFinal", Convert.ToDateTime(fechaFinal)),
                new SqlParameter("@CodigoCliente", Convert.ToInt32(codigoProducto))
            };

            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Productos)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.nombre} | {item.descripcion} ", Value = $"{item.codigoProducto}" });
            }

            ViewData["codigoProducto"] = new SelectList(listItems, "Value", "Text");

            var list = await _context.ReporteProductos.FromSqlRaw("SP_Productos_Fecha_Nombre @FechaInicio, @FechaFinal, @CodigoCliente", parameters.ToArray()).ToListAsync();

            return View(list);
        }

        public async Task<IActionResult> ReporteComprasClienteNombre(int? codigoCliente)
        {
            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Clientes)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.nombres} {item.apellidos} ", Value = $"{item.codigoCliente}" });
            }

            ViewData["codigoCliente"] = new SelectList(listItems, "Value", "Text");

            var list = await _context.ReporteClientes.FromSqlRaw("SP_Cliente_Nombre @CodigoCliente", new SqlParameter("@CodigoCliente", codigoCliente)).ToListAsync();

            return View(list);
        }

        public async Task<IActionResult> ReporteComprasClienteFecha(string fechaInicio, string fechaFinal)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@FechaInicio", Convert.ToDateTime(fechaInicio)),
                new SqlParameter("@FechaFinal", Convert.ToDateTime(fechaFinal))
            };

            var list = await _context.ReporteClientes.FromSqlRaw("SP_Cliente_Fecha @FechaInicio, @FechaFinal", parameters.ToArray()).ToListAsync();

            return View(list);
        }

        public async Task<IActionResult> ReporteComprasClienteNombreFecha(string fechaInicio, string fechaFinal, int? codigoCliente)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@FechaInicio", Convert.ToDateTime(fechaInicio)),
                new SqlParameter("@FechaFinal", Convert.ToDateTime(fechaFinal)),
                new SqlParameter("@CodigoCliente", Convert.ToInt32(codigoCliente))
            };

            List<SelectListItem> listItems = new List<SelectListItem>();

            listItems.Add(new SelectListItem() { Text = "Seleccione una opcion", Value = " " });

            foreach (var item in _context.Clientes)
            {
                listItems.Add(new SelectListItem() { Text = $"{item.nombres} {item.apellidos} ", Value = $"{item.codigoCliente}" });
            }

            ViewData["codigoCliente"] = new SelectList(listItems, "Value", "Text");

            var list = await _context.ReporteClientes.FromSqlRaw("SP_Cliente_Fecha_Nombre @FechaInicio, @FechaFinal, @CodigoCliente", parameters.ToArray()).ToListAsync();

            return View(list);
        }

        public async Task<IActionResult> ReporteEstadisticasFacturacion(string fechaInicio, string fechaFinal)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@FechaInicio", Convert.ToDateTime(fechaInicio)),
                new SqlParameter("@FechaFinal", Convert.ToDateTime(fechaFinal))
            };

            var list = await _context.ReporteFacturas.FromSqlRaw("SP_Estadistica_Facturacion @FechaInicio, @FechaFinal", parameters.ToArray()).ToListAsync();

            return View(list);
        }

    }
}
