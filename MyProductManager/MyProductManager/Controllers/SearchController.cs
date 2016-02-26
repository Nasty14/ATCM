using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq.Expressions;

namespace MyProductManager.Controllers
{
    public class SearchController : Controller
    {
        private PMEntitiesConStr db = new PMEntitiesConStr();
        //[Route("")]
        // GET: Search
        public ActionResult Index(string id)
        {
            var products = db.Products.Where(p => p.Name.Contains(id)).ToList();
            return View(products);
        }
    }
}