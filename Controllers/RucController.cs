using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using RucConsultaApp.Models;
using RucConsultaApp.Services;

namespace RucConsultaApp.Controllers
{
    public class RucController : Controller
    {
        private readonly RucService _rucService;

        public RucController(RucService rucService)
        {
            _rucService = rucService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Consultar(string ruc)
        {
            if (string.IsNullOrEmpty(ruc))
            {
                ModelState.AddModelError("", "El RUC es requerido.");
                return View("Index");
            }

            var rucInfo = await _rucService.GetRucInfoAsync(ruc);
            return View("Resultado", rucInfo);
        }
    }
}
