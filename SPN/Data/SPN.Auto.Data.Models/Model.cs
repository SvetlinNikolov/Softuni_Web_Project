using SPN.Auto.Data.Models.Enums;
using SPN.Data.Common.Contracts;
using SPN.Data.Common.Models;
using System;

namespace SPN.Auto.Data.Models
{
    public class Model : BaseEntity<int>, IDeletableEntity
    {
        public string Name { get; set; }

        //public DateTime Year { get; set; }

        //public int Horsepower { get; set; }

        //public Color Color { get; set; }

        //public Engine Engine { get; set; }

        //public GearBox GearBox { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
