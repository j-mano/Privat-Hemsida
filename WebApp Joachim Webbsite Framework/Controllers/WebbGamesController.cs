using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_Joachim_Webbsite_Framework.Controllers
{
    public class WebbGamesController : Controller
    {
        // GET: WebbGames
        public ActionResult Index()
        {
            //  Descritption of project
            ViewBag.MessageOfTheMonth           = "Here do you find links to othe project or links to different kind of games i have made. everything isa made by me if not othevise stated";

            //  Return to castleZombieProject
            ViewBag.ReturnToCastleZombieTitle   = "Return to castle zombie";
            ViewBag.ReturnToCastleZombieLink    = "Link to game";

            //  TreeInRow project
            ViewBag.TreeInRowTitle              = "tree in row game";
            ViewBag.TreeInRowLink               = "Link to game";

            // To be continued
            ViewBag.TbcTitle                    = "To be conntiued";
            ViewBag.TbcLink                     = "Link to game";

            return View();
        }
    }
}