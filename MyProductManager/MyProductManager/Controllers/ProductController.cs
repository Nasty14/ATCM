using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyProductManager.Models
{
    [RoutePrefix("api1")]
    public class ProductController : ApiController
    {
        private PMEntitiesConStr db = new PMEntitiesConStr();

        //[HttpGet]
        //public IHttpActionResult GetProducts()
        //{
        //    var products = db.Products.ToList();
        //    return Ok(products.Select(p => ModelFactory.Create(p)));
        //}


        [HttpGet]
        [Route("v1")]
        public IHttpActionResult GetProducts1()
        {
            var products = db.Products.ToList();
            return Ok(products.Select(p => ModelFactory.Create(p)));
        }

        [HttpGet]
        [Route("v2")]
        public IHttpActionResult GetProducts2()
        {
            var products = db.Products.Take(2).ToList();
            return Ok(products.Select(p => ModelFactory.Create(p)));
        }
    }
}
