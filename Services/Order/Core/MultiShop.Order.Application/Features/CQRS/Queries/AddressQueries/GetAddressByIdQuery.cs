﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Queries.AddressQueries
{
    public class GetAddressByIdQuery
    {
        public int AddressId { get; set; }

        public GetAddressByIdQuery(int addressId)
        {
            AddressId = addressId;
        }
    }
}
