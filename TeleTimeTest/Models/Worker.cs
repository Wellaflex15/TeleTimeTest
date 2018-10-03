using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleTimeTest.Models
{
    public enum TypeOfRole
    {
        Storkund, Avtal, GuG
    }
    public class Worker
    {
        public int WorkerID { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public TypeOfRole? TypeOfRole { get; set; }

        public int ShiftID { get; set; }
        public virtual Shift Shift { get; set; }
        // ICollection<Shift> Shifts { get; set; }
    }
}