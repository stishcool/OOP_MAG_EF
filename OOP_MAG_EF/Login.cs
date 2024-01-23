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
    public partial class Login : Form
    {
        private ApplicationContext dbContext;
        public Login()
        {
            InitializeComponent();
            dbContext = new ApplicationContext();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (IsUserAlreadyExists(emailInsert.Text, passwordInsert.Text))
            {
                if (emailInsert.Text == "admin" && passwordInsert.Text == "admin")
                {
                    this.Hide();
                    Admin ad = new Admin();
                    ad.Show();
                }
                else
                {
                    MessageBox.Show("Пользователь найден");
                    CurrentUser.LoggedInEmail = emailInsert.Text;
                    this.Hide();
                    MainPage mp = new MainPage();
                    mp.Show();
                }
            }
            else
            {
                MessageBox.Show("Почта или пароль введены неверно");
            }
        }
        private bool IsUserAlreadyExists(string email, string password)
        {
            // Проверка наличия пользователя с заданным email в базе данных
            var user = dbContext.Users.FirstOrDefault(u => u.Email == email);

            // Если пользователь с таким email найден
            if (user != null)
            {
                // Сравниваем пароль
                return user.Password == password;
            }

            return false; // Пользователь с таким email не найден
        }

        private void reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration rg = new Registration();
            rg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Smartphone smartphone = new Smartphone();
            Class1 classInstance = new Class1();
            classInstance.DisplayProductInformation(smartphone);
        }
    }
}