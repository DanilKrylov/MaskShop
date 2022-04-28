using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public int MaskId { get; set; }
        public Mask Mask { get; set; }
    }
}
