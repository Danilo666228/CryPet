using CryPet.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CryPet.Windows.Main
{
    public partial class MiniProfile : UserControl
    {
       
        public MiniProfile()
        {
            InitializeComponent();          
        }
        public async void FillProfile(int userId)
        {
            User user = new User();
            var result = await user.FillMiniProfile(userId);
            lblNameUser.Text = result.lastname;
            lblBalanceUser.Text = result.balance;

        }
        public Image PhotoUser
        {
            get { return pcbPhotoUser.Image; }
            set { pcbPhotoUser.Image = value; }
        }
        public string NameUser
        {
            get { return lblNameUser.Text; }
            set { lblNameUser.Text = value; }
        }
        public string BalanceUser
        {
            get { return lblBalanceUser.Text; }
            set { lblBalanceUser.Text = value; }
        }
    }
}
