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
    public partial class DashBoard : Form
    {
        public static string UserName = string.Empty;
        public static int Type;
        public static int Id;
        public DashBoard()
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
            Form frm = this.IsExits(typeof(Intro));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Intro home = new Intro();
                home.MdiParent = this;
                home.Show();
            }
        }
        private void Login()
        {
            Login login = new Login();
            login.ShowDialog();
        }

        public void HandleAuthority()
        {
           /* if (Type == 1)
            {
                ribbonPage3.Visible = true;
            }
            else
            {
                if (Type == 2)
                {
                    ribbonPageGroup7.Visible = false;
                    ribbonPageGroup8.Visible = false;
                }
                else
                {
                    ribbonPage3.Visible = false;
                }
            }*/
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
            Intro intro = new Intro();
            intro.MdiParent = this;
            intro.Show();
            Login();
            txtChao.Text = "Xin chào " + UserName +" !";
            HandleAuthority();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn đăng xuất ?", "Clinience", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.Id = (int)Id;
            cp.ShowDialog();
        }
    }
}
