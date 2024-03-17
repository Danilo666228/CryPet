namespace CryPet.Windows.Registration
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.SettingsForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlBackground = new Guna.UI2.WinForms.Guna2Panel();
            this.txbLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbMiddleName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbRepeatPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMain = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlBackground.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsForm
            // 
            this.SettingsForm.BorderRadius = 20;
            this.SettingsForm.ContainerControl = this;
            this.SettingsForm.DockIndicatorTransparencyValue = 0.6D;
            this.SettingsForm.TransparentWhileDrag = true;
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBackground.BackgroundImage")));
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackground.Controls.Add(this.pnlMain);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(894, 562);
            this.pnlBackground.TabIndex = 2;
            // 
            // txbLastName
            // 
            this.txbLastName.Animated = true;
            this.txbLastName.AutoRoundedCorners = true;
            this.txbLastName.BackColor = System.Drawing.Color.Transparent;
            this.txbLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txbLastName.BorderRadius = 19;
            this.txbLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbLastName.DefaultText = "";
            this.txbLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbLastName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbLastName.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbLastName.Location = new System.Drawing.Point(56, 56);
            this.txbLastName.Margin = new System.Windows.Forms.Padding(5);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.PasswordChar = '\0';
            this.txbLastName.PlaceholderText = "Фамилия";
            this.txbLastName.SelectedText = "";
            this.txbLastName.Size = new System.Drawing.Size(213, 41);
            this.txbLastName.TabIndex = 2;
            this.txbLastName.TabStop = false;
            this.txbLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Animated = true;
            this.txbFirstName.AutoRoundedCorners = true;
            this.txbFirstName.BackColor = System.Drawing.Color.Transparent;
            this.txbFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txbFirstName.BorderRadius = 19;
            this.txbFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbFirstName.DefaultText = "";
            this.txbFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbFirstName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbFirstName.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbFirstName.Location = new System.Drawing.Point(56, 124);
            this.txbFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.PasswordChar = '\0';
            this.txbFirstName.PlaceholderText = "Имя";
            this.txbFirstName.SelectedText = "";
            this.txbFirstName.Size = new System.Drawing.Size(213, 41);
            this.txbFirstName.TabIndex = 2;
            this.txbFirstName.TabStop = false;
            this.txbFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbMiddleName
            // 
            this.txbMiddleName.Animated = true;
            this.txbMiddleName.AutoRoundedCorners = true;
            this.txbMiddleName.BackColor = System.Drawing.Color.Transparent;
            this.txbMiddleName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txbMiddleName.BorderRadius = 19;
            this.txbMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMiddleName.DefaultText = "";
            this.txbMiddleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbMiddleName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbMiddleName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbMiddleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbMiddleName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMiddleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbMiddleName.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbMiddleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbMiddleName.Location = new System.Drawing.Point(56, 207);
            this.txbMiddleName.Margin = new System.Windows.Forms.Padding(5);
            this.txbMiddleName.Name = "txbMiddleName";
            this.txbMiddleName.PasswordChar = '\0';
            this.txbMiddleName.PlaceholderText = "Отчество";
            this.txbMiddleName.SelectedText = "";
            this.txbMiddleName.Size = new System.Drawing.Size(213, 41);
            this.txbMiddleName.TabIndex = 2;
            this.txbMiddleName.TabStop = false;
            this.txbMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbLogin
            // 
            this.txbLogin.Animated = true;
            this.txbLogin.AutoRoundedCorners = true;
            this.txbLogin.BackColor = System.Drawing.Color.Transparent;
            this.txbLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txbLogin.BorderRadius = 19;
            this.txbLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbLogin.DefaultText = "";
            this.txbLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbLogin.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbLogin.Location = new System.Drawing.Point(344, 56);
            this.txbLogin.Margin = new System.Windows.Forms.Padding(5);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.PasswordChar = '\0';
            this.txbLogin.PlaceholderText = "Логин";
            this.txbLogin.SelectedText = "";
            this.txbLogin.Size = new System.Drawing.Size(213, 41);
            this.txbLogin.TabIndex = 2;
            this.txbLogin.TabStop = false;
            this.txbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbPassword
            // 
            this.txbPassword.Animated = true;
            this.txbPassword.AutoRoundedCorners = true;
            this.txbPassword.BackColor = System.Drawing.Color.Transparent;
            this.txbPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txbPassword.BorderRadius = 19;
            this.txbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPassword.DefaultText = "";
            this.txbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPassword.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbPassword.Location = new System.Drawing.Point(344, 124);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '\0';
            this.txbPassword.PlaceholderText = "Пароль";
            this.txbPassword.SelectedText = "";
            this.txbPassword.Size = new System.Drawing.Size(213, 41);
            this.txbPassword.TabIndex = 2;
            this.txbPassword.TabStop = false;
            this.txbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbRepeatPassword
            // 
            this.txbRepeatPassword.Animated = true;
            this.txbRepeatPassword.AutoRoundedCorners = true;
            this.txbRepeatPassword.BackColor = System.Drawing.Color.Transparent;
            this.txbRepeatPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txbRepeatPassword.BorderRadius = 19;
            this.txbRepeatPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbRepeatPassword.DefaultText = "";
            this.txbRepeatPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbRepeatPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbRepeatPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbRepeatPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbRepeatPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbRepeatPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbRepeatPassword.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbRepeatPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbRepeatPassword.Location = new System.Drawing.Point(344, 207);
            this.txbRepeatPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txbRepeatPassword.Name = "txbRepeatPassword";
            this.txbRepeatPassword.PasswordChar = '\0';
            this.txbRepeatPassword.PlaceholderText = "Пароль";
            this.txbRepeatPassword.SelectedText = "";
            this.txbRepeatPassword.Size = new System.Drawing.Size(213, 41);
            this.txbRepeatPassword.TabIndex = 2;
            this.txbRepeatPassword.TabStop = false;
            this.txbRepeatPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.BorderRadius = 21;
            this.btnLogin.BorderThickness = 1;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.Font = new System.Drawing.Font("JetBrains Mono", 14.25F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(223, 287);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 45);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Вход";
            this.btnLogin.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.txbLastName);
            this.pnlMain.Controls.Add(this.btnLogin);
            this.pnlMain.Controls.Add(this.txbFirstName);
            this.pnlMain.Controls.Add(this.txbRepeatPassword);
            this.pnlMain.Controls.Add(this.txbPassword);
            this.pnlMain.Controls.Add(this.txbMiddleName);
            this.pnlMain.Controls.Add(this.txbLogin);
            this.pnlMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMain.Location = new System.Drawing.Point(137, 117);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShadowColor = System.Drawing.Color.Black;
            this.pnlMain.Size = new System.Drawing.Size(618, 360);
            this.pnlMain.TabIndex = 4;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 562);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "Registration";
            this.pnlBackground.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm SettingsForm;
        private Guna.UI2.WinForms.Guna2Panel pnlBackground;
        private Guna.UI2.WinForms.Guna2TextBox txbRepeatPassword;
        private Guna.UI2.WinForms.Guna2TextBox txbMiddleName;
        private Guna.UI2.WinForms.Guna2TextBox txbPassword;
        private Guna.UI2.WinForms.Guna2TextBox txbLogin;
        private Guna.UI2.WinForms.Guna2TextBox txbFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txbLastName;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlMain;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
    }
}