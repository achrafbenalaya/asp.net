using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using projethch.Models;
using  projethch.EF;
namespace projethch.EF
{//byachraf and marwen

    public class Dal:DbContext
    {

        public  DbSet<Employee> employees { get; set; }
        public DbSet<User> users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Empa");
            modelBuilder.Entity<Employee>().HasKey(x => x.EmpaId);

            modelBuilder.Entity<User>().ToTable("user");
            modelBuilder.Entity<User>().HasKey(x => x.Id);

        }
    }
}