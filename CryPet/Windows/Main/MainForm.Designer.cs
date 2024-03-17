namespace CryPet.Windows.Main
{
    partial class MainForm
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
            this.SettingsForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimizeForm = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnMaximizeForm = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnMarket = new Guna.UI2.WinForms.Guna2Button();
            this.btnMain = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.MiniProfile = new CryPet.Windows.Main.MiniProfile();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.ProfileControl = new CryPet.Windows.Main.ProfileControl();
            this.MarketControl = new CryPet.Windows.Main.MarketControl();
            this.MainControl = new CryPet.Windows.Main.MainControl();
            this.btnExitProfile = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsForm
            // 
            this.SettingsForm.BorderRadius = 20;
            this.SettingsForm.ContainerControl = this;
            this.SettingsForm.DockIndicatorTransparencyValue = 0.6D;
            this.SettingsForm.TransparentWhileDrag = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnMinimizeForm);
            this.pnlHeader.Controls.Add(this.btnMaximizeForm);
            this.pnlHeader.Controls.Add(this.btnCloseForm);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1600, 44);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnMinimizeForm
            // 
            this.btnMinimizeForm.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizeForm.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimizeForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizeForm.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimizeForm.IconColor = System.Drawing.Color.White;
            this.btnMinimizeForm.Location = new System.Drawing.Point(1465, 0);
            this.btnMinimizeForm.Name = "btnMinimizeForm";
            this.btnMinimizeForm.Size = new System.Drawing.Size(45, 44);
            this.btnMinimizeForm.TabIndex = 0;
            // 
            // btnMaximizeForm
            // 
            this.btnMaximizeForm.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizeForm.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnMaximizeForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizeForm.FillColor = System.Drawing.Color.Transparent;
            this.btnMaximizeForm.IconColor = System.Drawing.Color.White;
            this.btnMaximizeForm.Location = new System.Drawing.Point(1510, 0);
            this.btnMaximizeForm.Name = "btnMaximizeForm";
            this.btnMaximizeForm.Size = new System.Drawing.Size(45, 44);
            this.btnMaximizeForm.TabIndex = 0;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseForm.FillColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.IconColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(1555, 0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(45, 44);
            this.btnCloseForm.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnExitProfile);
            this.guna2Panel1.Controls.Add(this.btProfile);
            this.guna2Panel1.Controls.Add(this.btnMarket);
            this.guna2Panel1.Controls.Add(this.btnMain);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 44);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(276, 756);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btProfile
            // 
            this.btProfile.Animated = true;
            this.btProfile.BorderRadius = 15;
            this.btProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btProfile.FillColor = System.Drawing.Color.Transparent;
            this.btProfile.Font = new System.Drawing.Font("JetBrains Mono", 14.25F);
            this.btProfile.ForeColor = System.Drawing.Color.White;
            this.btProfile.Location = new System.Drawing.Point(0, 294);
            this.btProfile.Name = "btProfile";
            this.btProfile.Size = new System.Drawing.Size(276, 94);
            this.btProfile.TabIndex = 1;
            this.btProfile.Text = "Профиль";
            this.btProfile.Click += new System.EventHandler(this.btProfile_Click);
            // 
            // btnMarket
            // 
            this.btnMarket.Animated = true;
            this.btnMarket.BorderRadius = 15;
            this.btnMarket.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMarket.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMarket.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMarket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMarket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMarket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarket.FillColor = System.Drawing.Color.Transparent;
            this.btnMarket.Font = new System.Drawing.Font("JetBrains Mono", 14.25F);
            this.btnMarket.ForeColor = System.Drawing.Color.White;
            this.btnMarket.Location = new System.Drawing.Point(0, 200);
            this.btnMarket.Name = "btnMarket";
            this.btnMarket.Size = new System.Drawing.Size(276, 94);
            this.btnMarket.TabIndex = 1;
            this.btnMarket.Text = "Рынок";
            this.btnMarket.Click += new System.EventHandler(this.btnMarket_Click);
            // 
            // btnMain
            // 
            this.btnMain.Animated = true;
            this.btnMain.BorderRadius = 15;
            this.btnMain.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMain.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMain.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMain.FillColor = System.Drawing.Color.Transparent;
            this.btnMain.Font = new System.Drawing.Font("JetBrains Mono", 14.25F);
            this.btnMain.ForeColor = System.Drawing.Color.White;
            this.btnMain.Location = new System.Drawing.Point(0, 106);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(276, 94);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "Главная";
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.MiniProfile);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(276, 106);
            this.guna2Panel2.TabIndex = 0;
            // 
            // MiniProfile
            // 
            this.MiniProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MiniProfile.BalanceUser = "Баланс";
            this.MiniProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiniProfile.Location = new System.Drawing.Point(0, 0);
            this.MiniProfile.Name = "MiniProfile";
            this.MiniProfile.NameUser = "Имя";
            this.MiniProfile.PhotoUser = null;
            this.MiniProfile.Size = new System.Drawing.Size(276, 106);
            this.MiniProfile.TabIndex = 2;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.ProfileControl);
            this.guna2Panel3.Controls.Add(this.MarketControl);
            this.guna2Panel3.Controls.Add(this.MainControl);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(276, 44);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1324, 756);
            this.guna2Panel3.TabIndex = 2;
            // 
            // ProfileControl
            // 
            this.ProfileControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProfileControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileControl.Location = new System.Drawing.Point(0, 0);
            this.ProfileControl.Name = "ProfileControl";
            this.ProfileControl.Size = new System.Drawing.Size(1324, 756);
            this.ProfileControl.TabIndex = 2;
            // 
            // MarketControl
            // 
            this.MarketControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MarketControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarketControl.Location = new System.Drawing.Point(0, 0);
            this.MarketControl.Name = "MarketControl";
            this.MarketControl.Size = new System.Drawing.Size(1324, 756);
            this.MarketControl.TabIndex = 1;
            // 
            // MainControl
            // 
            this.MainControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainControl.Location = new System.Drawing.Point(0, 0);
            this.MainControl.Name = "MainControl";
            this.MainControl.Size = new System.Drawing.Size(1324, 756);
            this.MainControl.TabIndex = 0;
            // 
            // btnExitProfile
            // 
            this.btnExitProfile.Animated = true;
            this.btnExitProfile.BorderRadius = 15;
            this.btnExitProfile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnExitProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExitProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExitProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExitProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExitProfile.FillColor = System.Drawing.Color.Transparent;
            this.btnExitProfile.Font = new System.Drawing.Font("JetBrains Mono", 14.25F);
            this.btnExitProfile.ForeColor = System.Drawing.Color.White;
            this.btnExitProfile.Location = new System.Drawing.Point(3, 659);
            this.btnExitProfile.Name = "btnExitProfile";
            this.btnExitProfile.Size = new System.Drawing.Size(276, 94);
            this.btnExitProfile.TabIndex = 2;
            this.btnExitProfile.Text = "Сменить пользователя";
            this.btnExitProfile.Click += new System.EventHandler(this.btnExitProfile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1600, 800);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm SettingsForm;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimizeForm;
        private Guna.UI2.WinForms.Guna2ControlBox btnMaximizeForm;
        private Guna.UI2.WinForms.Guna2ControlBox btnCloseForm;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnMain;
        private Guna.UI2.WinForms.Guna2Button btProfile;
        private Guna.UI2.WinForms.Guna2Button btnMarket;
        private MiniProfile MiniProfile;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private MainControl MainControl;
        private ProfileControl ProfileControl;
        private MarketControl MarketControl;
        private Guna.UI2.WinForms.Guna2Button btnExitProfile;
    }
}