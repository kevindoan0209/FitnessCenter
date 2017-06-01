using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataAccessLayer;
using BussinessLogicLayer;

namespace FitnessCenter
{
    public partial class ExpireMember : DevExpress.XtraEditors.XtraForm
    {
        public int Id;
        public bool isAdd = true;
        public ExpireMember()
        {
            InitializeComponent();
            sqlDataSource5.Fill();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            int rowIndex = gvDanhMuc.FocusedRowHandle;
            string colID = "Customer_ID";
            object value = gvDanhMuc.GetRowCellValue(rowIndex, colID);
            if (value != null)
            {
                ExpireMemberDetail me = new ExpireMemberDetail();
                me.Id = (int)value;
                me.ShowDialog();
                sqlDataSource5.Fill();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa chọn đối tượng để cập nhật", "Fitness Center", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExpireMember_Load(object sender, EventArgs e)
        {
 
        }

        private void csmGiaHan_Click(object sender, EventArgs e)
        {
            int rowIndex = gvDanhMuc.FocusedRowHandle;
            string colID = "Customer_ID";
            object value = gvDanhMuc.GetRowCellValue(rowIndex, colID);
            if (value != null)
            {
                ExpireMemberDetail me = new ExpireMemberDetail();
                me.Id = (int)value;
                me.ShowDialog();
                sqlDataSource5.Fill();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa chọn đối tượng để cập nhật", "Fitness Center", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

   
    }
}