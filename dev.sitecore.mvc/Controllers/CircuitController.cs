using dev.sitecore.mvc.Models;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dev.sitecore.mvc.Controllers
{
    public class CircuitController : Controller
    {
        // GET: Circuit
        public ActionResult Featured()
        {
            Circuit circuit = new Circuit();

            circuit.Initialize(RenderingContext.Current.Rendering);
            
            return View(circuit);
        }
    }
}