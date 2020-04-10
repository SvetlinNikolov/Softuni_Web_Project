using SPN.Auto.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Auto.Web.InputModels.Automobile
{
    public class AutomobileCreateConciseInputModel
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int? PriceFrom { get; set; }

        public int? PriceTo { get; set; }

        public int? MileageFrom { get; set; }

        public int? MileageTo { get; set; }

        public Color? Color { get; set; }

        public int? YearFrom { get; set; }

        public int? YearTo { get; set; }

        public int? HorsepowerFrom { get; set; }

        public int? HorsepowerTo { get; set; }

        public Engine? Engine { get; set; }

        public GearBox? GearBox { get; set; }

        public Condition Condition { get; set; }

        public Body? Body { get; set; }

        public Region? Region { get; set; }

    }
}
