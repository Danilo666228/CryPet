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
        public int UserId { get; set; }
        public ProfileControl()
        {
            InitializeComponent();

        }
        public async void FillProfileData()
        {
            User user = new User();
            var result = await user.LoadDataUser(UserId);
            txbLastName.Text = result.lastname;
            txbFirstName.Text = result.firstname;
            txbMiddleName.Text = result.middlename;
        }
        private async void btnSaveSettings_Click(object sender, EventArgs e)
        {
            User user = new User();
            await user.UpdateDataUser(UserId, txbLastName.Text, txbFirstName.Text, txbMiddleName.Text);
        }

       
    }
}
