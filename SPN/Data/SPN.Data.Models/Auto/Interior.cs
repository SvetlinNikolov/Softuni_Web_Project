using SPN.Data.Common.Contracts;
using SPN.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SPN.Data.Models.Auto
{

    public class Interiors : BaseEntity<int>, IDeletableEntity
    {
        public bool? Bluetooth { get; set; }

        public bool? DVDPlayer { get; set; }

        public bool? PaddleShifters { get; set; }

        public bool? USBAux { get; set; }

        public bool? BoardComputer { get; set; }

        public bool? PowerMirrors { get; set; }

        public bool? PowerWindows { get; set; }

        public bool? ElectronicSeatControl { get; set; }

        public bool? AmbientLighting { get; set; }

        public bool? Navigation { get; set; }

        public bool? HeatedSteeringWheel { get; set; }

        public bool? Fridge { get; set; }

        public bool? HeatedSeats { get; set; }

        public bool? Stereo { get; set; }

        public bool? AutoPilot { get; set; }

        public bool? AndroidAuto { get; set; }

        public bool? AppleCarPlay { get; set; }

        public bool? PowerSteering { get; set; }

        public bool? AirConditioning { get; set; }

        public bool? MultiFunctionalSteeringWheel { get; set; }

        public bool? HeadUpDisplay { get; set; }

        public bool? SmokerPackage { get; set; }

        public bool? ArmRest { get; set; }

        public bool? HeatedWindshield { get; set; }

        public bool? StartStopSystem { get; set; }

        public bool? RainSensor { get; set; }

        public bool? CentralLocking { get; set; }

        public bool? MassageSeats { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
