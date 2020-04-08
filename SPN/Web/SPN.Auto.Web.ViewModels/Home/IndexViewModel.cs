using SPN.Auto.Web.ViewModels.Make;
using SPN.Auto.Web.ViewModels.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SPN.Auto.Web.ViewModels.Home
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            this.Makes = new List<SelectListItem>();
            this.Models = new List<SelectListItem>();
        }
        public List<SelectListItem> Makes { get; set; }

        public List<SelectListItem> Models { get; set; }
   
    }
}
