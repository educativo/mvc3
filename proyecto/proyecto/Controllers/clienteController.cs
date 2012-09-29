using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using proyecto.Models;

namespace proyecto.Controllers
{
    public class clienteController : Controller
    {
        //
        // GET: /cliente/

        public ActionResult Index()
        {
            return View();
        }

    }
}
