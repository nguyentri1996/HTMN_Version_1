namespace CSharp_Manager_Hotel
{
    partial class SystemView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemView));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnLogin = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnLogout = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnResetPass = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnUser = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.color = System.Drawing.Color.SeaGreen;
            this.btnLogin.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImagePosition = 20;
            this.btnLogin.ImageZoom = 25;
            this.btnLogin.LabelPosition = 41;
            this.btnLogin.LabelText = "ĐĂNG NHẬP";
            this.btnLogin.Location = new System.Drawing.Point(15, 15);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(376, 180);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLogout.color = System.Drawing.Color.SeaGreen;
            this.btnLogout.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImagePosition = 20;
            this.btnLogout.ImageZoom = 25;
            this.btnLogout.LabelPosition = 41;
            this.btnLogout.LabelText = "ĐĂNG XUẤT";
            this.btnLogout.Location = new System.Drawing.Point(409, 15);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(376, 180);
            this.btnLogout.TabIndex = 1;
            // 
            // btnResetPass
            // 
            this.btnResetPass.BackColor = System.Drawing.Color.SeaGreen;
            this.btnResetPass.color = System.Drawing.Color.SeaGreen;
            this.btnResetPass.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnResetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPass.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnResetPass.ForeColor = System.Drawing.Color.White;
            this.btnResetPass.Image = ((System.Drawing.Image)(resources.GetObject("btnResetPass.Image")));
            this.btnResetPass.ImagePosition = 20;
            this.btnResetPass.ImageZoom = 25;
            this.btnResetPass.LabelPosition = 41;
            this.btnResetPass.LabelText = "ĐỔI MẬT KHẨU";
            this.btnResetPass.Location = new System.Drawing.Point(15, 207);
            this.btnResetPass.Margin = new System.Windows.Forms.Padding(6);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(376, 180);
            this.btnResetPass.TabIndex = 2;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUser.color = System.Drawing.Color.SeaGreen;
            this.btnUser.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImagePosition = 20;
            this.btnUser.ImageZoom = 25;
            this.btnUser.LabelPosition = 41;
            this.btnUser.LabelText = "NGƯỜI DÙNG";
            this.btnUser.Location = new System.Drawing.Point(409, 207);
            this.btnUser.Margin = new System.Windows.Forms.Padding(6);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(376, 180);
            this.btnUser.TabIndex = 3;
            // 
            // SystemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnResetPass);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemView";
            this.Text = "SystemView";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuTileButton btnLogin;
        private Bunifu.Framework.UI.BunifuTileButton btnUser;
        private Bunifu.Framework.UI.BunifuTileButton btnResetPass;
        private Bunifu.Framework.UI.BunifuTileButton btnLogout;
    }
}