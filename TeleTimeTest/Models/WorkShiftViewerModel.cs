using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleTimeTest.Models
{
    public class WorkShiftViewerModel
    {
        public virtual ICollection<WorkShift> WorkShifts { get; set; }
        public virtual ICollection<WorkShiftName> WorkShiftNames { get; set; }
        public virtual ICollection<Time> Times { get; set; }
        public virtual ICollection<TypeOfShift> TypeOfShifts{ get; set; }
        public virtual ICollection<Person> Persons { get; set; }
    }
}