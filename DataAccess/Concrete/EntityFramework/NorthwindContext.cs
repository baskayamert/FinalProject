using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : DB tabloları ile proje classlarını bağlamak
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }



        //----Farklı isimlendirilmiş objeler ve database entitytilerini eşleştirebilmek için kullanılan yöntem----

        //public DbSet<Staff> Staffs { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //fluent mapping
        //    //modelBuilder.HasDefaultSchema("admin");
        //    modelBuilder.Entity<Staff>().ToTable("Employees");

        //    modelBuilder.Entity<Staff>().Property(p => p.Id).HasColumnName("EmployeeID");
        //    modelBuilder.Entity<Staff>().Property(p => p.Name).HasColumnName("FirstName");
        //    modelBuilder.Entity<Staff>().Property(p => p.Surname).HasColumnName("LastName");

        //}
    }
}
