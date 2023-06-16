﻿using RentAPI.Application.Repositories;
using RentAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAPI.Application.Repositories
{
    public interface IInvoiceFileReadRepository : IReadRepository<InvoiceFile>
    {
    }
}
