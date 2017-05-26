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
            Message message = new Message();
            message.ShowDialog();
            
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
            Form frm = this.IsExits(typeof(MemberManagement));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                MemberManagement member = new MemberManagement();
                member.MdiParent = this;
                member.Show();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            MessageLogOut message = new MessageLogOut();
            message.ShowDialog();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.Id = (int)Id;
            cp.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Message message = new Message();
            message.ShowDialog();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Form frm = this.IsExits(typeof(AccountManagement));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                AccountManagement account = new AccountManagement();
                account.MdiParent = this;
                account.Show();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MessageNotice message = new MessageNotice();
            message.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            MessageNotice message = new MessageNotice();
            message.ShowDialog();
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            MessageNotice message = new MessageNotice();
            message.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (SideMenu.Width == 55)
            {
                peLogo.Visible = true;
                txtPhienBan.Visible = true;
                btnDangXuat.Visible = true;
                btnThoat.Visible = true;
                txtChao.Visible = true;
                btnThoatBar.Visible = false;
                btnDangXuatBar.Visible = false;
                SideMenu.Visible = false;
                SideMenu.Width = 244;
                PanelAnimator.ShowSync(SideMenu);
               // LogoAnimator.ShowSync(peLogo);
            }
            else
            {
                peLogo.Visible = false;
                txtPhienBan.Visible = false;
                btnDangXuat.Visible = false;
                btnThoat.Visible = false;
                txtChao.Visible = false;
                btnThoatBar.Visible = true;
                btnDangXuatBar.Visible = true;
              //  LogoAnimator.Hide(peLogo);
                SideMenu.Visible = false;
                SideMenu.Width = 55;
                PanelAnimator.ShowSync(SideMenu);
               // LogoAnimator.ShowSync(peLogo);
               
            }
        }
    }
}
