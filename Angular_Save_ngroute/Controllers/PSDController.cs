using Angular_Save_ngroute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angular_Save_ngroute.Controllers
{
    public class PSDController : Controller
    {
        //
        // GET: /PSD/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Save(PSDViewModel PSD)
        {
            issEntities2 e = new issEntities2();
            foreach (var obj in PSD.employees)
            {
                e.Employees.Add(obj);
            }

            if (e.SaveChanges() > 0)
            {
                return (Json(new { Status = "success" }, JsonRequestBehavior.AllowGet));
            }

            return (Json(new { Status = "failure" }, JsonRequestBehavior.AllowGet));
        }

    }
}
