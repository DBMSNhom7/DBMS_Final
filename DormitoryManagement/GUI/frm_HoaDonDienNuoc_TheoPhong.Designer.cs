
namespace GUI
{
    partial class frm_HoaDonDienNuoc_TheoPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_huy = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_hoaDonDienNuoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_trangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_trangThai = new System.Windows.Forms.Label();
            this.lb_thanhTien = new System.Windows.Forms.Label();
            this.lb_ngayLap = new System.Windows.Forms.Label();
            this.lb_soNuoc = new System.Windows.Forms.Label();
            this.lb_maHoaDon = new System.Windows.Forms.Label();
            this.txb_maHoaDon = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_luu = new Guna.UI2.WinForms.Guna2Button();
            this.txb_thanhTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_soNuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sua = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_soDien = new System.Windows.Forms.Label();
            this.txb_soDien = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtp_ngayLap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.buttonXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoaDonDienNuoc)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_huy
            // 
            this.btn_huy.CheckedState.Parent = this.btn_huy;
            this.btn_huy.CustomImages.Parent = this.btn_huy;
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.HoverState.Parent = this.btn_huy;
            this.btn_huy.Location = new System.Drawing.Point(120, 336);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.ShadowDecoration.Parent = this.btn_huy;
            this.btn_huy.Size = new System.Drawing.Size(82, 35);
            this.btn_huy.TabIndex = 7;
            this.btn_huy.Text = "Huỷ";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonXuatExcel);
            this.panel1.Controls.Add(this.dgv_hoaDonDienNuoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(365, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 399);
            this.panel1.TabIndex = 4;
            // 
            // dgv_hoaDonDienNuoc
            // 
            this.dgv_hoaDonDienNuoc.AllowUserToAddRows = false;
            this.dgv_hoaDonDienNuoc.AllowUserToResizeColumns = false;
            this.dgv_hoaDonDienNuoc.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgv_hoaDonDienNuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_hoaDonDienNuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hoaDonDienNuoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_hoaDonDienNuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_hoaDonDienNuoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_hoaDonDienNuoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hoaDonDienNuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_hoaDonDienNuoc.ColumnHeadersHeight = 40;
            this.dgv_hoaDonDienNuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.ThanhTien,
            this.NgayLap,
            this.TrangThai});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_hoaDonDienNuoc.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_hoaDonDienNuoc.EnableHeadersVisualStyles = false;
            this.dgv_hoaDonDienNuoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_hoaDonDienNuoc.Location = new System.Drawing.Point(3, 3);
            this.dgv_hoaDonDienNuoc.Name = "dgv_hoaDonDienNuoc";
            this.dgv_hoaDonDienNuoc.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hoaDonDienNuoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_hoaDonDienNuoc.RowHeadersVisible = false;
            this.dgv_hoaDonDienNuoc.RowTemplate.DividerHeight = 5;
            this.dgv_hoaDonDienNuoc.RowTemplate.Height = 40;
            this.dgv_hoaDonDienNuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hoaDonDienNuoc.Size = new System.Drawing.Size(637, 396);
            this.dgv_hoaDonDienNuoc.TabIndex = 5;
            this.dgv_hoaDonDienNuoc.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_hoaDonDienNuoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_hoaDonDienNuoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_hoaDonDienNuoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_hoaDonDienNuoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_hoaDonDienNuoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_hoaDonDienNuoc.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_hoaDonDienNuoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_hoaDonDienNuoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_hoaDonDienNuoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_hoaDonDienNuoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgv_hoaDonDienNuoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgv_hoaDonDienNuoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_hoaDonDienNuoc.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_hoaDonDienNuoc.ThemeStyle.ReadOnly = true;
            this.dgv_hoaDonDienNuoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_hoaDonDienNuoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_hoaDonDienNuoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_hoaDonDienNuoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_hoaDonDienNuoc.ThemeStyle.RowsStyle.Height = 40;
            this.dgv_hoaDonDienNuoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgv_hoaDonDienNuoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_hoaDonDienNuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoaDonDienNuoc_CellClick_1);
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "MaHoaDon";
            this.MaHoaDon.FillWeight = 84.83527F;
            this.MaHoaDon.HeaderText = "Mã Hoá Đơn";
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.FillWeight = 169.5384F;
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.FillWeight = 57.04103F;
            this.NgayLap.HeaderText = "Ngày Lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.FillWeight = 87.33154F;
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // cb_trangThai
            // 
            this.cb_trangThai.BackColor = System.Drawing.Color.Transparent;
            this.cb_trangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_trangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_trangThai.FocusedColor = System.Drawing.Color.Empty;
            this.cb_trangThai.FocusedState.Parent = this.cb_trangThai;
            this.cb_trangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_trangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_trangThai.FormattingEnabled = true;
            this.cb_trangThai.HoverState.Parent = this.cb_trangThai;
            this.cb_trangThai.ItemHeight = 30;
            this.cb_trangThai.Items.AddRange(new object[] {
            "Chưa Thanh Toán",
            "Đã Thanh Toán"});
            this.cb_trangThai.ItemsAppearance.Parent = this.cb_trangThai;
            this.cb_trangThai.Location = new System.Drawing.Point(117, 209);
            this.cb_trangThai.Name = "cb_trangThai";
            this.cb_trangThai.ShadowDecoration.Parent = this.cb_trangThai;
            this.cb_trangThai.Size = new System.Drawing.Size(174, 36);
            this.cb_trangThai.TabIndex = 67;
            // 
            // lb_trangThai
            // 
            this.lb_trangThai.AutoSize = true;
            this.lb_trangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trangThai.Location = new System.Drawing.Point(8, 221);
            this.lb_trangThai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_trangThai.Name = "lb_trangThai";
            this.lb_trangThai.Size = new System.Drawing.Size(85, 20);
            this.lb_trangThai.TabIndex = 66;
            this.lb_trangThai.Text = "Trạng Thái:";
            // 
            // lb_thanhTien
            // 
            this.lb_thanhTien.AutoSize = true;
            this.lb_thanhTien.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thanhTien.Location = new System.Drawing.Point(8, 137);
            this.lb_thanhTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_thanhTien.Name = "lb_thanhTien";
            this.lb_thanhTien.Size = new System.Drawing.Size(89, 20);
            this.lb_thanhTien.TabIndex = 65;
            this.lb_thanhTien.Text = "Thành Tiền:";
            // 
            // lb_ngayLap
            // 
            this.lb_ngayLap.AutoSize = true;
            this.lb_ngayLap.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngayLap.Location = new System.Drawing.Point(9, 171);
            this.lb_ngayLap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ngayLap.Name = "lb_ngayLap";
            this.lb_ngayLap.Size = new System.Drawing.Size(78, 20);
            this.lb_ngayLap.TabIndex = 64;
            this.lb_ngayLap.Text = "Ngày Lập:";
            // 
            // lb_soNuoc
            // 
            this.lb_soNuoc.AutoSize = true;
            this.lb_soNuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_soNuoc.Location = new System.Drawing.Point(9, 102);
            this.lb_soNuoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_soNuoc.Name = "lb_soNuoc";
            this.lb_soNuoc.Size = new System.Drawing.Size(71, 20);
            this.lb_soNuoc.TabIndex = 63;
            this.lb_soNuoc.Text = "Số Nước:";
            // 
            // lb_maHoaDon
            // 
            this.lb_maHoaDon.AutoSize = true;
            this.lb_maHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maHoaDon.Location = new System.Drawing.Point(8, 24);
            this.lb_maHoaDon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_maHoaDon.Name = "lb_maHoaDon";
            this.lb_maHoaDon.Size = new System.Drawing.Size(100, 20);
            this.lb_maHoaDon.TabIndex = 61;
            this.lb_maHoaDon.Text = "Mã Hoá Đơn:";
            // 
            // txb_maHoaDon
            // 
            this.txb_maHoaDon.Animated = true;
            this.txb_maHoaDon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_maHoaDon.BorderRadius = 6;
            this.txb_maHoaDon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_maHoaDon.DefaultText = "";
            this.txb_maHoaDon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_maHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_maHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_maHoaDon.DisabledState.Parent = this.txb_maHoaDon;
            this.txb_maHoaDon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_maHoaDon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_maHoaDon.FocusedState.Parent = this.txb_maHoaDon;
            this.txb_maHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_maHoaDon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_maHoaDon.HoverState.Parent = this.txb_maHoaDon;
            this.txb_maHoaDon.Location = new System.Drawing.Point(117, 24);
            this.txb_maHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_maHoaDon.Name = "txb_maHoaDon";
            this.txb_maHoaDon.PasswordChar = '\0';
            this.txb_maHoaDon.PlaceholderText = "";
            this.txb_maHoaDon.SelectedText = "";
            this.txb_maHoaDon.ShadowDecoration.Parent = this.txb_maHoaDon;
            this.txb_maHoaDon.Size = new System.Drawing.Size(173, 25);
            this.txb_maHoaDon.TabIndex = 52;
            // 
            // btn_luu
            // 
            this.btn_luu.CheckedState.Parent = this.btn_luu;
            this.btn_luu.CustomImages.Parent = this.btn_luu;
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.HoverState.Parent = this.btn_luu;
            this.btn_luu.Location = new System.Drawing.Point(208, 336);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.ShadowDecoration.Parent = this.btn_luu;
            this.btn_luu.Size = new System.Drawing.Size(82, 35);
            this.btn_luu.TabIndex = 6;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txb_thanhTien
            // 
            this.txb_thanhTien.Animated = true;
            this.txb_thanhTien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_thanhTien.BorderRadius = 6;
            this.txb_thanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_thanhTien.DefaultText = "";
            this.txb_thanhTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_thanhTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_thanhTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_thanhTien.DisabledState.Parent = this.txb_thanhTien;
            this.txb_thanhTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_thanhTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_thanhTien.FocusedState.Parent = this.txb_thanhTien;
            this.txb_thanhTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_thanhTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_thanhTien.HoverState.Parent = this.txb_thanhTien;
            this.txb_thanhTien.Location = new System.Drawing.Point(117, 130);
            this.txb_thanhTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_thanhTien.Name = "txb_thanhTien";
            this.txb_thanhTien.PasswordChar = '\0';
            this.txb_thanhTien.PlaceholderText = "";
            this.txb_thanhTien.SelectedText = "";
            this.txb_thanhTien.ShadowDecoration.Parent = this.txb_thanhTien;
            this.txb_thanhTien.Size = new System.Drawing.Size(173, 25);
            this.txb_thanhTien.TabIndex = 55;
            // 
            // txb_soNuoc
            // 
            this.txb_soNuoc.Animated = true;
            this.txb_soNuoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_soNuoc.BorderRadius = 6;
            this.txb_soNuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_soNuoc.DefaultText = "";
            this.txb_soNuoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_soNuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_soNuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_soNuoc.DisabledState.Parent = this.txb_soNuoc;
            this.txb_soNuoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_soNuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_soNuoc.FocusedState.Parent = this.txb_soNuoc;
            this.txb_soNuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_soNuoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_soNuoc.HoverState.Parent = this.txb_soNuoc;
            this.txb_soNuoc.Location = new System.Drawing.Point(117, 95);
            this.txb_soNuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_soNuoc.Name = "txb_soNuoc";
            this.txb_soNuoc.PasswordChar = '\0';
            this.txb_soNuoc.PlaceholderText = "";
            this.txb_soNuoc.SelectedText = "";
            this.txb_soNuoc.ShadowDecoration.Parent = this.txb_soNuoc;
            this.txb_soNuoc.Size = new System.Drawing.Size(173, 25);
            this.txb_soNuoc.TabIndex = 54;
            // 
            // btn_them
            // 
            this.btn_them.CheckedState.Parent = this.btn_them;
            this.btn_them.CustomImages.Parent = this.btn_them;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.HoverState.Parent = this.btn_them;
            this.btn_them.Location = new System.Drawing.Point(32, 295);
            this.btn_them.Name = "btn_them";
            this.btn_them.ShadowDecoration.Parent = this.btn_them;
            this.btn_them.Size = new System.Drawing.Size(82, 35);
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
            this.btn_sua.Location = new System.Drawing.Point(120, 295);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.ShadowDecoration.Parent = this.btn_sua;
            this.btn_sua.Size = new System.Drawing.Size(82, 35);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa ";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_luu);
            this.panel2.Controls.Add(this.btn_huy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 399);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cb_trangThai);
            this.panel3.Controls.Add(this.lb_trangThai);
            this.panel3.Controls.Add(this.lb_thanhTien);
            this.panel3.Controls.Add(this.lb_ngayLap);
            this.panel3.Controls.Add(this.lb_soNuoc);
            this.panel3.Controls.Add(this.lb_soDien);
            this.panel3.Controls.Add(this.lb_maHoaDon);
            this.panel3.Controls.Add(this.txb_thanhTien);
            this.panel3.Controls.Add(this.txb_soNuoc);
            this.panel3.Controls.Add(this.txb_soDien);
            this.panel3.Controls.Add(this.txb_maHoaDon);
            this.panel3.Controls.Add(this.dtp_ngayLap);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 276);
            this.panel3.TabIndex = 2;
            // 
            // lb_soDien
            // 
            this.lb_soDien.AutoSize = true;
            this.lb_soDien.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_soDien.Location = new System.Drawing.Point(8, 63);
            this.lb_soDien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_soDien.Name = "lb_soDien";
            this.lb_soDien.Size = new System.Drawing.Size(66, 20);
            this.lb_soDien.TabIndex = 62;
            this.lb_soDien.Text = "Số Điện:";
            // 
            // txb_soDien
            // 
            this.txb_soDien.Animated = true;
            this.txb_soDien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_soDien.BorderRadius = 6;
            this.txb_soDien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_soDien.DefaultText = "";
            this.txb_soDien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_soDien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_soDien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_soDien.DisabledState.Parent = this.txb_soDien;
            this.txb_soDien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_soDien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_soDien.FocusedState.Parent = this.txb_soDien;
            this.txb_soDien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_soDien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_soDien.HoverState.Parent = this.txb_soDien;
            this.txb_soDien.Location = new System.Drawing.Point(117, 56);
            this.txb_soDien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_soDien.Name = "txb_soDien";
            this.txb_soDien.PasswordChar = '\0';
            this.txb_soDien.PlaceholderText = "";
            this.txb_soDien.SelectedText = "";
            this.txb_soDien.ShadowDecoration.Parent = this.txb_soDien;
            this.txb_soDien.Size = new System.Drawing.Size(173, 25);
            this.txb_soDien.TabIndex = 53;
            // 
            // dtp_ngayLap
            // 
            this.dtp_ngayLap.CheckedState.Parent = this.dtp_ngayLap;
            this.dtp_ngayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayLap.HoverState.Parent = this.dtp_ngayLap;
            this.dtp_ngayLap.Location = new System.Drawing.Point(117, 171);
            this.dtp_ngayLap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_ngayLap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_ngayLap.Name = "dtp_ngayLap";
            this.dtp_ngayLap.ShadowDecoration.Parent = this.dtp_ngayLap;
            this.dtp_ngayLap.Size = new System.Drawing.Size(173, 32);
            this.dtp_ngayLap.TabIndex = 0;
            this.dtp_ngayLap.Value = new System.DateTime(2021, 5, 10, 21, 59, 56, 437);
            // 
            // btn_xoa
            // 
            this.btn_xoa.CheckedState.Parent = this.btn_xoa;
            this.btn_xoa.CustomImages.Parent = this.btn_xoa;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.HoverState.Parent = this.btn_xoa;
            this.btn_xoa.Location = new System.Drawing.Point(208, 295);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.ShadowDecoration.Parent = this.btn_xoa;
            this.btn_xoa.Size = new System.Drawing.Size(82, 35);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // buttonXuatExcel
            // 
            this.buttonXuatExcel.BackColor = System.Drawing.SystemColors.Control;
            this.buttonXuatExcel.BorderColor = System.Drawing.Color.Gray;
            this.buttonXuatExcel.BorderThickness = 1;
            this.buttonXuatExcel.CheckedState.Parent = this.buttonXuatExcel;
            this.buttonXuatExcel.CustomImages.Parent = this.buttonXuatExcel;
            this.buttonXuatExcel.FillColor = System.Drawing.Color.Transparent;
            this.buttonXuatExcel.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Bold);
            this.buttonXuatExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonXuatExcel.HoverState.Parent = this.buttonXuatExcel;
            this.buttonXuatExcel.Image = global::GUI.Properties.Resources.icons8_xls_export_160px;
            this.buttonXuatExcel.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonXuatExcel.Location = new System.Drawing.Point(538, 340);
            this.buttonXuatExcel.Name = "buttonXuatExcel";
            this.buttonXuatExcel.ShadowDecoration.Parent = this.buttonXuatExcel;
            this.buttonXuatExcel.Size = new System.Drawing.Size(99, 47);
            this.buttonXuatExcel.TabIndex = 11;
            this.buttonXuatExcel.Text = "Xuất EXCEL";
            this.buttonXuatExcel.Click += new System.EventHandler(this.buttonXuatExcel_Click);
            // 
            // frm_HoaDonDienNuoc_TheoPhong2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1014, 399);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_HoaDonDienNuoc_TheoPhong2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_HoaDonDienNuoc_TheoPhong2";
            this.Load += new System.EventHandler(this.frm_HoaDonDienNuoc_TheoPhong2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoaDonDienNuoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_huy;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cb_trangThai;
        private System.Windows.Forms.Label lb_trangThai;
        private System.Windows.Forms.Label lb_thanhTien;
        private System.Windows.Forms.Label lb_ngayLap;
        private System.Windows.Forms.Label lb_soNuoc;
        private System.Windows.Forms.Label lb_maHoaDon;
        private Guna.UI2.WinForms.Guna2TextBox txb_maHoaDon;
        private Guna.UI2.WinForms.Guna2Button btn_luu;
        private Guna.UI2.WinForms.Guna2TextBox txb_thanhTien;
        private Guna.UI2.WinForms.Guna2TextBox txb_soNuoc;
        private Guna.UI2.WinForms.Guna2Button btn_them;
        private Guna.UI2.WinForms.Guna2Button btn_sua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngayLap;
        private Guna.UI2.WinForms.Guna2Button btn_xoa;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lb_soDien;
        private Guna.UI2.WinForms.Guna2TextBox txb_soDien;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_hoaDonDienNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private Guna.UI2.WinForms.Guna2Button buttonXuatExcel;
    }
}