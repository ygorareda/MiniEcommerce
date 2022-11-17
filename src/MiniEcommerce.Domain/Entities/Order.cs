using MiniEcommerce.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.Domain.Entities
{
    public class Order : BaseEntity
    {
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public string TotalPrice { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
