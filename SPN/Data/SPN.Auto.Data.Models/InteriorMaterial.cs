using SPN.Data.Common.Contracts;
using SPN.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SPN.Auto.Data.Models
{
  
    public class InteriorMaterials:BaseEntity<int>,IDeletableEntity
    {
      

        public bool? LeatherSteeringWheel { get; set; }

        public bool? LeatherSeats { get; set; }

        public bool? ClothSeats { get; set; }

        public bool? Alcantara { get; set; }

        public bool? Velour { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
