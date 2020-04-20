using SPN.Auto.Web.InputModels.Automobile;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Auto.Web.ViewModels.Automobile
{
    public class AutomobileViewModel
    {
        public int Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Title { get; set; }

        public string Comment { get; set; }

        public string AutomobileSellerId { get; set; }

        public string AutomobileSellerName { get; set; }

        public CreateConciseInputModel PrimaryProperties { get; set; }

        public SafetyInputModel Safety { get; set; }

        public InteriorInputModel Interiors { get; set; }

        public InteriorMaterialInputModel InteriorMaterials { get; set; }

        public SuspensionInputModel Suspensions { get; set; }

        public ExtraFeaturesInputModel ExtraFeatures { get; set; }

        public SpecializedInputModel SpecializedFeatures { get; set; }

        public ImagesInputModel Images { get; set; }
    }
}
