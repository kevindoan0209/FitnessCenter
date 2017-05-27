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
    public partial class MessageError : Form
    {
        public static int Id;
        public MessageError()
        {
            InitializeComponent();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MessageError_Load(object sender, EventArgs e)
        {

            lbThongBao.Text = "Đã thêm thành công";
            lbThongBao.Text = "Cập nhật thành công";
            lbThongBao.Text = "Đã xóa thành công";
        }
    }
}
