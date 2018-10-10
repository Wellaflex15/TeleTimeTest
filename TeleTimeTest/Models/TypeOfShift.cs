using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeleTimeTest.Models
{
    public class TypeOfShift
    {
        [Key]
        public string ShiftName { get; set; }

        public List<WorkShift> WorkShifts { get; set; }
    }
}