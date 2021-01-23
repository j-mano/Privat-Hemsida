using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_Joachim_Webbsite_Framework.Controllers
{
    public class LoginController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Index(string email, string name, string gender, string lastname, string location)
        {
            System.Environment.Exit(1);
        }

        public void GoogleLogin(string email, string name, string gender, string lastname, string location)
        {
            Console.WriteLine("test" + email + name + gender + lastname + location);
        }
    }
}