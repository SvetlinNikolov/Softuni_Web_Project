
using SPN.Data.Models.Auto.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Auto.Web.InputModels.Index
{
    public class IndexFormSearchConciseInputModel
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int? PriceFrom { get; set; }

        public int? PriceTo { get; set; }
            
        public int? BeforeYear { get; set; }

        public int? AfterYear { get; set; }

        public int? Horsepower { get; set; }

        public Engine Engine { get; set; }

        public GearBox GearBox { get; set; }
    }
}
