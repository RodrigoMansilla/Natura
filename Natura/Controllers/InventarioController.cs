using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Natura.Data;
using Natura.ViewModels;

namespace Natura.Controllers
{
    public class InventarioController : Controller
    {
        private Context db = new Context();
        // GET: Inventario
        public ActionResult Index()
        {
            return View(new InventarioViewModel {
                IdProducto = 1,
                Nombre = "Perro"
            });
         }
    }
}