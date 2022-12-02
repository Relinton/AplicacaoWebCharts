using AplicacaoWebDemoCharts.Models.Index;
using AplicacaoWebDemoCharts.Models.Proin;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoWebDemoCharts.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult ObterNavegadores()
        {
            Navegador navegador = new Navegador();
            var resultado = navegador.ObterTodos();
            return Json(resultado);
        }
        public JsonResult ObterNavegadoresParaGraficoDeBarra()
        {
            NavegadorBarra navegador = new NavegadorBarra();
            var resultado = navegador.ObterNavegadoresParaMontarGraficoBarra();
            return Json(resultado);
        }


        public IActionResult Proin()
        {
            Proin proin = new Proin();
            var resultado = proin.ObterTodos();
            return View(resultado);
        }
        public JsonResult ObterTodosParaProin()
        {
            Proin proin = new Proin();
            var resultado = proin.ObterTodos();
            return Json(resultado);
        }

        //public JsonResult ObterTodosProinParaGraficoDeBarra()
        //{
        //    Proin proin = new Proin();
        //    var resultado = proin.ObterTodos();
        //    return Json(resultado);
        //}
    }
}
