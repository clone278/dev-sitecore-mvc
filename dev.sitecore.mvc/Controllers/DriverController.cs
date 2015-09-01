using dev.sitecore.mvc.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dev.sitecore.mvc.Controllers
{
    public class DriverController : Controller
    {
        // GET: Driver
        public ActionResult Featured()
        {
            var repository = new DriverRepository();

            var driver = repository.GetDriver();

            var driverViewModel = repository.GetDriverViewModel(driver);

            return View(driverViewModel);
        }
    }
}