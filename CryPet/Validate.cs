using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryPet
{
    public class Validate
    {
        public bool RegistrationUser(string lastName, string firstName, string middleName, string login, string password, string repeatPassword)
        {
            if (string.IsNullOrWhiteSpace(lastName)
                || string.IsNullOrWhiteSpace(firstName)
                || string.IsNullOrWhiteSpace(middleName)
                || string.IsNullOrWhiteSpace(login)
                || string.IsNullOrWhiteSpace(password))
                
            {
                MessageBox.Show("Заполните все поля", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if(password != repeatPassword)
            {
                MessageBox.Show("Пароли не совпадают","Регистрация",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
