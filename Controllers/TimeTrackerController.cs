using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace TimeTrack.Controllers
{
    public class TimeTrackController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}