using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeleTimeTest.Models
{
    public class WorkShift
    {
        [Key]
        public int WorkShiftID { get; set; } // Can use unique name instead of number

        public List<WorkShiftName> WorkShiftNames { get; set; }

        public List<Person> Persons { get; set; }

        public List<Time> Times { get; set; }

        public List<TypeOfShift> TypeOfShifts { get; set; }
    }
}