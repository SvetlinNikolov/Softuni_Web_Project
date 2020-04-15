namespace SPN.Auto.Web.InputModels.Automobile
{
    using Microsoft.AspNetCore.Mvc;
    using SPN.Data.Models.Auto.Enums;

    public class SearchConciseInputModel
    {
        [BindProperty(SupportsGet =true)]
        public string Make { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Model { get; set; }

        public int? PriceFrom { get; set; }

        public int? PriceTo { get; set; }

        public int? MileageTo { get; set; }

        public Color? Color { get; set; }

        public int? YearFrom { get; set; }

        public int? YearTo { get; set; }

        public int? HorsepowerFrom { get; set; }

        public Engine? Engine { get; set; }

        public GearBox? GearBox { get; set; }

        public Condition Condition { get; set; }

        public Body? Body { get; set; }

        public Region? Region { get; set; }

    }
}
