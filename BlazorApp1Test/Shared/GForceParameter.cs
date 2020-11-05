using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorApp1Test.Shared
{
    public class GForceParameter
    {
        [Key]
        public int RecordID { get; set; }
        public string TailNumber { get; set; }
        public DateTime TimeInserted { get; set; }
        public double AccelX { get; set; }
        public double AccelY { get; set; }
        public double AccelZ { get; set; }
        public double Weight { get; set; }
        public DateTime TimeRecorded { get; set; }
    }
}
