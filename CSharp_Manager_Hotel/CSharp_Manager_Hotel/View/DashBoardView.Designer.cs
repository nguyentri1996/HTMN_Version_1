namespace CSharp_Manager_Hotel.DashBoard.View
{
    partial class DashBoardView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardView));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHelp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAnalysis = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRecord = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnManager = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSystem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelContent = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 50);
            this.panelTop.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnHelp);
            this.panel2.Controls.Add(this.btnAnalysis);
            this.panel2.Controls.Add(this.btnRecord);
            this.panel2.Controls.Add(this.btnManager);
            this.panel2.Controls.Add(this.btnSystem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 650);
            this.panel2.TabIndex = 1;
            // 
            // btnHelp
            // 
            this.btnHelp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.BorderRadius = 0;
            this.btnHelp.ButtonText = "TRỢ GIÚP";
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.DisabledColor = System.Drawing.Color.Gray;
            this.btnHelp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHelp.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHelp.Iconimage")));
            this.btnHelp.Iconimage_right = null;
            this.btnHelp.Iconimage_right_Selected = null;
            this.btnHelp.Iconimage_Selected = null;
            this.btnHelp.IconMarginLeft = 0;
            this.btnHelp.IconMarginRight = 0;
            this.btnHelp.IconRightVisible = true;
            this.btnHelp.IconRightZoom = 0D;
            this.btnHelp.IconVisible = true;
            this.btnHelp.IconZoom = 90D;
            this.btnHelp.IsTab = false;
            this.btnHelp.Location = new System.Drawing.Point(0, 268);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnHelp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnHelp.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHelp.selected = false;
            this.btnHelp.Size = new System.Drawing.Size(200, 70);
            this.btnHelp.TabIndex = 1;
            this.btnHelp.Text = "TRỢ GIÚP";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Textcolor = System.Drawing.Color.White;
            this.btnHelp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAnalysis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnalysis.BorderRadius = 0;
            this.btnAnalysis.ButtonText = "THỐNG KÊ";
            this.btnAnalysis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalysis.DisabledColor = System.Drawing.Color.Gray;
            this.btnAnalysis.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAnalysis.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAnalysis.Iconimage")));
            this.btnAnalysis.Iconimage_right = null;
            this.btnAnalysis.Iconimage_right_Selected = null;
            this.btnAnalysis.Iconimage_Selected = null;
            this.btnAnalysis.IconMarginLeft = 0;
            this.btnAnalysis.IconMarginRight = 0;
            this.btnAnalysis.IconRightVisible = true;
            this.btnAnalysis.IconRightZoom = 0D;
            this.btnAnalysis.IconVisible = true;
            this.btnAnalysis.IconZoom = 90D;
            this.btnAnalysis.IsTab = false;
            this.btnAnalysis.Location = new System.Drawing.Point(0, 201);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAnalysis.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAnalysis.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAnalysis.selected = false;
            this.btnAnalysis.Size = new System.Drawing.Size(200, 70);
            this.btnAnalysis.TabIndex = 3;
            this.btnAnalysis.Text = "THỐNG KÊ";
            this.btnAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalysis.Textcolor = System.Drawing.Color.White;
            this.btnAnalysis.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecord.BorderRadius = 0;
            this.btnRecord.ButtonText = "DANH MỤC";
            this.btnRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecord.DisabledColor = System.Drawing.Color.Gray;
            this.btnRecord.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRecord.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRecord.Iconimage")));
            this.btnRecord.Iconimage_right = null;
            this.btnRecord.Iconimage_right_Selected = null;
            this.btnRecord.Iconimage_Selected = null;
            this.btnRecord.IconMarginLeft = 0;
            this.btnRecord.IconMarginRight = 0;
            this.btnRecord.IconRightVisible = true;
            this.btnRecord.IconRightZoom = 0D;
            this.btnRecord.IconVisible = true;
            this.btnRecord.IconZoom = 90D;
            this.btnRecord.IsTab = false;
            this.btnRecord.Location = new System.Drawing.Point(0, 134);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRecord.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRecord.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRecord.selected = false;
            this.btnRecord.Size = new System.Drawing.Size(200, 70);
            this.btnRecord.TabIndex = 2;
            this.btnRecord.Text = "DANH MỤC";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.Textcolor = System.Drawing.Color.White;
            this.btnRecord.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnManager
            // 
            this.btnManager.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManager.BorderRadius = 0;
            this.btnManager.ButtonText = "QUẢN LÝ";
            this.btnManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManager.DisabledColor = System.Drawing.Color.Gray;
            this.btnManager.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManager.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnManager.Iconimage")));
            this.btnManager.Iconimage_right = null;
            this.btnManager.Iconimage_right_Selected = null;
            this.btnManager.Iconimage_Selected = null;
            this.btnManager.IconMarginLeft = 0;
            this.btnManager.IconMarginRight = 0;
            this.btnManager.IconRightVisible = true;
            this.btnManager.IconRightZoom = 0D;
            this.btnManager.IconVisible = true;
            this.btnManager.IconZoom = 90D;
            this.btnManager.IsTab = false;
            this.btnManager.Location = new System.Drawing.Point(0, 67);
            this.btnManager.Name = "btnManager";
            this.btnManager.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnManager.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnManager.OnHoverTextColor = System.Drawing.Color.White;
            this.btnManager.selected = false;
            this.btnManager.Size = new System.Drawing.Size(200, 70);
            this.btnManager.TabIndex = 1;
            this.btnManager.Text = "QUẢN LÝ";
            this.btnManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManager.Textcolor = System.Drawing.Color.White;
            this.btnManager.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnSystem
            // 
            this.btnSystem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSystem.BorderRadius = 0;
            this.btnSystem.ButtonText = "HỆ THỐNG";
            this.btnSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSystem.DisabledColor = System.Drawing.Color.Gray;
            this.btnSystem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSystem.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSystem.Iconimage")));
            this.btnSystem.Iconimage_right = null;
            this.btnSystem.Iconimage_right_Selected = null;
            this.btnSystem.Iconimage_Selected = null;
            this.btnSystem.IconMarginLeft = 0;
            this.btnSystem.IconMarginRight = 0;
            this.btnSystem.IconRightVisible = true;
            this.btnSystem.IconRightZoom = 0D;
            this.btnSystem.IconVisible = true;
            this.btnSystem.IconZoom = 90D;
            this.btnSystem.IsTab = false;
            this.btnSystem.Location = new System.Drawing.Point(0, 0);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSystem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSystem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSystem.selected = false;
            this.btnSystem.Size = new System.Drawing.Size(200, 70);
            this.btnSystem.TabIndex = 0;
            this.btnSystem.Text = "HỆ THỐNG";
            this.btnSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystem.Textcolor = System.Drawing.Color.White;
            this.btnSystem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContent.Location = new System.Drawing.Point(200, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 650);
            this.panelContent.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(947, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DashBoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoardView";
            this.Text = "DashBoardView";
            this.panelTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.Panel panelContent;
        private Bunifu.Framework.UI.BunifuFlatButton btnSystem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTop;
        private Bunifu.Framework.UI.BunifuFlatButton btnHelp;
        private Bunifu.Framework.UI.BunifuFlatButton btnAnalysis;
        private Bunifu.Framework.UI.BunifuFlatButton btnRecord;
        private Bunifu.Framework.UI.BunifuFlatButton btnManager;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox btnClose;
    }
}