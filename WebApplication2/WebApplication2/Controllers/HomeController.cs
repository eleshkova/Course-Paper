using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();
        public ActionResult Index(string genre)
        {
           IEnumerable<Book> books = db.Books;
            ViewBag.Books = books;
            return View(db.Books);
        }
        public ActionResult Books(string genre)
        {
            var allbooks = db.Books.OrderBy(a => Guid.NewGuid()).Take(1);
            if (genre != "Любой")                
            allbooks = db.Books.Where(a => a.Genre.Contains(genre)).OrderBy(a => Guid.NewGuid()).Take(1);
            ViewBag.Books = allbooks;
            return View(allbooks);
        }
    }
}