namespace FitnessCenter
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaKhauCu = new DevExpress.XtraEditors.TextEdit();
            this.btnDoiMatKhau = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cbxHienMatKhai = new DevExpress.XtraEditors.CheckEdit();
            this.lbTrangThai = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMatKhau2 = new DevExpress.XtraEditors.TextEdit();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtHienCu = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhauCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxHienMatKhai.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau2.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHienCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Location = new System.Drawing.Point(66, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 41);
            this.panel1.TabIndex = 0;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(8, 11);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtTen.Properties.Appearance.Options.UseBackColor = true;
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Properties.Appearance.Options.UseForeColor = true;
            this.txtTen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtTen.Size = new System.Drawing.Size(262, 20);
            this.txtTen.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.txtMaKhauCu);
            this.panel2.Location = new System.Drawing.Point(66, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 41);
            this.panel2.TabIndex = 1;
            // 
            // txtMaKhauCu
            // 
            this.txtMaKhauCu.Location = new System.Drawing.Point(8, 10);
            this.txtMaKhauCu.Name = "txtMaKhauCu";
            this.txtMaKhauCu.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.txtMaKhauCu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhauCu.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtMaKhauCu.Properties.Appearance.Options.UseBackColor = true;
            this.txtMaKhauCu.Properties.Appearance.Options.UseFont = true;
            this.txtMaKhauCu.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaKhauCu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtMaKhauCu.Properties.UseSystemPasswordChar = true;
            this.txtMaKhauCu.Size = new System.Drawing.Size(262, 20);
            this.txtMaKhauCu.TabIndex = 3;
            this.txtMaKhauCu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKhauCu_KeyPress);
            this.txtMaKhauCu.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaKhauCu_Validating);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDoiMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoiMatKhau.BorderRadius = 0;
            this.btnDoiMatKhau.ButtonText = "              Đổi mật khẩu";
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMatKhau.DisabledColor = System.Drawing.Color.Gray;
            this.btnDoiMatKhau.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDoiMatKhau.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.Iconimage")));
            this.btnDoiMatKhau.Iconimage_right = null;
            this.btnDoiMatKhau.Iconimage_right_Selected = null;
            this.btnDoiMatKhau.Iconimage_Selected = null;
            this.btnDoiMatKhau.IconMarginLeft = 12;
            this.btnDoiMatKhau.IconMarginRight = 0;
            this.btnDoiMatKhau.IconRightVisible = true;
            this.btnDoiMatKhau.IconRightZoom = 0D;
            this.btnDoiMatKhau.IconVisible = true;
            this.btnDoiMatKhau.IconZoom = 75D;
            this.btnDoiMatKhau.IsTab = false;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(66, 370);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDoiMatKhau.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(149)))), ((int)(((byte)(222)))));
            this.btnDoiMatKhau.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.selected = false;
            this.btnDoiMatKhau.Size = new System.Drawing.Size(278, 41);
            this.btnDoiMatKhau.TabIndex = 2;
            this.btnDoiMatKhau.Text = "              Đổi mật khẩu";
            this.btnDoiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMatKhau.Textcolor = System.Drawing.Color.White;
            this.btnDoiMatKhau.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(382, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 20;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(63, 29);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(71, 16);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Họ và tên :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(63, 108);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(85, 16);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "Mật khẩu cũ :";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cbxHienMatKhai
            // 
            this.cbxHienMatKhai.Location = new System.Drawing.Point(360, 298);
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
            this.lbTrangThai.Location = new System.Drawing.Point(69, 341);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(0, 16);
            this.lbTrangThai.TabIndex = 9;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(63, 267);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(121, 16);
            this.bunifuCustomLabel3.TabIndex = 13;
            this.bunifuCustomLabel3.Text = "Nhập lại mật khẩu :";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(63, 190);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(93, 16);
            this.bunifuCustomLabel4.TabIndex = 12;
            this.bunifuCustomLabel4.Text = "Mật khẩu mới :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.txtMatKhau2);
            this.panel3.Location = new System.Drawing.Point(66, 287);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 41);
            this.panel3.TabIndex = 11;
            // 
            // txtMatKhau2
            // 
            this.txtMatKhau2.Location = new System.Drawing.Point(8, 10);
            this.txtMatKhau2.Name = "txtMatKhau2";
            this.txtMatKhau2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.txtMatKhau2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau2.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtMatKhau2.Properties.Appearance.Options.UseBackColor = true;
            this.txtMatKhau2.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhau2.Properties.Appearance.Options.UseForeColor = true;
            this.txtMatKhau2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtMatKhau2.Properties.UseSystemPasswordChar = true;
            this.txtMatKhau2.Size = new System.Drawing.Size(262, 20);
            this.txtMatKhau2.TabIndex = 3;
            this.txtMatKhau2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau2_KeyPress);
            this.txtMatKhau2.Validating += new System.ComponentModel.CancelEventHandler(this.txtMatKhau2_Validating);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.panel4.Controls.Add(this.txtMatKhau);
            this.panel4.Location = new System.Drawing.Point(66, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 41);
            this.panel4.TabIndex = 10;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(8, 11);
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
            this.txtMatKhau.TabIndex = 0;
            this.txtMatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_KeyPress);
            this.txtMatKhau.Validating += new System.ComponentModel.CancelEventHandler(this.txtMatKhau_Validating);
            // 
            // txtHienCu
            // 
            this.txtHienCu.Location = new System.Drawing.Point(390, 419);
            this.txtHienCu.Name = "txtHienCu";
            this.txtHienCu.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.txtHienCu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHienCu.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtHienCu.Properties.Appearance.Options.UseBackColor = true;
            this.txtHienCu.Properties.Appearance.Options.UseFont = true;
            this.txtHienCu.Properties.Appearance.Options.UseForeColor = true;
            this.txtHienCu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtHienCu.Properties.UseSystemPasswordChar = true;
            this.txtHienCu.Size = new System.Drawing.Size(10, 20);
            this.txtHienCu.TabIndex = 14;
            this.txtHienCu.Visible = false;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(390, 419);
            this.txtMa.Name = "txtMa";
            this.txtMa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.txtMa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtMa.Properties.Appearance.Options.UseBackColor = true;
            this.txtMa.Properties.Appearance.Options.UseFont = true;
            this.txtMa.Properties.Appearance.Options.UseForeColor = true;
            this.txtMa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtMa.Properties.UseSystemPasswordChar = true;
            this.txtMa.Size = new System.Drawing.Size(10, 20);
            this.txtMa.TabIndex = 15;
            this.txtMa.Visible = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(412, 447);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.txtHienCu);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lbTrangThai);
            this.Controls.Add(this.cbxHienMatKhai);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhauCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxHienMatKhai.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau2.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHienCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnDoiMatKhau;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtMaKhauCu;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private DevExpress.XtraEditors.CheckEdit cbxHienMatKhai;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTrangThai;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.TextEdit txtMatKhau2;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.TextEdit txtHienCu;
    }
}