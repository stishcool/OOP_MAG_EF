using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MAG_EF
{
    public class Delivery
    {
        public int Id { get; set; }
        public DateTime DeliveryDate { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual List<Product> Products { get; set; }

        public override string ToString()
        {
            return $"Delivery: DeliveryDate = {DeliveryDate}; Supplier = {Supplier.Name}; Total Products = {Products.Count}";
        }
    }
}
