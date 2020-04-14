using SPN.Data.Common.Contracts;
using SPN.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Data.Models.Auto
{
    public class Images : BaseEntity<int>, IDeletableEntity
    {
        public string ImageUrl1 { get; set; }

        public string ImageUrl2 { get; set; }

        public string ImageUrl3 { get; set; }

        public string ImageUrl4 { get; set; }

        public string ImageUrl5 { get; set; }

        public string ImageUrl6 { get; set; }

        public string ImageUrl7 { get; set; }

        public string ImageUrl8 { get; set; }

        public string ImageUrl9 { get; set; }

        public string ImageUrl10 { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
