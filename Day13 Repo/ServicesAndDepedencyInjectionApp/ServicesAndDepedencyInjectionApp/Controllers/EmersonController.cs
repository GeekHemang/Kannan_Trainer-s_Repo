using Microsoft.AspNetCore.Mvc;

namespace ServicesAndDepedencyInjectionApp.Controllers
{
    public class EmersonController: Controller
    {

        [HttpGet]
        //public string Services()
        //{
        //    return "<h1>This is services page</h1>";
        //}

        public IActionResult Services()
        {
            //model
            ViewBag.MyMessage = "services are on power and water";

            return this.View();

            
        }
    }
}
