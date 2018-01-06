using ShopProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShopProject.Web.DataContexts
{
    public class DataContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ShopSchedule> ShopSchedules { get; set; }
    }
}