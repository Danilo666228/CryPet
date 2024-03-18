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
    public partial class CoinPanel : UserControl
    {
        public CoinPanel()
        {
            InitializeComponent();
        }
        public async Task LoadPriceCoin()
        {
            Coin coin = new Coin();
            lblPrice.Text = Convert.ToDecimal(await coin.GetPriceCoin(lblShortName.Text)).ToString();           
        }
        public Image IconCoin
        {
            get { return pcbIconCoin.Image; }
            set { pcbIconCoin.Image = value; }
        }
        public string FullNameCoin
        {
            get { return lblFullName.Text; }
            set { lblFullName.Text = value; }
        }
        public string ShortNameCoin
        {
            get { return lblShortName.Text; }
            set { lblShortName.Text = value; }
        }
        public string PriceCoin
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }
    }
}
