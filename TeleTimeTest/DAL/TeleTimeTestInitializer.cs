using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeleTimeTest.Models;

namespace TeleTimeTest.DAL
{
    //public class TeleTimeTestInitializer : System.Data.Entity.DropCreateDatabaseAlways<TeleTimeTestContext>
    public class TeleTimeTestInitializer : System.Data.Entity.DropCreateDatabaseAlways<TeleTimeTestContext>
    {
        protected override void Seed(TeleTimeTestContext context)
        {
            // Creating dummy data to test out the database -> not sure if we will keep this. 

            var workShift = new List<WorkShift>
            {
                new WorkShift{ WorkShiftID = 1 },
                new WorkShift{ WorkShiftID = 2 }
                
                //new WorkShift{ WorkShiftNameID=1, TimeID=1, TypeOfShiftID=1, PersonID=1 },
                //new WorkShift{ WorkShiftNameID=1, TimeID=1, TypeOfShiftID=2, PersonID=2 },
                //new WorkShift{ WorkShiftNameID=1, TimeID=1, TypeOfShiftID=3, PersonID=3 },
                //new WorkShift{ WorkShiftNameID=1, TimeID=2, TypeOfShiftID=1, PersonID=4 },
                //new WorkShift{ WorkShiftNameID=1, TimeID=2, TypeOfShiftID=2, PersonID=5 },
                //new WorkShift{ WorkShiftNameID=1, TimeID=2, TypeOfShiftID=3, PersonID=6 }
                 
                //new WorkShift{ WorkShiftID=2, WorkShiftNameID=2, TimeID=2, TypeOfShiftID=3, PersonID=6, },
                //new WorkShift{ WorkShiftID=2, WorkShiftNameID=2, TimeID=2, TypeOfShiftID=2, PersonID=5, },
                //new WorkShift{ WorkShiftID=2, WorkShiftNameID=2, TimeID=2, TypeOfShiftID=1, PersonID=4, },
                //new WorkShift{ WorkShiftID=2, WorkShiftNameID=2, TimeID=1, TypeOfShiftID=3, PersonID=3, },
                //new WorkShift{ WorkShiftID=2, WorkShiftNameID=2, TimeID=1, TypeOfShiftID=2, PersonID=2, },
                //new WorkShift{ WorkShiftID=2, WorkShiftNameID=2, TimeID=1, TypeOfShiftID=1, PersonID=1, }
            };

            workShift.ForEach(s => context.WorkShifts.Add(s));

            // TIME
            var times = new List<Time>
            {
                new Time { StartEndTime = "08-12", WorkShiftID = context.WorkShifts.Find(1).WorkShiftID },
                new Time { StartEndTime = "08-12", WorkShiftID = context.WorkShifts.Find(1).WorkShiftID },
                new Time { StartEndTime = "08-12", WorkShiftID = context.WorkShifts.Find(1).WorkShiftID },
                new Time { StartEndTime = "12-17", WorkShiftID = context.WorkShifts.Find(1).WorkShiftID },
                new Time { StartEndTime = "12-17", WorkShiftID = context.WorkShifts.Find(1).WorkShiftID },
                new Time { StartEndTime = "12-17", WorkShiftID = context.WorkShifts.Find(1).WorkShiftID }
            };

            times.ForEach(s => context.Times.Add(s));

            // TYPEOFSHIFT
            var typeOfShifts = new List<TypeOfShift>
            {
                new TypeOfShift { ShiftName = "Front", WorkShiftID = context.WorkShifts.Find(1).WorkShiftID },
                new TypeOfShift { ShiftName = "Back", WorkShiftID = context.WorkShifts.Find(1).WorkShiftID },
                new TypeOfShift { ShiftName = "CallBack", WorkShiftID = context.WorkShifts.Find(1).WorkShiftID },
                new TypeOfShift { ShiftName = "Front", WorkShiftID = context.WorkShifts.Find(1).WorkShiftID },
                new TypeOfShift { ShiftName = "Back", WorkShiftID = context.WorkShifts.Find(1).WorkShiftID },
                new TypeOfShift { ShiftName = "CallBack", WorkShiftID = context.WorkShifts.Find(1).WorkShiftID }
            };

            typeOfShifts.ForEach(s => context.TypeOfShifts.Add(s));

            // PERSON
            var persons = new List<Person>
            {
                new Person { Name = "David Welin", EMail = "david@mail.com", WorkShiftID = context.WorkShifts.Find(1).WorkShiftID },
                new Person { Name = "Pelle Anka", EMail = "pelle@mail.com", WorkShiftID = context.WorkShifts.Find(1).WorkShiftID },
                new Person { Name = "Kalle Kråka", EMail = "kalle@mail.com", WorkShiftID = context.WorkShifts.Find(1).WorkShiftID },
                new Person { Name = "Nisse Naprapat", EMail = "nisse@mail.com", WorkShiftID = context.WorkShifts.Find(1).WorkShiftID },
                new Person { Name = "Rille Rille", EMail = "rille@mail.com", WorkShiftID = context.WorkShifts.Find(1).WorkShiftID },
                new Person { Name = "Olle Olsson", EMail = "olle@mail.com", WorkShiftID = context.WorkShifts.Find(1).WorkShiftID }
            };

            persons.ForEach(s => context.Persons.Add(s));

            var workShiftNames = new List<WorkShiftName>
            {
                new WorkShiftName { Name = "Standard", WorkShiftID = context.WorkShifts.Find(1).WorkShiftID }
            };

            workShiftNames.ForEach(s => context.WorkShiftNames.Add(s));

            

            // WORKER
            //var workers = new List<Worker>
            //{
            //    new Worker { WorkerID = 1, Name = "David Welin", EMail = "david@gmail.com", TypeOfRole = TypeOfRole.Avtal, ShiftID = 1 },
            //    new Worker { WorkerID = 2, Name = "Kalle Welin", EMail = "kalle@gmail.com", TypeOfRole = TypeOfRole.Avtal, ShiftID = 2 },
            //    new Worker { WorkerID = 3, Name = "Olle Welin", EMail = "olle@gmail.com", TypeOfRole = TypeOfRole.Avtal, ShiftID = 3 }
            //};

            //workers.ForEach(s => context.Workers.Add(s));
            //context.SaveChanges();

        }
    }
}