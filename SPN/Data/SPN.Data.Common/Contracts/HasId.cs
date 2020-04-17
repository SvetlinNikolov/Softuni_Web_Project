using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SPN.Data.Common.Contracts
{
    public class HasId<TKey>
    {
        [Key]
        public TKey Id { get; set; }
    }
}
