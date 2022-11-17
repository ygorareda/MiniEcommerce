using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.Domain.Enums
{
    public enum OrderStatus
    {
        Pending = 10,
        Processing = 20,
        Complete = 30,
        Cancelled = 40
    }
}
