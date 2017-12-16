using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NS.Controllers
{
    public class PaneldeControlController : Controller
    {
        // GET: PaneldeControl
        public ActionResult Index()
        {
            return View(Index);
        }
    }
}