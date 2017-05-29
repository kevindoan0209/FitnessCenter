namespace FitnessCenter
{
    partial class LockAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockAccess));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.btnDangNhap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cbxHienMatKhai = new DevExpress.XtraEditors.CheckEdit();
            this.lbTrangThai = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxHienMatKhai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.txtMatKhau);
            this.panel2.Location = new System.Drawing.Point(67, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 41);
            this.panel2.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(8, 10);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.txtMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtMatKhau.Properties.Appearance.Options.UseBackColor = true;
            this.txtMatKhau.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhau.Properties.Appearance.Options.UseForeColor = true;
            this.txtMatKhau.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtMatKhau.Properties.UseSystemPasswordChar = true;
            this.txtMatKhau.Size = new System.Drawing.Size(262, 20);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangNhap.BorderRadius = 0;
            this.btnDangNhap.ButtonText = "             Mở khóa";
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.DisabledColor = System.Drawing.Color.Gray;
            this.btnDangNhap.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDangNhap.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Iconimage")));
            this.btnDangNhap.Iconimage_right = null;
            this.btnDangNhap.Iconimage_right_Selected = null;
            this.btnDangNhap.Iconimage_Selected = null;
            this.btnDangNhap.IconMarginLeft = 12;
            this.btnDangNhap.IconMarginRight = 0;
            this.btnDangNhap.IconRightVisible = true;
            this.btnDangNhap.IconRightZoom = 0D;
            this.btnDangNhap.IconVisible = true;
            this.btnDangNhap.IconZoom = 75D;
            this.btnDangNhap.IsTab = false;
            this.btnDangNhap.Location = new System.Drawing.Point(67, 212);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDangNhap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.btnDangNhap.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDangNhap.selected = false;
            this.btnDangNhap.Size = new System.Drawing.Size(278, 41);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "             Mở khóa";
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.Textcolor = System.Drawing.Color.White;
            this.btnDangNhap.TextFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(386, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 20;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cbxHienMatKhai
            // 
            this.cbxHienMatKhai.Location = new System.Drawing.Point(351, 147);
            this.cbxHienMatKhai.Name = "cbxHienMatKhai";
            this.cbxHienMatKhai.Properties.Caption = "";
            this.cbxHienMatKhai.Size = new System.Drawing.Size(20, 19);
            this.cbxHienMatKhai.TabIndex = 8;
            this.cbxHienMatKhai.ToolTip = "Hiện mật khẩu";
            this.cbxHienMatKhai.CheckedChanged += new System.EventHandler(this.cbxHienMatKhai_CheckedChanged);
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.ForeColor = System.Drawing.Color.Red;
            this.lbTrangThai.Location = new System.Drawing.Point(72, 186);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(0, 16);
            this.lbTrangThai.TabIndex = 9;
            // 
            // LockAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(416, 267);
            this.Controls.Add(this.lbTrangThai);
            this.Controls.Add(this.cbxHienMatKhai);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LockAccess";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxHienMatKhai.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnDangNhap;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private DevExpress.XtraEditors.CheckEdit cbxHienMatKhai;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTrangThai;
    }
}