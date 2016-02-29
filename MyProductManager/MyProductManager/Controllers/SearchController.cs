using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyProductManager.Controllers
{
    public class SearchController : Controller
    {
        private PMEntitiesConStr db = new PMEntitiesConStr();
        //[Route("")]
        // GET: Search
        public async Task<ActionResult> Index(string id)
        {
            var products = await db.Products.Where(p => p.Name.Contains(id)).ToListAsync();
            return View(products);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}