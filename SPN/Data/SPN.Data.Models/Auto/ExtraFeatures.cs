using SPN.Data.Common.Contracts;
using SPN.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SPN.Data.Models.Auto
{

    public class ExtraFeatures : BaseEntity<int>, IDeletableEntity
    {


        public bool? KeylessEntry { get; set; }

        public bool? KeylessIgnition { get; set; }

        public bool? LowGear { get; set; }

        public bool? PanoramicRoof { get; set; }

        public bool? RoofRack { get; set; }

        public bool? ElectricTailgate { get; set; }

        public bool? LongBase { get; set; }

        public bool? ShortBase { get; set; }

        public bool? Registered { get; set; }

        public bool? MOT { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
