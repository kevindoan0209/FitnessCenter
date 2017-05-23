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

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExits(typeof(Account));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Account account = new Account();
                account.MdiParent = this;
                account.Show();
            }
        }

        private void btnReminder_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExits(typeof(Reminder));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Reminder reminder = new Reminder();
                reminder.MdiParent = this;
                reminder.Show();
            }
        }
    }
}
