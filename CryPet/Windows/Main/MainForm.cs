using CryPet.Windows.Authorized;
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
    public partial class MainForm : Form
    {
        public int UserId {  get; set; }
        public MainForm()
        {
            InitializeComponent();
            MainControl.BringToFront();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            MiniProfile.FillProfile(UserId);
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            MainControl.BringToFront();
        }

        private void btnMarket_Click(object sender, EventArgs e)
        {
            MarketControl.BringToFront();
        }

        private void btProfile_Click(object sender, EventArgs e)
        {
            ProfileControl.BringToFront();
        }

        private void btnExitProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorizedForm authorizedForm = new AuthorizedForm();
            authorizedForm.Show();
        }
    }
}
