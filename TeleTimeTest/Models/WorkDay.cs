using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TeleTimeTest.Models
{
    public class WorkDay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DayID { get; set; }
        public DateTime Date { get; set; }
        
        public int WeekNumberID { get; set; }
        public virtual WorkWeek WorkWeek { get; set; }

        public int? WorkShiftID { get; set; }
        public virtual WorkShift WorkShift { get; set; }
    }
}