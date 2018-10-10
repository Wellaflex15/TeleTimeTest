using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeleTimeTest.Models
{
    public class WorkShiftName
    {
        [Key]
        public string WorkShiftNameName { get; set; }

        public List<WorkShift> WorkShifts { get; set; }
    }
}