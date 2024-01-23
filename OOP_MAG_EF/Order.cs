using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MAG_EF
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; } // Добавлено свойство Quantity
        public decimal Amount { get; set; } // Добавлено свойство Amount
        public virtual Users User { get; set; }
        public override string ToString()
        {
            return $"Order: OrderDate = {OrderDate}; User = {UserId}, Product = {Product}";
        }
    }
}
