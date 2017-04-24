using System;
using Xunit;
using BuckeyeStore.Api.Controllers;
using BuckeyeStore.Api.Data;
using Microsoft.AspNetCore.Mvc;
using BuckeyeStore.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace BuckeyeStore.Api.Tests
{
    public class ProductsControllerTests : IClassFixture<ContextFixture>
    {

        private ContextFixture fixture;

        public ProductsControllerTests(ContextFixture contextFixture)
        {
            fixture = contextFixture;
        }

        [Fact]
        public void CanGetAllProducts()
        {
            var controller = new ProductsController(fixture.Db);

            var result = controller.Get() as OkObjectResult;

            Assert.IsType<OkObjectResult>(result);

        }

        [Fact]
        public void CanGetProduct()
        {
            var controller = new ProductsController(fixture.Db);

            var result = controller.Get(1);

            Assert.IsType<OkObjectResult>(result);

        }
    }
}