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
    public partial class Form1 : Form
    {
        BAL_NhanVien xulyNhanVien = new BAL_NhanVien();

        public string keyword = "";
        private string Ma_nhanvien = "";
        public Form1(string user)
        {
            InitializeComponent();
            Ma_nhanvien = user;
            AddControl_page(tabPage4, new ControlQuanLyThuePhong(Ma_nhanvien));
            AddControl_page(tabPage3, new ControlPhong());
            AddControl_page(tabPage2, new ControlKhachHang());
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Year - dateTimePicker1.Value.Year <= 17)
            {
                MessageBox.Show("Yêu cầu 18 tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string GioiTinh = null;
            if (radNam.Checked == true)
                GioiTinh = "Nam";
            else GioiTinh = "Nữ";
            string ma = txtMaNV.Text;
            string ten = txtTenNV.Text;
            DateTime ngaySinh = dateTimePicker1.Value;
            string diaChi = txtDiaChi.Text;
            string phone = txtSDT.Text;
            string user = txtUser.Text;
            string pass = txtPass.Text;
            try
            {
                BEL_NhanVien nv = new BEL_NhanVien(ma, ten, GioiTinh, ngaySinh, diaChi, phone,user ,pass);
                if (nv.Id == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã nhân viên !!!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if (nv.Name =="")
                    {
                        MessageBox.Show("Bạn chưa nhập tên nhân viên!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (nv.Address =="")
                        {
                            MessageBox.Show("Bạn chưa nhập địa chỉ !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (nv.Phone =="")
                            {
                                MessageBox.Show("Bạn chưa nhập số điện thoại !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (nv.User =="")
                                {
                                    MessageBox.Show("Bạn chưa nhập sser !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (nv.Pass =="")
                                    {
                                        MessageBox.Show("Bạn chưa nhập pass !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                        }
                    }
                    
                }

                else
                {
                    BAL_NhanVien themNhanVien = new BAL_NhanVien();
                    bool ketQuaThem = themNhanVien.ThemNhanVien(nv);
                    if (ketQuaThem == true)
                    {
                        MessageBox.Show("Đã thêm thành công 1 nhân viên: " + ten + " vào databale", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvNhanVien.DataSource = xulyNhanVien.DocDSNhanVien();
                    }
                    else
                    { 
                        MessageBox.Show("Không thành công");
                        
                    }
                }                      
            }
            catch (Exception)
            {
                throw;
            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = xulyNhanVien.DocDSNhanVien();
            btnCapNhat.Enabled = false;
            txtPass.UseSystemPasswordChar = true;
        }
        private string maDangChon = null;
        private void dgvNhanVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvNhanVien.SelectedRows[0].Index; // Lấy ra giá trị của hàng đầu tiên trong bảng được chọn
            txtMaNV.Text = dgvNhanVien.Rows[index].Cells[0].Value.ToString(); // Lấy dữ liệu theo hàng Index và Cột Cells

            txtTenNV.Text = dgvNhanVien.Rows[index].Cells[1].Value.ToString();
            dateTimePicker1.Text = dgvNhanVien.Rows[index].Cells[2].Value.ToString();
            string gioiTinh = dgvNhanVien.Rows[index].Cells[3].Value.ToString();
            if (gioiTinh.Equals("Nam"))
                radNam.Checked = true;
            else
                radNu.Checked = true;
            txtDiaChi.Text = dgvNhanVien.Rows[index].Cells[4].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[index].Cells[5].Value.ToString();
            txtUser.Text = dgvNhanVien.Rows[index].Cells[6].Value.ToString();
            txtPass.Text = dgvNhanVien.CurrentRow.Cells["PASS"].Value.ToString();
            btnCapNhat.Enabled = true;
            //maDangChon = dgvNhanVien.CurrentRow.Cells[0].Value.ToString().Trim();

            //txtMaNV.Text = dgvNhanVien.CurrentRow.Cells["MANV"].Value.ToString();
            //txtTenNV.Text = dgvNhanVien.CurrentRow.Cells["HOTENNV"].Value.ToString();
            //string gioiTinh = dgvNhanVien.CurrentRow.Cells["GIOITINH"].Value.ToString();
            //if (gioiTinh.Equals("Nam"))
            //    radNam.Checked = true;
            //else
            //    radNu.Checked = true;
            //dateTimePicker1.Text = dgvNhanVien.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            //txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["DIACHI"].Value.ToString();
            //txtSDT.Text = dgvNhanVien.CurrentRow.Cells["PHONE"].Value.ToString();
            //txtUser.Text = dgvNhanVien.CurrentRow.Cells["USERNAME"].Value.ToString();
            //btnCapNhat.Enabled = true;


        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows[0].Index > -1)
            {
                string gioiTinh = null;
                if (radNam.Checked == true)
                    gioiTinh = "Nam";
                else gioiTinh = "Nữ";

                string manv = txtMaNV.Text;
                string tennv = txtTenNV.Text;
                DateTime ngaysinh = dateTimePicker1.Value;
                string diachi = txtDiaChi.Text;
                string sodienthoai = txtSDT.Text;
                string user = txtUser.Text;
                string pass = txtPass.Text;
                try
                {
                    BAL_NhanVien capNhat = new BAL_NhanVien();
                    bool ketqua = capNhat.updateNhanVien(manv, tennv, gioiTinh, ngaysinh, diachi, sodienthoai,user,pass);
                    if (ketqua == true)
                    {
                        MessageBox.Show("Đã cập nhật thành công 1 nhân viên: " + tennv, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvNhanVien.DataSource = xulyNhanVien.DocDSNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công: " + tennv, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không thể thay đổi mã nhân viên !!!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                finally
                {
                    dgvNhanVien.DataSource = xulyNhanVien.DocDSNhanVien();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tennv = txtTenNV.Text;
            string manv = txtMaNV.Text;
            try
            {
                BAL_NhanVien xoaNV = new BAL_NhanVien();
                bool ketqua = xoaNV.deleteNhanVien(manv);
                if (ketqua == true)
                {
                    MessageBox.Show("Đã xóa thành công 1 nhân viên: " + tennv, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Xóa không thành công:  " + tennv, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Không thể xóa " + tennv, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                dgvNhanVien.DataSource = xulyNhanVien.DocDSNhanVien();
            }
        }
        //Đăng xuất ra khỏi màn hình chính quay về lại form đăng nhập
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
                this.Close();
                FDangNhap f = new FDangNhap();
                f.Show();
                
           
        
        }
        public void AddControl_page(TabPage tab,Control x)
        {
            x.Dock = DockStyle.Fill;
            tab.Controls.Add(x);
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = xulyNhanVien.TimkiemNhanVien(txtNhap_timkiem.Text);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (h == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = xulyNhanVien.DocDSNhanVien();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkHienThi_CheckedChanged(object sender, EventArgs e)
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
