using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BEL;
using BAL;

namespace ProjectDA
{
    public partial class FDangNhap : Form
    {
        private string Ma_nhanvien = "";
        ControlQuanLyThuePhong ctrl = new ControlQuanLyThuePhong();

        public FDangNhap()
        {
            InitializeComponent();
        }
        private void FDangNhap_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnDangNhap;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            BEL_DangNhap dn = new BEL_DangNhap(user, pass);
            BAL_DangNhap xuLyDangNhap = new BAL_DangNhap();
            bool ketQua = xuLyDangNhap.checkLogin(user, pass);
            if (ketQua == true)
            {
                MessageBox.Show("Đăng nhập thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Ma_nhanvien = xuLyDangNhap.FindNhanVienByUser(user).Rows[0].ItemArray[1].ToString();
                Form1 f = new Form1(Ma_nhanvien);
                this.Hide();
                f.Show();
             

            }
            else
            { MessageBox.Show("Không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHienThi.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
