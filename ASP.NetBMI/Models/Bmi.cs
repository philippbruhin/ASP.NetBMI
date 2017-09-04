using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ASP.NetBMI.Models
{
    public class Bmi
    {
        [Display(Name = "Weight in kg")]
        public double Weight { get; set; }

        [Display(Name = "Height in cm")]
        public double Height { get; set; }
    }
}
