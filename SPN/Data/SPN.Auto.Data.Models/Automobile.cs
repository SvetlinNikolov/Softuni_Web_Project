using SPN.Data.Common.Contracts;
using SPN.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Auto.Data.Models
{
    public class Automobile : BaseEntity<int>, IDeletableEntity
    {
        public int MakeId { get; set; }
        public Make Make { get; set; }

        public int ModelId { get; set; }
        public Model Model { get; set; }

        public PrimaryProperties PrimaryProperties { get; set; }
        public int PrimaryPropertiesId { get; set; }

        public Safety Safety { get; set; }
        public int SafetyId { get; set; }

        public Interiors Interiors { get; set; }
        public int InteriorsId { get; set; }

        public InteriorMaterials InteriorMaterials { get; set; }
        public int InteriorMaterialsId { get; set; }

        public Suspensions Suspensions { get; set; }
        public int SuspensionsId { get; set; }

        public SpecializedFeatures SpecializedFeatures { get; set; }
        public int SpecializedFeaturesId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
