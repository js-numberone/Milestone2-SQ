using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorApp1Test.Shared
{
    public class AttitudeParamater
    {
        [Key]
        public int GForceID { get; set; }
        public float Altitude { get; set; }
        public float Pitch { get; set; }
        public float Bank { get; set; }
    }
}
