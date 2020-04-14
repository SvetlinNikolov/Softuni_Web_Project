namespace SPN.Auto.Web.InputModels.Automobile
{
    public class MainSearchInputModel
    {
        public SearchConciseInputModel PrimaryProperties { get; set; }

        public SafetyInputModel Safety { get; set; }

        public InteriorInputModel Interiors { get; set; }

        public InteriorMaterialInputModel InteriorMaterials { get; set; }

        public SuspensionInputModel Suspensions { get; set; }

        public ExtraFeaturesInputModel ExtraFeatures { get; set; }

        public SpecializedInputModel SpecializedFeatures { get; set; }
    }
}
