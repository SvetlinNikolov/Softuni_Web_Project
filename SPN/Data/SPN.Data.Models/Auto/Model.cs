
using SPN.Data.Common.Contracts;
using SPN.Data.Common.Models;
using System;

namespace SPN.Data.Models.Auto
{
    public class Model : BaseEntity<int>, IDeletableEntity
    {
        public Make Make { get; set; }

        public int MakeId { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
