using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiPhongTro
{
    public partial class HeThongChinh : Form
    {
        public HeThongChinh()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        private void showForm()
        {
            DangKiTaiKhoan dk = new DangKiTaiKhoan();
            dk.Show();
        }
        private void setLocation()
        {
            plDangKi.Controls.Clear();
            DangKiTaiKhoan.TopLevel = false;
            DangKiTaiKhoan.FormBorderStyle = FormBorderStyle.Sizable;
            form2.Dock = DockStyle.Fill;

            PAdd.Controls.Add(form2);
            PAdd.Tag = form2;
        }
        private void DangKiTaiKhoan_Click(object sender, EventArgs e)
        {
            

        }
    }
}
