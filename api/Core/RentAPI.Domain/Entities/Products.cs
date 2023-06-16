using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentAPI.Domain.Entities.Common;

namespace RentAPI.Domain.Entities
{
    public class Products : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }

        public ICollection<Orders> Orders { get; set;}
        public ICollection<ProductImageFile> ProductImageFiles { get; set; }
    }
}
