using JQueryTableData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQueryTableData.Controllers
{
    public class FriendsController : Controller
    {
        // GET: Friends
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetList() 
        {
            using (DBModels db = new DBModels())
            {
                var frdList = db.Friends.ToList<Friend>();
                return Json(new { data=frdList }, JsonRequestBehavior.AllowGet);
            }   
        }
    }
}