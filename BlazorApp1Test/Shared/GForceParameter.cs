using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorApp1Test.Shared
{
    public class GForceParameter
    {
        [Key]
        public int Record_Id { get; set; }
        public string TailNumber { get; set; }
        public DateTime TimeInserted { get; set; }
        public float AccelX { get; set; }
        public float AccelY { get; set; }
        public float AccelZ { get; set; }
        public float Weight { get; set; }
        public DateTime TimeRecorded { get; set; }
    }
}
