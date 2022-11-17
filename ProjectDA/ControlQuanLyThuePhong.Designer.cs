
namespace ProjectDA
{
    partial class ControlQuanLyThuePhong
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlQuanLyThuePhong));
            this.dgvThuePhong = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbKhachHangThanThiet = new System.Windows.Forms.GroupBox();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.checkTraPhong = new System.Windows.Forms.CheckBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnThuePhong = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbKhachHang = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtQuocTich = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.MAHOADON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuePhong)).BeginInit();
            this.gbKhachHangThanThiet.SuspendLayout();
            this.gbKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThuePhong
            // 
            this.dgvThuePhong.AllowUserToAddRows = false;
            this.dgvThuePhong.AllowUserToDeleteRows = false;
            this.dgvThuePhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThuePhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuePhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHOADON,
            this.MANV,
            this.MAPHG,
            this.MAKH,
            this.NGAYDK,
            this.NGAYKT});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThuePhong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThuePhong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThuePhong.Location = new System.Drawing.Point(0, 452);
            this.dgvThuePhong.Name = "dgvThuePhong";
            this.dgvThuePhong.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThuePhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThuePhong.RowHeadersWidth = 51;
            this.dgvThuePhong.RowTemplate.Height = 24;
            this.dgvThuePhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuePhong.Size = new System.Drawing.Size(1708, 507);
            this.dgvThuePhong.TabIndex = 43;
            this.dgvThuePhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuePhong_CellClick);
            // 
            // gbKhachHangThanThiet
            // 
            this.gbKhachHangThanThiet.Controls.Add(this.btnInHoaDon);
            this.gbKhachHangThanThiet.Controls.Add(this.btnXoa);
            this.gbKhachHangThanThiet.Controls.Add(this.checkTraPhong);
            this.gbKhachHangThanThiet.Controls.Add(this.btnTinhTien);
            this.gbKhachHangThanThiet.Controls.Add(this.txtNV);
            this.gbKhachHangThanThiet.Controls.Add(this.btnTraPhong);
            this.gbKhachHangThanThiet.Controls.Add(this.btnThuePhong);
            this.gbKhachHangThanThiet.Controls.Add(this.label5);
            this.gbKhachHangThanThiet.Controls.Add(this.label4);
            this.gbKhachHangThanThiet.Controls.Add(this.cboPhong);
            this.gbKhachHangThanThiet.Controls.Add(this.label2);
            this.gbKhachHangThanThiet.Controls.Add(this.cboKhachHang);
            this.gbKhachHangThanThiet.Controls.Add(this.dtpNgayTra);
            this.gbKhachHangThanThiet.Controls.Add(this.dtpNgayNhan);
            this.gbKhachHangThanThiet.Controls.Add(this.label11);
            this.gbKhachHangThanThiet.Controls.Add(this.label9);
            this.gbKhachHangThanThiet.Location = new System.Drawing.Point(35, 56);
            this.gbKhachHangThanThiet.Name = "gbKhachHangThanThiet";
            this.gbKhachHangThanThiet.Size = new System.Drawing.Size(726, 311);
            this.gbKhachHangThanThiet.TabIndex = 68;
            this.gbKhachHangThanThiet.TabStop = false;
            this.gbKhachHangThanThiet.Text = "Khách hàng thân thiết";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(534, 243);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(91, 44);
            this.btnInHoaDon.TabIndex = 85;
            this.btnInHoaDon.Text = "Thống Kê";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(408, 244);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 44);
            this.btnXoa.TabIndex = 84;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // checkTraPhong
            // 
            this.checkTraPhong.AutoSize = true;
            this.checkTraPhong.Location = new System.Drawing.Point(357, 181);
            this.checkTraPhong.Name = "checkTraPhong";
            this.checkTraPhong.Size = new System.Drawing.Size(18, 17);
            this.checkTraPhong.TabIndex = 83;
            this.checkTraPhong.UseVisualStyleBackColor = true;
            this.checkTraPhong.CheckedChanged += new System.EventHandler(this.checkTraPhong_CheckedChanged);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Enabled = false;
            this.btnTinhTien.Location = new System.Drawing.Point(290, 247);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(98, 42);
            this.btnTinhTien.TabIndex = 82;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // txtNV
            // 
            this.txtNV.Location = new System.Drawing.Point(476, 41);
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(224, 22);
            this.txtNV.TabIndex = 81;
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Location = new System.Drawing.Point(172, 246);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(101, 42);
            this.btnTraPhong.TabIndex = 80;
            this.btnTraPhong.Text = "Trả Phòng";
            this.btnTraPhong.UseVisualStyleBackColor = true;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // btnThuePhong
            // 
            this.btnThuePhong.Location = new System.Drawing.Point(53, 247);
            this.btnThuePhong.Name = "btnThuePhong";
            this.btnThuePhong.Size = new System.Drawing.Size(97, 42);
            this.btnThuePhong.TabIndex = 79;
            this.btnThuePhong.Text = "Thuê Phòng";
            this.btnThuePhong.UseVisualStyleBackColor = true;
            this.btnThuePhong.Click += new System.EventHandler(this.btnThuePhong_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 78;
            this.label5.Text = "Mã Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 77;
            this.label4.Text = "Nhân Viên";
            // 
            // cboPhong
            // 
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(476, 103);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(224, 24);
            this.cboPhong.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 74;
            this.label2.Text = "Khách Hàng";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(140, 36);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(211, 24);
            this.cboKhachHang.TabIndex = 73;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Enabled = false;
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(140, 176);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(211, 22);
            this.dtpNgayTra.TabIndex = 72;
            // 
            // dtpNgayNhan
            // 
            this.dtpNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhan.Location = new System.Drawing.Point(140, 101);
            this.dtpNgayNhan.Name = "dtpNgayNhan";
            this.dtpNgayNhan.Size = new System.Drawing.Size(211, 22);
            this.dtpNgayNhan.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 17);
            this.label11.TabIndex = 70;
            this.label11.Text = "Ngày trả phòng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 69;
            this.label9.Text = "Ngày đặt phòng";
            // 
            // gbKhachHang
            // 
            this.gbKhachHang.Controls.Add(this.btnThem);
            this.gbKhachHang.Controls.Add(this.txtDiaChi);
            this.gbKhachHang.Controls.Add(this.label7);
            this.gbKhachHang.Controls.Add(this.label6);
            this.gbKhachHang.Controls.Add(this.label19);
            this.gbKhachHang.Controls.Add(this.label8);
            this.gbKhachHang.Controls.Add(this.radNam);
            this.gbKhachHang.Controls.Add(this.label10);
            this.gbKhachHang.Controls.Add(this.label12);
            this.gbKhachHang.Controls.Add(this.radNu);
            this.gbKhachHang.Controls.Add(this.txtSDT);
            this.gbKhachHang.Controls.Add(this.label13);
            this.gbKhachHang.Controls.Add(this.dateTimePicker1);
            this.gbKhachHang.Controls.Add(this.txtTenKH);
            this.gbKhachHang.Controls.Add(this.txtCMND);
            this.gbKhachHang.Controls.Add(this.txtQuocTich);
            this.gbKhachHang.Controls.Add(this.label14);
            this.gbKhachHang.Controls.Add(this.txtMaKH);
            this.gbKhachHang.Location = new System.Drawing.Point(767, 56);
            this.gbKhachHang.Name = "gbKhachHang";
            this.gbKhachHang.Size = new System.Drawing.Size(849, 311);
            this.gbKhachHang.TabIndex = 71;
            this.gbKhachHang.TabStop = false;
            this.gbKhachHang.Text = "Thông tin";
            this.gbKhachHang.Visible = false;
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(241, 245);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 42);
            this.btnThem.TabIndex = 72;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(573, 39);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(239, 22);
            this.txtDiaChi.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "CMND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Mã Khách Hàng";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(28, 145);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 17);
            this.label19.TabIndex = 45;
            this.label19.Text = "Giới tính";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Số Điện Thoại";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(181, 142);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(58, 21);
            this.radNam.TabIndex = 37;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(447, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "Địa Chỉ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(450, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 49;
            this.label12.Text = "Quốc Tịch";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(327, 141);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(47, 21);
            this.radNu.TabIndex = 38;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(573, 89);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(239, 22);
            this.txtSDT.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 42;
            this.label13.Text = "Ngày Sinh";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 193);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 22);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(167, 90);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(236, 22);
            this.txtTenKH.TabIndex = 35;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(573, 142);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(239, 22);
            this.txtCMND.TabIndex = 50;
            // 
            // txtQuocTich
            // 
            this.txtQuocTich.Location = new System.Drawing.Point(572, 193);
            this.txtQuocTich.Name = "txtQuocTich";
            this.txtQuocTich.Size = new System.Drawing.Size(239, 22);
            this.txtQuocTich.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 17);
            this.label14.TabIndex = 41;
            this.label14.Text = "Họ và Tên KH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(167, 44);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(237, 22);
            this.txtMaKH.TabIndex = 34;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(88, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 21);
            this.checkBox1.TabIndex = 65;
            this.checkBox1.Text = "Khách hàng mới";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.Control;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(35, 13);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(32, 27);
            this.btnLamMoi.TabIndex = 85;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // MAHOADON
            // 
            this.MAHOADON.DataPropertyName = "MAHOADON";
            this.MAHOADON.FillWeight = 30F;
            this.MAHOADON.HeaderText = "Mã Hóa Đơn";
            this.MAHOADON.MinimumWidth = 6;
            this.MAHOADON.Name = "MAHOADON";
            this.MAHOADON.ReadOnly = true;
            // 
            // MANV
            // 
            this.MANV.DataPropertyName = "MANV";
            this.MANV.FillWeight = 30F;
            this.MANV.HeaderText = "Mã Nhân Viên";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            this.MANV.ReadOnly = true;
            // 
            // MAPHG
            // 
            this.MAPHG.DataPropertyName = "MAPHG";
            this.MAPHG.FillWeight = 30F;
            this.MAPHG.HeaderText = "Mã Phòng";
            this.MAPHG.MinimumWidth = 6;
            this.MAPHG.Name = "MAPHG";
            this.MAPHG.ReadOnly = true;
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.FillWeight = 30F;
            this.MAKH.HeaderText = "Mã Khách Hàng";
            this.MAKH.MinimumWidth = 6;
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            // 
            // NGAYDK
            // 
            this.NGAYDK.DataPropertyName = "NGAYDK";
            this.NGAYDK.FillWeight = 50F;
            this.NGAYDK.HeaderText = "Ngày Đặt Phòng";
            this.NGAYDK.MinimumWidth = 6;
            this.NGAYDK.Name = "NGAYDK";
            this.NGAYDK.ReadOnly = true;
            // 
            // NGAYKT
            // 
            this.NGAYKT.DataPropertyName = "NGAYKT";
            this.NGAYKT.FillWeight = 50F;
            this.NGAYKT.HeaderText = "Ngày Trả Phòng";
            this.NGAYKT.MinimumWidth = 6;
            this.NGAYKT.Name = "NGAYKT";
            this.NGAYKT.ReadOnly = true;
            // 
            // ControlQuanLyThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbKhachHangThanThiet);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.gbKhachHang);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dgvThuePhong);
            this.Name = "ControlQuanLyThuePhong";
            this.Size = new System.Drawing.Size(1708, 959);
            this.Load += new System.EventHandler(this.ControlQuanLyThuePhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuePhong)).EndInit();
            this.gbKhachHangThanThiet.ResumeLayout(false);
            this.gbKhachHangThanThiet.PerformLayout();
            this.gbKhachHang.ResumeLayout(false);
            this.gbKhachHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvThuePhong;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbKhachHangThanThiet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayNhan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.GroupBox gbKhachHang;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtQuocTich;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnThuePhong;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtNV;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.CheckBox checkTraPhong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHOADON;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYKT;
    }
}
