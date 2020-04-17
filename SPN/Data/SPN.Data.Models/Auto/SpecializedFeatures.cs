using SPN.Data.Common.Contracts;
using SPN.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SPN.Data.Models.Auto
{

    public class SpecializedFeatures : HasId<int>
    {
        public bool? DisabledAccessible { get; set; }

        public bool? Taxi { get; set; }

        public bool? Ambulance { get; set; }

        public bool? Hearse { get; set; }

        public bool? Learner { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
