using SPN.Data.Common.Contracts;
using SPN.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Auto.Data.Models
{
    public class Make : BaseEntity<int>, IDeletableEntity
    {
        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}

