using Microsoft.EntityFrameworkCore;
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

namespace OOP_MAG_EF
{
    public partial class Registration : Form
    {
        private ApplicationContext dbContext;
        public Registration()
        {
            InitializeComponent();
            dbContext = new ApplicationContext();
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                CustomException.InvalidPhone IP = new CustomException.InvalidPhone(phoneInsert.Text);
                if (IP.IsValid)
                {
                    if (ValCheck())
                    {
                        Users newUser = new Users // sozdanie novogo polzovatel'a
                        {
                            Name = nameInsert.Text,
                            Surname = surnameInsert.Text,
                            Patronymic = patronymicInsert.Text,
                            Email = emailInsert.Text,
                            Password = passwordInsert.Text,
                            Phone = "+7" + phoneInsert.Text,
                            Address = addressInsert.Text,
                            ShopId = 1
                        };



                        dbContext.Users.Add(newUser); // dobavlenie
                        dbContext.SaveChanges(); // sohranenie

                        MessageBox.Show("Успешно");

                        CurrentUser.LoggedInEmail = emailInsert.Text;

                        this.Hide();
                        MainPage mp = new MainPage();
                        mp.Show();

                    }
                    else
                    {
                        MessageBox.Show("Заполните все поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (DbUpdateException ex)
            {
                // proverka narusheni'a unikalnosti
                if (ex.InnerException is Npgsql.PostgresException postgresException && postgresException.SqlState == "23505")
                {
                    MessageBox.Show("Пользователь с таким адресом электронной почты уже существует.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    throw new DbUpdateException("Произошла ошибка при выполнении DoSomething.", ex);
                }
            }
        }
        private bool ValCheck()
        {
            return (
            !string.IsNullOrEmpty(nameInsert.Text) &&
            !string.IsNullOrEmpty(surnameInsert.Text) &&
            !string.IsNullOrEmpty(patronymicInsert.Text) &&
            !string.IsNullOrEmpty(emailInsert.Text) &&
            !string.IsNullOrEmpty(label9.Text) &&
            !string.IsNullOrEmpty(addressInsert.Text));
        }
    }
}