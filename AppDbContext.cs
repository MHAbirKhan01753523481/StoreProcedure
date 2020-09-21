using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataBaseQuery.Models;

namespace DataBaseQuery.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<DataBaseQuery.Models.Orders> Orders { get; set; }
        public DbSet<DataBaseQuery.Models.Customer> Customer { get; set; }
       // public DbSet<DataBaseQuery.Models.spCustomer> sp_Customer { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Query<spCustomer>();
            modelBuilder.Query<CustomerList>();
        }

        public ICollection<spCustomer> GetCustomer()
        {
            return this.Query<spCustomer>().FromSql("sp_Customer").ToList();
        }

        public ICollection<CustomerList> GetCustomerList()
        {
            return this.Query<CustomerList>().FromSql("SpCustomerList").ToList();
        }
    }
}
