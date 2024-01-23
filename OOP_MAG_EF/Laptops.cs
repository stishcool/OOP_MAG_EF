using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOP_MAG_EF
{
    public partial class Laptops : Form
    {
        private ApplicationContext dbContext;
        private Order userOrder;
        public Laptops()
        {
            InitializeComponent();
            dbContext = new ApplicationContext();
            GetInfo(firstProduct.Text, secondProduct.Text);
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
                    costSecondProduct.Text = "Цена: " + price.ToString();
                    string description = product2.Description;
                    descriptionSecondProduct.Text = description;
                    int quantity = product2.StockQuantity;
                    quantitySecondProduct.Text = "Наличие: " + quantity.ToString();
                }
                else
                {
                    costSecondProduct.Text = "Нет в наличии";
                }
            }
            return;
        }
        private void addToCartFirstProduct_Click(object sender, EventArgs e)
        {
            InitializeUserOrder(firstProduct.Text);
        }
        private void addToCartSecondProduct_Click(object sender, EventArgs e)
        {
            InitializeUserOrder(secondProduct.Text);
        }
        private void InitializeUserOrder(string productName)
        {
            if (!string.IsNullOrEmpty(CurrentUser.LoggedInEmail))
            {
                Users currentUser = dbContext.Users.FirstOrDefault(u => u.Email == CurrentUser.LoggedInEmail);

                if (currentUser != null)
                {
                    var product = dbContext.Products.FirstOrDefault(p => p.Name == productName);

                    if (product != null)
                    {
                        userOrder = new Order
                        {
                            OrderDate = DateTime.UtcNow,
                            UserId = currentUser.Id,
                            Product = productName,
                            Quantity = 1, // Устанавливаем количество
                            Amount = product.Price // Устанавливаем сумму (цену продукта)
                        };

                        UpdateProductQuantity(product, 1);

                        dbContext.Orders.Add(userOrder);
                        dbContext.SaveChanges();
                        GetInfo(firstProduct.Text, secondProduct.Text);
                    }
                    else
                    {
                        MessageBox.Show("Выбранный продукт не найден.");
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось найти пользователя с указанным email.");
                }
            }
            else
            {
                MessageBox.Show("Не выполнен вход в систему.");
            }
        }
        private void UpdateProductQuantity(Product product, int quantity)
        {
            product.StockQuantity -= quantity;
            dbContext.SaveChanges();
        }

        private void cart_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage mp = new MainPage();
            mp.Show();
        }
    }
}