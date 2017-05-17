using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TestController : Controller
    {
        TestEntities dbase = new TestEntities();
        public ActionResult Test()
        {
            IEnumerable<Questions> quest = dbase.Questions;
            var q = dbase.Questions.Include(a=>a.Table);
            ViewBag.Questions = q;
            return View(q);
        }
        public PartialViewResult CheckAnswer(int id)
        {
            IList<Table> ans = new List<Table>();
            foreach (var i in dbase.Table)
            {
                ans.Add(i);
            }
            return PartialView(ans);
        }
        }
}