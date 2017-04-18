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
        public IEnumerable<string> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public void Post([FromBody]Product product)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Product product)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}