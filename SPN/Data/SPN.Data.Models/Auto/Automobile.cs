using SPN.Data.Common.Contracts;
using SPN.Data.Common.Models;
using SPN.Data.Models.Shared.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Data.Models.Auto
{
    public class Automobile : BaseEntity<int>, IDeletableEntity
    {
        public string Title { get; set; }

        public string Comment { get; set; }

        public virtual  User User { get; set; }
        public string UserId { get; set; }

        public virtual Make Make { get; set; }
        public int? MakeId { get; set; }

        public virtual Model Model { get; set; }
        public int? ModelId { get; set; }

        public virtual PrimaryProperties PrimaryProperties { get; set; }
        public int? PrimaryPropertiesId { get; set; }

        public virtual Safety Safety { get; set; }
        public int? SafetyId { get; set; }

        public virtual Interiors Interiors { get; set; }
        public int? InteriorsId { get; set; }

        public virtual InteriorMaterials InteriorMaterials { get; set; }
        public int? InteriorMaterialsId { get; set; }

        public virtual Suspensions Suspensions { get; set; }
        public int? SuspensionsId { get; set; }

        public virtual SpecializedFeatures SpecializedFeatures { get; set; }
        public int? SpecializedFeaturesId { get; set; }

        public virtual ExtraFeatures ExtraFeatures { get; set; }
        public int? ExtraFeaturesId { get; set; }

        public virtual Images Images { get; set; }
        public int ImagesId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
