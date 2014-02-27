using CalculadoraDeImpostos.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculadoraDeImpostos.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    
        [HttpPost]
        public ActionResult Calcular(CalculadoraViewModel calculadoraModel)
        {
            if (ModelState.IsValid) {
                calculadoraModel.Imposto = new Calculadora().calcularImposto(calculadoraModel.Salario);
                return View("Index", calculadoraModel);
            }
            return RedirectToAction("Index");
        }
    }
}