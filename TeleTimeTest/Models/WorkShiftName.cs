using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleTimeTest.Models
{
    public class WorkShiftName
    {
        public int WorkShiftNameID { get; set; }
        public string Name { get; set; }

        public int WorkShiftID { get; set; }
        public WorkShift WorkShift { get; set; }
    }
}