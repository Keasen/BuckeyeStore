using System;
using Xunit;
using BuckeyeStore.Api.Controllers;
using BuckeyeStore.Api.Data;
using Microsoft.AspNetCore.Mvc;
using BuckeyeStore.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BuckeyeStore.Api.Tests
{
    public class ProductsControllerTests
    {
        private BuckeyeStoreContext db;

        public ProductsControllerTests()
        {
            InitializeContext();
        }

        private void InitializeContext()
        {
            var builder = new DbContextOptionsBuilder<BuckeyeStoreContext>();

            var context = new BuckeyeStoreContext(builder.Options);
            var products = Enumerable.Range(1, 10)
                .Select(i => new Product { Id = i, Name = $"T-Shirt{i}", Brand = "Nike" });
            context.Products.AddRange(products);
            int changed = context.SaveChanges();
            db = context;
        }

        [Fact]
        public void CanGetAllProducts()
        {
            var controller = new ProductsController(db);
            var result = controller.Get();
            Assert.NotNull(result);

        }
    }
}