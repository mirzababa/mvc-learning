using CodeFirst1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst1.DAL
{
    public class MachineContext : DbContext
    {
        public MachineContext() : base("MachineContext")
        {
        }

        public DbSet<Machine> Machines { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Machine.Mapping());
        }
    }
}