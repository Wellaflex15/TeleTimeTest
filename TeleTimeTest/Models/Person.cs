using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TeleTimeTest.Models
{
    public class Person
    {
        //Primary key
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }

        public int WorkShiftID { get; set; }
        public WorkShift WorkShift { get; set; }
    }
}