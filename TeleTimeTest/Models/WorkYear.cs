using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TeleTimeTest.Models
{
    public class WorkYear
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int YearID { get; set; }

        public virtual ICollection<WorkWeek> WorkWeeks { get; set; }
    }
}