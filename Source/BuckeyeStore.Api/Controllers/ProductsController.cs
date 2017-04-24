using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BuckeyeStore.Core;
using BuckeyeStore.Api.Data;

namespace BuckeyeStore.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private BuckeyeStoreContext db;

        public ProductsController(BuckeyeStoreContext context)
        {
            this.db = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.Products);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(db.Products.Find(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Product product)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}