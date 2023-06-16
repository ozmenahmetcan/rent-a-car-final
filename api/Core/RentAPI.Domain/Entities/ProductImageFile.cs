using RentAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAPI.Domain.Entities
{
    public class ProductImageFile : File
    {

        public ICollection<Products> Products { get; set; }
    }
}
