using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BEL;
using BAL;


namespace ProjectDA
{
    public partial class ControlKhachHang : UserControl
    {
        BAL_KhachHang xulyKhachHang = new BAL_KhachHang();
        public ControlKhachHang()
        {
            InitializeComponent();
        }

        private void ControlKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = xulyKhachHang.DocDSKhachHang();
            btnCapNhat.Enabled = false;
        }

        public void layDanhSachKhachHang(DataGridView dgv)
        {
            BAL_KhachHang xulyKhachHang = new BAL_KhachHang();
            dgv.DataSource = xulyKhachHang.DocDSKhachHang();
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
            string ma = txtMaKH.Text;
            string ten = txtTenKH.Text;
            DateTime ngaySinh = dateTimePicker1.Value;
            string diaChi = txtDiaChi.Text;
            string phone = txtSDT.Text;
            string cmnd = txtCMND.Text;
            string quoctich = txtQuocTich.Text;
            try
            {
                BEL_KhachHang kh = new BEL_KhachHang(ma, ten, ngaySinh, GioiTinh, diaChi, phone, cmnd, quoctich);
                BAL_KhachHang themKhachHang = new BAL_KhachHang();
                bool ketQuaThem = themKhachHang.ThemKhachHang(kh);
                if (ketQuaThem == true)
                {
                    MessageBox.Show("Đã thêm thành công 1 khách hàng: " + ten + " vào databale", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    layDanhSachKhachHang(dgvKhachHang);
                }
                else MessageBox.Show("Không thành công" ,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                throw;
            }
        }
        private string maDangChon = null;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maDangChon = dgvKhachHang.CurrentRow.Cells[0].Value.ToString().Trim();

            txtMaKH.Text = dgvKhachHang.CurrentRow.Cells["MAKH"].Value.ToString();
            txtTenKH.Text = dgvKhachHang.CurrentRow.Cells["HOTENKH"].Value.ToString();
            string gioiTinh = dgvKhachHang.CurrentRow.Cells["GIOITINH"].Value.ToString();
            if (gioiTinh.Equals("Nam"))
                radNam.Checked = true;
            else
                radNu.Checked = true;
            dateTimePicker1.Text = dgvKhachHang.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells["DIACHI"].Value.ToString();
            txtSDT.Text = dgvKhachHang.CurrentRow.Cells["PHONE"].Value.ToString();
            txtCMND.Text = dgvKhachHang.CurrentRow.Cells["CMND"].Value.ToString();
            txtQuocTich.Text = dgvKhachHang.CurrentRow.Cells["QUOCTICH"].Value.ToString();
            btnCapNhat.Enabled = true;

        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows[0].Index > -1)
            {
                string gioiTinh = null;
                if (radNam.Checked == true)
                    gioiTinh = "Nam";
                else gioiTinh = "Nữ";

                string maKH = txtMaKH.Text;
                string tenKH = txtTenKH.Text;
                DateTime ngaySinh = dateTimePicker1.Value;
                string diaChi = txtDiaChi.Text;
                string SĐT = txtSDT.Text;
                string cmnd = txtCMND.Text;
                string quocTich = txtQuocTich.Text;
                try
                {
                    BAL_KhachHang capNhat = new BAL_KhachHang();
                    bool ketqua = capNhat.CapNhatKhachHang(maKH, tenKH, ngaySinh, gioiTinh, diaChi, SĐT, cmnd, quocTich);
                        if (ketqua == true)
                        {
                             MessageBox.Show("Đã cập nhật thành công 1 khách hàng: " + tenKH, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             dgvKhachHang.DataSource = xulyKhachHang.DocDSKhachHang();
                        }
                         else
                        {
                            MessageBox.Show("Cập nhật không thành công: " + tenKH, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi : " + ex.Message);
                }
                finally
                {
                    dgvKhachHang.DataSource = xulyKhachHang.DocDSKhachHang();
                }
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = xulyKhachHang.TimKiemKhachHang(txtNhap_timkiem.Text);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = xulyKhachHang.DocDSKhachHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text;
            string tenKH = txtTenKH.Text;
            try
            {
                BAL_KhachHang xoaKH = new BAL_KhachHang();
                bool ketQua = xoaKH.deleteKhachHang(maKH);
                if (ketQua == true)
                {
                    MessageBox.Show("Đã xóa thành công 1 nhân viên: " + tenKH, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Xoa không thành công:  " + tenKH, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dgvKhachHang.DataSource = xulyKhachHang.DocDSKhachHang();           }
        }
    }
}
