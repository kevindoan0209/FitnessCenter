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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            DataFitnessCenterDataContext db = new DataFitnessCenterDataContext();
            var fitness = db.FitnessCenters.Where(i => i.FitnessCenter_ID == 1).SingleOrDefault();
            if (fitness != null)
            {
                lbTenPhong.Text = fitness.FitnessCenter_Name;
                lbDiaChi.Text = fitness.FitnessCenter_Address;
                lbSoDienThoai.Text = fitness.FitnessCenter_Tel;
                lbEmail.Text = fitness.FitnessCenter_Email;
                lbFacebook.Text = fitness.FitnessCenter_Facebook;
                lbTieuDe.Text = fitness.FitnessCenter_Name;
            }
        }
    }
}
