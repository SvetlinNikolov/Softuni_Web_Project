using SPN.Auto.Web.ViewModels.Make;
using SPN.Auto.Web.ViewModels.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Auto.Web.ViewModels.Index
{
    public class IndexPageViewModel
    {
        public IEnumerable<MakeConciseViewModel> MakesListing { get; set; }

        public IEnumerable<ModelConciseViewModel> ModelsListing { get; set; }
    }
}
