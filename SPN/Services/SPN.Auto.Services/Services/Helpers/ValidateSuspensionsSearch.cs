using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Data.Models.Auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPN.Auto.Services.Services.Helpers
{
    public class ValidateSuspensionsSearch : IHelper
    {
        public IQueryable<Automobile> ValidateSearchProperties(MainSearchInputModel inputModel, IQueryable<Automobile> automobiles)
        {
            if (inputModel.Suspensions == null) return automobiles;

            var suspensions = inputModel.Suspensions;

            var ElectronicSuspensionControl = suspensions.ElectronicSuspensionControl.HasValue ? suspensions.ElectronicSuspensionControl : false;
            var AdaptiveAirSuspension = suspensions.AdaptiveAirSuspension.HasValue ? suspensions.AdaptiveAirSuspension : false;
            var LockingDifferential = suspensions.LockingDifferential.HasValue ? suspensions.LockingDifferential : false;
            var ActiveSuspension = suspensions.ActiveSuspension.HasValue ? suspensions.ActiveSuspension : false;

            if (ElectronicSuspensionControl == true)
            {
                automobiles = automobiles.Where(x => x.Suspensions.ElectronicSuspensionControl == true);
            }
            if (AdaptiveAirSuspension == true)
            {
                automobiles = automobiles.Where(x => x.Suspensions.AdaptiveAirSuspension == true);
            }
            if (LockingDifferential == true)
            {
                automobiles = automobiles.Where(x => x.Suspensions.LockingDifferential == true);
            }
            if (ActiveSuspension == true)
            {
                automobiles = automobiles.Where(x => x.Suspensions.ActiveSuspension == true);
            }

            return automobiles;
        }
    }
}
