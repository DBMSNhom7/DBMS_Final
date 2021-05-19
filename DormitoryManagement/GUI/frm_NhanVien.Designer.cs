
namespace GUI
{
    partial class frm_NhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cb_toa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txb_maHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_chucVu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_tenChucVu = new System.Windows.Forms.Label();
            this.lb_maHD = new System.Windows.Forms.Label();
            this.lb_tenToa = new System.Windows.Forms.Label();
            this.lb_dienThoai = new System.Windows.Forms.Label();
            this.lb_diaChi = new System.Windows.Forms.Label();
            this.lb_ngaySinh = new System.Windows.Forms.Label();
            this.lb_hoTen = new System.Windows.Forms.Label();
            this.lb_maNV = new System.Windows.Forms.Label();
            this.lb_timKiem = new System.Windows.Forms.Label();
            this.txb_dienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_diaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_hoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_maNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_timKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_maHD = new Guna.UI2.WinForms.Guna2Button();
            this.btn_timKiem = new Guna.UI2.WinForms.Guna2Button();
            this.dtp_ngaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sua = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_taiLai = new Guna.UI2.WinForms.Guna2Button();
            this.btn_luu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_huy = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_nhanVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenToa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // cb_toa
            // 
            this.cb_toa.BackColor = System.Drawing.Color.Transparent;
            this.cb_toa.BorderRadius = 6;
            this.cb_toa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_toa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_toa.FocusedColor = System.Drawing.Color.Empty;
            this.cb_toa.FocusedState.Parent = this.cb_toa;
            this.cb_toa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_toa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_toa.FormattingEnabled = true;
            this.cb_toa.HoverState.Parent = this.cb_toa;
            this.cb_toa.ItemHeight = 30;
            this.cb_toa.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_toa.ItemsAppearance.Parent = this.cb_toa;
            this.cb_toa.Location = new System.Drawing.Point(135, 302);
            this.cb_toa.Margin = new System.Windows.Forms.Padding(4);
            this.cb_toa.Name = "cb_toa";
            this.cb_toa.ShadowDecoration.Parent = this.cb_toa;
            this.cb_toa.Size = new System.Drawing.Size(229, 36);
            this.cb_toa.TabIndex = 58;
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
            this.txb_maHD.Location = new System.Drawing.Point(133, 395);
            this.txb_maHD.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_maHD.Name = "txb_maHD";
            this.txb_maHD.PasswordChar = '\0';
            this.txb_maHD.PlaceholderText = "";
            this.txb_maHD.SelectedText = "";
            this.txb_maHD.ShadowDecoration.Parent = this.txb_maHD;
            this.txb_maHD.Size = new System.Drawing.Size(231, 31);
            this.txb_maHD.TabIndex = 56;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cb_chucVu);
            this.panel3.Controls.Add(this.lb_tenChucVu);
            this.panel3.Controls.Add(this.lb_maHD);
            this.panel3.Controls.Add(this.lb_tenToa);
            this.panel3.Controls.Add(this.lb_dienThoai);
            this.panel3.Controls.Add(this.lb_diaChi);
            this.panel3.Controls.Add(this.lb_ngaySinh);
            this.panel3.Controls.Add(this.lb_hoTen);
            this.panel3.Controls.Add(this.lb_maNV);
            this.panel3.Controls.Add(this.lb_timKiem);
            this.panel3.Controls.Add(this.cb_toa);
            this.panel3.Controls.Add(this.txb_maHD);
            this.panel3.Controls.Add(this.txb_dienThoai);
            this.panel3.Controls.Add(this.txb_diaChi);
            this.panel3.Controls.Add(this.txb_hoTen);
            this.panel3.Controls.Add(this.txb_maNV);
            this.panel3.Controls.Add(this.txb_timKiem);
            this.panel3.Controls.Add(this.btn_maHD);
            this.panel3.Controls.Add(this.btn_timKiem);
            this.panel3.Controls.Add(this.dtp_ngaySinh);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 549);
            this.panel3.TabIndex = 2;
            // 
            // cb_chucVu
            // 
            this.cb_chucVu.BackColor = System.Drawing.Color.Transparent;
            this.cb_chucVu.BorderRadius = 6;
            this.cb_chucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_chucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_chucVu.FocusedColor = System.Drawing.Color.Empty;
            this.cb_chucVu.FocusedState.Parent = this.cb_chucVu;
            this.cb_chucVu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_chucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_chucVu.FormattingEnabled = true;
            this.cb_chucVu.HoverState.Parent = this.cb_chucVu;
            this.cb_chucVu.ItemHeight = 30;
            this.cb_chucVu.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_chucVu.ItemsAppearance.Parent = this.cb_chucVu;
            this.cb_chucVu.Location = new System.Drawing.Point(135, 349);
            this.cb_chucVu.Margin = new System.Windows.Forms.Padding(4);
            this.cb_chucVu.Name = "cb_chucVu";
            this.cb_chucVu.ShadowDecoration.Parent = this.cb_chucVu;
            this.cb_chucVu.Size = new System.Drawing.Size(229, 36);
            this.cb_chucVu.TabIndex = 68;
            // 
            // lb_tenChucVu
            // 
            this.lb_tenChucVu.AutoSize = true;
            this.lb_tenChucVu.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenChucVu.Location = new System.Drawing.Point(15, 355);
            this.lb_tenChucVu.Name = "lb_tenChucVu";
            this.lb_tenChucVu.Size = new System.Drawing.Size(89, 25);
            this.lb_tenChucVu.TabIndex = 67;
            this.lb_tenChucVu.Text = "Chức Vụ:";
            // 
            // lb_maHD
            // 
            this.lb_maHD.AutoSize = true;
            this.lb_maHD.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maHD.Location = new System.Drawing.Point(15, 401);
            this.lb_maHD.Name = "lb_maHD";
            this.lb_maHD.Size = new System.Drawing.Size(78, 25);
            this.lb_maHD.TabIndex = 66;
            this.lb_maHD.Text = "Mã HD:";
            // 
            // lb_tenToa
            // 
            this.lb_tenToa.AutoSize = true;
            this.lb_tenToa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenToa.Location = new System.Drawing.Point(13, 307);
            this.lb_tenToa.Name = "lb_tenToa";
            this.lb_tenToa.Size = new System.Drawing.Size(103, 25);
            this.lb_tenToa.TabIndex = 65;
            this.lb_tenToa.Text = "Thuộc Tòa:";
            // 
            // lb_dienThoai
            // 
            this.lb_dienThoai.AutoSize = true;
            this.lb_dienThoai.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dienThoai.Location = new System.Drawing.Point(15, 261);
            this.lb_dienThoai.Name = "lb_dienThoai";
            this.lb_dienThoai.Size = new System.Drawing.Size(109, 25);
            this.lb_dienThoai.TabIndex = 64;
            this.lb_dienThoai.Text = "Điện Thoại:";
            // 
            // lb_diaChi
            // 
            this.lb_diaChi.AutoSize = true;
            this.lb_diaChi.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diaChi.Location = new System.Drawing.Point(15, 213);
            this.lb_diaChi.Name = "lb_diaChi";
            this.lb_diaChi.Size = new System.Drawing.Size(79, 25);
            this.lb_diaChi.TabIndex = 63;
            this.lb_diaChi.Text = "Địa Chỉ:";
            // 
            // lb_ngaySinh
            // 
            this.lb_ngaySinh.AutoSize = true;
            this.lb_ngaySinh.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaySinh.Location = new System.Drawing.Point(13, 164);
            this.lb_ngaySinh.Name = "lb_ngaySinh";
            this.lb_ngaySinh.Size = new System.Drawing.Size(105, 25);
            this.lb_ngaySinh.TabIndex = 62;
            this.lb_ngaySinh.Text = "Ngày Sinh:";
            // 
            // lb_hoTen
            // 
            this.lb_hoTen.AutoSize = true;
            this.lb_hoTen.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hoTen.Location = new System.Drawing.Point(13, 112);
            this.lb_hoTen.Name = "lb_hoTen";
            this.lb_hoTen.Size = new System.Drawing.Size(76, 25);
            this.lb_hoTen.TabIndex = 61;
            this.lb_hoTen.Text = "Họ Tên:";
            // 
            // lb_maNV
            // 
            this.lb_maNV.AutoSize = true;
            this.lb_maNV.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maNV.Location = new System.Drawing.Point(15, 70);
            this.lb_maNV.Name = "lb_maNV";
            this.lb_maNV.Size = new System.Drawing.Size(77, 25);
            this.lb_maNV.TabIndex = 60;
            this.lb_maNV.Text = "Mã NV:";
            // 
            // lb_timKiem
            // 
            this.lb_timKiem.AutoSize = true;
            this.lb_timKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timKiem.Location = new System.Drawing.Point(15, 21);
            this.lb_timKiem.Name = "lb_timKiem";
            this.lb_timKiem.Size = new System.Drawing.Size(49, 25);
            this.lb_timKiem.TabIndex = 59;
            this.lb_timKiem.Text = "Tìm:";
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
            this.txb_dienThoai.Location = new System.Drawing.Point(133, 259);
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
            this.txb_diaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb_diaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_diaChi.HoverState.Parent = this.txb_diaChi;
            this.txb_diaChi.Location = new System.Drawing.Point(133, 213);
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
            this.txb_hoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb_hoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_hoTen.HoverState.Parent = this.txb_hoTen;
            this.txb_hoTen.Location = new System.Drawing.Point(133, 112);
            this.txb_hoTen.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_hoTen.Name = "txb_hoTen";
            this.txb_hoTen.PasswordChar = '\0';
            this.txb_hoTen.PlaceholderText = "";
            this.txb_hoTen.SelectedText = "";
            this.txb_hoTen.ShadowDecoration.Parent = this.txb_hoTen;
            this.txb_hoTen.Size = new System.Drawing.Size(231, 31);
            this.txb_hoTen.TabIndex = 50;
            // 
            // txb_maNV
            // 
            this.txb_maNV.Animated = true;
            this.txb_maNV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_maNV.BorderRadius = 6;
            this.txb_maNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_maNV.DefaultText = "";
            this.txb_maNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_maNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_maNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_maNV.DisabledState.Parent = this.txb_maNV;
            this.txb_maNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_maNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_maNV.FocusedState.Parent = this.txb_maNV;
            this.txb_maNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_maNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_maNV.HoverState.Parent = this.txb_maNV;
            this.txb_maNV.Location = new System.Drawing.Point(133, 70);
            this.txb_maNV.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_maNV.Name = "txb_maNV";
            this.txb_maNV.PasswordChar = '\0';
            this.txb_maNV.PlaceholderText = "";
            this.txb_maNV.SelectedText = "";
            this.txb_maNV.ShadowDecoration.Parent = this.txb_maNV;
            this.txb_maNV.Size = new System.Drawing.Size(231, 31);
            this.txb_maNV.TabIndex = 49;
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
            this.txb_timKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb_timKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_timKiem.HoverState.Parent = this.txb_timKiem;
            this.txb_timKiem.Location = new System.Drawing.Point(135, 15);
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
            this.btn_maHD.BorderRadius = 6;
            this.btn_maHD.CheckedState.Parent = this.btn_maHD;
            this.btn_maHD.CustomImages.Parent = this.btn_maHD;
            this.btn_maHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_maHD.ForeColor = System.Drawing.Color.White;
            this.btn_maHD.HoverState.Parent = this.btn_maHD;
            this.btn_maHD.Location = new System.Drawing.Point(373, 398);
            this.btn_maHD.Margin = new System.Windows.Forms.Padding(4);
            this.btn_maHD.Name = "btn_maHD";
            this.btn_maHD.ShadowDecoration.Parent = this.btn_maHD;
            this.btn_maHD.Size = new System.Drawing.Size(61, 31);
            this.btn_maHD.TabIndex = 48;
            this.btn_maHD.Text = "...";
            this.btn_maHD.Click += new System.EventHandler(this.btn_maHD_Click);
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.BorderRadius = 6;
            this.btn_timKiem.CheckedState.Parent = this.btn_timKiem;
            this.btn_timKiem.CustomImages.Parent = this.btn_timKiem;
            this.btn_timKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timKiem.ForeColor = System.Drawing.Color.White;
            this.btn_timKiem.HoverState.Parent = this.btn_timKiem;
            this.btn_timKiem.Location = new System.Drawing.Point(373, 15);
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
            this.dtp_ngaySinh.BorderRadius = 6;
            this.dtp_ngaySinh.CheckedState.Parent = this.dtp_ngaySinh;
            this.dtp_ngaySinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaySinh.HoverState.Parent = this.dtp_ngaySinh;
            this.dtp_ngaySinh.Location = new System.Drawing.Point(135, 153);
            this.dtp_ngaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_ngaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_ngaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_ngaySinh.Name = "dtp_ngaySinh";
            this.dtp_ngaySinh.ShadowDecoration.Parent = this.dtp_ngaySinh;
            this.dtp_ngaySinh.Size = new System.Drawing.Size(231, 45);
            this.dtp_ngaySinh.TabIndex = 0;
            this.dtp_ngaySinh.Value = new System.DateTime(2021, 5, 10, 21, 59, 56, 437);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 655);
            this.panel2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_them);
            this.flowLayoutPanel1.Controls.Add(this.btn_sua);
            this.flowLayoutPanel1.Controls.Add(this.btn_xoa);
            this.flowLayoutPanel1.Controls.Add(this.btn_taiLai);
            this.flowLayoutPanel1.Controls.Add(this.btn_luu);
            this.flowLayoutPanel1.Controls.Add(this.btn_huy);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 549);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(439, 106);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_them
            // 
            this.btn_them.BorderRadius = 6;
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
            this.btn_sua.BorderRadius = 6;
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
            this.btn_xoa.BorderRadius = 6;
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
            this.btn_taiLai.BorderRadius = 6;
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
            // btn_luu
            // 
            this.btn_luu.BorderRadius = 6;
            this.btn_luu.CheckedState.Parent = this.btn_luu;
            this.btn_luu.CustomImages.Parent = this.btn_luu;
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.HoverState.Parent = this.btn_luu;
            this.btn_luu.Location = new System.Drawing.Point(121, 55);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.ShadowDecoration.Parent = this.btn_luu;
            this.btn_luu.Size = new System.Drawing.Size(109, 43);
            this.btn_luu.TabIndex = 6;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.BorderRadius = 6;
            this.btn_huy.CheckedState.Parent = this.btn_huy;
            this.btn_huy.CustomImages.Parent = this.btn_huy;
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.HoverState.Parent = this.btn_huy;
            this.btn_huy.Location = new System.Drawing.Point(238, 55);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.ShadowDecoration.Parent = this.btn_huy;
            this.btn_huy.Size = new System.Drawing.Size(109, 43);
            this.btn_huy.TabIndex = 7;
            this.btn_huy.Text = "Huỷ";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonXuatExcel);
            this.panel1.Controls.Add(this.dgv_nhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(451, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 655);
            this.panel1.TabIndex = 2;
            // 
            // buttonXuatExcel
            // 
            this.buttonXuatExcel.BorderColor = System.Drawing.Color.Gray;
            this.buttonXuatExcel.BorderRadius = 6;
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
            this.buttonXuatExcel.Location = new System.Drawing.Point(0, 597);
            this.buttonXuatExcel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXuatExcel.Name = "buttonXuatExcel";
            this.buttonXuatExcel.ShadowDecoration.Parent = this.buttonXuatExcel;
            this.buttonXuatExcel.Size = new System.Drawing.Size(865, 58);
            this.buttonXuatExcel.TabIndex = 9;
            this.buttonXuatExcel.Text = "Xuất EXCEL";
            this.buttonXuatExcel.Click += new System.EventHandler(this.buttonXuatExcel_Click);
            // 
            // dgv_nhanVien
            // 
            this.dgv_nhanVien.AllowUserToAddRows = false;
            this.dgv_nhanVien.AllowUserToResizeColumns = false;
            this.dgv_nhanVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgv_nhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_nhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_nhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_nhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_nhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_nhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_nhanVien.ColumnHeadersHeight = 40;
            this.dgv_nhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTen,
            this.NgaySinh,
            this.TenToa,
            this.TenChucVu});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_nhanVien.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_nhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_nhanVien.EnableHeadersVisualStyles = false;
            this.dgv_nhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_nhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgv_nhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_nhanVien.Name = "dgv_nhanVien";
            this.dgv_nhanVien.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_nhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_nhanVien.RowHeadersVisible = false;
            this.dgv_nhanVien.RowHeadersWidth = 51;
            this.dgv_nhanVien.RowTemplate.DividerHeight = 5;
            this.dgv_nhanVien.RowTemplate.Height = 40;
            this.dgv_nhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nhanVien.Size = new System.Drawing.Size(865, 655);
            this.dgv_nhanVien.TabIndex = 5;
            this.dgv_nhanVien.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_nhanVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_nhanVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_nhanVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_nhanVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_nhanVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_nhanVien.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_nhanVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_nhanVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_nhanVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_nhanVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgv_nhanVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgv_nhanVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_nhanVien.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_nhanVien.ThemeStyle.ReadOnly = true;
            this.dgv_nhanVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_nhanVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_nhanVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_nhanVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_nhanVien.ThemeStyle.RowsStyle.Height = 40;
            this.dgv_nhanVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgv_nhanVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_nhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhanVien_CellClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.FillWeight = 84.83527F;
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
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
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.FillWeight = 87.33154F;
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // TenToa
            // 
            this.TenToa.DataPropertyName = "TenToa";
            this.TenToa.FillWeight = 103.7915F;
            this.TenToa.HeaderText = "Thuộc Toà";
            this.TenToa.MinimumWidth = 6;
            this.TenToa.Name = "TenToa";
            this.TenToa.ReadOnly = true;
            // 
            // TenChucVu
            // 
            this.TenChucVu.DataPropertyName = "TenChucVu";
            this.TenChucVu.FillWeight = 70.93935F;
            this.TenChucVu.HeaderText = "Chức Vụ";
            this.TenChucVu.MinimumWidth = 6;
            this.TenChucVu.Name = "TenChucVu";
            this.TenChucVu.ReadOnly = true;
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_NhanVien";
            this.Text = "frm_NhanVien2";
            this.Load += new System.EventHandler(this.frm_NhanVien2_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox cb_toa;
        private Guna.UI2.WinForms.Guna2TextBox txb_maHD;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txb_dienThoai;
        private Guna.UI2.WinForms.Guna2TextBox txb_diaChi;
        private Guna.UI2.WinForms.Guna2TextBox txb_hoTen;
        private Guna.UI2.WinForms.Guna2TextBox txb_maNV;
        private Guna.UI2.WinForms.Guna2TextBox txb_timKiem;
        private Guna.UI2.WinForms.Guna2Button btn_maHD;
        private Guna.UI2.WinForms.Guna2Button btn_timKiem;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngaySinh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btn_them;
        private Guna.UI2.WinForms.Guna2Button btn_sua;
        private Guna.UI2.WinForms.Guna2Button btn_xoa;
        private Guna.UI2.WinForms.Guna2Button btn_taiLai;
        private Guna.UI2.WinForms.Guna2Button btn_huy;
        private Guna.UI2.WinForms.Guna2Button btn_luu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_tenChucVu;
        private System.Windows.Forms.Label lb_maHD;
        private System.Windows.Forms.Label lb_tenToa;
        private System.Windows.Forms.Label lb_dienThoai;
        private System.Windows.Forms.Label lb_diaChi;
        private System.Windows.Forms.Label lb_ngaySinh;
        private System.Windows.Forms.Label lb_hoTen;
        private System.Windows.Forms.Label lb_maNV;
        private System.Windows.Forms.Label lb_timKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cb_chucVu;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_nhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenToa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChucVu;
        private Guna.UI2.WinForms.Guna2Button buttonXuatExcel;
    }
}