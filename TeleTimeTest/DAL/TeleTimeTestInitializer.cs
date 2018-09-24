using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeleTimeTest.Models;

namespace TeleTimeTest.DAL
{
    public class TeleTimeTestInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TeleTimeTestContext>
    {
        protected override void Seed(TeleTimeTestContext context)
        {
            var workYears = new List<WorkYear>
            {
                new WorkYear{ YearID=2018 }
            };

            workYears.ForEach(s => context.WorkYears.Add(s));
            context.SaveChanges();

            var workWeeks = new List<WorkWeek>();
            
            for (int w = 0; w < 52; w++) {
                WorkWeek workWeek = new WorkWeek { WeekNumberID = w + 1, YearID = 2018 };
                workWeeks.Add(workWeek);
            }
            

            workWeeks.ForEach(s => context.WorkWeeks.Add(s));
            context.SaveChanges();

            var date = new DateTime(2018, 1, 1);
            var workDays2 = new List<WorkDay>();
            var dayNumber = 0;

            for (int w = 0; w < 52; w++)
            {
                for (int i = 0; i < 7; i++)
                {
                    WorkDay day = new WorkDay() { DayID = dayNumber + 1, Date = date.AddDays(dayNumber), WeekNumberID = w + 1 };
                    workDays2.Add(day);
                    dayNumber++;
                }
            }
            

            workDays2.ForEach(s => context.WorkDays.Add(s));
            context.SaveChanges();
            
        }
    }
}