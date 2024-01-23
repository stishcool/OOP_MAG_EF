using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MAG_EF
{
    public interface IProduct
    {
        string GetName();
        decimal GetPrice();
    }
    public class Smartphone : IProduct
    {
        public string GetName()
        {
            return "Смартфон";
        }

        public decimal GetPrice()
        {
            return 15000m;
        }
    }
}