using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Parcial2.Models;

namespace Parcial2.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Random()
        {
            var Cliente = new Clientes()

            {
                Nombre = "Sebastian",
                Apellido = "Ocampo Hernandez",
                Sueldo = 3500000
            };


            return View(Cliente);
        }
    }
}