using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Eshop.Models;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Eshop.Context
{
    public class ProductsContext: DbContext
    {
        public ProductsContext() : base("ProductsContextDB")
        { }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product>Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}