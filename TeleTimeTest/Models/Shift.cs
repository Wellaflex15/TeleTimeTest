﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleTimeTest.Models
{
    public enum TypeOfShift
    {
        Front, Back, CallBack
    }
    public class Shift
    {
        public int ShiftID { get; set; }
        public DateTime ShiftStart { get; set; }
        public DateTime ShiftEnd { get; set; }
        public int NumberOfWorkers { get; set; }
        public TypeOfShift? TypeOfShift { get; set; }

        public ICollection<WorkShift> WorkShifts { get; set; }
        public ICollection<Worker> Workers { get; set; }
    }
}