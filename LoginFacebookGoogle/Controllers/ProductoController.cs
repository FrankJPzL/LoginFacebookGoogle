using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using DA_Access;


namespace LoginFacebookGoogle.Controllers
{
    public class ProductoController : Controller
    {
        DA_Producto daProducto = new DA_Producto();
        BE_Producto oProducto = new BE_Producto();
        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarProductos()
        {
            ViewBag.listaProductos = daProducto.Listar_Productos();
            return View(daProducto.Listar_Productos());
        }

        public ActionResult Select(int id)
        {
            BE_Producto oProducto = daProducto.Listar_Productos().Where(i => i.cod_Producto == id).FirstOrDefault();
            
            return View(oProducto);
        }


    }
}