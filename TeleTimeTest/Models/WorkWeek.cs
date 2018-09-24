using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TeleTimeTest.Models
{
    public class WorkWeek
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WeekNumberID { get; set; }

        public int YearID { get; set; }
        public virtual WorkYear WorkYear { get; set;}

        public virtual ICollection<WorkDay> WorkDays { get; set; }
    }
}