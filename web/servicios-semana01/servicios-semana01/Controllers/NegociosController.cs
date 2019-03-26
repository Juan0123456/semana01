using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace servicios_semana01.Controllers
{
    public class NegociosController : Controller
    {
        // GET: Negocios
        public ActionResult Index()//pagina de inicio
        {
            return View();
        }
    }
}