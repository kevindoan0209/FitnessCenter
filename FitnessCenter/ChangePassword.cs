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
    public partial class ChangePassword : Form
    {
        public int Id;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    txtHienCu.EditValue = account.Account_Password;
                    txtMa.ReadOnly = true;
                    txtTen.ReadOnly = true;
                }
            }
        }

        private void cbxHienMatKhai_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHienMatKhai.Checked)
            {
                this.txtMatKhau.Properties.UseSystemPasswordChar = false;
                this.txtMatKhau2.Properties.UseSystemPasswordChar = false;
                this.txtMaKhauCu.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtMatKhau.Properties.UseSystemPasswordChar = true;
                this.txtMatKhau2.Properties.UseSystemPasswordChar = true;
                this.txtMaKhauCu.Properties.UseSystemPasswordChar = true;
            }
        }

        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            if (txtMatKhau.Text.Length > 20 || txtMatKhau.Text.Length < 6)
            {
               
                lbTrangThai.Text = "*Mật khẩu phải từ 6 đến 20 kí tự";
                txtMatKhau.Focus();
                e.Cancel = true;
                btnDoiMatKhau.Enabled = false;
            }
            else
            {
                lbTrangThai.Text = "";
                e.Cancel = false;
                btnDoiMatKhau.Enabled = true;
            }
        }

        private void txtMatKhau2_Validating(object sender, CancelEventArgs e)
        {
            if (txtMatKhau2.Text.Length > 20 || txtMatKhau2.Text.Length < 6)
            {
               
                lbTrangThai.Text = "*Mật khẩu phải từ 6 đến 20 kí tự";
                txtMatKhau2.Focus();
                e.Cancel = true;
                btnDoiMatKhau.Enabled = false;
            }
            else
            {
                lbTrangThai.Text = "";
                e.Cancel = false;
                btnDoiMatKhau.Enabled = true;
            }
        }

        private void txtMaKhauCu_Validating(object sender, CancelEventArgs e)
        {
            if (txtMaKhauCu.Text.Length > 20 || txtMaKhauCu.Text.Length < 6)
            {
               
                lbTrangThai.Text = "*Mật khẩu phải từ 6 đến 20 kí tự";
                txtMaKhauCu.Focus();
                e.Cancel = true;
                btnDoiMatKhau.Enabled = false;
            }
            else
            {
                lbTrangThai.Text = "";
                e.Cancel = false;
                btnDoiMatKhau.Enabled = true;
            }
        }

        private void txtMaKhauCu_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaKhauCu.Text))
                {
                    lbTrangThai.Text = "*Nhập mật khẩu cũ";
                    txtMaKhauCu.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(txtMatKhau.Text))
                    {
                        lbTrangThai.Text = "*Nhập mật khẩu mới";
                        txtMatKhau.Focus();
                    }
                    else
                    {
                        if (txtMatKhau.Text != txtMatKhau2.Text)
                        {
                            lbTrangThai.Text = "*Mật khẩu mới không trùng khớp";
                            txtMatKhau2.Focus();
                        }
                        else
                        {
                            if (txtMaKhauCu.Text != txtHienCu.Text)
                            {
                                lbTrangThai.Text = "*Mật khẩu cũ không đúng";
                                txtMaKhauCu.Focus();
                            }
                            else
                            {
                                int id = Int32.Parse(txtMa.Text);
                                string name = txtTen.Text;
                                string password = txtMatKhau.Text;
                                BLL_Human.UpdateAccountPassword(id, name, password);
                                this.Close();
                                XtraMessageBox.Show("Đổi mật khẩu thành công", "Clinience", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            FillDataUpdate();
        }
    }
}
