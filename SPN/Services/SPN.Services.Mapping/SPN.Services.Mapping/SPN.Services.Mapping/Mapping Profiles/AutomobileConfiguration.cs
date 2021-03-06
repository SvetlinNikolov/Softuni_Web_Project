﻿using AutoMapper;
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



            this.CreateMap<Automobile, AutomobileViewModel>()
                .ForMember(x => x.AutomobileSellerId, y => y.MapFrom(z => z.UserId))
                .ForMember(x => x.AutomobileSellerName, y => y.MapFrom(z => z.User.UserName))
                .ForMember(x => x.Images, y => y.Ignore());

            this.CreateMap<Automobile, EditAutomobileInputModel>()
                .ForMember(x => x.Images, y => y.Ignore());

            this.CreateMap<EditAutomobileInputModel, Automobile>();

            this.CreateMap<PrimaryProperties, CreateConciseInputModel>();
            this.CreateMap<Safety, SafetyInputModel>();
            this.CreateMap<Interiors, InteriorInputModel>();
            this.CreateMap<InteriorMaterials, InteriorMaterialInputModel>();
            this.CreateMap<Suspensions, SuspensionInputModel>();
            this.CreateMap<ExtraFeatures, ExtraFeaturesInputModel>();
            this.CreateMap<SpecializedFeatures, SpecializedInputModel>();

            this.CreateMap<SearchConciseInputModel, PrimaryProperties>();
            this.CreateMap<SafetyInputModel, Safety>();
            this.CreateMap<InteriorInputModel, Interiors>();
            this.CreateMap<InteriorMaterialInputModel, InteriorMaterials>();
            this.CreateMap<SuspensionInputModel, Suspensions>();
            this.CreateMap<ExtraFeaturesInputModel, ExtraFeatures>();
            this.CreateMap<SpecializedInputModel, SpecializedFeatures>();


            this.CreateMap<ImagesInputModel, Images>();

            this.CreateMap<Make, MakeConciseViewModel>();
            this.CreateMap<Model, ModelConciseViewModel>();
        }
    }
}
