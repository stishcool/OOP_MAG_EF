using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MAG_EF
{
    internal class Class1
    {
        public void DisplayProductInformation(IProduct product)
        {
            // Отображение информации о продукте в корзине
            string productName = product.GetName();
            decimal productPrice = product.GetPrice();
            MessageBox.Show($"Product: {productName}, Price: {productPrice}");
        }
    }
}
