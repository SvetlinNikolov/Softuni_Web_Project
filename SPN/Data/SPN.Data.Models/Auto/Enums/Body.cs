using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SPN.Data.Models.Auto.Enums
{
    public enum Body
    {
        Sedan = 1,
        Coupe = 2,
        Hatchback = 3,
        Minivan = 4,
        Pickup = 5,
        [Display(Name = "Station Wagon")]
        StationWagon = 6,
        Convertible = 7,
        SUV = 8
    }
}
