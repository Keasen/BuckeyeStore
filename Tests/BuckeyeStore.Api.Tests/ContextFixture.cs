using System;
using System.Linq;
using BuckeyeStore.Api.Data;
using BuckeyeStore.Core;
using Microsoft.EntityFrameworkCore;

namespace BuckeyeStore.Api.Tests
{
    public class ContextFixture : IDisposable
    {

        public ContextFixture()
        {
            InitializeContext();
        }

        public void Dispose()
        {
            Db = null;
        }

        public BuckeyeStoreContext Db { get; private set; }

        private void InitializeContext()
        {
            var builder = new DbContextOptionsBuilder<BuckeyeStoreContext>()
                .UseInMemoryDatabase();

            var context = new BuckeyeStoreContext(builder.Options);

            var products = Enumerable.Range(1, 10)
                .Select(i => new Product { Id = i, Name = $"T-Shirt{i}", Brand = "Nike" });

            context.Products.AddRange(products);

            int changed = context.SaveChanges();

            Db = context;
        }
    }
}