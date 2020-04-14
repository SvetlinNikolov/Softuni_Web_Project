using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SPN.Auto.Web.InputModels.Automobile
{
    public class MainCreateInputModel

    {
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
