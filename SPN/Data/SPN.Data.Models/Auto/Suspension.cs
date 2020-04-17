using SPN.Data.Common.Contracts;
using SPN.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SPN.Data.Models.Auto
{
    public class Suspensions : HasId<int>
    {
        public bool? ElectronicSuspensionControl { get; set; }

        public bool? AdaptiveAirSuspension { get; set; }

        public bool? LockingDifferential { get; set; }

        public bool? ActiveSuspension { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
