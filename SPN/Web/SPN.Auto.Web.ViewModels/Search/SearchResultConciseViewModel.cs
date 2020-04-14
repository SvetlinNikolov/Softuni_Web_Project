using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Auto.Web.ViewModels.Search
{
    public class SearchResultConciseViewModel
    {
        public int Id { get; set; } 

        public string Make { get; set; }

        public string Model { get; set; }

        public string Title { get; set; }

        public string Year { get; set; }

        public string SellerName { get; set; }

        public int SellerId { get; set; }

        public string Mileage { get; set; }

        public DateTime CreatedOn { get; set; }

        public int Price { get; set; }

        public string ImageUrl { get; set; }
    }
}
