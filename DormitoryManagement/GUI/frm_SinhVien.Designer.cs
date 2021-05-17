
namespace GUI
{
    partial class frm_SinhVien
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_sinhVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sua = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_taiLai = new Guna.UI2.WinForms.Guna2Button();
            this.btn_huy = new Guna.UI2.WinForms.Guna2Button();
            this.btn_luu = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_gioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_KTKL = new Guna.UI2.WinForms.Guna2Button();
            this.txb_maHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_phong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_CMNDTN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_dienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_diaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_hoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_CMND = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_maSV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_timKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_maHD = new Guna.UI2.WinForms.Guna2Button();
            this.btn_chiTietPhong = new Guna.UI2.WinForms.Guna2Button();
            this.btn_chiTietTN = new Guna.UI2.WinForms.Guna2Button();
            this.btn_timKiem = new Guna.UI2.WinForms.Guna2Button();
            this.dtp_ngaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lb_maHD = new System.Windows.Forms.Label();
            this.lb_phong = new System.Windows.Forms.Label();
            this.lb_hoTenTN = new System.Windows.Forms.Label();
            this.lb_dienThoai = new System.Windows.Forms.Label();
            this.lb_diaChi = new System.Windows.Forms.Label();
            this.lb_ngaySinh = new System.Windows.Forms.Label();
            this.lb_gioiTinh = new System.Windows.Forms.Label();
            this.lb_hoTen = new System.Windows.Forms.Label();
            this.lb_CMND = new System.Windows.Forms.Label();
            this.lb_maSV = new System.Windows.Forms.Label();
            this.lb_timKiem = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinhVien)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonXuatExcel);
            this.panel1.Controls.Add(this.dgv_sinhVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(439, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 683);
            this.panel1.TabIndex = 0;
            // 
            // buttonXuatExcel
            // 
            this.buttonXuatExcel.BorderColor = System.Drawing.Color.Gray;
            this.buttonXuatExcel.BorderThickness = 1;
            this.buttonXuatExcel.CheckedState.Parent = this.buttonXuatExcel;
            this.buttonXuatExcel.CustomImages.Parent = this.buttonXuatExcel;
            this.buttonXuatExcel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonXuatExcel.FillColor = System.Drawing.Color.Transparent;
            this.buttonXuatExcel.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Bold);
            this.buttonXuatExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonXuatExcel.HoverState.Parent = this.buttonXuatExcel;
            this.buttonXuatExcel.Image = global::GUI.Properties.Resources.icons8_xls_export_160px;
            this.buttonXuatExcel.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonXuatExcel.Location = new System.Drawing.Point(0, 625);
            this.buttonXuatExcel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXuatExcel.Name = "buttonXuatExcel";
            this.buttonXuatExcel.ShadowDecoration.Parent = this.buttonXuatExcel;
            this.buttonXuatExcel.Size = new System.Drawing.Size(865, 58);
            this.buttonXuatExcel.TabIndex = 7;
            this.buttonXuatExcel.Text = "Xuất EXCEL";
            this.buttonXuatExcel.Click += new System.EventHandler(this.buttonXuatExcel_Click);
            // 
            // dgv_sinhVien
            // 
            this.dgv_sinhVien.AllowUserToAddRows = false;
            this.dgv_sinhVien.AllowUserToDeleteRows = false;
            this.dgv_sinhVien.AllowUserToResizeColumns = false;
            this.dgv_sinhVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_sinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_sinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sinhVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_sinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_sinhVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_sinhVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_sinhVien.ColumnHeadersHeight = 40;
            this.dgv_sinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.GioiTinh,
            this.NgaySinh,
            this.DienThoai,
            this.MaPhong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sinhVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_sinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_sinhVien.EnableHeadersVisualStyles = false;
            this.dgv_sinhVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_sinhVien.Location = new System.Drawing.Point(0, 0);
            this.dgv_sinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_sinhVien.Name = "dgv_sinhVien";
            this.dgv_sinhVien.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sinhVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_sinhVien.RowHeadersVisible = false;
            this.dgv_sinhVien.RowHeadersWidth = 51;
            this.dgv_sinhVien.RowTemplate.DividerHeight = 5;
            this.dgv_sinhVien.RowTemplate.Height = 40;
            this.dgv_sinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sinhVien.Size = new System.Drawing.Size(865, 683);
            this.dgv_sinhVien.TabIndex = 4;
            this.dgv_sinhVien.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_sinhVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_sinhVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_sinhVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_sinhVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_sinhVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_sinhVien.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_sinhVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_sinhVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_sinhVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_sinhVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgv_sinhVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgv_sinhVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_sinhVien.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_sinhVien.ThemeStyle.ReadOnly = true;
            this.dgv_sinhVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_sinhVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_sinhVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_sinhVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_sinhVien.ThemeStyle.RowsStyle.Height = 40;
            this.dgv_sinhVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgv_sinhVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_sinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sinhVien_CellClick);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.FillWeight = 84.83527F;
            this.MaSV.HeaderText = "Mã SV";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.FillWeight = 169.5384F;
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.FillWeight = 57.04103F;
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.FillWeight = 87.33154F;
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.FillWeight = 103.7915F;
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.MinimumWidth = 6;
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.FillWeight = 70.93935F;
            this.MaPhong.HeaderText = "Phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_them);
            this.flowLayoutPanel1.Controls.Add(this.btn_sua);
            this.flowLayoutPanel1.Controls.Add(this.btn_xoa);
            this.flowLayoutPanel1.Controls.Add(this.btn_taiLai);
            this.flowLayoutPanel1.Controls.Add(this.btn_huy);
            this.flowLayoutPanel1.Controls.Add(this.btn_luu);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 577);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(439, 106);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_them
            // 
            this.btn_them.CheckedState.Parent = this.btn_them;
            this.btn_them.CustomImages.Parent = this.btn_them;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.HoverState.Parent = this.btn_them;
            this.btn_them.Location = new System.Drawing.Point(4, 4);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.ShadowDecoration.Parent = this.btn_them;
            this.btn_them.Size = new System.Drawing.Size(109, 43);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.CheckedState.Parent = this.btn_sua;
            this.btn_sua.CustomImages.Parent = this.btn_sua;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.HoverState.Parent = this.btn_sua;
            this.btn_sua.Location = new System.Drawing.Point(121, 4);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.ShadowDecoration.Parent = this.btn_sua;
            this.btn_sua.Size = new System.Drawing.Size(109, 43);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa ";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.CheckedState.Parent = this.btn_xoa;
            this.btn_xoa.CustomImages.Parent = this.btn_xoa;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.HoverState.Parent = this.btn_xoa;
            this.btn_xoa.Location = new System.Drawing.Point(238, 4);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.ShadowDecoration.Parent = this.btn_xoa;
            this.btn_xoa.Size = new System.Drawing.Size(109, 43);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_taiLai
            // 
            this.btn_taiLai.CheckedState.Parent = this.btn_taiLai;
            this.btn_taiLai.CustomImages.Parent = this.btn_taiLai;
            this.btn_taiLai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taiLai.ForeColor = System.Drawing.Color.White;
            this.btn_taiLai.HoverState.Parent = this.btn_taiLai;
            this.btn_taiLai.Location = new System.Drawing.Point(4, 55);
            this.btn_taiLai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_taiLai.Name = "btn_taiLai";
            this.btn_taiLai.ShadowDecoration.Parent = this.btn_taiLai;
            this.btn_taiLai.Size = new System.Drawing.Size(109, 43);
            this.btn_taiLai.TabIndex = 5;
            this.btn_taiLai.Text = "Tải lại";
            this.btn_taiLai.Click += new System.EventHandler(this.btn_taiLai_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.CheckedState.Parent = this.btn_huy;
            this.btn_huy.CustomImages.Parent = this.btn_huy;
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.HoverState.Parent = this.btn_huy;
            this.btn_huy.Location = new System.Drawing.Point(121, 55);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.ShadowDecoration.Parent = this.btn_huy;
            this.btn_huy.Size = new System.Drawing.Size(109, 43);
            this.btn_huy.TabIndex = 7;
            this.btn_huy.Text = "Huỷ";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.CheckedState.Parent = this.btn_luu;
            this.btn_luu.CustomImages.Parent = this.btn_luu;
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.HoverState.Parent = this.btn_luu;
            this.btn_luu.Location = new System.Drawing.Point(238, 55);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.ShadowDecoration.Parent = this.btn_luu;
            this.btn_luu.Size = new System.Drawing.Size(109, 43);
            this.btn_luu.TabIndex = 6;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 683);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cb_gioiTinh);
            this.panel3.Controls.Add(this.btn_KTKL);
            this.panel3.Controls.Add(this.txb_maHD);
            this.panel3.Controls.Add(this.txb_phong);
            this.panel3.Controls.Add(this.txb_CMNDTN);
            this.panel3.Controls.Add(this.txb_dienThoai);
            this.panel3.Controls.Add(this.txb_diaChi);
            this.panel3.Controls.Add(this.txb_hoTen);
            this.panel3.Controls.Add(this.txb_CMND);
            this.panel3.Controls.Add(this.txb_maSV);
            this.panel3.Controls.Add(this.txb_timKiem);
            this.panel3.Controls.Add(this.btn_maHD);
            this.panel3.Controls.Add(this.btn_chiTietPhong);
            this.panel3.Controls.Add(this.btn_chiTietTN);
            this.panel3.Controls.Add(this.btn_timKiem);
            this.panel3.Controls.Add(this.dtp_ngaySinh);
            this.panel3.Controls.Add(this.lb_maHD);
            this.panel3.Controls.Add(this.lb_phong);
            this.panel3.Controls.Add(this.lb_hoTenTN);
            this.panel3.Controls.Add(this.lb_dienThoai);
            this.panel3.Controls.Add(this.lb_diaChi);
            this.panel3.Controls.Add(this.lb_ngaySinh);
            this.panel3.Controls.Add(this.lb_gioiTinh);
            this.panel3.Controls.Add(this.lb_hoTen);
            this.panel3.Controls.Add(this.lb_CMND);
            this.panel3.Controls.Add(this.lb_maSV);
            this.panel3.Controls.Add(this.lb_timKiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 577);
            this.panel3.TabIndex = 2;
            // 
            // cb_gioiTinh
            // 
            this.cb_gioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cb_gioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_gioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gioiTinh.FocusedColor = System.Drawing.Color.Empty;
            this.cb_gioiTinh.FocusedState.Parent = this.cb_gioiTinh;
            this.cb_gioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_gioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_gioiTinh.FormattingEnabled = true;
            this.cb_gioiTinh.HoverState.Parent = this.cb_gioiTinh;
            this.cb_gioiTinh.ItemHeight = 30;
            this.cb_gioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gioiTinh.ItemsAppearance.Parent = this.cb_gioiTinh;
            this.cb_gioiTinh.Location = new System.Drawing.Point(133, 188);
            this.cb_gioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.cb_gioiTinh.Name = "cb_gioiTinh";
            this.cb_gioiTinh.ShadowDecoration.Parent = this.cb_gioiTinh;
            this.cb_gioiTinh.Size = new System.Drawing.Size(151, 36);
            this.cb_gioiTinh.TabIndex = 58;
            // 
            // btn_KTKL
            // 
            this.btn_KTKL.CheckedState.Parent = this.btn_KTKL;
            this.btn_KTKL.CustomImages.Parent = this.btn_KTKL;
            this.btn_KTKL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KTKL.ForeColor = System.Drawing.Color.White;
            this.btn_KTKL.HoverState.Parent = this.btn_KTKL;
            this.btn_KTKL.Location = new System.Drawing.Point(175, 512);
            this.btn_KTKL.Margin = new System.Windows.Forms.Padding(4);
            this.btn_KTKL.Name = "btn_KTKL";
            this.btn_KTKL.ShadowDecoration.Parent = this.btn_KTKL;
            this.btn_KTKL.Size = new System.Drawing.Size(189, 34);
            this.btn_KTKL.TabIndex = 57;
            this.btn_KTKL.Text = "Khen thưởng - Kỷ luật";
            this.btn_KTKL.Click += new System.EventHandler(this.btn_KTKL_Click);
            // 
            // txb_maHD
            // 
            this.txb_maHD.Animated = true;
            this.txb_maHD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_maHD.BorderRadius = 6;
            this.txb_maHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_maHD.DefaultText = "";
            this.txb_maHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_maHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_maHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_maHD.DisabledState.Parent = this.txb_maHD;
            this.txb_maHD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_maHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_maHD.FocusedState.Parent = this.txb_maHD;
            this.txb_maHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_maHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_maHD.HoverState.Parent = this.txb_maHD;
            this.txb_maHD.Location = new System.Drawing.Point(133, 474);
            this.txb_maHD.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_maHD.Name = "txb_maHD";
            this.txb_maHD.PasswordChar = '\0';
            this.txb_maHD.PlaceholderText = "";
            this.txb_maHD.SelectedText = "";
            this.txb_maHD.ShadowDecoration.Parent = this.txb_maHD;
            this.txb_maHD.Size = new System.Drawing.Size(231, 31);
            this.txb_maHD.TabIndex = 56;
            // 
            // txb_phong
            // 
            this.txb_phong.Animated = true;
            this.txb_phong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_phong.BorderRadius = 6;
            this.txb_phong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_phong.DefaultText = "";
            this.txb_phong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_phong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_phong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_phong.DisabledState.Parent = this.txb_phong;
            this.txb_phong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_phong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_phong.FocusedState.Parent = this.txb_phong;
            this.txb_phong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_phong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_phong.HoverState.Parent = this.txb_phong;
            this.txb_phong.Location = new System.Drawing.Point(133, 434);
            this.txb_phong.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_phong.Name = "txb_phong";
            this.txb_phong.PasswordChar = '\0';
            this.txb_phong.PlaceholderText = "";
            this.txb_phong.SelectedText = "";
            this.txb_phong.ShadowDecoration.Parent = this.txb_phong;
            this.txb_phong.Size = new System.Drawing.Size(231, 31);
            this.txb_phong.TabIndex = 55;
            // 
            // txb_CMNDTN
            // 
            this.txb_CMNDTN.Animated = true;
            this.txb_CMNDTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_CMNDTN.BorderRadius = 6;
            this.txb_CMNDTN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_CMNDTN.DefaultText = "";
            this.txb_CMNDTN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_CMNDTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_CMNDTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_CMNDTN.DisabledState.Parent = this.txb_CMNDTN;
            this.txb_CMNDTN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_CMNDTN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_CMNDTN.FocusedState.Parent = this.txb_CMNDTN;
            this.txb_CMNDTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_CMNDTN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_CMNDTN.HoverState.Parent = this.txb_CMNDTN;
            this.txb_CMNDTN.Location = new System.Drawing.Point(133, 384);
            this.txb_CMNDTN.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_CMNDTN.Name = "txb_CMNDTN";
            this.txb_CMNDTN.PasswordChar = '\0';
            this.txb_CMNDTN.PlaceholderText = "";
            this.txb_CMNDTN.SelectedText = "";
            this.txb_CMNDTN.ShadowDecoration.Parent = this.txb_CMNDTN;
            this.txb_CMNDTN.Size = new System.Drawing.Size(231, 31);
            this.txb_CMNDTN.TabIndex = 54;
            // 
            // txb_dienThoai
            // 
            this.txb_dienThoai.Animated = true;
            this.txb_dienThoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_dienThoai.BorderRadius = 6;
            this.txb_dienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_dienThoai.DefaultText = "";
            this.txb_dienThoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_dienThoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_dienThoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_dienThoai.DisabledState.Parent = this.txb_dienThoai;
            this.txb_dienThoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_dienThoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_dienThoai.FocusedState.Parent = this.txb_dienThoai;
            this.txb_dienThoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_dienThoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_dienThoai.HoverState.Parent = this.txb_dienThoai;
            this.txb_dienThoai.Location = new System.Drawing.Point(133, 341);
            this.txb_dienThoai.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_dienThoai.Name = "txb_dienThoai";
            this.txb_dienThoai.PasswordChar = '\0';
            this.txb_dienThoai.PlaceholderText = "";
            this.txb_dienThoai.SelectedText = "";
            this.txb_dienThoai.ShadowDecoration.Parent = this.txb_dienThoai;
            this.txb_dienThoai.Size = new System.Drawing.Size(231, 31);
            this.txb_dienThoai.TabIndex = 53;
            // 
            // txb_diaChi
            // 
            this.txb_diaChi.Animated = true;
            this.txb_diaChi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_diaChi.BorderRadius = 6;
            this.txb_diaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_diaChi.DefaultText = "";
            this.txb_diaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_diaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_diaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_diaChi.DisabledState.Parent = this.txb_diaChi;
            this.txb_diaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_diaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_diaChi.FocusedState.Parent = this.txb_diaChi;
            this.txb_diaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_diaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_diaChi.HoverState.Parent = this.txb_diaChi;
            this.txb_diaChi.Location = new System.Drawing.Point(133, 294);
            this.txb_diaChi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_diaChi.Name = "txb_diaChi";
            this.txb_diaChi.PasswordChar = '\0';
            this.txb_diaChi.PlaceholderText = "";
            this.txb_diaChi.SelectedText = "";
            this.txb_diaChi.ShadowDecoration.Parent = this.txb_diaChi;
            this.txb_diaChi.Size = new System.Drawing.Size(231, 31);
            this.txb_diaChi.TabIndex = 52;
            // 
            // txb_hoTen
            // 
            this.txb_hoTen.Animated = true;
            this.txb_hoTen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_hoTen.BorderRadius = 6;
            this.txb_hoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_hoTen.DefaultText = "";
            this.txb_hoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_hoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_hoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_hoTen.DisabledState.Parent = this.txb_hoTen;
            this.txb_hoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_hoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_hoTen.FocusedState.Parent = this.txb_hoTen;
            this.txb_hoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_hoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_hoTen.HoverState.Parent = this.txb_hoTen;
            this.txb_hoTen.Location = new System.Drawing.Point(133, 150);
            this.txb_hoTen.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_hoTen.Name = "txb_hoTen";
            this.txb_hoTen.PasswordChar = '\0';
            this.txb_hoTen.PlaceholderText = "";
            this.txb_hoTen.SelectedText = "";
            this.txb_hoTen.ShadowDecoration.Parent = this.txb_hoTen;
            this.txb_hoTen.Size = new System.Drawing.Size(231, 31);
            this.txb_hoTen.TabIndex = 51;
            // 
            // txb_CMND
            // 
            this.txb_CMND.Animated = true;
            this.txb_CMND.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_CMND.BorderRadius = 6;
            this.txb_CMND.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_CMND.DefaultText = "";
            this.txb_CMND.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_CMND.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_CMND.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_CMND.DisabledState.Parent = this.txb_CMND;
            this.txb_CMND.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_CMND.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_CMND.FocusedState.Parent = this.txb_CMND;
            this.txb_CMND.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_CMND.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_CMND.HoverState.Parent = this.txb_CMND;
            this.txb_CMND.Location = new System.Drawing.Point(133, 112);
            this.txb_CMND.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_CMND.Name = "txb_CMND";
            this.txb_CMND.PasswordChar = '\0';
            this.txb_CMND.PlaceholderText = "";
            this.txb_CMND.SelectedText = "";
            this.txb_CMND.ShadowDecoration.Parent = this.txb_CMND;
            this.txb_CMND.Size = new System.Drawing.Size(231, 31);
            this.txb_CMND.TabIndex = 50;
            // 
            // txb_maSV
            // 
            this.txb_maSV.Animated = true;
            this.txb_maSV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_maSV.BorderRadius = 6;
            this.txb_maSV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_maSV.DefaultText = "";
            this.txb_maSV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_maSV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_maSV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_maSV.DisabledState.Parent = this.txb_maSV;
            this.txb_maSV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_maSV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_maSV.FocusedState.Parent = this.txb_maSV;
            this.txb_maSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_maSV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_maSV.HoverState.Parent = this.txb_maSV;
            this.txb_maSV.Location = new System.Drawing.Point(133, 70);
            this.txb_maSV.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_maSV.Name = "txb_maSV";
            this.txb_maSV.PasswordChar = '\0';
            this.txb_maSV.PlaceholderText = "";
            this.txb_maSV.SelectedText = "";
            this.txb_maSV.ShadowDecoration.Parent = this.txb_maSV;
            this.txb_maSV.Size = new System.Drawing.Size(231, 31);
            this.txb_maSV.TabIndex = 49;
            // 
            // txb_timKiem
            // 
            this.txb_timKiem.Animated = true;
            this.txb_timKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_timKiem.BorderRadius = 6;
            this.txb_timKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_timKiem.DefaultText = "";
            this.txb_timKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_timKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_timKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_timKiem.DisabledState.Parent = this.txb_timKiem;
            this.txb_timKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_timKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_timKiem.FocusedState.Parent = this.txb_timKiem;
            this.txb_timKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_timKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_timKiem.HoverState.Parent = this.txb_timKiem;
            this.txb_timKiem.Location = new System.Drawing.Point(133, 21);
            this.txb_timKiem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_timKiem.Name = "txb_timKiem";
            this.txb_timKiem.PasswordChar = '\0';
            this.txb_timKiem.PlaceholderText = "";
            this.txb_timKiem.SelectedText = "";
            this.txb_timKiem.ShadowDecoration.Parent = this.txb_timKiem;
            this.txb_timKiem.Size = new System.Drawing.Size(231, 31);
            this.txb_timKiem.TabIndex = 4;
            // 
            // btn_maHD
            // 
            this.btn_maHD.CheckedState.Parent = this.btn_maHD;
            this.btn_maHD.CustomImages.Parent = this.btn_maHD;
            this.btn_maHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_maHD.ForeColor = System.Drawing.Color.White;
            this.btn_maHD.HoverState.Parent = this.btn_maHD;
            this.btn_maHD.Location = new System.Drawing.Point(377, 474);
            this.btn_maHD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_maHD.Name = "btn_maHD";
            this.btn_maHD.ShadowDecoration.Parent = this.btn_maHD;
            this.btn_maHD.Size = new System.Drawing.Size(61, 31);
            this.btn_maHD.TabIndex = 48;
            this.btn_maHD.Text = "...";
            this.btn_maHD.Click += new System.EventHandler(this.btn_maHD_Click);
            // 
            // btn_chiTietPhong
            // 
            this.btn_chiTietPhong.CheckedState.Parent = this.btn_chiTietPhong;
            this.btn_chiTietPhong.CustomImages.Parent = this.btn_chiTietPhong;
            this.btn_chiTietPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_chiTietPhong.ForeColor = System.Drawing.Color.White;
            this.btn_chiTietPhong.HoverState.Parent = this.btn_chiTietPhong;
            this.btn_chiTietPhong.Location = new System.Drawing.Point(377, 428);
            this.btn_chiTietPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chiTietPhong.Name = "btn_chiTietPhong";
            this.btn_chiTietPhong.ShadowDecoration.Parent = this.btn_chiTietPhong;
            this.btn_chiTietPhong.Size = new System.Drawing.Size(61, 31);
            this.btn_chiTietPhong.TabIndex = 47;
            this.btn_chiTietPhong.Text = "...";
            this.btn_chiTietPhong.Click += new System.EventHandler(this.btn_chiTietPhong_Click);
            // 
            // btn_chiTietTN
            // 
            this.btn_chiTietTN.CheckedState.Parent = this.btn_chiTietTN;
            this.btn_chiTietTN.CustomImages.Parent = this.btn_chiTietTN;
            this.btn_chiTietTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_chiTietTN.ForeColor = System.Drawing.Color.White;
            this.btn_chiTietTN.HoverState.Parent = this.btn_chiTietTN;
            this.btn_chiTietTN.Location = new System.Drawing.Point(377, 384);
            this.btn_chiTietTN.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chiTietTN.Name = "btn_chiTietTN";
            this.btn_chiTietTN.ShadowDecoration.Parent = this.btn_chiTietTN;
            this.btn_chiTietTN.Size = new System.Drawing.Size(61, 31);
            this.btn_chiTietTN.TabIndex = 3;
            this.btn_chiTietTN.Text = "...";
            this.btn_chiTietTN.Click += new System.EventHandler(this.btn_chiTietTN_Click);
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.CheckedState.Parent = this.btn_timKiem;
            this.btn_timKiem.CustomImages.Parent = this.btn_timKiem;
            this.btn_timKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timKiem.ForeColor = System.Drawing.Color.White;
            this.btn_timKiem.HoverState.Parent = this.btn_timKiem;
            this.btn_timKiem.Location = new System.Drawing.Point(373, 21);
            this.btn_timKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.ShadowDecoration.Parent = this.btn_timKiem;
            this.btn_timKiem.Size = new System.Drawing.Size(61, 31);
            this.btn_timKiem.TabIndex = 0;
            this.btn_timKiem.Text = "Tìm";
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // dtp_ngaySinh
            // 
            this.dtp_ngaySinh.CheckedState.Parent = this.dtp_ngaySinh;
            this.dtp_ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaySinh.HoverState.Parent = this.dtp_ngaySinh;
            this.dtp_ngaySinh.Location = new System.Drawing.Point(133, 240);
            this.dtp_ngaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_ngaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_ngaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_ngaySinh.Name = "dtp_ngaySinh";
            this.dtp_ngaySinh.ShadowDecoration.Parent = this.dtp_ngaySinh;
            this.dtp_ngaySinh.Size = new System.Drawing.Size(231, 42);
            this.dtp_ngaySinh.TabIndex = 0;
            this.dtp_ngaySinh.Value = new System.DateTime(2021, 5, 10, 21, 59, 56, 437);
            // 
            // lb_maHD
            // 
            this.lb_maHD.AutoSize = true;
            this.lb_maHD.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maHD.Location = new System.Drawing.Point(15, 480);
            this.lb_maHD.Name = "lb_maHD";
            this.lb_maHD.Size = new System.Drawing.Size(78, 25);
            this.lb_maHD.TabIndex = 38;
            this.lb_maHD.Text = "Mã HD:";
            // 
            // lb_phong
            // 
            this.lb_phong.AutoSize = true;
            this.lb_phong.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phong.Location = new System.Drawing.Point(15, 434);
            this.lb_phong.Name = "lb_phong";
            this.lb_phong.Size = new System.Drawing.Size(72, 25);
            this.lb_phong.TabIndex = 37;
            this.lb_phong.Text = "Phòng:";
            // 
            // lb_hoTenTN
            // 
            this.lb_hoTenTN.AutoSize = true;
            this.lb_hoTenTN.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hoTenTN.Location = new System.Drawing.Point(15, 390);
            this.lb_hoTenTN.Name = "lb_hoTenTN";
            this.lb_hoTenTN.Size = new System.Drawing.Size(111, 25);
            this.lb_hoTenTN.TabIndex = 36;
            this.lb_hoTenTN.Text = "Thân Nhân:";
            // 
            // lb_dienThoai
            // 
            this.lb_dienThoai.AutoSize = true;
            this.lb_dienThoai.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dienThoai.Location = new System.Drawing.Point(15, 347);
            this.lb_dienThoai.Name = "lb_dienThoai";
            this.lb_dienThoai.Size = new System.Drawing.Size(109, 25);
            this.lb_dienThoai.TabIndex = 35;
            this.lb_dienThoai.Text = "Điện Thoại:";
            // 
            // lb_diaChi
            // 
            this.lb_diaChi.AutoSize = true;
            this.lb_diaChi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diaChi.Location = new System.Drawing.Point(15, 298);
            this.lb_diaChi.Name = "lb_diaChi";
            this.lb_diaChi.Size = new System.Drawing.Size(79, 25);
            this.lb_diaChi.TabIndex = 34;
            this.lb_diaChi.Text = "Địa Chỉ:";
            // 
            // lb_ngaySinh
            // 
            this.lb_ngaySinh.AutoSize = true;
            this.lb_ngaySinh.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaySinh.Location = new System.Drawing.Point(15, 246);
            this.lb_ngaySinh.Name = "lb_ngaySinh";
            this.lb_ngaySinh.Size = new System.Drawing.Size(105, 25);
            this.lb_ngaySinh.TabIndex = 33;
            this.lb_ngaySinh.Text = "Ngày Sinh:";
            // 
            // lb_gioiTinh
            // 
            this.lb_gioiTinh.AutoSize = true;
            this.lb_gioiTinh.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gioiTinh.Location = new System.Drawing.Point(15, 201);
            this.lb_gioiTinh.Name = "lb_gioiTinh";
            this.lb_gioiTinh.Size = new System.Drawing.Size(94, 25);
            this.lb_gioiTinh.TabIndex = 32;
            this.lb_gioiTinh.Text = "Giới Tính:";
            // 
            // lb_hoTen
            // 
            this.lb_hoTen.AutoSize = true;
            this.lb_hoTen.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hoTen.Location = new System.Drawing.Point(15, 156);
            this.lb_hoTen.Name = "lb_hoTen";
            this.lb_hoTen.Size = new System.Drawing.Size(76, 25);
            this.lb_hoTen.TabIndex = 31;
            this.lb_hoTen.Text = "Họ Tên:";
            // 
            // lb_CMND
            // 
            this.lb_CMND.AutoSize = true;
            this.lb_CMND.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CMND.Location = new System.Drawing.Point(15, 112);
            this.lb_CMND.Name = "lb_CMND";
            this.lb_CMND.Size = new System.Drawing.Size(76, 25);
            this.lb_CMND.TabIndex = 30;
            this.lb_CMND.Text = "CMND:";
            // 
            // lb_maSV
            // 
            this.lb_maSV.AutoSize = true;
            this.lb_maSV.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maSV.Location = new System.Drawing.Point(15, 70);
            this.lb_maSV.Name = "lb_maSV";
            this.lb_maSV.Size = new System.Drawing.Size(72, 25);
            this.lb_maSV.TabIndex = 29;
            this.lb_maSV.Text = "Mã SV:";
            // 
            // lb_timKiem
            // 
            this.lb_timKiem.AutoSize = true;
            this.lb_timKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timKiem.Location = new System.Drawing.Point(15, 21);
            this.lb_timKiem.Name = "lb_timKiem";
            this.lb_timKiem.Size = new System.Drawing.Size(76, 25);
            this.lb_timKiem.TabIndex = 28;
            this.lb_timKiem.Text = "Tìm SV:";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // frm_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 683);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_SinhVien";
            this.Text = "frm_SinhVien2";
            this.Load += new System.EventHandler(this.frm_SinhVien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinhVien)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_them;
        private Guna.UI2.WinForms.Guna2Button btn_sua;
        private Guna.UI2.WinForms.Guna2Button btn_xoa;
        private Guna.UI2.WinForms.Guna2Button btn_taiLai;
        private Guna.UI2.WinForms.Guna2Button btn_luu;
        private Guna.UI2.WinForms.Guna2Button btn_huy;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txb_maSV;
        private Guna.UI2.WinForms.Guna2TextBox txb_timKiem;
        private Guna.UI2.WinForms.Guna2Button btn_maHD;
        private Guna.UI2.WinForms.Guna2Button btn_chiTietPhong;
        private Guna.UI2.WinForms.Guna2Button btn_chiTietTN;
        private Guna.UI2.WinForms.Guna2Button btn_timKiem;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngaySinh;
        private System.Windows.Forms.Label lb_maHD;
        private System.Windows.Forms.Label lb_phong;
        private System.Windows.Forms.Label lb_hoTenTN;
        private System.Windows.Forms.Label lb_dienThoai;
        private System.Windows.Forms.Label lb_diaChi;
        private System.Windows.Forms.Label lb_ngaySinh;
        private System.Windows.Forms.Label lb_gioiTinh;
        private System.Windows.Forms.Label lb_hoTen;
        private System.Windows.Forms.Label lb_CMND;
        private System.Windows.Forms.Label lb_maSV;
        private System.Windows.Forms.Label lb_timKiem;
        private Guna.UI2.WinForms.Guna2TextBox txb_CMND;
        private Guna.UI2.WinForms.Guna2TextBox txb_maHD;
        private Guna.UI2.WinForms.Guna2TextBox txb_phong;
        private Guna.UI2.WinForms.Guna2TextBox txb_CMNDTN;
        private Guna.UI2.WinForms.Guna2TextBox txb_dienThoai;
        private Guna.UI2.WinForms.Guna2TextBox txb_diaChi;
        private Guna.UI2.WinForms.Guna2TextBox txb_hoTen;
        private Guna.UI2.WinForms.Guna2Button btn_KTKL;
        private Guna.UI2.WinForms.Guna2ComboBox cb_gioiTinh;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button buttonXuatExcel;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_sinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
    }
}