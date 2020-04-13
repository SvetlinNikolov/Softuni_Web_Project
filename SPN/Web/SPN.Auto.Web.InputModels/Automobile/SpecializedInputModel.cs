using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Auto.Web.InputModels.Automobile
{
    public class SpecializedInputModel
    {
        public bool? DisabledAccessible { get; set; }

        public bool? Taxi { get; set; }

        public bool? Ambulance { get; set; }

        public bool? Hearse { get; set; }

        public bool? Learner { get; set; }
    }
}
