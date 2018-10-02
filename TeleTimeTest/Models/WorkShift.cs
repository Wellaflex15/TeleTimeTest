using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleTimeTest.Models
{
    public class WorkShift
    {
        public int WorkShiftID { get; set; }
        public string ShiftName { get; set; }
        
        public ICollection<WorkDay> WorkDays { get; set; }

        public ICollection<Shift> Shifts { get; set; }
    }
}