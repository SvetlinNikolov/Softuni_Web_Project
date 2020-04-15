using SPN.Data.Models.Auto.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SPN.Auto.Web.InputModels.Automobile
{
    public class CreateConciseInputModel
    {

        //TODO add messages here
        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }


        public int? Price { get; set; }

        
        public int? Mileage { get; set; }

        public Color? Color { get; set; }

     
        public int Year { get; set; }

    
        public int? Horsepower { get; set; }

        public Engine? Engine { get; set; }

      
        public GearBox? GearBox { get; set; }

     
        public Condition Condition { get; set; }

        public Body? Body { get; set; }

       
        public Region? Region { get; set; }
    }
}
