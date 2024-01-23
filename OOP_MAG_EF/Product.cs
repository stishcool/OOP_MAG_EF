using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MAG_EF
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Delivery> Deliveries { get; set; }

        public override string ToString()
        {
            return $"Product: Name = {Name}; Description = {Description}; Price = {Price}; Stock Quantity = {StockQuantity}";
        }
    }
}