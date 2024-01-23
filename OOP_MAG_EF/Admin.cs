using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Admin : Form
    {
        private ApplicationContext dbContext;
        public Admin()
        {
            InitializeComponent();
            dbContext = new ApplicationContext();

            laptopChoice.Items.Add("Ноутбук Lenovo L485");
            laptopChoice.Items.Add("Ноутбук Lenovo L793");

            searchChoice.Items.Add("Ноутбук Lenovo L485");
            searchChoice.Items.Add("Ноутбук Lenovo L793");

            laptopDeleteChoice.Items.Add("Ноутбук Lenovo L485");
            laptopDeleteChoice.Items.Add("Ноутбук Lenovo L793");
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            int laptop = -1;

            if (this.laptopChoice.SelectedIndex == 0)
            {
                laptop = 7;
            }
            else if (this.laptopChoice.SelectedIndex == 1)
            {
                laptop = 6;
            }

            int quantity = int.Parse(quantityProduct.Text);

            var product = dbContext.Products.FirstOrDefault(p => p.Id == laptop);
            if (product != null)
            {
                IncreaseProductQuantity(product, quantity);
                MessageBox.Show("Товар добавлен");
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
        private void laptopDelete_Click(object sender, EventArgs e)
        {
            int laptop = -1;

            if (this.laptopDeleteChoice.SelectedIndex == 0)
            {
                laptop = 7;
            }
            else if (this.laptopDeleteChoice.SelectedIndex == 1)
            {
                laptop = 6;
            }

            int quantity = int.Parse(quantityDelete.Text);

            var product = dbContext.Products.FirstOrDefault(p => p.Id == laptop);
            if (product != null && product.StockQuantity > 0)
            {
                DecreaseProductQuantity(product, quantity);
                MessageBox.Show("Товар удален");
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
        private void searchProduct_Click(object sender, EventArgs e)
        {
            int laptop = -1;

            if (this.searchChoice.SelectedIndex == 0)
            {
                laptop = 7;
            }
            else if (this.searchChoice.SelectedIndex == 1)
            {
                laptop = 6;
            }

            using (var dbContext = new ApplicationContext())
            {
                var product = dbContext.Products.FirstOrDefault(p => p.Id == laptop);
                if (product != null)
                {
                    var data = new List<Product> { product };
                    productShow.DataSource = data;
                }
                else if (laptop == -1)
                {
                    var allProducts = dbContext.Products.ToList();
                    if (allProducts.Any())
                    {
                        productShow.DataSource = allProducts;
                    }
                    else
                    {
                        MessageBox.Show("Нет доступных пользователей.");
                    }
                }
                else
                {
                    MessageBox.Show("Продукт не найден");
                }
            }
        }
        private void IncreaseProductQuantity(Product product, int quantity)
        {
            product.StockQuantity += quantity;
            dbContext.SaveChanges();
        }
        private void DecreaseProductQuantity(Product product, int quantity)
        {
            product.StockQuantity -= quantity;
            dbContext.SaveChanges();
        }
        private void userSearch_Click(object sender, EventArgs e)
        {
            int userID = int.Parse(userIDChioce.Text);

            using (var dbContext = new ApplicationContext())
            {
                var user = dbContext.Users.FirstOrDefault(u => u.Id == userID);
                if (user != null)
                {
                    var data = new List<Users> { user };
                    userShow.DataSource = data;
                }
                else if (userID == 0)
                {
                    var allUsers = dbContext.Users.ToList();
                    if (allUsers.Any())
                    {
                        userShow.DataSource = allUsers;
                    }
                    else
                    {
                        MessageBox.Show("Нет доступных пользователей.");
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }
    }
}