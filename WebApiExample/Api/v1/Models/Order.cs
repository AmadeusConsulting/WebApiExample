using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiExample.Api.v1.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public string VendorName { get; set; }

        public decimal Amount { get; set; }
    }
}