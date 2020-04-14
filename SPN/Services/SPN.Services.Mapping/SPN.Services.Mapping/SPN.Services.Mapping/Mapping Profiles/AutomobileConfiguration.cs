using AutoMapper;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Auto.Web.ViewModels.Automobile;
using SPN.Auto.Web.ViewModels.Make;
using SPN.Auto.Web.ViewModels.Model;
using SPN.Data.Models.Auto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Auto.Services.Mapping.MappingProfiles
{
    public class AutomobileConfiguration : Profile
    {
        public AutomobileConfiguration()
        {
            this.CreateMap<MainCreateInputModel, Automobile>();
            this.CreateMap<CreateConciseInputModel, PrimaryProperties>();
            this.CreateMap<ExtraFeaturesInputModel, ExtraFeatures>();
            this.CreateMap<InteriorInputModel, Interiors>();
            this.CreateMap<InteriorMaterialInputModel, InteriorMaterials>();
            this.CreateMap<SafetyInputModel, Safety>();
            this.CreateMap<SpecializedInputModel, SpecializedFeatures>();
            this.CreateMap<SuspensionInputModel, Suspensions>();
            this.CreateMap<ImagesInputModel, Images>();
            this.CreateMap<Automobile, AutomobileViewModel>();

            this.CreateMap<Make, MakeConciseViewModel>();
            this.CreateMap<Model, ModelConciseViewModel>();
        }
    }
}
