using RentAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAPI.Domain.Entities
{
    public class Customers : BaseEntity
    {

        public string Name { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
