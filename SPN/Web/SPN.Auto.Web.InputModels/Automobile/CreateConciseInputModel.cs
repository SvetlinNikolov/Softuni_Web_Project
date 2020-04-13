using SPN.Auto.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SPN.Auto.Web.InputModels.Automobile
{
    public class CreateConciseInputModel
    {
        [Required] //TODO add messages here
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public int? Price { get; set; }

        [Required]
        public int? Mileage { get; set; }

        public Color? Color { get; set; }

        [Required]
        public DateTime Year { get; set; }

        [Required]
        public int? Horsepower { get; set; }

        [Required]
        public Engine? Engine { get; set; }

        [Required]
        public GearBox? GearBox { get; set; }

        [Required]
        public Condition Condition { get; set; }

        public Body? Body { get; set; }

        [Required]
        public Region? Region { get; set; }
    }
}
