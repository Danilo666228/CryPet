namespace CryPet.Windows.Main
{
    partial class MainControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CoinPanelBNB = new CryPet.Windows.Main.CoinPanel();
            this.CoinPanelETH = new CryPet.Windows.Main.CoinPanel();
            this.CoinPanelBTC = new CryPet.Windows.Main.CoinPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Главная";
            // 
            // CoinPanelBNB
            // 
            this.CoinPanelBNB.FullNameCoin = "Имя";
            this.CoinPanelBNB.IconCoin = null;
            this.CoinPanelBNB.Location = new System.Drawing.Point(936, 128);
            this.CoinPanelBNB.Name = "CoinPanelBNB";
            this.CoinPanelBNB.PriceCoin = "Цена";
            this.CoinPanelBNB.ShortNameCoin = "BNB";
            this.CoinPanelBNB.Size = new System.Drawing.Size(306, 132);
            this.CoinPanelBNB.TabIndex = 1;
            // 
            // CoinPanelETH
            // 
            this.CoinPanelETH.FullNameCoin = "Имя";
            this.CoinPanelETH.IconCoin = null;
            this.CoinPanelETH.Location = new System.Drawing.Point(493, 128);
            this.CoinPanelETH.Name = "CoinPanelETH";
            this.CoinPanelETH.PriceCoin = "Цена";
            this.CoinPanelETH.ShortNameCoin = "ETH";
            this.CoinPanelETH.Size = new System.Drawing.Size(306, 132);
            this.CoinPanelETH.TabIndex = 1;
            // 
            // CoinPanelBTC
            // 
            this.CoinPanelBTC.FullNameCoin = "Имя";
            this.CoinPanelBTC.IconCoin = null;
            this.CoinPanelBTC.Location = new System.Drawing.Point(31, 128);
            this.CoinPanelBTC.Name = "CoinPanelBTC";
            this.CoinPanelBTC.PriceCoin = "Цена";
            this.CoinPanelBTC.ShortNameCoin = "BTC";
            this.CoinPanelBTC.Size = new System.Drawing.Size(306, 132);
            this.CoinPanelBTC.TabIndex = 1;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.CoinPanelBNB);
            this.Controls.Add(this.CoinPanelETH);
            this.Controls.Add(this.CoinPanelBTC);
            this.Controls.Add(this.label1);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(1324, 756);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CoinPanel CoinPanelBTC;
        private CoinPanel CoinPanelETH;
        private CoinPanel CoinPanelBNB;
    }
}
