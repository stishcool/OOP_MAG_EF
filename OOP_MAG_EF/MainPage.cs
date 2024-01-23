using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_MAG_EF
{
    public partial class MainPage : Form
    {
        private ApplicationContext dbContext;
        public MainPage()
        {
            InitializeComponent();
            dbContext = new ApplicationContext();
            GetInfo(firstProduct.Text, secondProductText.Text);
        }



        public void GetInfo(string name1, string name2)
        {
            using (var dbContext = new ApplicationContext())
            {
                var product1 = dbContext.Products
                    .FirstOrDefault(p => p.Name == name1);

                if (product1 != null)
                {
                    decimal price = product1.Price;
                    costFirstProduct.Text = "Цена: " + price.ToString();
                    string description = product1.Description;
                    descriptionFirstProduct.Text = description;
                    int quantity = product1.StockQuantity;
                    quantityFirstProduct.Text = "Наличие: " + quantity.ToString();
                }
                else
                {
                    costFirstProduct.Text = "Нет в наличии";
                }
                var product2 = dbContext.Products
                    .FirstOrDefault(p => p.Name == name2);

                if (product2 != null)
                {
                    decimal price = product2.Price;
                    costSecondProduct.Text = "Цена: " + price.ToString();//
                    string description = product2.Description;
                    descriptionSecondProduct.Text = description;//
                    int quantity = product2.StockQuantity;
                    quantitySecondProduct.Text = "Наличие: " + quantity.ToString();//
                }
                else
                {
                    costSecondProduct.Text = "Нет в наличии";
                }
            }
            return;
        }

        private void cart_Click(object sender, EventArgs e)
        {
            this.Close();
            Cart c = new Cart();
            c.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            Laptops lp = new Laptops();
            lp.Show();
        }
    }
}