﻿using System;
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
    public partial class MainControl : UserControl
    {
        public MainControl()
        {
            InitializeComponent();
        }
        public async Task UpdatePanelCoin()
        {
            await CoinPanelBTC.LoadPriceCoin();
            await CoinPanelETH.LoadPriceCoin();
            await CoinPanelBNB.LoadPriceCoin();
            await UpdatePanelCoin();
        }

    }
}
