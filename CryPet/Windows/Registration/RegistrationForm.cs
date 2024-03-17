using CryPet.Data;
using CryPet.Windows.Authorized;
using CryPet.Windows.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryPet.Windows.Registration
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private async void btnRegistration_Click(object sender, EventArgs e)
        {
            User user = new User();
            Validate validate = new Validate();
            AuthorizedForm authorized = new AuthorizedForm();
            if (validate.RegistrationUser(txbLastName.Text, txbFirstName.Text, txbMiddleName.Text, txbLogin.Text, txbPassword.Text, txbRepeatPassword.Text))
            {
                if (await user.AddUser(txbLastName.Text, txbFirstName.Text, txbMiddleName.Text, txbLogin.Text, txbPassword.Text))
                {
                    MessageBox.Show("Вы успешно зарегистрированы");
                    this.Hide();
                    authorized.Show();
                }

            }
        }
    }
}
