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
using System.Data;
using System.Data.SqlClient;

namespace ProjectDA
{
    public partial class ControlQuanLyThuePhong : UserControl
    {
        private string Ma_nhanvien = "";

        BAL_KhachHang xuLyMaKhachHang = new BAL_KhachHang();
        BAL_Phong xuLyPhong = new BAL_Phong();

        public ControlQuanLyThuePhong()
        {
            InitializeComponent();
        }
        public ControlQuanLyThuePhong(string user)
        {
            InitializeComponent();
            Ma_nhanvien = user;
        }
        private void LayDanhSachThuePhong(DataGridView dgv)
        {
            BAL_QuanLyThuePhong xuLyThuePhong = new BAL_QuanLyThuePhong();
            dgv.DataSource = xuLyThuePhong.DanhSachThuePhong();
        }

        private void ControlQuanLyThuePhong_Load(object sender, EventArgs e)
        {
            LayDanhSachThuePhong(dgvThuePhong);
            BAL_DangNhap xuLyDangNhap = new BAL_DangNhap();
            txtNV.Text = xuLyDangNhap.FindNhanVienByMa(Ma_nhanvien).Rows[0].ItemArray[2].ToString();
            txtNV.Enabled = false;
            btnXoa.Enabled = false;
            btnTraPhong.Enabled = false;
            layDuLieu_KH();
            layDuLieu_Phong();


        }
        public void layDuLieu_Phong()
        {
            cboPhong.Text = "";
            cboPhong.DataSource = xuLyPhong.DanhSachPhong_rong();
            cboPhong.DisplayMember = "MAPHG";
            cboPhong.ValueMember = "MAPHG";
            if (cboPhong.Items.Count > 0)
            {
                cboPhong.SelectedIndex = 0;
            }
        }
        public void layDuLieu_KH()
        {
            cboKhachHang.DataSource = xuLyMaKhachHang.DocDSKhachHang();
            cboKhachHang.DisplayMember = "HOTENKH";
            cboKhachHang.ValueMember = "MAKH";
        }
        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            if (cboKhachHang.Items.Count < 1)
            {
                MessageBox.Show("Hết Phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            string maKH = cboKhachHang.SelectedValue.ToString();
            string maPHG = cboPhong.SelectedValue.ToString();
            DateTime ngayDatPhong = dtpNgayNhan.Value;
            DateTime ngayTraPhong = dtpNgayTra.Value;
            try
            {
                bool ketQuaThuePhong = false;
                BEL_QuanLyThuePhong tp = new BEL_QuanLyThuePhong(Ma_nhanvien, maKH, maPHG, ngayDatPhong, ngayTraPhong);
                BAL_QuanLyThuePhong thuePhong = new BAL_QuanLyThuePhong();
                if (checkTraPhong.Checked)
                {
                    if (ngayTraPhong.CompareTo(ngayDatPhong) == -1)
                    {
                        MessageBox.Show("Ngày trả phòng phải lớn ngày đặt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    ketQuaThuePhong = thuePhong.ThuePhong(tp);

                }
                else
                {
                    ketQuaThuePhong = thuePhong.ThuePhong_NoTraPhong(tp);
                }
                if (ketQuaThuePhong == true)
                {
                    BAL_Phong xuLyPhong = new BAL_Phong();
                    xuLyPhong.setrollphong(maPHG, 1.ToString());
                    layDuLieu_Phong();
                    MessageBox.Show("Mã khách hàng" + maKH + " đã thuê phòng thành công !! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Mã khách hàng" + maKH + " thuê phòng không thành công !! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LayDanhSachThuePhong(dgvThuePhong);
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                gbKhachHang.Visible = true;
            }
            else
                gbKhachHang.Visible = false;

        }
        private void dgvThuePhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BAL_QuanLyThuePhong xulyThuePhong = new BAL_QuanLyThuePhong();
            double tong = xulyThuePhong.gettonghoadon(dgvThuePhong.CurrentRow.Cells["MAHOADON"].Value.ToString());
            if (dgvThuePhong.CurrentRow.Cells["NGAYKT"].Value.ToString().Equals(""))
            {
                btnXoa.Enabled = false;
                btnTraPhong.Enabled = true;
                btnTinhTien.Enabled = false;
            }
            else
            {
                btnTraPhong.Enabled = false;
                btnTinhTien.Enabled = true;
                btnXoa.Enabled = true;
                //dtpNgayTra.Text = dgvThuePhong.CurrentRow.Cells["NGAYKT"].Value.ToString();
            }
            if (!dgvThuePhong.CurrentRow.Cells["NGAYKT"].Value.ToString().Equals("") && DateTime.Parse(dgvThuePhong.CurrentRow.Cells["NGAYKT"].Value.ToString()).CompareTo(DateTime.Now) == 1)
            {
                btnTraPhong.Enabled = true;
            }
            if (dgvThuePhong.CurrentRow.Cells["NGAYDK"].Value.ToString().Equals("") || DateTime.Parse(dgvThuePhong.CurrentRow.Cells["NGAYDK"].Value.ToString()).CompareTo(DateTime.Now) == 1)
            {
                btnTraPhong.Enabled = false;
            }
            if (!tong.Equals(0))
            {
                btnTraPhong.Enabled = false;
            }
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
                }
                else
                {
                    MessageBox.Show("Không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                layDuLieu_KH();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi vui lòng thử lại...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            int songayo = dtpNgayTra.Value.Subtract(dtpNgayNhan.Value).Days;
            songayo = songayo <= 0 ? 1 : songayo;
            BAL_Phong xuLyPhong = new BAL_Phong();
            double gia = xuLyPhong.getGia_Phong(dgvThuePhong.CurrentRow.Cells["MAPHG"].Value.ToString());

            BAL_QuanLyThuePhong xulyThuePhong = new BAL_QuanLyThuePhong();
            bool setNKT = xulyThuePhong.traphong_themNKT(dgvThuePhong.CurrentRow.Cells["MAHOADON"].Value.ToString(), DateTime.Now);
            bool settongHD = xulyThuePhong.Settonghoadon(dgvThuePhong.CurrentRow.Cells["MAHOADON"].Value.ToString(), (double)(songayo * gia));

            bool setroll = xuLyPhong.setrollphong(dgvThuePhong.CurrentRow.Cells["MAPHG"].Value.ToString(), 0.ToString());
            if (setNKT && setroll&&settongHD)
            {
                LayDanhSachThuePhong(dgvThuePhong);
                layDuLieu_Phong();
                MessageBox.Show("Trả phòng thành công (" + dgvThuePhong.CurrentRow.Cells["MAHOADON"].Value.ToString() + ")" + "\n Khách hàng: " + dgvThuePhong.CurrentRow.Cells["MAKH"].Value.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!setNKT)
                {
                    MessageBox.Show("Lỗi ngày trả phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!setroll)
                    {
                        MessageBox.Show("Lỗi roll", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi tong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private void checkTraPhong_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTraPhong.Checked == true)
            {
                dtpNgayTra.Enabled = true;
            }
            else
            {
                dtpNgayTra.Enabled = false;
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            //int songayo = dtpNgayTra.Value.Subtract(dtpNgayNhan.Value).Days;
            //BAL_Phong xuLyPhong = new BAL_Phong();
            //double gia = xuLyPhong.getGia_Phong(dgvThuePhong.CurrentRow.Cells["MAPHG"].Value.ToString());
            //BAL_KhachHang xulyKhachHang = new BAL_KhachHang();
            //int songayo = dtpNgayTra.Value.Subtract(dtpNgayNhan.Value).Days;
            //BAL_QuanLyThuePhong xuLyThuePhong = new BAL_QuanLyThuePhong();
            //double hoadon = xuLyThuePhong.gettonghoadon(dgvThuePhong.CurrentRow.Cells["MAHOADON"].Value.ToString());
            //BAL_KhachHang xulyKhachHang = new BAL_KhachHang();

            //if (songayo < 0)
            //{
            //    MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //if (songayo == 0)
            //{
            //    songayo = 1;
            //}

            //string ouput = "Khách hàng: " + xulyKhachHang.GetNameKH(dgvThuePhong.CurrentRow.Cells["MAKH"].Value.ToString()) + "\n" +
            //    "Số ngày ở: " + (songayo) + "\n" +
            //    "Thành tiền: " + (gia * songayo) ;
            //MessageBox.Show(ouput);
             int songayo = dtpNgayTra.Value.Subtract(dtpNgayNhan.Value).Days;
            BAL_Phong xuLyPhong = new BAL_Phong();
            double gia = xuLyPhong.getGia_Phong(dgvThuePhong.CurrentRow.Cells["MAPHG"].Value.ToString());
            BAL_KhachHang xulyKhachHang = new BAL_KhachHang();

            if (songayo < 0)
            {
                MessageBox.Show("Lỗi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (songayo == 0)
            {
                songayo = 1;
            }

            string ouput = "Khách hàng: " + xulyKhachHang.GetNameKH(dgvThuePhong.CurrentRow.Cells["MAKH"].Value.ToString()) + "\n" +
                "Số ngày ở: " + songayo + "\n" +
                "Thành tiền: " + (songayo * gia).ToString();
            MessageBox.Show(ouput);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                BAL_QuanLyThuePhong xoaPhong = new BAL_QuanLyThuePhong();
                bool ketQua = xoaPhong.deleteThuePhong(dgvThuePhong.CurrentRow.Cells["MAHOADON"].Value.ToString());
                if (ketQua == true)
                {
                    MessageBox.Show("Đã xóa thành công 1 phòng: " + dgvThuePhong.CurrentRow.Cells["MAHOADON"].Value.ToString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Xóa không thành công:  " + dgvThuePhong.CurrentRow.Cells["MAHOADON"].Value.ToString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                LayDanhSachThuePhong(dgvThuePhong);
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LayDanhSachThuePhong(dgvThuePhong);
            layDuLieu_Phong();
            layDuLieu_KH();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            var FormReport = new FormReport();
            FormReport.ShowDialog();
        }

    }
}
