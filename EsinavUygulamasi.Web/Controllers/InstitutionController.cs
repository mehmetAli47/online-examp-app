using Microsoft.AspNetCore.Mvc;

namespace EsinavUygulamasi.Controllers
{
    public class InstitutionController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
