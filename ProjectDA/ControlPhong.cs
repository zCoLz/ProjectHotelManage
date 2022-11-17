using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;

namespace ProjectDA
{
    public partial class ControlPhong : UserControl
    {
        public ControlPhong()
        {
            InitializeComponent();
        }
        BAL_Phong xuLyPhong = new BAL_Phong();
        BAL_Loai xuLyLoai = new BAL_Loai();
        BAL_TinhTrang xuLyTinhTrang = new BAL_TinhTrang();
        private void ControlPhong_Load(object sender, EventArgs e)
        {


            dgvPhong.DataSource = xuLyPhong.DanhSachPhong();
            btnSua.Enabled = false;

            cboLoai.DataSource = xuLyLoai.DocDanhSachLoai();
            cboLoai.DisplayMember = "TENLOAI";
            cboLoai.ValueMember = "IDLOAI";

            cboTinhTrang.DataSource = xuLyTinhTrang.TinhTrangPhong();
            cboTinhTrang.DisplayMember = "TENTTRANG";
            cboTinhTrang.ValueMember = "IDTTRANG";

            cboTrangThai.SelectedIndex = 0;
        }
        public void layDSPhong(DataGridView dgv)
        {
            BAL_Phong xLyPhong = new BAL_Phong();
            dgv.DataSource = xuLyPhong.DanhSachPhong();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cboTrangThai.Enabled = true;
            string maPhg = txtMaPhong.Text;
            string loai = cboLoai.SelectedValue.ToString();
            string tinhTrang = cboTinhTrang.SelectedValue.ToString();
            string gia = txtGia.Text;
            string trangThai = cboTrangThai.SelectedIndex.ToString();
            try
            {
                BEL_Phong ph = new BEL_Phong(maPhg, loai, tinhTrang, gia, trangThai);
                BAL_Phong themPhong = new BAL_Phong();
                bool ketQuaThem = themPhong.ThemPhong(ph);
                if (ketQuaThem == true)
                {
                    MessageBox.Show("Đã thêm thành công 1 phòng: " + maPhg + "vào database", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    layDSPhong(dgvPhong);
                }
                else MessageBox.Show("Không thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private string maDangChon = null;
        public int combobox_index(ComboBox cbo, string value)
        {
            for (int i = 0; i < cbo.Items.Count; i++)
            {
                if (cbo.GetItemText(cbo.Items[i]).Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }
        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
            int roll = -1;
            try
            {
                maDangChon = dgvPhong.CurrentRow.Cells[0].Value.ToString().Trim();
                txtMaPhong.Text = dgvPhong.CurrentRow.Cells["MAPHG"].Value.ToString();
                int index_cboloai = combobox_index(cboLoai, dgvPhong.CurrentRow.Cells["TENLOAI"].Value.ToString());
                cboLoai.SelectedIndex = index_cboloai == -1 ? 0 : index_cboloai;
                int index_cbottrang = combobox_index(cboTinhTrang, dgvPhong.CurrentRow.Cells["TENTTRANG"].Value.ToString());
                cboTinhTrang.SelectedIndex = index_cbottrang == -1 ? 0 : index_cbottrang;

                txtGia.Text = double.Parse(dgvPhong.CurrentRow.Cells["GIA"].Value.ToString()).ToString(".");
                if (!dgvPhong.CurrentRow.Cells["ROLL"].Value.ToString().Equals(""))
                {
                    roll = int.Parse(dgvPhong.CurrentRow.Cells["ROLL"].Value.ToString());
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Lỗi không có giá trị !!!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (roll != -1)
            {
                cboTrangThai.SelectedIndex = roll;
            }
            if (roll == 1)
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
            cboTrangThai.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            string maPhg = txtMaPhong.Text;
            string loai = cboLoai.SelectedValue.ToString();
            string tinhTrang = cboTinhTrang.SelectedValue.ToString();
            string gia = txtGia.Text;
            string trangThai = cboTrangThai.Items.ToString();
            try
            {
                BAL_Phong capnhat = new BAL_Phong();
                bool ketQua = capnhat.updatePhong(maPhg, loai, tinhTrang, gia);
                if (ketQua == true)
                {
                    MessageBox.Show("Đã cập nhật thành công phòng  " + maPhg, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvPhong.DataSource = xuLyPhong.DanhSachPhong();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công: " + maPhg, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {

                MessageBox.Show("Lỗi dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text;
            try
            {
                BAL_Phong xoaPhong = new BAL_Phong();
                bool ketQua = xoaPhong.deletePhong(maPhong);
                if (ketQua == true)
                {
                    MessageBox.Show("Đã xóa thành công 1 phòng: " + maPhong, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Xóa không thành công: " + maPhong, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dgvPhong.DataSource = xuLyPhong.DanhSachPhong();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaPhong.Clear();
            txtGia.Clear();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            dgvPhong.DataSource = xuLyPhong.DanhSachPhong();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvPhong.DataSource = xuLyPhong.timKiem(txtNhap_timkiem.Text);
        }
    }
}
