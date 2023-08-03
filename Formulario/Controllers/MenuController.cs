using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Formulario.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            return View("Inicio");
        }

        public ActionResult FormularioDatos()
        {
            return View("FormularioDatos");
        }

        public ActionResult FormularioDireccion()
        {
            return View("FormularioDireccion");
        }

        public ActionResult FormularioPOST(string Nombre, string Paterno, string Materno, string Edad)
        {
            string mensajeUno = $"Mi nombre es {Nombre} {Paterno} {Materno} y tengo {Edad} años";
            TempData["tempdata1"] = mensajeUno;

            return View("FormularioDatos");
        }

        public ActionResult FormularioPOST2(string Direccion, string Colonia, string Delegacion)
        {
            string mensajeDos = $"{Direccion} {Colonia} {Delegacion}";
            TempData["tempdata2"] = mensajeDos;

            return View("VistaDireccion");
        }
    }
}