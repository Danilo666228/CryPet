using CryPet.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryPet.Windows.Main
{
    public partial class ProfileControl : UserControl
    {
        public ProfileControl()
        {
            InitializeComponent();
        }

        private async void btnSaveSettings_Click(object sender, EventArgs e)
        {
            User user = new User();
            await user.UpdateDataUser(12, txbLastName.Text, txbFirstName.Text, txbMiddleName.Text);
        }
    }
}
