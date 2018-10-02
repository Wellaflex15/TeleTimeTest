using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeleTimeTest.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TeleTimeTest.DAL
{
    public class TeleTimeTestContext : DbContext
    {
        public TeleTimeTestContext() : base("TeleTimeTestContext")
        {

        }

        public DbSet<WorkYear> WorkYears { get; set; }
        public DbSet<WorkWeek> WorkWeeks { get; set; }
        public DbSet<WorkDay> WorkDays { get; set; }
        public DbSet<WorkShift> WorkShifts { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Worker> Workers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}