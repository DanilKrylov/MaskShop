using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.Models
{
    public class ShopCart
    {
        [Key]
        public string UserLogin { get; set; }
        public User User { get; set; }
        public List<Order> Orders { get; set;}
    }
}
