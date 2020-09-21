using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBaseQuery.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
