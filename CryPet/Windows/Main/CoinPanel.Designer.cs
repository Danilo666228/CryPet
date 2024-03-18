namespace CryPet.Windows.Main
{
    partial class CoinPanel
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
            this.components = new System.ComponentModel.Container();
            this.GradientPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblFullName = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.GradientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GradientPanel
            // 
            this.GradientPanel.Controls.Add(this.guna2PictureBox1);
            this.GradientPanel.Controls.Add(this.lblPrice);
            this.GradientPanel.Controls.Add(this.lbl);
            this.GradientPanel.Controls.Add(this.lblFullName);
            this.GradientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GradientPanel.Location = new System.Drawing.Point(0, 0);
            this.GradientPanel.Name = "GradientPanel";
            this.GradientPanel.Size = new System.Drawing.Size(306, 132);
            this.GradientPanel.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFullName.Location = new System.Drawing.Point(64, 19);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(45, 25);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Имя";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl.Location = new System.Drawing.Point(17, 84);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(45, 25);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Имя";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(175, 56);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 25);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Цена";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Gray;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(8, 6);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(50, 50);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // CoinPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GradientPanel);
            this.Name = "CoinPanel";
            this.Size = new System.Drawing.Size(306, 132);
            this.GradientPanel.ResumeLayout(false);
            this.GradientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel GradientPanel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblFullName;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
