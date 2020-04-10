using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SPN.Auto.Data.Models.Enums
{
    public enum Region
    {
        [Display(Name = "Greater London")]
        GreaterLondon = 1,
        [Display(Name = "South East")]
        SouthEast = 2,
        [Display(Name = "South West")]
        SouthWest = 3,
        [Display(Name = "West Midlands")]
        WestMidlands = 4,
        [Display(Name = "North West")]
        NorthWest = 5,
        [Display(Name = "North East")]
        NorthEast = 6,
        [Display(Name = "Yorkshire and the Humber")]
        YorkshireandtheHumber = 7,
        [Display(Name = "East Midlands")]
        EastMidlands = 8,
        [Display(Name = "East Anglia")]
        EastAnglia = 9
    }
}
