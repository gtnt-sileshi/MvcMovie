using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET method : /HelloWorld

        public IActionResult Index()
        {
            return View();
        }

        // GET method : /HelloWorld/Welcome
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            
            return View();
        }

        //Controller/ActionName/Parameter 
    }
}
