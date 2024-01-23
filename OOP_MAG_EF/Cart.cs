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

namespace OOP_MAG_EF
{
    public partial class Cart : Form
    {
        private ApplicationContext dbContext;
        private int userId;  // Добавим переменную для хранения ID пользователя
        private decimal totalAmount = 0;

        public Cart()
        {
            InitializeComponent();
            dbContext = new ApplicationContext();

            cartShow.Columns.Add("ProductName", "Название");
            cartShow.Columns.Add("ProductPrice", "Ценв");
            cartShow.Columns.Add("Quantity", "Колличество");
            cartShow.Columns.Add("Amount", "Цена");

            // Получим ID пользователя по электронной почте
            var loggedInUser = dbContext.Users.FirstOrDefault(u => u.Email == CurrentUser.LoggedInEmail);

            if (loggedInUser != null)
            {
                userId = loggedInUser.Id;
                DisplayCartItems();
            }
            else
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void DisplayCartItems()
        {
            // Очистим DataGridView перед добавлением новых данных
            cartShow.Rows.Clear();

            // Получим Id пользователя
            var userId = dbContext.Users
                .Where(u => u.Email == CurrentUser.LoggedInEmail)
                .Select(u => u.Id)
                .FirstOrDefault();

            // Найдем все заказы пользователя
            var userOrders = dbContext.Orders
                .Where(o => o.UserId == userId)
                .ToList();

            // Обнулим общую сумму перед отображением новых данных
            totalAmount = 0;  // Используем поле класса, а не локальную переменную

            foreach (var order in userOrders)
            {
                // Используем свойство Product для получения информации о продукте
                var productName = order.Product;
                var productPrice = dbContext.Products
                    .Where(p => p.Name == productName)
                    .Select(p => p.Price)
                    .FirstOrDefault();

                // Добавим данные в DataGridView
                cartShow.Rows.Add(productName, productPrice, order.Quantity, order.Amount);

                // Обновим общую сумму
                totalAmount += order.Amount;
            }

            // Выведем общую сумму в какой-то элемент интерфейса (например, Label)
            totalAmountLabel.Text = $"Сумма: {totalAmount}";
        }



        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            if (cartShow.SelectedRows.Count > 0)
            {
                int selectedIndex = cartShow.SelectedRows[0].Index;
                var productName = cartShow.Rows[selectedIndex].Cells[0].Value.ToString();
                var orderToDelete = dbContext.Orders.FirstOrDefault(order => order.Product == productName);


                if (orderToDelete != null)
                {
                    totalAmount -= orderToDelete.Amount;
                    dbContext.Orders.Remove(orderToDelete);
                    dbContext.SaveChanges();
                    RefreshCart();
                }
            }
        }

        private void RefreshCart()
        {
            // Обновите содержимое корзины
            DisplayCartItems();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage mp = new MainPage();
            mp.Show();
        }
    }
}