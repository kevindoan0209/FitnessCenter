using BussinessLogicLayer;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dlr = XtraMessageBox.Show("Bạn có thật sự muốn thoát ?", "Clinience", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String TenDangNhap = txtTenDangNhap.Text;
            String MatKhau = txtMatKhau.Text;
            if (string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {          
                lbTrangThai.Text = "*Vui lòng nhập tên đăng nhập và mật khẩu";
                txtTenDangNhap.Focus();
            }
            else
            {
                try
                {
                    int count = BLL_Human.Select_CheckUserNameSoftware(TenDangNhap).Rows.Count;
                    if (count < 0)
                    {
                        lbTrangThai.Text = "*Tài khoản không được phép truy cập";
                        txtTenDangNhap.Focus();
                    }
                    else
                    {
                        DataTable dt = BLL_Human.Login(TenDangNhap, MatKhau);
                        if (dt.Rows.Count > 0)
                        {
                            DataRow dr = dt.Rows[0];
                            string name = dr["Account_Name"].ToString();
                            int id = Convert.ToInt32(dr["Account_ID"]);
                            int type = Convert.ToInt32(dr["Account_Type_ID"]);
                            string status = Convert.ToString(dr["Account_Status"]);
                            if (status == "Đang hoạt động")
                            {
                                DashBoard.UserName = name;
                                DashBoard.Id = id;
                                DashBoard.Id = id;
                                DashBoard.Type = type;
                                this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                lbTrangThai.Text = "*Tài khoản này đã bị khóa";
                            }
                        }
                        else
                        {
                            lbTrangThai.Text = "*Tên đăng nhập hoặc mật khẩu không hợp lệ";
                            txtTenDangNhap.Text = "";
                            txtMatKhau.Text = "";
                            txtTenDangNhap.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cbxHienMatKhai_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHienMatKhai.Checked)
            {
                this.txtMatKhau.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtMatKhau.Properties.UseSystemPasswordChar = true;
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
    }
}
