namespace FitnessCenter
{
    partial class MemberManagement
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberManagement));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.csmXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.csmCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnXuatFile = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.grcDanhMuc = new DevExpress.XtraGrid.GridControl();
            this.gvDanhMuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).BeginInit();
            this.SuspendLayout();
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
            columnExpression1.ColumnName = "Account_ID";
            table1.MetaSerializable = "0|0|125|180";
            table1.Name = "Account";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Account_Name";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "Account_UserName";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "Account_Password";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "Account_Status";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "Account_Image";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "Account_Type_Authority";
            table2.MetaSerializable = "0|0|125|100";
            table2.Name = "Account_Type";
            columnExpression7.Table = table2;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "Account_Type_ID";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Name = "Account";
            relationColumnInfo1.NestedKeyColumn = "Account_Type_ID";
            relationColumnInfo1.ParentKeyColumn = "Account_Type_ID";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // panelControl2
            // 
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
            // btnXuatFile
            // 
            this.btnXuatFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnXuatFile.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnXuatFile.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatFile.Image")));
            this.btnXuatFile.Location = new System.Drawing.Point(325, 8);
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
            this.labelControl1.Location = new System.Drawing.Point(452, 16);
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(679, 63);
            this.panelControl1.TabIndex = 2;
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
            this.searchControl1.Location = new System.Drawing.Point(36, 20);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(254, 20);
            this.searchControl1.TabIndex = 0;
            // 
            // grcDanhMuc
            // 
            this.grcDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDanhMuc.Location = new System.Drawing.Point(0, 63);
            this.grcDanhMuc.MainView = this.gvDanhMuc;
            this.grcDanhMuc.Name = "grcDanhMuc";
            this.grcDanhMuc.Size = new System.Drawing.Size(679, 326);
            this.grcDanhMuc.TabIndex = 3;
            this.grcDanhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMuc});
            // 
            // gvDanhMuc
            // 
            this.gvDanhMuc.GridControl = this.grcDanhMuc;
            this.gvDanhMuc.Name = "gvDanhMuc";
            // 
            // MemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 429);
            this.ControlBox = false;
            this.Controls.Add(this.grcDanhMuc);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberManagement";
            this.Text = "Hội viên";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem csmXoa;
        private System.Windows.Forms.ToolStripMenuItem csmCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnXuatFile;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraGrid.GridControl grcDanhMuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMuc;
    }
}