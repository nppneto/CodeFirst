using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AplicacaoComCodeFirst.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext(): base("name=BlogContext")
        {
            Database.Connection.ConnectionString = 
                @"Server=DESKTOP-PF66N0S\SQLEXPRESS;
            Database=BlogBDLivro;
            User ID=sa;Password=codinome";
        }

        public DbSet<Posts> Posts { get; set; }

        public DbSet<Categorias> Categorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}