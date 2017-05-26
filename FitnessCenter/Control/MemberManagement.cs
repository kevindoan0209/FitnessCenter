using BussinessLogicLayer;
using DataAccessLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessCenter
{
    public partial class MemberManagement : Form
    {
        public static int Id;
        public MemberManagement()
        {
            InitializeComponent();
            sqlDataSource2.Fill();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            try
            {
                string FileName = "C:\\Users\\Admin\\Desktop\\DanhSachNguoiDung.xls";
                grcDanhMuc.ExportToXls(FileName);
                XtraMessageBox.Show("Đã xuất tệp thành công. Tệp được lưu ngoài màn hình chính", "Fitness Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Không thể xuất được tệp tin", "Fitness Center", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetFillData()
        {
            lbTen.Text = "";        
            lbGioiTinh.Text = "";
            lbSoDienThoai.Text = "";
            lbLoaiThe.Text = "";
            lbTuoi.Text = "";
            peAnh.EditValue = "";
            lbNgayHetHan.Text = "";
            lbNgayNop.Text = "";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            sqlDataSource2.Fill();
            ResetFillData();
        }
        private Form IsExits(Type type)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == type)
                {
                    return f;
                }
            }
            return null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExits(typeof(AccountDetail));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                AccountDetail account = new AccountDetail();
                account.isAdd = true;
                account.ShowDialog();
                sqlDataSource2.Fill();
            }
        }

        private void csmXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Fitness Center", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rowIndex = gvDanhMuc.FocusedRowHandle;
                    string colID = "Customer_ID";
                    object value = gvDanhMuc.GetRowCellValue(rowIndex, colID);
                    if (value != null)
                    {
                        DataFitnessCenterDataContext dc = new DataFitnessCenterDataContext();
                        var customer = dc.Customers.Where(s => s.Customer_ID == (int)value).SingleOrDefault();
                        int accountId = Convert.ToInt32(customer.Customer_ID);
                        if (Id != accountId)
                        {
                            if (customer != null)
                            {
                                dc.Customers.DeleteOnSubmit(customer);
                                dc.SubmitChanges();
                                sqlDataSource2.Fill();
                                XtraMessageBox.Show("Đã xóa thành công", "Fitness Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Không được phép xóa tài khoản sử dụng hiện tại", "Fitness Center", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn đối tượng cần xóa", "Fitness Center", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Không được phép xóa đối tượng này, đối tượng đã được thêm ở một danh mục khác", "Fitness Center", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void csmCapNhat_Click(object sender, EventArgs e)
        {
            int rowIndex = gvDanhMuc.FocusedRowHandle;
            string colID = "Customer_ID";
            object value = gvDanhMuc.GetRowCellValue(rowIndex, colID);
            if (value != null)
            {
                MemberDetail md = new MemberDetail();
                md.Id = (int)value;
                md.ShowDialog();
                sqlDataSource2.Fill();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa chọn đối tượng để cập nhật", "Fitness Center", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExits(typeof(MemberDetail));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                MemberDetail md = new MemberDetail();
                md.isAdd = true;
                md.ShowDialog();
                sqlDataSource2.Fill();
            }
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            sqlDataSource2.Fill();
        }

        private void btnXuatFile_Click_1(object sender, EventArgs e)
        {
            try
            {
                string FileName = "C:\\Users\\Admin\\Desktop\\DanhSachHoiVien.xls";
                grcDanhMuc.ExportToXls(FileName);
                XtraMessageBox.Show("Đã xuất tệp thành công. Tệp được lưu ngoài màn hình chính", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Không thể xuất được tệp tin", "Fitness Center", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            int rowIndex = gvDanhMuc.FocusedRowHandle;
            string colID = "Customer_ID";
            object value = gvDanhMuc.GetRowCellValue(rowIndex, colID);
            if (value != null)
            {
                MemberDetail md = new MemberDetail();
                md.Id = (int)value;
                md.ShowDialog();
                sqlDataSource2.Fill();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa chọn đối tượng để cập nhật", "Fitness Center", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = gvDanhMuc.FocusedRowHandle;
            string colID = "Customer_ID";
            object value = gvDanhMuc.GetRowCellValue(rowIndex, colID);
            if (value != null)
            {
                int Id = (int)value;
                DataFitnessCenterDataContext db = new DataFitnessCenterDataContext();
                var customer = db.Customers.Where(i => i.Customer_ID == (int)Id).SingleOrDefault();
                if (customer != null)
                {
                    lbTen.Text = customer.Customer_Name;
                    lbGioiTinh.Text = customer.Customer_Sex;
                    lbSoDienThoai.Text = customer.Customer_Phone;
                    DateTime age = Convert.ToDateTime(customer.Customer_Age);
                    int ageInYrs = DateTime.Now.Year - age.Year;
                    lbTuoi.Text = ageInYrs + " tuổi";
                    peAnh.EditValue = customer.Customer_Image;
                   // lbLoaiThe.Text = customer.Membership_ID;
                    lbNgayHetHan.Text = Convert.ToString(customer.Customer_StartDate);
                    lbNgayNop.Text = Convert.ToString(customer.Customer_EndDate);
                }
                else
                {
                    XtraMessageBox.Show("Bạn chưa chọn bệnh nhân để xem thông tin chi tiết", "Fitness Center", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
