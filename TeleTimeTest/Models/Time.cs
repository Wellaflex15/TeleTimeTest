using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleTimeTest.Models
{
    public class Time
    {
        public int TimeID { get; set; }
        public string StartEndTime { get; set; }

        public int WorkShiftID { get; set; }
        public WorkShift WorkShift { get; set; }
    }
}