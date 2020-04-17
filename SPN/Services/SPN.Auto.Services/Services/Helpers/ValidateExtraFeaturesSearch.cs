using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Data.Models.Auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPN.Auto.Services.Services.Helpers
{
    public  class ValidateExtraFeaturesSearch : IHelper
    {
        public  IQueryable<Automobile> ValidateSearchProperties(MainSearchInputModel inputModel, IQueryable<Automobile> automobiles)
        {
            if (inputModel.ExtraFeatures == null) return automobiles;

            var extraFeatures = inputModel.ExtraFeatures;

            var KeylessEntry = extraFeatures.KeylessEntry.HasValue ? extraFeatures.KeylessEntry : false;
            var KeylessIgnition = extraFeatures.KeylessIgnition.HasValue ? extraFeatures.KeylessIgnition : false;
            var LowGear = extraFeatures.LowGear.HasValue ? extraFeatures.LowGear : false;
            var PanoramicRoof = extraFeatures.PanoramicRoof.HasValue ? extraFeatures.PanoramicRoof : false;
            var RoofRack = extraFeatures.RoofRack.HasValue ? extraFeatures.RoofRack : false;

            var ElectricTailgate = extraFeatures.ElectricTailgate.HasValue ? extraFeatures.ElectricTailgate : false;
            var LongBase = extraFeatures.LongBase.HasValue ? extraFeatures.LongBase : false;
            var ShortBase = extraFeatures.ShortBase.HasValue ? extraFeatures.ShortBase : false;
            var Registered = extraFeatures.Registered.HasValue ? extraFeatures.Registered : false;
            var MOT = extraFeatures.MOT.HasValue ? extraFeatures.MOT : false;

            if (KeylessEntry == true)
            {
                automobiles = automobiles.Where(x => x.ExtraFeatures.KeylessEntry == true);
            }
            if (KeylessIgnition == true)
            {
                automobiles = automobiles.Where(x => x.ExtraFeatures.KeylessIgnition == true);
            }
            if (LowGear == true)
            {
                automobiles = automobiles.Where(x => x.ExtraFeatures.LowGear == true);
            }
            if (PanoramicRoof == true)
            {
                automobiles = automobiles.Where(x => x.ExtraFeatures.PanoramicRoof == true);
            }
            if (RoofRack == true)
            {
                automobiles = automobiles.Where(x => x.ExtraFeatures.RoofRack == true);
            }
            if (ElectricTailgate == true)
            {
                automobiles = automobiles.Where(x => x.ExtraFeatures.ElectricTailgate == true);
            }
            if (LongBase == true)
            {
                automobiles = automobiles.Where(x => x.ExtraFeatures.LongBase == true);
            }
            if (ShortBase == true)
            {
                automobiles = automobiles.Where(x => x.ExtraFeatures.ShortBase == true);
            }
            if (Registered == true)
            {
                automobiles = automobiles.Where(x => x.ExtraFeatures.Registered == true);
            }
            if (MOT == true)
            {
                automobiles = automobiles.Where(x => x.ExtraFeatures.MOT == true);
            }

            return automobiles;

        }
    }
}
