namespace CryPet.Windows.Main
{
    partial class ProfileControl
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
            this.grbInformation = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txbLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbMiddleName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSaveSettings = new Guna.UI2.WinForms.Guna2Button();
            this.grbInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Профиль";
            // 
            // grbInformation
            // 
            this.grbInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grbInformation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grbInformation.BorderRadius = 10;
            this.grbInformation.Controls.Add(this.btnSaveSettings);
            this.grbInformation.Controls.Add(this.txbMiddleName);
            this.grbInformation.Controls.Add(this.txbFirstName);
            this.grbInformation.Controls.Add(this.txbLastName);
            this.grbInformation.Controls.Add(this.guna2PictureBox1);
            this.grbInformation.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grbInformation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grbInformation.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbInformation.ForeColor = System.Drawing.Color.Silver;
            this.grbInformation.Location = new System.Drawing.Point(38, 145);
            this.grbInformation.Name = "grbInformation";
            this.grbInformation.Size = new System.Drawing.Size(470, 515);
            this.grbInformation.TabIndex = 1;
            this.grbInformation.Text = "Личная информация";
            this.grbInformation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(25, 68);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(150, 150);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // txbLastName
            // 
            this.txbLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbLastName.DefaultText = "";
            this.txbLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbLastName.Location = new System.Drawing.Point(218, 79);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.PasswordChar = '\0';
            this.txbLastName.PlaceholderText = "";
            this.txbLastName.SelectedText = "";
            this.txbLastName.Size = new System.Drawing.Size(200, 36);
            this.txbLastName.TabIndex = 1;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbFirstName.DefaultText = "";
            this.txbFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbFirstName.Location = new System.Drawing.Point(218, 137);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.PasswordChar = '\0';
            this.txbFirstName.PlaceholderText = "";
            this.txbFirstName.SelectedText = "";
            this.txbFirstName.Size = new System.Drawing.Size(200, 36);
            this.txbFirstName.TabIndex = 1;
            // 
            // txbMiddleName
            // 
            this.txbMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMiddleName.DefaultText = "";
            this.txbMiddleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbMiddleName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbMiddleName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbMiddleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbMiddleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbMiddleName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbMiddleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbMiddleName.Location = new System.Drawing.Point(218, 192);
            this.txbMiddleName.Name = "txbMiddleName";
            this.txbMiddleName.PasswordChar = '\0';
            this.txbMiddleName.PlaceholderText = "";
            this.txbMiddleName.SelectedText = "";
            this.txbMiddleName.Size = new System.Drawing.Size(200, 36);
            this.txbMiddleName.TabIndex = 1;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveSettings.ForeColor = System.Drawing.Color.White;
            this.btnSaveSettings.Location = new System.Drawing.Point(218, 287);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(180, 45);
            this.btnSaveSettings.TabIndex = 2;
            this.btnSaveSettings.Text = "guna2Button1";
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.grbInformation);
            this.Controls.Add(this.label1);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(1324, 756);
            this.grbInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox grbInformation;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnSaveSettings;
        private Guna.UI2.WinForms.Guna2TextBox txbMiddleName;
        private Guna.UI2.WinForms.Guna2TextBox txbFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txbLastName;
    }
}
