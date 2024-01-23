using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MAG_EF
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
        public override string ToString()
        {
            return $"User: Name = {Name}; Surname = {Surname}; " +
                $"Patronymic = {Patronymic}; Email = {Email}; " +
                $"Password = {Password}; Phone = {Phone}; Address = {Address}";
        }
    }
}