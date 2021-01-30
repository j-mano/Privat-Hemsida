using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using WebApp_Joachim_Webbsite_Framework.Models;
using WebApp_Joachim_Webbsite_Framework.UserCredentials;

namespace WebApp_Joachim_Webbsite_Framework.Controllers
{
    public class LoginController : Controller
    {
        CredentialModell user = new CredentialModell();

        public ActionResult Index()
        {
            return View();
        }

        public void GoogleLogin(string email, string name, string gender, string lastname, string location)
        {
            // Recive info from index info

            CredentialModell user = new CredentialModell();
            user.fName      = name;
            user.lName      = lastname;
            user.email      = email;
            user.location   = location; // Location not planed to used at the moment.

            saveCredential(user);
        }

        public void saveCredential(CredentialModell user)
        {
            try
            {
                GetUserCredentials.setLoginstatus(user);
            }
            catch
            {
                Index();
            }
        }
    }
}