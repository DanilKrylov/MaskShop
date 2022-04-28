using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskShop.Models
{
    public class Mask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } 
        public int Count { get; set; }
        public List<Image> Images { get; set; }

        public Mask(string name, string description, decimal price, int count)
        {
            Name = name;
            Description = description;
            Price = price;
            Count = count;
        }
    }
}
