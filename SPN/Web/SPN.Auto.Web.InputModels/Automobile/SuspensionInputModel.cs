using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Auto.Web.InputModels.Automobile
{
    public class SuspensionInputModel
    {
        public bool? ElectronicSuspensionControl { get; set; }

        public bool? AdaptiveAirSuspension { get; set; }

        public bool? LockingDifferential { get; set; }

        public bool? ActiveSuspension { get; set; }
    }
}
