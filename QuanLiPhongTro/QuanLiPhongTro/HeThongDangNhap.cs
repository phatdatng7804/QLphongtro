using QuanLiPhongTro.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiPhongTro
{
    public partial class DangNhapTK : Form
    {
        public DangNhapTK()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                using (QuanLi quanLi = new QuanLi()) 
                {
                    string taiKhoan = txtTaiKhoan.Text;
                    string matKhau = txtMatKhau.Text;
                    var admin = quanLi.DangNhaps.FirstOrDefault(dn => dn.TaiKhoan == taiKhoan && dn.MatKhau == matKhau);
                    if (admin != null)
                    {
                        MessageBox.Show("Đăng nhập thành công!","Thông Báo",MessageBoxButtons.OK);
                        HeThongChinh heThong = new HeThongChinh();
                        heThong.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản thật mật khẩu không đúng!","Thông Báo",MessageBoxButtons.OK);
                    }
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi kết nối với cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(dr == DialogResult.No) 
            {

            }
        }
    }
}
