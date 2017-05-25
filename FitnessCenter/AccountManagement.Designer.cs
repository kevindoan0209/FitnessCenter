namespace FitnessCenter
{
    partial class AccountManagement
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column16 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression16 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManagement));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.grcDanhMuc = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.csmXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.csmCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gvDanhMuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAccount_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount_UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount_Password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount_Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount_Image = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount_Type_Authority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount_Type_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnKhoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuatFile = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(679, 63);
            this.panelControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.searchControl1);
            this.groupBox1.Location = new System.Drawing.Point(169, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // searchControl1
            // 
            this.searchControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchControl1.Client = this.grcDanhMuc;
            this.searchControl1.Location = new System.Drawing.Point(36, 20);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.grcDanhMuc;
            this.searchControl1.Size = new System.Drawing.Size(254, 20);
            this.searchControl1.TabIndex = 0;
            // 
            // grcDanhMuc
            // 
            this.grcDanhMuc.ContextMenuStrip = this.contextMenuStrip1;
            this.grcDanhMuc.DataMember = "Account";
            this.grcDanhMuc.DataSource = this.sqlDataSource1;
            this.grcDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grcDanhMuc.EmbeddedNavigator.TextStringFormat = "Trang {0} / {1}";
            this.grcDanhMuc.Location = new System.Drawing.Point(0, 63);
            this.grcDanhMuc.MainView = this.gvDanhMuc;
            this.grcDanhMuc.Name = "grcDanhMuc";
            this.grcDanhMuc.Size = new System.Drawing.Size(679, 326);
            this.grcDanhMuc.TabIndex = 2;
            this.grcDanhMuc.UseEmbeddedNavigator = true;
            this.grcDanhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMuc});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csmXoa,
            this.csmCapNhat});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            // 
            // csmXoa
            // 
            this.csmXoa.Name = "csmXoa";
            this.csmXoa.Size = new System.Drawing.Size(122, 22);
            this.csmXoa.Text = "Xóa";
            this.csmXoa.Click += new System.EventHandler(this.csmXoa_Click);
            // 
            // csmCapNhat
            // 
            this.csmCapNhat.Name = "csmCapNhat";
            this.csmCapNhat.Size = new System.Drawing.Size(122, 22);
            this.csmCapNhat.Text = "Cập nhật";
            this.csmCapNhat.Click += new System.EventHandler(this.csmCapNhat_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DESKTOP-M75UEQH\\SQLEXPRESS_FitnessCenter_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression9.ColumnName = "Account_ID";
            table3.MetaSerializable = "0|0|125|180";
            table3.Name = "Account";
            columnExpression9.Table = table3;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "Account_Name";
            columnExpression10.Table = table3;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "Account_UserName";
            columnExpression11.Table = table3;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "Account_Password";
            columnExpression12.Table = table3;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "Account_Status";
            columnExpression13.Table = table3;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "Account_Image";
            columnExpression14.Table = table3;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "Account_Type_Authority";
            table4.MetaSerializable = "0|0|125|100";
            table4.Name = "Account_Type";
            columnExpression15.Table = table4;
            column15.Expression = columnExpression15;
            columnExpression16.ColumnName = "Account_Type_ID";
            columnExpression16.Table = table3;
            column16.Expression = columnExpression16;
            selectQuery2.Columns.Add(column9);
            selectQuery2.Columns.Add(column10);
            selectQuery2.Columns.Add(column11);
            selectQuery2.Columns.Add(column12);
            selectQuery2.Columns.Add(column13);
            selectQuery2.Columns.Add(column14);
            selectQuery2.Columns.Add(column15);
            selectQuery2.Columns.Add(column16);
            selectQuery2.Name = "Account";
            relationColumnInfo2.NestedKeyColumn = "Account_Type_ID";
            relationColumnInfo2.ParentKeyColumn = "Account_Type_ID";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table4;
            join2.Parent = table3;
            selectQuery2.Relations.Add(join2);
            selectQuery2.Tables.Add(table3);
            selectQuery2.Tables.Add(table4);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gvDanhMuc
            // 
            this.gvDanhMuc.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDanhMuc.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDanhMuc.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gvDanhMuc.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvDanhMuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccount_ID,
            this.colAccount_Name,
            this.colAccount_UserName,
            this.colAccount_Password,
            this.colAccount_Status,
            this.colAccount_Image,
            this.colAccount_Type_Authority,
            this.colAccount_Type_ID});
            this.gvDanhMuc.GridControl = this.grcDanhMuc;
            this.gvDanhMuc.Name = "gvDanhMuc";
            this.gvDanhMuc.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDanhMuc.OptionsView.ShowGroupPanel = false;
            // 
            // colAccount_ID
            // 
            this.colAccount_ID.FieldName = "Account_ID";
            this.colAccount_ID.Name = "colAccount_ID";
            // 
            // colAccount_Name
            // 
            this.colAccount_Name.Caption = "Tên người dùng";
            this.colAccount_Name.FieldName = "Account_Name";
            this.colAccount_Name.Name = "colAccount_Name";
            this.colAccount_Name.Visible = true;
            this.colAccount_Name.VisibleIndex = 1;
            this.colAccount_Name.Width = 174;
            // 
            // colAccount_UserName
            // 
            this.colAccount_UserName.Caption = "Tài khoản";
            this.colAccount_UserName.FieldName = "Account_UserName";
            this.colAccount_UserName.Name = "colAccount_UserName";
            this.colAccount_UserName.Visible = true;
            this.colAccount_UserName.VisibleIndex = 2;
            this.colAccount_UserName.Width = 158;
            // 
            // colAccount_Password
            // 
            this.colAccount_Password.FieldName = "Account_Password";
            this.colAccount_Password.Name = "colAccount_Password";
            // 
            // colAccount_Status
            // 
            this.colAccount_Status.Caption = "Trạng thái";
            this.colAccount_Status.FieldName = "Account_Status";
            this.colAccount_Status.Name = "colAccount_Status";
            this.colAccount_Status.Visible = true;
            this.colAccount_Status.VisibleIndex = 4;
            this.colAccount_Status.Width = 117;
            // 
            // colAccount_Image
            // 
            this.colAccount_Image.Caption = "Ảnh";
            this.colAccount_Image.FieldName = "Account_Image";
            this.colAccount_Image.Name = "colAccount_Image";
            this.colAccount_Image.Visible = true;
            this.colAccount_Image.VisibleIndex = 0;
            this.colAccount_Image.Width = 72;
            // 
            // colAccount_Type_Authority
            // 
            this.colAccount_Type_Authority.Caption = "Phân quyền";
            this.colAccount_Type_Authority.FieldName = "Account_Type_Authority";
            this.colAccount_Type_Authority.Name = "colAccount_Type_Authority";
            this.colAccount_Type_Authority.Visible = true;
            this.colAccount_Type_Authority.VisibleIndex = 3;
            this.colAccount_Type_Authority.Width = 140;
            // 
            // colAccount_Type_ID
            // 
            this.colAccount_Type_ID.FieldName = "Account_Type_ID";
            this.colAccount_Type_ID.Name = "colAccount_Type_ID";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnKhoa);
            this.panelControl2.Controls.Add(this.btnXuatFile);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.btnLamMoi);
            this.panelControl2.Controls.Add(this.btnThem);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 389);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(679, 40);
            this.panelControl2.TabIndex = 1;
            // 
            // btnKhoa
            // 
            this.btnKhoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnKhoa.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoa.Image")));
            this.btnKhoa.Location = new System.Drawing.Point(216, 7);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(103, 28);
            this.btnKhoa.TabIndex = 13;
            this.btnKhoa.Text = "Khóa tài khoản";
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnXuatFile.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnXuatFile.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatFile.Image")));
            this.btnXuatFile.Location = new System.Drawing.Point(325, 7);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(123, 28);
            this.btnXuatFile.TabIndex = 12;
            this.btnXuatFile.Text = "Kết xuất danh sách";
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Location = new System.Drawing.Point(449, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(351, 14);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "* Nhấn chuột phải trên danh sách để xóa hoặc cập nhật dữ liệu";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(135, 7);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 28);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(5, 7);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 28);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm tài khoản mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // AccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 429);
            this.ControlBox = false;
            this.Controls.Add(this.grcDanhMuc);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountManagement";
            this.Text = "Tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl grcDanhMuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMuc;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount_UserName;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount_Password;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount_Status;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount_Image;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount_Type_Authority;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount_Type_ID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem csmXoa;
        private System.Windows.Forms.ToolStripMenuItem csmCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnKhoa;
        private DevExpress.XtraEditors.SimpleButton btnXuatFile;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}