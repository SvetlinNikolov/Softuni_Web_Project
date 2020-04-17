using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Data.Models.Auto;
using System;
using System.Linq;

namespace SPN.Auto.Services.Services.Helpers
{
    public class ValidateInteriorSearch : IHelper
    {
        public IQueryable<Automobile> ValidateSearchProperties(MainSearchInputModel inputModel, IQueryable<Automobile> automobiles)
        {
            if (inputModel.Interiors == null) return automobiles;

            var interiors = inputModel.Interiors;

            var Bluetooth = interiors.Bluetooth.HasValue ? interiors.Bluetooth : false;
            var DVDPlayer = interiors.DVDPlayer.HasValue ? interiors.DVDPlayer : false;
            var PaddleShifters = interiors.PaddleShifters.HasValue ? interiors.PaddleShifters : false;
            var USBAux = interiors.USBAux.HasValue ? interiors.USBAux : false;
            var BoardComputer = interiors.BoardComputer.HasValue ? interiors.BoardComputer : false;
            var PowerMirrors = interiors.PowerMirrors.HasValue ? interiors.PowerMirrors : false;

            var PowerWindows = interiors.PowerWindows.HasValue ? interiors.PowerWindows : false;
            var ElectronicSeatControl = interiors.ElectronicSeatControl.HasValue ? interiors.ElectronicSeatControl : false;
            var AmbientLighting = interiors.AmbientLighting.HasValue ? interiors.AmbientLighting : false;
            var Navigation = interiors.Navigation.HasValue ? interiors.Navigation : false;
            var HeatedSteeringWheel = interiors.HeatedSteeringWheel.HasValue ? interiors.HeatedSteeringWheel : false;
            var Fridge = interiors.Fridge.HasValue ? interiors.Fridge : false;

            var HeatedSeats = interiors.HeatedSeats.HasValue ? interiors.HeatedSeats : false;
            var Stereo = interiors.Stereo.HasValue ? interiors.Stereo : false;
            var AutoPilot = interiors.AutoPilot.HasValue ? interiors.AutoPilot : false;
            var AndroidAuto = interiors.AndroidAuto.HasValue ? interiors.AndroidAuto : false;
            var AppleCarPlay = interiors.AppleCarPlay.HasValue ? interiors.AppleCarPlay : false;
            var PowerSteering = interiors.PowerSteering.HasValue ? interiors.PowerSteering : false;

            var AirConditioning = interiors.AirConditioning.HasValue ? interiors.AirConditioning : false;
            var MultiFunctionalSteeringWheel = interiors.MultiFunctionalSteeringWheel.HasValue ? interiors.MultiFunctionalSteeringWheel : false;
            var HeadUpDisplay = interiors.HeadUpDisplay.HasValue ? interiors.HeadUpDisplay : false;
            var SmokerPackage = interiors.SmokerPackage.HasValue ? interiors.SmokerPackage : false;
            var ArmRest = interiors.ArmRest.HasValue ? interiors.ArmRest : false;
            var HeatedWindshield = interiors.HeatedWindshield.HasValue ? interiors.HeatedWindshield : false;

            var StartStopSystem = interiors.StartStopSystem.HasValue ? interiors.StartStopSystem : false;
            var RainSensor = interiors.RainSensor.HasValue ? interiors.RainSensor : false;
            var CentralLocking = interiors.CentralLocking.HasValue ? interiors.CentralLocking : false;
            var MassageSeats = interiors.MassageSeats.HasValue ? interiors.MassageSeats : false;


            if (Bluetooth == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.Bluetooth == true);
            }

            if (DVDPlayer == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.DVDPlayer == true);
            }

            if (PaddleShifters == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.PaddleShifters == true);
            }

            if (USBAux == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.USBAux == true);
            }

            if (BoardComputer == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.BoardComputer == true);
            }
            if (PowerMirrors == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.PowerMirrors == true);
            }

            if (PowerWindows == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.PowerWindows == true);
            }

            if (ElectronicSeatControl == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.ElectronicSeatControl == true);
            }

            if (AmbientLighting == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.AmbientLighting == true);
            }

            if (Navigation == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.Navigation == true);
            }
            if (HeatedSteeringWheel == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.HeatedSteeringWheel == true);
            }

            if (Fridge == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.Fridge == true);
            }

            if (HeatedSeats == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.HeatedSeats == true);
            }

            if (Stereo == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.Stereo == true);
            }

            if (AutoPilot == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.AutoPilot == true);
            }
            if (AndroidAuto == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.AndroidAuto == true);
            }

            if (AppleCarPlay == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.AppleCarPlay == true);
            }

            if (PowerSteering == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.PowerSteering == true);
            }

            if (AirConditioning == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.AirConditioning == true);
            }

            if (MultiFunctionalSteeringWheel == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.MultiFunctionalSteeringWheel == true);
            }
            if (HeadUpDisplay == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.HeadUpDisplay == true);
            }

            if (SmokerPackage == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.SmokerPackage == true);
            }

            if (ArmRest == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.ArmRest == true);
            }

            if (HeatedWindshield == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.HeatedWindshield == true);
            }

            if (StartStopSystem == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.StartStopSystem == true);
            }
            if (RainSensor == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.RainSensor == true);
            }

            if (CentralLocking == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.CentralLocking == true);
            }

            if (MassageSeats == true)
            {
                automobiles = automobiles.Where(x => x.Interiors.MassageSeats == true);
            }

            return automobiles;

        }


    }
}
