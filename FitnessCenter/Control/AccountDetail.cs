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
    public partial class AccountDetail : DevExpress.XtraEditors.XtraForm
    {
        public int Id;
        public bool isAdd = true;
        public AccountDetail()
        {
            InitializeComponent();

            sqlDataSource2.Fill();
        }

        private void peAnh_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = ("Image Files |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
                openFileDialog.FilterIndex = 4;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtAnh.Text = openFileDialog.FileName;
                    peAnh.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
            catch (Exception)
            {
                lbTrangThai.Text = "*Không thể tải được ảnh";
            }
        }

        private void AccountDetail_Load(object sender, EventArgs e)
        {
            FillDataUpdate();
            txtMa.ReadOnly = true;
        }
        public void FillDataUpdate()
        {
            if (Id != 0)
            {
                DataFitnessCenterDataContext db = new DataFitnessCenterDataContext();
                var account = db.Accounts.Where(i => i.Account_ID == (int)Id).SingleOrDefault();
                if (account != null)
                {
                    txtTen.EditValue = account.Account_Name;
                    txtMa.EditValue = account.Account_ID;
                    txtTenDangNhap.EditValue = account.Account_UserName;
                    peAnh.EditValue = account.Account_Image;
                    txtMatKhau.EditValue = account.Account_Password;
                    lkePhanQuyen.EditValue = account.Account_Type_ID;
                    txtMatKhau2.EditValue = account.Account_Password;
                    txtMa.ReadOnly = true;
                    txtTenDangNhap.ReadOnly = true;
                }
            }
        }
        private void SaveUpdate()
        {
            try
            {
                if (string.IsNullOrEmpty(txtTen.Text))
                {

                    lbTrangThai.Text = "*Vui lòng nhập tên người sử dụng";
                    txtTen.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(txtTenDangNhap.Text))
                    {

                        lbTrangThai.Text = "*Vui lòng nhập tên đăng nhập";
                        txtTenDangNhap.Focus();
                    }
                    else
                    {
                        if (lkePhanQuyen.Text == "Chọn quyền hạn")
                        {

                            lbTrangThai.Text = "*Vui lòng chọn phân quyền";
                            lkePhanQuyen.Focus();
                        }
                        else
                        {
                            if (txtMatKhau.Text != txtMatKhau2.Text)
                            {

                                lbTrangThai.Text = "*Mật khẩu không trùng khớp";
                                txtMatKhau2.Focus();
                            }
                            else
                            {
                                int id = Int32.Parse(txtMa.Text);
                                string name = txtTen.Text;
                                string username = txtTenDangNhap.Text;
                                string password = txtMatKhau.Text;
                                string image = txtAnh.Text;
                                string group = lkePhanQuyen.GetColumnValue("Account_Type_ID").ToString();
                                int type = Int32.Parse(group);
                                int count = BLL_Human.Select_Username(username).Rows.Count;
                                if (string.IsNullOrEmpty(txtAnh.Text))
                                {
                                    BLL_Human.UpdateAccountNoImage(id, name, username, password, type);
                                    this.Close();
                                }
                                else
                                {
                                    BLL_Human.UpdateAccount(id, name, username, password, image, type);
                                    this.Close();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                String info = ex.Message;
                MessageError error = new MessageError();
                error.message = info;
                error.ShowDialog();
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAdd == false)
                {
                    SaveUpdate();
                }
                else
                {
                    if (string.IsNullOrEmpty(txtTen.Text))
                    {

                        lbTrangThai.Text = "*Vui lòng nhập tên người sử dụng";
                        txtTen.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtTenDangNhap.Text))
                        {

                            lbTrangThai.Text = "*Vui lòng nhập tên đăng nhập";
                            txtTenDangNhap.Focus();
                        }
                        else
                        {
                            if (txtTenDangNhap.Text.Length > 20 || txtTenDangNhap.Text.Length < 5)
                            {

                                lbTrangThai.Text = "*Tên đăng nhập phải từ 5 đến 20 kí tự";
                                txtTenDangNhap.Focus();
                            }
                            else
                            {
                                if (lkePhanQuyen.Text == "Chọn quyền hạn")
                                {
                                    lbTrangThai.Text = "*Vui lòng chọn phân quyền";
                                    lkePhanQuyen.Focus();
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(txtMatKhau.Text))
                                    {
                                        lbTrangThai.Text = "*Vui lòng nhập mật khẩu";
                                        txtMatKhau.Focus();
                                    }
                                    else
                                    {
                                        if (txtMatKhau.Text.Length > 12 || txtMatKhau.Text.Length < 6)
                                        {
                                            lbTrangThai.Text = "*Mật khẩu phải từ 6 đến 12 kí tự";
                                            txtMatKhau.Focus();
                                        }
                                        else
                                        {
                                            if (txtMatKhau.Text != txtMatKhau2.Text)
                                            {
                                                lbTrangThai.Text = "*Mật khẩu không trùng khớp";
                                                txtMatKhau2.Focus();
                                            }
                                            else
                                            {
                                                string name = txtTen.Text;
                                                string username = txtTenDangNhap.Text;
                                                string password = txtMatKhau.Text;
                                                string image = txtAnh.Text;
                                                string group = lkePhanQuyen.GetColumnValue("Account_Type_ID").ToString();
                                                int type = Int32.Parse(group);
                                                int count = BLL_Human.Select_Username(username).Rows.Count;
                                                if (count > 0)
                                                {
                                                    lbTrangThai.Text = "*Tên đăng nhập này đã tồn tại";
                                                    txtTenDangNhap.Focus();
                                                }
                                                else
                                                {
                                                    if (string.IsNullOrEmpty(txtAnh.Text))
                                                    {
                                                        BLL_Human.InsertAccountNoImage(name, username, password, type);
                                                        String status = "Đang hoạt động";
                                                        int humanId = BLL_Human.GetLastIdAccount();
                                                        BLL_Human.UpdateAccountStatus(humanId, status);
                                                        this.Close();
                                                    }
                                                    else
                                                    {
                                                        BLL_Human.InsertAccount(name, username, password, image, type);
                                                        String status = "Đang hoạt động";
                                                        int humanId = BLL_Human.GetLastIdAccount();
                                                        BLL_Human.UpdateAccountStatus(humanId, status);
                                                        this.Close();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                String info = ex.Message;
                MessageError error = new MessageError();
                error.message = info;
                error.ShowDialog();
            }
        }

        private void cbxHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHienMatKhau.Checked)
            {
                this.txtMatKhau.Properties.UseSystemPasswordChar = false;
                this.txtMatKhau2.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtMatKhau.Properties.UseSystemPasswordChar = true;
                this.txtMatKhau2.Properties.UseSystemPasswordChar = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            if (txtMatKhau.Text.Length > 20 || txtMatKhau.Text.Length < 6)
            {

                lbTrangThai.Text = "*Mật khẩu phải từ 6 đến 20 kí tự";
                txtMatKhau.Focus();
                e.Cancel = true;
                btnTao.Enabled = false;
            }
            else
            {
                lbTrangThai.Text = "";
                e.Cancel = false;
                btnTao.Enabled = true;
            }
        }

        private void txtTenDangNhap_Validating(object sender, CancelEventArgs e)
        {
            if (txtTenDangNhap.Text.Length > 20 || txtTenDangNhap.Text.Length < 5)
            {

                lbTrangThai.Text = "*Tên đăng nhập phải từ 5 đến 20 kí tự";
                txtTenDangNhap.Focus();
                e.Cancel = true;
                btnTao.Enabled = false;
            }
            else
            {
                lbTrangThai.Text = "";
                e.Cancel = false;
                btnTao.Enabled = true;
            }
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsSymbol(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else
            {
                lbTrangThai.Text = "*Không được phép nhập kí tự đặc biệt";
                e.Handled = true;
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsSymbol(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else
            {
                lbTrangThai.Text = "*Không được phép nhập kí tự đặc biệt";
                e.Handled = true;
            }
        }

        private void txtMatKhau2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsSymbol(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else
            {
                lbTrangThai.Text = "*Không được phép nhập kí tự đặc biệt";
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void peAnh_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = ("Image Files |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
                openFileDialog.FilterIndex = 4;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtAnh.Text = openFileDialog.FileName;
                    peAnh.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Không thể tải được ảnh", ex.Message);
            }
        }

        private void cbxHienMatKhau_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbxHienMatKhau.Checked)
            {
                this.txtMatKhau.Properties.UseSystemPasswordChar = false;
                this.txtMatKhau2.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtMatKhau.Properties.UseSystemPasswordChar = true;
                this.txtMatKhau2.Properties.UseSystemPasswordChar = true;
            }
        }
    }
}