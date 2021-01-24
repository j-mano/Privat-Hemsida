using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_Joachim_Webbsite_Framework.Models;
using WebApp_Joachim_Webbsite_Framework.UserCredentials;

namespace WebApp_Joachim_Webbsite_Framework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // View titles and decoration
            ViewBag.Title                           = "Joachim Johnson personal webbsite";

            ViewBag.IntroduktionText                = "Detta är skrivet i asp.net mvc framework. Hemmsidan är främst framtagen för att uppehålla en viss grad av programeringsvana samt att ha olika typer av project att visa";
            
            // Description of Website
            ViewBag.DescriptionTitle                = "Kort om mig själv";
            ViewBag.Description                     = ApiClass.Apis.LoadMyPersionalDescription.getDescription();

            // Velcome to webbsite
            ViewBag.SecondParagrafpTxtDescription   = "Välkomna";
            ViewBag.SecondParagrafpTxt              = "Känn er välkomna att kolla runt på hemsidan med olika projekt jag har gjort eller hitta min linkedin och andra sociala medier på kontakta mig";


            CredentialModell user = GetUserCredentials.GetUserLoginstatus();

            // LoginAccount
            ViewBag.loginUserName       = "User: " + user.username;
            ViewBag.Logdin              = "Logdin Status: " + user.logdin;
            ViewBag.Email               = "Email: " + user.email;
            ViewBag.isAdmin             = "Has admin rights " + user.isAdmin;

            return View();
        }

        public ActionResult About()
        {
            // View titles and decoration
            ViewBag.Title                       = "Om mig själv och om hemsidan";
            ViewBag.Message                     = "Beskrivning om mig själv samt hemsidan";

            // Description of Joachim (orgidinal author) / personal description
            ViewBag.PersonalDescriptionTitle    = "Besrkivning om mig själv";
            ViewBag.PersonalDescription         = ApiClass.Apis.LoadMyPersionalDescription.getDescription();
            ViewBag.MyProgramingsSkills         = ApiClass.Apis.LoadMySkills.getMySkills();

            // Description of webbsite
            ViewBag.WebbsiteDescriptionTitle    = "Beskriving om hemsidan";
            ViewBag.WebbsiteDescription         = "Den här hemsidan är skriven för att påvisa vissa kunskaper som jag har erhållit från min tid från örebro universitet.";

            return View();
        }

        public ActionResult Contact()
        {
            // view titles and decoration
            ViewBag.Title                   = "Vill komma i kontakt med mig?";
            ViewBag.Message                 = "Här hittar ni allt från direktkontakt med mig samt även sociala medier.";
            ViewBag.Adress                  = "Slöta L:a kardgarden";

            // Social media.
            ViewBag.LindedinAdress          = "https://www.linkedin.com/in/joachim-johnson-913389133/";
            ViewBag.LindedinAdresslinktext  = "LinkedinLänk";

            ViewBag.WordPress               = "https://jopbgroup.wordpress.com/";
            ViewBag.WordPressLinktext       = "Wordpresslänk";

            ViewBag.Facebook                = "https://www.facebook.com/jtrex924";
            ViewBag.FacebookLinktext        = "FacebookLänk";

            // Direkt Contact.
            ViewBag.Phone                   = "0738241837";

            return View();
        }
    }
}