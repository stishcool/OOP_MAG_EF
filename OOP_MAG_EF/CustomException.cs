using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MAG_EF
{
    public class CustomException 
    {
        public class InvalidPhone 
        {
            public bool IsValid { get; private set; } = true;
            public InvalidPhone(string phoneInsert) 
            {
                if (phoneInsert == null)
                {
                    MessageBox.Show("Строка номер телефона не может быть пустой.");
                    IsValid = false;
                }
                if (phoneInsert.Any(char.IsLetter))
                {
                    MessageBox.Show("Номер телефона не должен содержать буквы.");
                    IsValid = false;
                }
                const int expectedDigitCount = 10;
                string digitsOnly = new string(phoneInsert.Where(char.IsDigit).ToArray());
                if (digitsOnly.Length != expectedDigitCount)
                {
                    MessageBox.Show("Некорректный номер телефона. Должно быть 10 цифр.");
                    IsValid = false;
                }
            }
        }     
    }
}
