using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SPN.Data.Models.Auto.Enums
{
    public enum Condition
    {
        New = 1,
        Used = 2,
        [Display(Name = "For parts")]
        ForParts = 3,
    }
}
