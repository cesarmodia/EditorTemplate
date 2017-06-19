using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EditorTemplate.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Edit()
        {
            return View(new Models.Cliente());
        }
    }
}