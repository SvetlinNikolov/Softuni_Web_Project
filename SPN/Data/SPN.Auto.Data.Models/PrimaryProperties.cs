using SPN.Auto.Data.Models.Enums;
using SPN.Data.Common.Contracts;
using SPN.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SPN.Auto.Data.Models
{

    public class PrimaryProperties :BaseEntity<int>, IDeletableEntity
    {
        public int Price { get; set; }

        public DateTime Year { get; set; }

        public int Horsepower { get; set; }

        public Engine Engine { get; set; }

        public GearBox GearBox { get; set; }

        public Condition Condition { get; set; }

        public Body? Body { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}



