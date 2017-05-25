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
    public partial class MessageNotice : Form
    {
        public MessageNotice()
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
    }
}
