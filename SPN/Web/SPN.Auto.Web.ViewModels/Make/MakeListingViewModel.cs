using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Auto.Web.ViewModels.Make
{
    public class MakeListingViewModel
    {
        IEnumerable<MakeConciseViewModel> Makes { get; set; }
    }
}
