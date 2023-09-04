using Microsoft.AspNetCore.Mvc;

namespace PTPMQL2324.Controllers
{
    public class Personcontroller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string fName)
        {
            ViewBag.thongBao = "xin chao" + fName;
            return View();
        }
        
    
    }
}