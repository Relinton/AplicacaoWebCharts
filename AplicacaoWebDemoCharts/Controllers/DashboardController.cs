using AplicacaoWebDemoCharts.Models.Index;
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
    }
}
