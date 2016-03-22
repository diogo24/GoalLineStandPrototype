using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoalLineStandPrototype.Controllers
{
    public class GLSHomeController : Controller
    {
        // GET: GLSHome
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewGame()
        {
            return View();
        }

        public ActionResult SelectTeam()
        {
            return View();
        }
    }
}