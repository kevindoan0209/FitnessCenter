namespace FitnessCenter
{
    partial class ExpireMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpireMember));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.AllColumns allColumns1 = new DevExpress.DataAccess.Sql.AllColumns();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.AllColumns allColumns2 = new DevExpress.DataAccess.Sql.AllColumns();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            this.lbTrangThai = new DevExpress.XtraEditors.LabelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnGiaHan = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.HeaderExpire = new DevExpress.XtraEditors.PanelControl();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.grcDanhMuc = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.csmGiaHan = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlDataSource5 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gvDanhMuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomer_ID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Name2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Image1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Age2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Sex2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Email1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Phone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Job1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Address1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMembership_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_StartDate2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_EndDate2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer_Note1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMembership_Membership_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMembership_Name1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMembership_Price1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMembership_Note = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderExpire)).BeginInit();
            this.HeaderExpire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbTrangThai.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lbTrangThai.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lbTrangThai.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.lbTrangThai.Location = new System.Drawing.Point(27, 14);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(0, 15);
            this.lbTrangThai.TabIndex = 34;
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(483, 9);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 25);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Đóng";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaHan.Image")));
            this.btnGiaHan.Location = new System.Drawing.Point(402, 9);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(75, 25);
            this.btnGiaHan.TabIndex = 0;
            this.btnGiaHan.Text = "Gia hạn";
            this.btnGiaHan.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.lbTrangThai);
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.btnGiaHan);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 267);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(567, 44);
            this.panelControl1.TabIndex = 8;
         
            // 
            // HeaderExpire
            // 
            this.HeaderExpire.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.HeaderExpire.Appearance.Options.UseBackColor = true;
            this.HeaderExpire.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.HeaderExpire.Controls.Add(this.bunifuCustomLabel2);
            this.HeaderExpire.Controls.Add(this.pictureBox6);
            this.HeaderExpire.Controls.Add(this.btnClose);
            this.HeaderExpire.Controls.Add(this.bunifuCustomLabel1);
            this.HeaderExpire.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderExpire.Location = new System.Drawing.Point(0, 0);
            this.HeaderExpire.Name = "HeaderExpire";
            this.HeaderExpire.Size = new System.Drawing.Size(567, 34);
            this.HeaderExpire.TabIndex = 10;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(35, 8);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(114, 18);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Hội viên hết hạn";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(9, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(538, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 20;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(39, 8);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(0, 19);
            this.bunifuCustomLabel1.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.HeaderExpire;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // grcDanhMuc
            // 
            this.grcDanhMuc.ContextMenuStrip = this.contextMenuStrip1;
            this.grcDanhMuc.DataMember = "Customer";
            this.grcDanhMuc.DataSource = this.sqlDataSource5;
            this.grcDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.TextStringFormat = "Trang {0} / {1}";
            this.grcDanhMuc.Location = new System.Drawing.Point(0, 34);
            this.grcDanhMuc.MainView = this.gvDanhMuc;
            this.grcDanhMuc.Name = "grcDanhMuc";
            this.grcDanhMuc.Size = new System.Drawing.Size(567, 233);
            this.grcDanhMuc.TabIndex = 13;
            this.grcDanhMuc.UseEmbeddedNavigator = true;
            this.grcDanhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMuc});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csmGiaHan});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 26);
            // 
            // csmGiaHan
            // 
            this.csmGiaHan.Name = "csmGiaHan";
            this.csmGiaHan.Size = new System.Drawing.Size(114, 22);
            this.csmGiaHan.Text = "Gia hạn";
            this.csmGiaHan.Click += new System.EventHandler(this.csmGiaHan_Click);
            // 
            // sqlDataSource5
            // 
            this.sqlDataSource5.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_FitnessCenter_Connection";
            this.sqlDataSource5.Name = "sqlDataSource5";
            table1.MetaSerializable = "0|0|125|300";
            table1.Name = "Customer";
            allColumns1.Table = table1;
            table2.MetaSerializable = "0|0|125|120";
            table2.Name = "Membership";
            allColumns2.Table = table2;
            selectQuery1.Columns.Add(allColumns1);
            selectQuery1.Columns.Add(allColumns2);
            selectQuery1.FilterString = "[Customer.Customer_EndDate] <= ?Parameter2";
            selectQuery1.Name = "Customer";
            queryParameter1.Name = "Parameter2";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("LOCALDATETIMENOW()", typeof(System.DateTime));
            selectQuery1.Parameters.Add(queryParameter1);
            relationColumnInfo1.NestedKeyColumn = "Membership_ID";
            relationColumnInfo1.ParentKeyColumn = "Membership_ID";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            this.sqlDataSource5.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource5.ResultSchemaSerializable = resources.GetString("sqlDataSource5.ResultSchemaSerializable");
            // 
            // gvDanhMuc
            // 
            this.gvDanhMuc.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDanhMuc.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDanhMuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomer_ID2,
            this.colCustomer_Name2,
            this.colCustomer_Image1,
            this.colCustomer_Age2,
            this.colCustomer_Sex2,
            this.colCustomer_Email1,
            this.colCustomer_Phone1,
            this.colCustomer_Job1,
            this.colCustomer_Address1,
            this.colMembership_ID1,
            this.colCustomer_StartDate2,
            this.colCustomer_EndDate2,
            this.colCustomer_Note1,
            this.colMembership_Membership_ID,
            this.colMembership_Name1,
            this.colMembership_Price1,
            this.colMembership_Note});
            this.gvDanhMuc.GridControl = this.grcDanhMuc;
            this.gvDanhMuc.Name = "gvDanhMuc";
            this.gvDanhMuc.OptionsBehavior.Editable = false;
            this.gvDanhMuc.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDanhMuc.OptionsView.ShowGroupPanel = false;
            // 
            // colCustomer_ID2
            // 
            this.colCustomer_ID2.FieldName = "Customer_ID";
            this.colCustomer_ID2.Name = "colCustomer_ID2";
            // 
            // colCustomer_Name2
            // 
            this.colCustomer_Name2.Caption = "Tên hội viên";
            this.colCustomer_Name2.FieldName = "Customer_Name";
            this.colCustomer_Name2.Name = "colCustomer_Name2";
            this.colCustomer_Name2.Visible = true;
            this.colCustomer_Name2.VisibleIndex = 0;
            this.colCustomer_Name2.Width = 188;
            // 
            // colCustomer_Image1
            // 
            this.colCustomer_Image1.FieldName = "Customer_Image";
            this.colCustomer_Image1.Name = "colCustomer_Image1";
            // 
            // colCustomer_Age2
            // 
            this.colCustomer_Age2.Caption = "Ngày sinh";
            this.colCustomer_Age2.FieldName = "Customer_Age";
            this.colCustomer_Age2.Name = "colCustomer_Age2";
            this.colCustomer_Age2.Visible = true;
            this.colCustomer_Age2.VisibleIndex = 1;
            this.colCustomer_Age2.Width = 81;
            // 
            // colCustomer_Sex2
            // 
            this.colCustomer_Sex2.Caption = "Giới tính";
            this.colCustomer_Sex2.FieldName = "Customer_Sex";
            this.colCustomer_Sex2.Name = "colCustomer_Sex2";
            this.colCustomer_Sex2.Visible = true;
            this.colCustomer_Sex2.VisibleIndex = 2;
            this.colCustomer_Sex2.Width = 55;
            // 
            // colCustomer_Email1
            // 
            this.colCustomer_Email1.FieldName = "Customer_Email";
            this.colCustomer_Email1.Name = "colCustomer_Email1";
            // 
            // colCustomer_Phone1
            // 
            this.colCustomer_Phone1.FieldName = "Customer_Phone";
            this.colCustomer_Phone1.Name = "colCustomer_Phone1";
            // 
            // colCustomer_Job1
            // 
            this.colCustomer_Job1.FieldName = "Customer_Job";
            this.colCustomer_Job1.Name = "colCustomer_Job1";
            // 
            // colCustomer_Address1
            // 
            this.colCustomer_Address1.FieldName = "Customer_Address";
            this.colCustomer_Address1.Name = "colCustomer_Address1";
            // 
            // colMembership_ID1
            // 
            this.colMembership_ID1.FieldName = "Membership_ID";
            this.colMembership_ID1.Name = "colMembership_ID1";
            // 
            // colCustomer_StartDate2
            // 
            this.colCustomer_StartDate2.FieldName = "Customer_StartDate";
            this.colCustomer_StartDate2.Name = "colCustomer_StartDate2";
            // 
            // colCustomer_EndDate2
            // 
            this.colCustomer_EndDate2.Caption = "Ngày hết hạn";
            this.colCustomer_EndDate2.FieldName = "Customer_EndDate";
            this.colCustomer_EndDate2.Name = "colCustomer_EndDate2";
            this.colCustomer_EndDate2.Visible = true;
            this.colCustomer_EndDate2.VisibleIndex = 3;
            this.colCustomer_EndDate2.Width = 92;
            // 
            // colCustomer_Note1
            // 
            this.colCustomer_Note1.FieldName = "Customer_Note";
            this.colCustomer_Note1.Name = "colCustomer_Note1";
            // 
            // colMembership_Membership_ID
            // 
            this.colMembership_Membership_ID.FieldName = "Membership_Membership_ID";
            this.colMembership_Membership_ID.Name = "colMembership_Membership_ID";
            // 
            // colMembership_Name1
            // 
            this.colMembership_Name1.Caption = "Loại thẻ";
            this.colMembership_Name1.FieldName = "Membership_Name";
            this.colMembership_Name1.Name = "colMembership_Name1";
            this.colMembership_Name1.Visible = true;
            this.colMembership_Name1.VisibleIndex = 4;
            this.colMembership_Name1.Width = 77;
            // 
            // colMembership_Price1
            // 
            this.colMembership_Price1.Caption = "Đơn giá";
            this.colMembership_Price1.FieldName = "Membership_Price";
            this.colMembership_Price1.Name = "colMembership_Price1";
            this.colMembership_Price1.Visible = true;
            this.colMembership_Price1.VisibleIndex = 5;
            this.colMembership_Price1.Width = 56;
            // 
            // colMembership_Note
            // 
            this.colMembership_Note.FieldName = "Membership_Note";
            this.colMembership_Note.Name = "colMembership_Note";
            // 
            // ExpireMember
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 311);
            this.ControlBox = false;
            this.Controls.Add(this.grcDanhMuc);
            this.Controls.Add(this.HeaderExpire);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExpireMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.ExpireMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderExpire)).EndInit();
            this.HeaderExpire.ResumeLayout(false);
            this.HeaderExpire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbTrangThai;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnGiaHan;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl HeaderExpire;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private DevExpress.XtraGrid.GridControl grcDanhMuc;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource5;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_ID2;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Name2;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Image1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Age2;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Sex2;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Email1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Phone1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Job1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Address1;
        private DevExpress.XtraGrid.Columns.GridColumn colMembership_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_StartDate2;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_EndDate2;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer_Note1;
        private DevExpress.XtraGrid.Columns.GridColumn colMembership_Membership_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMembership_Name1;
        private DevExpress.XtraGrid.Columns.GridColumn colMembership_Price1;
        private DevExpress.XtraGrid.Columns.GridColumn colMembership_Note;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem csmGiaHan;
    }
}