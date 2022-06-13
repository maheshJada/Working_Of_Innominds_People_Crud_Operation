

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Working_Of_Innominds_People_Crud_Operation.Models
{

    public class ApplicationContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options) : base(options)
        {

        }
        public DbSet<Employee> EmployeeTable { get; set; }
        public DbSet<It> ItTable { get; set; }
        public DbSet<Courier_To_The_Company> CourierTable { get; set; }
        public DbSet<Visitors> VisitorsTable { get; set; }
        public DbSet<Cafetaria> CafetariaTable { get; set; }
        public DbSet<SecuritySystemMaintanace> MaintanacesTable { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
           
        }
        //public class ApplicationContext:DbContext
        //{
        //    /// <summary>
        //    /// It is a ApplicationContext constructor 
        //    /// it is used for whenever object is created  then constructor is automatically invoked
        //    /// </summary>
        //    /// <param name="options"></param>
        //    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        //    {

        //    }
        //    #region It will have all the tables

        //    public DbSet<Employee> EmployeeTable { get; set; }
        //    public DbSet<It> ItTable { get; set; }
        //    public DbSet<Courier_To_The_Company> CourierTable { get; set; }
        //    public DbSet<Visitors> VisitorsTable { get; set; }
        //    public DbSet<Cafetaria> CafetariaTable { get; set; }
        //    public DbSet<SecuritySystemMaintanace> MaintanacesTable { get; set; }

        //    #endregion
        //}
    }
}
