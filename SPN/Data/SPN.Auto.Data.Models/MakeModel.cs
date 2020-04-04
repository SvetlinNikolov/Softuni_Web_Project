using SPN.Data.Common.Contracts;
using SPN.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Auto.Data.Models
{
    public class MakeModel : IDeletableEntity
    {
        public int MakeId { get; set; }

        public Make Make { get; set; }

        public int ModelId { get; set; }

        public Model Model { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
