using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Data.Models.Auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPN.Auto.Services.Services.Helpers
{
    public class ValidateSafetySearch:IHelper
    {
        public IQueryable<Automobile> ValidateSearchProperties(MainSearchInputModel inputModel, IQueryable<Automobile> automobiles)
        {
            if (inputModel.Safety == null) return automobiles;

            var safety = inputModel.Safety;

            var GPS = safety.GPS.HasValue ? safety.GPS : false;
            var StabilityControl = safety.StabilityControl.HasValue ? safety.StabilityControl : false;
            var TractionControl = safety.TractionControl.HasValue ? safety.TractionControl : false;
            var AdaptiveHeadlights = safety.AdaptiveHeadlights.HasValue ? safety.AdaptiveHeadlights : false;
            var AutomaticBrakeSystem = safety.AutomaticBrakeSystem.HasValue ? safety.AutomaticBrakeSystem : false;
            var FrontAirbags = safety.FrontAirbags.HasValue ? safety.FrontAirbags : false;
            var RearAirbags = safety.RearAirbags.HasValue ? safety.RearAirbags : false;

            var SideAirbags = safety.SideAirbags.HasValue ? safety.SideAirbags : false;
            var FourWheelSteering = safety.FourWheelSteering.HasValue ? safety.FourWheelSteering : false;
            var ElectronicStabilityProgram = safety.ElectronicStabilityProgram.HasValue ? safety.ElectronicStabilityProgram : false;
            var TirePressureMonitoringSystem = safety.TirePressureMonitoringSystem.HasValue ? safety.TirePressureMonitoringSystem : false;
            var RearParkingSensor = safety.RearParkingSensor.HasValue ? safety.RearParkingSensor : false;
            var FrontParkingSensor = safety.FrontParkingSensor.HasValue ? safety.FrontParkingSensor : false;
            var ISOFIX = safety.ISOFIX.HasValue ? safety.ISOFIX : false;

            var ForwardCollisionWarning = safety.ForwardCollisionWarning.HasValue ? safety.ForwardCollisionWarning : false;
            var AutomaticEmergencyBraking = safety.AutomaticEmergencyBraking.HasValue ? safety.AutomaticEmergencyBraking : false;
            var PedestrianDetection = safety.PedestrianDetection.HasValue ? safety.PedestrianDetection : false;
            var BlindSpotMonitoring = safety.BlindSpotMonitoring.HasValue ? safety.BlindSpotMonitoring : false;
            var LaneKeepingAssistance = safety.LaneKeepingAssistance.HasValue ? safety.LaneKeepingAssistance : false;
            var AdaptiveCruiseControl = safety.AdaptiveCruiseControl.HasValue ? safety.AdaptiveCruiseControl : false;
            var LaneCenteringAssist = safety.LaneCenteringAssist.HasValue ? safety.LaneCenteringAssist : false;

            var HillDescendAssist = safety.HillDescendAssist.HasValue ? safety.HillDescendAssist : false;
            var DistTronic = safety.DistTronic.HasValue ? safety.DistTronic : false;
            var FourWheelDrive = safety.FourWheelDrive.HasValue ? safety.FourWheelDrive : false;
            var AlarmSystem = safety.AlarmSystem.HasValue ? safety.AlarmSystem : false;
            var EmergencyCallSystem = safety.EmergencyCallSystem.HasValue ? safety.EmergencyCallSystem : false;

            if (GPS == true)
            {
                automobiles = automobiles.Where(x => x.Safety.GPS == true);
            }
            if (StabilityControl == true)
            {
                automobiles = automobiles.Where(x => x.Safety.StabilityControl == true);
            }
            if (TractionControl == true)
            {
                automobiles = automobiles.Where(x => x.Safety.TractionControl == true);
            }
            if (AdaptiveHeadlights == true)
            {
                automobiles = automobiles.Where(x => x.Safety.AdaptiveHeadlights == true);
            }
            if (AutomaticBrakeSystem == true)
            {
                automobiles = automobiles.Where(x => x.Safety.AutomaticBrakeSystem == true);
            }
            if (FrontAirbags == true)
            {
                automobiles = automobiles.Where(x => x.Safety.FrontAirbags == true);
            }
             if (RearAirbags == true)
            {
                automobiles = automobiles.Where(x => x.Safety.RearAirbags == true);
            }
            if (SideAirbags == true)
            {
                automobiles = automobiles.Where(x => x.Safety.SideAirbags == true);
            }
            if (FourWheelSteering == true)
            {
                automobiles = automobiles.Where(x => x.Safety.FourWheelSteering == true);
            }
            if (ElectronicStabilityProgram == true)
            {
                automobiles = automobiles.Where(x => x.Safety.ElectronicStabilityProgram == true);
            }
            if (TirePressureMonitoringSystem == true)
            {
                automobiles = automobiles.Where(x => x.Safety.TirePressureMonitoringSystem == true);
            }
            if (RearParkingSensor == true)
            {
                automobiles = automobiles.Where(x => x.Safety.RearParkingSensor == true);
            }
            if (FrontParkingSensor == true)
            {
                automobiles = automobiles.Where(x => x.Safety.FrontParkingSensor == true);
            }
            if (ISOFIX == true)
            {
                automobiles = automobiles.Where(x => x.Safety.ISOFIX == true);
            }
            if (ForwardCollisionWarning == true)
            {
                automobiles = automobiles.Where(x => x.Safety.ForwardCollisionWarning == true);
            }
             if (AutomaticEmergencyBraking == true)
            {
                automobiles = automobiles.Where(x => x.Safety.AutomaticEmergencyBraking == true);
            }
            if (PedestrianDetection == true)
            {
                automobiles = automobiles.Where(x => x.Safety.PedestrianDetection == true);
            }
            if (BlindSpotMonitoring == true)
            {
                automobiles = automobiles.Where(x => x.Safety.BlindSpotMonitoring == true);
            }
            if (LaneKeepingAssistance == true)
            {
                automobiles = automobiles.Where(x => x.Safety.LaneKeepingAssistance == true);
            }
            if (AdaptiveCruiseControl == true)
            {
                automobiles = automobiles.Where(x => x.Safety.AdaptiveCruiseControl == true);
            }
            if (LaneCenteringAssist == true)
            {
                automobiles = automobiles.Where(x => x.Safety.LaneCenteringAssist == true);
            }
            if (HillDescendAssist == true)
            {
                automobiles = automobiles.Where(x => x.Safety.HillDescendAssist == true);
            }
            if (DistTronic == true)
            {
                automobiles = automobiles.Where(x => x.Safety.DistTronic == true);
            }
            if (FourWheelDrive == true)
            {
                automobiles = automobiles.Where(x => x.Safety.FourWheelDrive == true);
            }
            if (AlarmSystem == true)
            {
                automobiles = automobiles.Where(x => x.Safety.AlarmSystem == true);
            }
            if (EmergencyCallSystem == true)
            {
                automobiles = automobiles.Where(x => x.Safety.EmergencyCallSystem == true);
            }


            return automobiles;


        }
    }
}
