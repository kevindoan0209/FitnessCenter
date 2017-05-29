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
    public partial class LockAccess : Form
    {
        public int Id;
        public LockAccess()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Message message = new Message();
            message.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String password = txtMatKhau.Text;
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                lbTrangThai.Text = "*Vui lòng nhập mật khẩu";
                txtMatKhau.Focus();
            }
            else
            {
                try
                {
                    DataTable dt = BLL_Human.LockAccess(Id, password);
                    if (dt.Rows.Count > 0)
                    {
                        this.Close();
                    }
                    else
                    {
                        lbTrangThai.Text = "*Mật khẩu không hợp lệ";
                        txtMatKhau.Text = "";
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
