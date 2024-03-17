using CryPet.Data;
using CryPet.Windows.Main;
using CryPet.Windows.Registration;
using System;
using System.Windows.Forms;

namespace CryPet.Windows.Authorized
{
    public partial class AuthorizedForm : Form
    {
        public AuthorizedForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            int? UserId = await user.GetUserId(txbLogin.Text, txbPassword.Text);
            if (UserId != null)
            {
                MessageBox.Show("Успешный вход");
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.UserId = (int)UserId;
                mainForm.Show();
                
            }
        }

        private void lblRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void swhUsePasswordChar_CheckedChanged(object sender, EventArgs e)
        {
            txbPassword.UseSystemPasswordChar = !txbPassword.UseSystemPasswordChar;
        }
    }
}
