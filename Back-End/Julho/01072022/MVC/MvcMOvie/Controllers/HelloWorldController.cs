using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMOvie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome(string nome, int vezes =1, int ID=1 )
        {   
            return HtmlEncoder.Default.Encode($"oi {nome}, vezes: {vezes}, ID: {ID}");
        }
        public string Proximo()
        {
            return "Próximo!";
        }
    }  
}
