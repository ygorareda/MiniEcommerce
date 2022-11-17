using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Price{ get; set; }
        public int StockQuantity { get; set; }

    }
}
