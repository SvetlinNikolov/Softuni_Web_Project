using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Data.Models.Auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPN.Auto.Services.Services.Helpers
{
    public class ValidateInteriorMaterialsSearch : IHelper
    {
        public IQueryable<Automobile> ValidateSearchProperties(MainSearchInputModel inputModel, IQueryable<Automobile> automobiles)
        {
            if (inputModel.InteriorMaterials == null) return automobiles;

            var interiorMaterials = inputModel.InteriorMaterials;

            var LeatherSteeringWheel = interiorMaterials.LeatherSteeringWheel.HasValue ? interiorMaterials.LeatherSteeringWheel : false;
            var LeatherSeats = interiorMaterials.LeatherSeats.HasValue ? interiorMaterials.LeatherSeats : false;
            var ClothSeats = interiorMaterials.ClothSeats.HasValue ? interiorMaterials.ClothSeats : false;
            var Alcantara = interiorMaterials.Alcantara.HasValue ? interiorMaterials.Alcantara : false;
            var Velour = interiorMaterials.Velour.HasValue ? interiorMaterials.Velour : false;

            if (LeatherSteeringWheel == true)
            {
                automobiles = automobiles.Where(x => x.InteriorMaterials.LeatherSteeringWheel == true);
            }
            if (LeatherSeats == true)
            {
                automobiles = automobiles.Where(x => x.InteriorMaterials.LeatherSeats == true);
            }
            if (ClothSeats == true)
            {
                automobiles = automobiles.Where(x => x.InteriorMaterials.ClothSeats == true);
            }
            if (Alcantara == true)
            {
                automobiles = automobiles.Where(x => x.InteriorMaterials.Alcantara == true);
            }
            if (Velour == true)
            {
                automobiles = automobiles.Where(x => x.InteriorMaterials.Velour == true);
            }

            return automobiles;
        }
    }
}
