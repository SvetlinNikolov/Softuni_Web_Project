using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SPN.Auto.Data.Models.Enums
{
    public enum Engine
    {
        Other = 0,
        Petrol = 1,
        Diesel = 2,
        Electric = 3,
        Hybrid = 4,
        LPG = 5,
        Hydrogen = 6,
        [Display(Name = "Natural Gas")]
        NaturalGas = 7,

    }
}
