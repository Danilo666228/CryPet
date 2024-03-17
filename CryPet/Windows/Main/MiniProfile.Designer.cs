namespace CryPet.Windows.Main
{
    partial class MiniProfile
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
            this.lblNameUser = new System.Windows.Forms.Label();
            this.lblBalanceUser = new System.Windows.Forms.Label();
            this.pcbPhotoUser = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhotoUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNameUser.Location = new System.Drawing.Point(108, 21);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(45, 25);
            this.lblNameUser.TabIndex = 1;
            this.lblNameUser.Text = "Имя";
            // 
            // lblBalanceUser
            // 
            this.lblBalanceUser.AutoSize = true;
            this.lblBalanceUser.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBalanceUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBalanceUser.Location = new System.Drawing.Point(108, 56);
            this.lblBalanceUser.Name = "lblBalanceUser";
            this.lblBalanceUser.Size = new System.Drawing.Size(78, 25);
            this.lblBalanceUser.TabIndex = 1;
            this.lblBalanceUser.Text = "Баланс";
            // 
            // pcbPhotoUser
            // 
            this.pcbPhotoUser.BackColor = System.Drawing.Color.Transparent;
            this.pcbPhotoUser.BorderRadius = 10;
            this.pcbPhotoUser.ImageRotate = 0F;
            this.pcbPhotoUser.Location = new System.Drawing.Point(19, 21);
            this.pcbPhotoUser.Name = "pcbPhotoUser";
            this.pcbPhotoUser.Size = new System.Drawing.Size(66, 60);
            this.pcbPhotoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPhotoUser.TabIndex = 0;
            this.pcbPhotoUser.TabStop = false;
            this.pcbPhotoUser.UseTransparentBackground = true;
            // 
            // MiniProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lblBalanceUser);
            this.Controls.Add(this.lblNameUser);
            this.Controls.Add(this.pcbPhotoUser);
            this.Name = "MiniProfile";
            this.Size = new System.Drawing.Size(276, 106);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhotoUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pcbPhotoUser;
        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.Label lblBalanceUser;
    }
}
