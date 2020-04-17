using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Data.Models.Auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPN.Auto.Services.Services.Helpers
{
    public class ValidateSpecializedFeaturesSearch : IHelper
    {
        public IQueryable<Automobile> ValidateSearchProperties(MainSearchInputModel inputModel, IQueryable<Automobile> automobiles)
        {
            if (inputModel.SpecializedFeatures == null) return automobiles;

            var specialized = inputModel.SpecializedFeatures;

            var DisabledAccessible = specialized.DisabledAccessible.HasValue ? specialized.DisabledAccessible : false;
            var Taxi = specialized.Taxi.HasValue ? specialized.Taxi : false;
            var Ambulance = specialized.Ambulance.HasValue ? specialized.Ambulance : false;

            var Hearse = specialized.Hearse.HasValue ? specialized.Hearse : false;
            var Learner = specialized.Learner.HasValue ? specialized.Learner : false;

            if (DisabledAccessible == true)
            {
                automobiles = automobiles.Where(x => x.SpecializedFeatures.DisabledAccessible == true);
            }
            if (Taxi == true)
            {
                automobiles = automobiles.Where(x => x.SpecializedFeatures.Taxi == true);
            }
            if (Ambulance == true)
            {
                automobiles = automobiles.Where(x => x.SpecializedFeatures.Ambulance == true);
            }
            if (Hearse == true)
            {
                automobiles = automobiles.Where(x => x.SpecializedFeatures.Hearse == true);
            }
            if (Learner == true)
            {
                automobiles = automobiles.Where(x => x.SpecializedFeatures.Learner == true);
            }

            return automobiles;
        }
    }
}
