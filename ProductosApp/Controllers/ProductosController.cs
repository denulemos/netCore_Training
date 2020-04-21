using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : Controller
    {
        List<Producto> productos;

        public ProductosController()
        {
            productos = new List<Producto>();
            Producto a = new Producto() { ID = 1, Nombre = "Leche", Descripcion = "Lacteos", Precio = 4243 };
            this.productos.Add(a);
        }


        [HttpGet]
        public ActionResult<List<Producto>> GetAll()
        {
            //al hacer un GET, devuelvo la lista de productos en un JSON
            //Listar Productos 
            return this.productos;
        }

        [HttpGet ("{id}")]
        public ActionResult<Producto> Get(int id)
        {
            //devolver producto con el mismo ID 
            //Buscar productos
            return this.productos.Where(c => c.ID == id).FirstOrDefault();

        }
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Producto value)
        {
            //Insertar productos
            this.productos.Add(value);
            return true;
        }

        [HttpPut ("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Producto value)
        {
            //Modificar producto
            var prod = this.productos.Where(c => c.ID == id).FirstOrDefault();
            prod.Nombre = value.Nombre;
            prod.Precio = value.Precio;
            prod.Descripcion = value.Descripcion;
            return true;
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            var prod = this.productos.Where(c => c.ID == id).FirstOrDefault();
            this.productos.Remove(prod);
            return true;
        }

    }
}