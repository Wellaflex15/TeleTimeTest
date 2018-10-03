using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeleTimeTest.Models;

namespace TeleTimeTest.DAL
{
    //public class TeleTimeTestInitializer : System.Data.Entity.DropCreateDatabaseAlways<TeleTimeTestContext>
    public class TeleTimeTestInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TeleTimeTestContext>
    {
        protected override void Seed(TeleTimeTestContext context)
        {
            // Creating dummy data to test out the database -> not sure if we will keep this. 
            // WORKYEAR
            var workYears = new List<WorkYear>
            {
                new WorkYear{ YearID=2018 }
            };

            workYears.ForEach(s => context.WorkYears.Add(s));
            context.SaveChanges();

            // WORKWEEK
            var workWeeks = new List<WorkWeek>();
            
            for (int w = 0; w < 52; w++) {
                WorkWeek workWeek = new WorkWeek { WeekNumberID = w + 1, YearID = 2018 };
                workWeeks.Add(workWeek);
            }
            
            workWeeks.ForEach(s => context.WorkWeeks.Add(s));
            context.SaveChanges();

            // WORKDAY
            var date = new DateTime(2018, 1, 1);
            var workDays = new List<WorkDay>();
            var random = new Random();
            var dayNumber = 0;

            for (int w = 0; w < 52; w++)
            {
                for (int i = 0; i < 7; i++)
                {
                    WorkDay day = new WorkDay() { DayID = dayNumber + 1, Date = date.AddDays(dayNumber), WeekNumberID = w + 1, WorkShiftID = random.Next(1, 3) };
                    workDays.Add(day);
                    dayNumber++;
                }
            }

            workDays.ForEach(s => context.WorkDays.Add(s));
            // context.SaveChanges();

            // WORKSHIFT
            //var workShifts = new List<WorkShift>
            //{
            //    new WorkShift { WorkShiftID = 1, ShiftName = "Regular", Shifts = new List<Shift>() },
            //    new WorkShift { WorkShiftID = 2, ShiftName = "Invoice", Shifts = new List<Shift>() }
            //};

            var workShift1 = new WorkShift { WorkShiftID = 1, ShiftName = "Regular", Shifts = new List<Shift>() };
            var workShift2 = new WorkShift { WorkShiftID = 2, ShiftName = "Invoice", Shifts = new List<Shift>() };

            // workShifts.ForEach(s => context.WorkShifts.Add(s));
            // context.SaveChanges();

            // SHIFTS
            //var shifts = new List<Shift>
            //{
            //    new Shift { ShiftID = 1, ShiftStart = 8, ShiftEnd = 12, NumberOfWorkers = 3, TypeOfShift = TypeOfShift.Front },
            //    new Shift { ShiftID = 2, ShiftStart = 12, ShiftEnd = 17, NumberOfWorkers = 3, TypeOfShift = TypeOfShift.Front },
            //    new Shift { ShiftID = 3, ShiftStart = 8, ShiftEnd = 17, NumberOfWorkers = 3, TypeOfShift = TypeOfShift.Back }
            //};

            var shift1 = new Shift { ShiftID = 1, ShiftStart = 8, ShiftEnd = 12, NumberOfWorkers = 3, TypeOfShift = TypeOfShift.Front };
            var shift2 = new Shift { ShiftID = 2, ShiftStart = 12, ShiftEnd = 17, NumberOfWorkers = 3, TypeOfShift = TypeOfShift.Front };
            var shift3 = new Shift { ShiftID = 3, ShiftStart = 8, ShiftEnd = 17, NumberOfWorkers = 3, TypeOfShift = TypeOfShift.Back };

            workShift1.Shifts.Add(shift1);
            workShift1.Shifts.Add(shift2);
            workShift1.Shifts.Add(shift3);

            workShift2.Shifts.Add(shift1);
            workShift2.Shifts.Add(shift2);
            workShift2.Shifts.Add(shift3);

            context.WorkShifts.Add(workShift1);
            context.WorkShifts.Add(workShift2);

            context.SaveChanges();

            // WORKER
            var workers = new List<Worker>
            {
                new Worker { WorkerID = 1, Name = "David Welin", EMail = "david@gmail.com", TypeOfRole = TypeOfRole.Avtal, ShiftID = 1 },
                new Worker { WorkerID = 2, Name = "Kalle Welin", EMail = "kalle@gmail.com", TypeOfRole = TypeOfRole.Avtal, ShiftID = 2 },
                new Worker { WorkerID = 3, Name = "Olle Welin", EMail = "olle@gmail.com", TypeOfRole = TypeOfRole.Avtal, ShiftID = 3 }
            };

            workers.ForEach(s => context.Workers.Add(s));
            context.SaveChanges();

        }
    }
}