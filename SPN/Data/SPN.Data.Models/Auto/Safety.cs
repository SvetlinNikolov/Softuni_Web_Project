using SPN.Data.Common.Contracts;
using SPN.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SPN.Data.Models.Auto
{

    public class Safety : BaseEntity<int>, IDeletableEntity
    {
        public bool? GPS { get; set; }

        public bool? StabilityControl { get; set; }

        public bool? TractionControl { get; set; }

        public bool? AdaptiveHeadlights { get; set; }

        public bool? AutomaticBrakeSystem { get; set; }

        public bool? FrontAirbags { get; set; }

        public bool? RearAirbags { get; set; }

        public bool? SideAirbags { get; set; }

        public bool? FourWheelSteering { get; set; }

        public bool? ElectronicStabilityProgram { get; set; }

        public bool? TirePressureMonitoringSystem { get; set; }

        public bool? RearParkingSensor { get; set; }

        public bool? FrontParkingSensor { get; set; }

        public bool? ISOFIX { get; set; }

        public bool? ForwardCollisionWarning { get; set; }

        public bool? AutomaticEmergencyBraking { get; set; }

        public bool? PedestrianDetection { get; set; }

        public bool? BlindSpotMonitoring { get; set; }

        public bool? LaneKeepingAssistance { get; set; }

        public bool? AdaptiveCruiseControl { get; set; }

        public bool? LaneCenteringAssist { get; set; }

        public bool? HillDescendAssist { get; set; }

        public bool? DistTronic { get; set; }

        public bool? FourWheelDrive { get; set; }

        public bool? AlarmSystem { get; set; }

        public bool? EmergencyCallSystem { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
