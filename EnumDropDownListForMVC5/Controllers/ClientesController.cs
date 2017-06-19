using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnumDropDownListForMVC5.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View(new Models.ViewModelCliente());
        }
    }
}