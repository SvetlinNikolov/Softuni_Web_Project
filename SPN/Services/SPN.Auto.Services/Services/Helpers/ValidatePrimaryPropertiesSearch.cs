using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Data.Models.Auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPN.Auto.Services.Services.Helpers
{
    public class ValidatePrimaryPropertiesSearch : IHelper
    {
        public IQueryable<Automobile> ValidateSearchProperties(MainSearchInputModel inputModel, IQueryable<Automobile> automobiles)
        {
            if (inputModel.PrimaryProperties == null) return automobiles;

            var make = !string.IsNullOrEmpty(inputModel.PrimaryProperties.Make)? inputModel.PrimaryProperties.Make:null;
            var model = !string.IsNullOrEmpty(inputModel.PrimaryProperties.Model) ? inputModel.PrimaryProperties.Model : null;

            var yearFrom = inputModel.PrimaryProperties.YearFrom.HasValue ? inputModel.PrimaryProperties.YearFrom : -1;
            var yearTo = inputModel.PrimaryProperties.YearTo.HasValue ? inputModel.PrimaryProperties.YearTo : -1;
            var horsePowerFrom = inputModel.PrimaryProperties.HorsepowerFrom.HasValue ? inputModel.PrimaryProperties.HorsepowerFrom : -1;

            var priceFrom = inputModel.PrimaryProperties.PriceFrom.HasValue ? inputModel.PrimaryProperties.PriceFrom : -1;
            var priceTo = inputModel.PrimaryProperties.PriceTo.HasValue ? inputModel.PrimaryProperties.PriceFrom : -1;
            var mileageTo = inputModel.PrimaryProperties.MileageTo.HasValue ? inputModel.PrimaryProperties.MileageTo : -1;

            var color = inputModel.PrimaryProperties.Color.HasValue ? (int)inputModel.PrimaryProperties.Color : -1;
            var engine = inputModel.PrimaryProperties.Engine.HasValue ? (int)inputModel.PrimaryProperties.Engine : -1;
            var gearbox = inputModel.PrimaryProperties.GearBox.HasValue ? (int)inputModel.PrimaryProperties.GearBox : -1;
            var condition = inputModel.PrimaryProperties.Condition.HasValue ? (int)inputModel.PrimaryProperties.Condition : -1;
            var body = inputModel.PrimaryProperties.Body.HasValue ? (int)inputModel.PrimaryProperties.Body : -1;
            var region = inputModel.PrimaryProperties.Region.HasValue ? (int)inputModel.PrimaryProperties.Region : -1;

            if (!string.IsNullOrEmpty(make))
            {
                automobiles = automobiles.Where(x => x.Make.Name==make);
            }
            if (!string.IsNullOrEmpty(model))
            {
                automobiles = automobiles.Where(x => x.Model.Name == model);
            }

            if (yearFrom.Value >= 0)
            {
                automobiles = automobiles.Where(x => x.PrimaryProperties.Year >= yearFrom);
            }
            if (yearTo.Value >= 0)
            {
                automobiles = automobiles.Where(x => x.PrimaryProperties.Year <= yearTo);
            }
            if (horsePowerFrom.Value >= 0)
            {
                automobiles = automobiles.Where(x => x.PrimaryProperties.Horsepower >= horsePowerFrom);
            }
            if (priceFrom.Value >= 0)
            {
                automobiles = automobiles.Where(x => x.PrimaryProperties.Price >= priceFrom);
            }
            if (priceTo.Value >= 0)
            {
                automobiles = automobiles.Where(x => x.PrimaryProperties.Price <= priceTo);
            }
            if (mileageTo.Value >= 0)
            {
                automobiles = automobiles.Where(x => x.PrimaryProperties.Mileage <= mileageTo);
            }
            if (color >= 0)
            {
                automobiles = automobiles.Where(x => (int)x.PrimaryProperties.Color == color);
            }
            if (engine >= 0)
            {
                automobiles = automobiles.Where(x => (int)x.PrimaryProperties.Engine == engine);
            }
            if (gearbox >= 0)
            {
                automobiles = automobiles.Where(x => (int)x.PrimaryProperties.GearBox == gearbox);
            }
            if (condition >= 0)
            {
                automobiles = automobiles.Where(x => (int)x.PrimaryProperties.Condition == condition);
            }
            if (body >= 0)
            {
                automobiles = automobiles.Where(x => (int)x.PrimaryProperties.Body == body);
            }
            if (region >= 0)
            {
                automobiles = automobiles.Where(x => (int)x.PrimaryProperties.Region == region);
            }

            return automobiles;
        }
    }
}
