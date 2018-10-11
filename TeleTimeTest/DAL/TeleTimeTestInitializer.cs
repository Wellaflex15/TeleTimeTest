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

            

            // TIME
            var times = new List<Time>
            {
                new Time { StartEndTime = "08-12" },
                new Time { StartEndTime = "12-17" }
            };

            times.ForEach(s => context.Times.Add(s));

            // TYPEOFSHIFT
            var typeOfShifts = new List<TypeOfShift>
            {
                new TypeOfShift { ShiftName = "Front" },
                new TypeOfShift { ShiftName = "Back" },
                new TypeOfShift { ShiftName = "CallBack" },
            };

            typeOfShifts.ForEach(s => context.TypeOfShifts.Add(s));

            // PERSON
            var persons = new List<Person>
            {
                new Person { Name = "David Welin", EMail = "david@mail.com" },
                new Person { Name = "Pelle Anka", EMail = "pelle@mail.com" },
                new Person { Name = "Kalle Kråka", EMail = "kalle@mail.com" },
                new Person { Name = "Nisse Naprapat", EMail = "nisse@mail.com" },
                new Person { Name = "Rille Rille", EMail = "rille@mail.com" },
                new Person { Name = "Olle Olsson", EMail = "olle@mail.com" }
            };

            persons.ForEach(s => context.Persons.Add(s));

            // WORKSHIFTNAME
            var workShiftNames = new List<WorkShiftName>
            {
                new WorkShiftName { WorkShiftNameName = "Standard" },
                new WorkShiftName { WorkShiftNameName = "Legend" }
            };

            workShiftNames.ForEach(s => context.WorkShiftNames.Add(s));

            //WORKDAY

            DateTime date = DateTime.Now;

            var workDays = new List<WorkDay>
            {
                new WorkDay { Date = date.DayOfYear },
                new WorkDay { Date = date.DayOfYear+1 },
                new WorkDay { Date = date.DayOfYear+2 }
            };

            workDays.ForEach(s => context.WorkDays.Add(s));

            DateTime toDay = DateTime.Now;
            int toDayNumber = toDay.DayOfYear;

            var workShift = new List<WorkShift>
            {
                // Idag
                new WorkShift{
                    WorkShiftNameName = context.WorkShiftNames.Find("Standard").WorkShiftNameName,
                    StartEndTime = context.Times.Find("08-12").StartEndTime,
                    ShiftName = context.TypeOfShifts.Find("Front").ShiftName,
                    Name = context.Persons.Find("David Welin").Name,
                    Date = context.WorkDays.Find(toDayNumber).Date },
                new WorkShift{
                    WorkShiftNameName = context.WorkShiftNames.Find("Standard").WorkShiftNameName,
                    StartEndTime = context.Times.Find("08-12").StartEndTime,
                    ShiftName = context.TypeOfShifts.Find("Back").ShiftName,
                    Name = context.Persons.Find("Pelle Anka").Name, 
                    Date = context.WorkDays.Find(toDayNumber).Date },
                new WorkShift{
                    WorkShiftNameName = context.WorkShiftNames.Find("Standard").WorkShiftNameName,
                    StartEndTime = context.Times.Find("08-12").StartEndTime,
                    ShiftName = context.TypeOfShifts.Find("CallBack").ShiftName,
                    Name = context.Persons.Find("Kalle Kråka").Name,
                    Date = context.WorkDays.Find(toDayNumber).Date },
                new WorkShift{
                    WorkShiftNameName = context.WorkShiftNames.Find("Standard").WorkShiftNameName,
                    StartEndTime = context.Times.Find("12-17").StartEndTime,
                    ShiftName = context.TypeOfShifts.Find("Front").ShiftName,
                    Name = context.Persons.Find("Nisse Naprapat").Name,
                    Date = context.WorkDays.Find(toDayNumber).Date },
                new WorkShift{
                    WorkShiftNameName = context.WorkShiftNames.Find("Standard").WorkShiftNameName,
                    StartEndTime = context.Times.Find("12-17").StartEndTime,
                    ShiftName = context.TypeOfShifts.Find("Back").ShiftName,
                    Name = context.Persons.Find("Rille Rille").Name,
                    Date = context.WorkDays.Find(toDayNumber).Date },
                new WorkShift{
                    WorkShiftNameName = context.WorkShiftNames.Find("Standard").WorkShiftNameName,
                    StartEndTime = context.Times.Find("12-17").StartEndTime,
                    ShiftName = context.TypeOfShifts.Find("CallBack").ShiftName,
                    Name = context.Persons.Find("Olle Olsson").Name,
                    Date = context.WorkDays.Find(toDayNumber).Date },
                // Imorgon
                new WorkShift{
                    WorkShiftNameName = context.WorkShiftNames.Find("Legend").WorkShiftNameName,
                    StartEndTime = context.Times.Find("08-12").StartEndTime,
                    ShiftName = context.TypeOfShifts.Find("Front").ShiftName,
                    Name = context.Persons.Find("Olle Olsson").Name,
                    Date = context.WorkDays.Find(toDayNumber+1).Date },
                new WorkShift{
                    WorkShiftNameName = context.WorkShiftNames.Find("Legend").WorkShiftNameName,
                    StartEndTime = context.Times.Find("08-12").StartEndTime,
                    ShiftName = context.TypeOfShifts.Find("Back").ShiftName,
                    Name = context.Persons.Find("Nisse Naprapat").Name,
                    Date = context.WorkDays.Find(toDayNumber+1).Date },
                new WorkShift{
                    WorkShiftNameName = context.WorkShiftNames.Find("Legend").WorkShiftNameName,
                    StartEndTime = context.Times.Find("08-12").StartEndTime,
                    ShiftName = context.TypeOfShifts.Find("CallBack").ShiftName,
                    Name = context.Persons.Find("Kalle Kråka").Name,
                    Date = context.WorkDays.Find(toDayNumber+1).Date },
                new WorkShift{
                    WorkShiftNameName = context.WorkShiftNames.Find("Legend").WorkShiftNameName,
                    StartEndTime = context.Times.Find("12-17").StartEndTime,
                    ShiftName = context.TypeOfShifts.Find("Front").ShiftName,
                    Name = context.Persons.Find("Pelle Anka").Name,
                    Date = context.WorkDays.Find(toDayNumber+1).Date },
                new WorkShift{
                    WorkShiftNameName = context.WorkShiftNames.Find("Legend").WorkShiftNameName,
                    StartEndTime = context.Times.Find("12-17").StartEndTime,
                    ShiftName = context.TypeOfShifts.Find("Back").ShiftName,
                    Name = context.Persons.Find("David Welin").Name,
                    Date = context.WorkDays.Find(toDayNumber+1).Date },
                new WorkShift{
                    WorkShiftNameName = context.WorkShiftNames.Find("Legend").WorkShiftNameName,
                    StartEndTime = context.Times.Find("12-17").StartEndTime,
                    ShiftName = context.TypeOfShifts.Find("CallBack").ShiftName,
                    Name = context.Persons.Find("David Welin").Name,
                    Date = context.WorkDays.Find(toDayNumber+1).Date },
                // Övermorgon
                new WorkShift{
                    WorkShiftNameName = context.WorkShiftNames.Find("Legend").WorkShiftNameName,
                    StartEndTime = context.Times.Find("08-12").StartEndTime,
                    ShiftName = context.TypeOfShifts.Find("Front").ShiftName,
                    Name = context.Persons.Find("Olle Olsson").Name,
                    Date = context.WorkDays.Find(toDayNumber+2).Date },
                new WorkShift{
                    WorkShiftNameName = context.WorkShiftNames.Find("Legend").WorkShiftNameName,
                    StartEndTime = context.Times.Find("08-12").StartEndTime,
                    ShiftName = context.TypeOfShifts.Find("Back").ShiftName,
                    Name = context.Persons.Find("Nisse Naprapat").Name,
                    Date = context.WorkDays.Find(toDayNumber+2).Date },
                new WorkShift{
                    WorkShiftNameName = context.WorkShiftNames.Find("Legend").WorkShiftNameName,
                    StartEndTime = context.Times.Find("08-12").StartEndTime,
                    ShiftName = context.TypeOfShifts.Find("CallBack").ShiftName,
                    Name = context.Persons.Find("Kalle Kråka").Name,
                    Date = context.WorkDays.Find(toDayNumber+2).Date },
                new WorkShift{
                    WorkShiftNameName = context.WorkShiftNames.Find("Legend").WorkShiftNameName,
                    StartEndTime = context.Times.Find("12-17").StartEndTime,
                    ShiftName = context.TypeOfShifts.Find("Front").ShiftName,
                    Name = context.Persons.Find("Pelle Anka").Name,
                    Date = context.WorkDays.Find(toDayNumber+2).Date },
                new WorkShift{
                    WorkShiftNameName = context.WorkShiftNames.Find("Legend").WorkShiftNameName,
                    StartEndTime = context.Times.Find("12-17").StartEndTime,
                    ShiftName = context.TypeOfShifts.Find("Back").ShiftName,
                    Name = context.Persons.Find("David Welin").Name,
                    Date = context.WorkDays.Find(toDayNumber+2).Date },
                new WorkShift{
                    WorkShiftNameName = context.WorkShiftNames.Find("Legend").WorkShiftNameName,
                    StartEndTime = context.Times.Find("12-17").StartEndTime,
                    ShiftName = context.TypeOfShifts.Find("CallBack").ShiftName,
                    Name = context.Persons.Find("David Welin").Name,
                    Date = context.WorkDays.Find(toDayNumber+2).Date },
                 
                //new WorkShift{ WorkShiftID=2, WorkShiftNameID=2, TimeID=2, TypeOfShiftID=3, PersonID=6, },
                //new WorkShift{ WorkShiftID=2, WorkShiftNameID=2, TimeID=2, TypeOfShiftID=2, PersonID=5, },
                //new WorkShift{ WorkShiftID=2, WorkShiftNameID=2, TimeID=2, TypeOfShiftID=1, PersonID=4, },
                //new WorkShift{ WorkShiftID=2, WorkShiftNameID=2, TimeID=1, TypeOfShiftID=3, PersonID=3, },
                //new WorkShift{ WorkShiftID=2, WorkShiftNameID=2, TimeID=1, TypeOfShiftID=2, PersonID=2, },
                //new WorkShift{ WorkShiftID=2, WorkShiftNameID=2, TimeID=1, TypeOfShiftID=1, PersonID=1, }
            };

            workShift.ForEach(s => context.WorkShifts.Add(s));

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