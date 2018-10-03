using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleTimeTest.Models
{
    public class WorkShift
    {
        public WorkShift()
        {
            this.Shifts = new HashSet<Shift>();
        }
        public int WorkShiftID { get; set; }
        public string ShiftName { get; set; }

        public ICollection<WorkDay> WorkDays { get; set; }

        public ICollection<Shift> Shifts { get; set; }
    }
}