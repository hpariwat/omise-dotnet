﻿using Omise.Models;
using System.Threading.Tasks;
using System;

namespace Omise.Examples.Examples
{
    public class Search : Example
    {
        public async Task Retrieve_Retrieve()
        {
            var charges = await Client.Charges.Search(
                query: "TSUNAMI",
                order: Ordering.ReverseChronological
            );

            Console.WriteLine($"total tsunami charges: {charges.Total}");
        }
    }
}