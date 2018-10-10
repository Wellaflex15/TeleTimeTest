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

        public DbSet<Person> Persons { get; set; }
        public DbSet<Time> Times { get; set; }
        public DbSet<TypeOfShift> TypeOfShifts { get; set; }
        public DbSet<WorkShift> WorkShifts { get; set; }
        public DbSet<WorkShiftName> WorkShiftNames { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<WorkShift>()
            //    .HasMany<Shift>(s => s.Shifts)
            //    .WithMany(c => c.WorkShifts)
            //    .Map(cs =>
            //            {
            //                cs.MapLeftKey("WorkShiftRefId");
            //                cs.MapRightKey("ShiftRefId");
            //                cs.ToTable("WorkShiftShift");
            //            });
        }
    }
}