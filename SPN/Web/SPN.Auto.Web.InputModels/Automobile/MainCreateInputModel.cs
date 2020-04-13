using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Auto.Web.InputModels.Automobile
{
    public class MainCreateInputModel
    {
        public CreateConciseInputModel Main { get; set; }

        public SafetyInputModel Safety { get; set; }

        public InteriorInputModel Interior { get; set; }

        public InteriorMaterialInputModel InteriorMaterial { get; set; }

        public SuspensionInputModel Suspension { get; set; }

        public ExtraFeaturesInputModel Extra { get; set; }

        public SpecializedInputModel Specialized { get; set; }
    }
}
