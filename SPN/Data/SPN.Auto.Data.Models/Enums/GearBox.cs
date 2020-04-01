using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SPN.Auto.Data.Models.Enums
{
    public enum GearBox
    {
        Manual = 1,
        Automatic = 2,
        [Display(Name = "Semi Automatic")]
        SemiAutomatic
    }
}
