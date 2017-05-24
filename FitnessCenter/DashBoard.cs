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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExits(typeof(Home));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Home home = new Home();
                home.MdiParent = this;
                home.Show();
            }
        }

      
    }
}
