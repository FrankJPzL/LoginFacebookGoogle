using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using DA_Access;

namespace LoginFacebookGoogle.Controllers
{
    public class HomeController : Controller
    {
        DA_Producto daProducto = new DA_Producto();
        public ActionResult Index()
        {
            ViewBag.listaProductos = daProducto.Listar_Productos();
            return View();
        }

        public ActionResult Select(int id)
        {
            BE_Producto oProducto = daProducto.Listar_Productos().Where(i => i.cod_Producto == id).FirstOrDefault();

            return View(oProducto);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}