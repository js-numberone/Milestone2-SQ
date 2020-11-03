using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1Test.Shared
{
    public class GForceParameter
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public double AccelX { get; set; }
        public double AccelY { get; set; }
        public double AccelZ { get; set; }
        public double Weight { get; set; }
    }
}
