using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleTimeTest.Models
{
    public class TypeOfShift
    {
        public int TypeOfShiftID { get; set; }
        public string ShiftName { get; set; }

        public int WorkShiftID { get; set; }
        public WorkShift WorkShift { get; set; }
    }
}