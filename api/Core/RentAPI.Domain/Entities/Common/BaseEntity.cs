﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAPI.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid Id {  get; set; }   
        public DateTime CreatedDate { get; set; } 
        virtual public DateTime UpdatedDate { get; set;}

    }
}