
namespace GUI
{
    partial class frm_Phong
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cb_loaiPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_SVDangO = new Guna.UI2.WinForms.Guna2Button();
            this.txb_SVDangO = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_HoaDonDienNuoc = new Guna.UI2.WinForms.Guna2Button();
            this.lb_SVDangO = new System.Windows.Forms.Label();
            this.lb_sucChua = new System.Windows.Forms.Label();
            this.lb_loaiPhong = new System.Windows.Forms.Label();
            this.lb_tenToa = new System.Windows.Forms.Label();
            this.lb_maPhong = new System.Windows.Forms.Label();
            this.lb_timKiem = new System.Windows.Forms.Label();
            this.txb_sucChua = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_phong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_toa = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_timKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_timKiem = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_taiLai = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sua = new Guna.UI2.WinForms.Guna2Button();
            this.btn_huy = new Guna.UI2.WinForms.Guna2Button();
            this.btn_luu = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_phong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SucChuaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLDangO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenToa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // cb_loaiPhong
            // 
            this.cb_loaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.cb_loaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_loaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_loaiPhong.FocusedColor = System.Drawing.Color.Empty;
            this.cb_loaiPhong.FocusedState.Parent = this.cb_loaiPhong;
            this.cb_loaiPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_loaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_loaiPhong.FormattingEnabled = true;
            this.cb_loaiPhong.HoverState.Parent = this.cb_loaiPhong;
            this.cb_loaiPhong.ItemHeight = 30;
            this.cb_loaiPhong.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_loaiPhong.ItemsAppearance.Parent = this.cb_loaiPhong;
            this.cb_loaiPhong.Location = new System.Drawing.Point(133, 217);
            this.cb_loaiPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_loaiPhong.Name = "cb_loaiPhong";
            this.cb_loaiPhong.ShadowDecoration.Parent = this.cb_loaiPhong;
            this.cb_loaiPhong.Size = new System.Drawing.Size(229, 36);
            this.cb_loaiPhong.TabIndex = 58;
            // 
            // btn_SVDangO
            // 
            this.btn_SVDangO.CheckedState.Parent = this.btn_SVDangO;
            this.btn_SVDangO.CustomImages.Parent = this.btn_SVDangO;
            this.btn_SVDangO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SVDangO.ForeColor = System.Drawing.Color.White;
            this.btn_SVDangO.HoverState.Parent = this.btn_SVDangO;
            this.btn_SVDangO.Location = new System.Drawing.Point(16, 420);
            this.btn_SVDangO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SVDangO.Name = "btn_SVDangO";
            this.btn_SVDangO.ShadowDecoration.Parent = this.btn_SVDangO;
            this.btn_SVDangO.Size = new System.Drawing.Size(189, 34);
            this.btn_SVDangO.TabIndex = 57;
            this.btn_SVDangO.Text = "Sinh Viên Đang Ở";
            this.btn_SVDangO.Click += new System.EventHandler(this.btn_SVDangO_Click);
            // 
            // txb_SVDangO
            // 
            this.txb_SVDangO.Animated = true;
            this.txb_SVDangO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_SVDangO.BorderRadius = 6;
            this.txb_SVDangO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_SVDangO.DefaultText = "";
            this.txb_SVDangO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_SVDangO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_SVDangO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_SVDangO.DisabledState.Parent = this.txb_SVDangO;
            this.txb_SVDangO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_SVDangO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_SVDangO.FocusedState.Parent = this.txb_SVDangO;
            this.txb_SVDangO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_SVDangO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_SVDangO.HoverState.Parent = this.txb_SVDangO;
            this.txb_SVDangO.Location = new System.Drawing.Point(133, 366);
            this.txb_SVDangO.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_SVDangO.Name = "txb_SVDangO";
            this.txb_SVDangO.PasswordChar = '\0';
            this.txb_SVDangO.PlaceholderText = "";
            this.txb_SVDangO.SelectedText = "";
            this.txb_SVDangO.ShadowDecoration.Parent = this.txb_SVDangO;
            this.txb_SVDangO.Size = new System.Drawing.Size(231, 31);
            this.txb_SVDangO.TabIndex = 54;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_HoaDonDienNuoc);
            this.panel3.Controls.Add(this.lb_SVDangO);
            this.panel3.Controls.Add(this.lb_sucChua);
            this.panel3.Controls.Add(this.lb_loaiPhong);
            this.panel3.Controls.Add(this.lb_tenToa);
            this.panel3.Controls.Add(this.lb_maPhong);
            this.panel3.Controls.Add(this.lb_timKiem);
            this.panel3.Controls.Add(this.cb_loaiPhong);
            this.panel3.Controls.Add(this.btn_SVDangO);
            this.panel3.Controls.Add(this.txb_SVDangO);
            this.panel3.Controls.Add(this.txb_sucChua);
            this.panel3.Controls.Add(this.txb_phong);
            this.panel3.Controls.Add(this.txb_toa);
            this.panel3.Controls.Add(this.txb_timKiem);
            this.panel3.Controls.Add(this.btn_timKiem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 543);
            this.panel3.TabIndex = 2;
            // 
            // btn_HoaDonDienNuoc
            // 
            this.btn_HoaDonDienNuoc.CheckedState.Parent = this.btn_HoaDonDienNuoc;
            this.btn_HoaDonDienNuoc.CustomImages.Parent = this.btn_HoaDonDienNuoc;
            this.btn_HoaDonDienNuoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoaDonDienNuoc.ForeColor = System.Drawing.Color.White;
            this.btn_HoaDonDienNuoc.HoverState.Parent = this.btn_HoaDonDienNuoc;
            this.btn_HoaDonDienNuoc.Location = new System.Drawing.Point(239, 420);
            this.btn_HoaDonDienNuoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_HoaDonDienNuoc.Name = "btn_HoaDonDienNuoc";
            this.btn_HoaDonDienNuoc.ShadowDecoration.Parent = this.btn_HoaDonDienNuoc;
            this.btn_HoaDonDienNuoc.Size = new System.Drawing.Size(189, 34);
            this.btn_HoaDonDienNuoc.TabIndex = 65;
            this.btn_HoaDonDienNuoc.Text = "Hoá Đơn Điện Nước";
            this.btn_HoaDonDienNuoc.Click += new System.EventHandler(this.btn_HoaDonDienNuoc_Click);
            // 
            // lb_SVDangO
            // 
            this.lb_SVDangO.AutoSize = true;
            this.lb_SVDangO.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SVDangO.Location = new System.Drawing.Point(15, 372);
            this.lb_SVDangO.Name = "lb_SVDangO";
            this.lb_SVDangO.Size = new System.Drawing.Size(110, 25);
            this.lb_SVDangO.TabIndex = 64;
            this.lb_SVDangO.Text = "SV Đang Ở:";
            // 
            // lb_sucChua
            // 
            this.lb_sucChua.AutoSize = true;
            this.lb_sucChua.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sucChua.Location = new System.Drawing.Point(15, 299);
            this.lb_sucChua.Name = "lb_sucChua";
            this.lb_sucChua.Size = new System.Drawing.Size(98, 25);
            this.lb_sucChua.TabIndex = 63;
            this.lb_sucChua.Text = "Sức Chứa:";
            // 
            // lb_loaiPhong
            // 
            this.lb_loaiPhong.AutoSize = true;
            this.lb_loaiPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loaiPhong.Location = new System.Drawing.Point(15, 226);
            this.lb_loaiPhong.Name = "lb_loaiPhong";
            this.lb_loaiPhong.Size = new System.Drawing.Size(112, 25);
            this.lb_loaiPhong.TabIndex = 62;
            this.lb_loaiPhong.Text = "Loại Phòng:";
            // 
            // lb_tenToa
            // 
            this.lb_tenToa.AutoSize = true;
            this.lb_tenToa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenToa.Location = new System.Drawing.Point(15, 92);
            this.lb_tenToa.Name = "lb_tenToa";
            this.lb_tenToa.Size = new System.Drawing.Size(80, 25);
            this.lb_tenToa.TabIndex = 61;
            this.lb_tenToa.Text = "Tên Tòa:";
            // 
            // lb_maPhong
            // 
            this.lb_maPhong.AutoSize = true;
            this.lb_maPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maPhong.Location = new System.Drawing.Point(15, 156);
            this.lb_maPhong.Name = "lb_maPhong";
            this.lb_maPhong.Size = new System.Drawing.Size(105, 25);
            this.lb_maPhong.TabIndex = 60;
            this.lb_maPhong.Text = "Mã Phòng:";
            // 
            // lb_timKiem
            // 
            this.lb_timKiem.AutoSize = true;
            this.lb_timKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timKiem.Location = new System.Drawing.Point(15, 30);
            this.lb_timKiem.Name = "lb_timKiem";
            this.lb_timKiem.Size = new System.Drawing.Size(49, 25);
            this.lb_timKiem.TabIndex = 59;
            this.lb_timKiem.Text = "Tìm:";
            // 
            // txb_sucChua
            // 
            this.txb_sucChua.Animated = true;
            this.txb_sucChua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_sucChua.BorderRadius = 6;
            this.txb_sucChua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_sucChua.DefaultText = "";
            this.txb_sucChua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_sucChua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_sucChua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_sucChua.DisabledState.Parent = this.txb_sucChua;
            this.txb_sucChua.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_sucChua.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_sucChua.FocusedState.Parent = this.txb_sucChua;
            this.txb_sucChua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_sucChua.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_sucChua.HoverState.Parent = this.txb_sucChua;
            this.txb_sucChua.Location = new System.Drawing.Point(133, 293);
            this.txb_sucChua.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_sucChua.Name = "txb_sucChua";
            this.txb_sucChua.PasswordChar = '\0';
            this.txb_sucChua.PlaceholderText = "";
            this.txb_sucChua.SelectedText = "";
            this.txb_sucChua.ShadowDecoration.Parent = this.txb_sucChua;
            this.txb_sucChua.Size = new System.Drawing.Size(231, 31);
            this.txb_sucChua.TabIndex = 53;
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
            this.txb_phong.Location = new System.Drawing.Point(133, 156);
            this.txb_phong.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_phong.Name = "txb_phong";
            this.txb_phong.PasswordChar = '\0';
            this.txb_phong.PlaceholderText = "";
            this.txb_phong.SelectedText = "";
            this.txb_phong.ShadowDecoration.Parent = this.txb_phong;
            this.txb_phong.Size = new System.Drawing.Size(231, 31);
            this.txb_phong.TabIndex = 50;
            // 
            // txb_toa
            // 
            this.txb_toa.Animated = true;
            this.txb_toa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_toa.BorderRadius = 6;
            this.txb_toa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_toa.DefaultText = "";
            this.txb_toa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_toa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_toa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_toa.DisabledState.Parent = this.txb_toa;
            this.txb_toa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_toa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_toa.FocusedState.Parent = this.txb_toa;
            this.txb_toa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_toa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_toa.HoverState.Parent = this.txb_toa;
            this.txb_toa.Location = new System.Drawing.Point(133, 92);
            this.txb_toa.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_toa.Name = "txb_toa";
            this.txb_toa.PasswordChar = '\0';
            this.txb_toa.PlaceholderText = "";
            this.txb_toa.SelectedText = "";
            this.txb_toa.ShadowDecoration.Parent = this.txb_toa;
            this.txb_toa.Size = new System.Drawing.Size(231, 31);
            this.txb_toa.TabIndex = 49;
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
            // btn_timKiem
            // 
            this.btn_timKiem.CheckedState.Parent = this.btn_timKiem;
            this.btn_timKiem.CustomImages.Parent = this.btn_timKiem;
            this.btn_timKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timKiem.ForeColor = System.Drawing.Color.White;
            this.btn_timKiem.HoverState.Parent = this.btn_timKiem;
            this.btn_timKiem.Location = new System.Drawing.Point(373, 21);
            this.btn_timKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.ShadowDecoration.Parent = this.btn_timKiem;
            this.btn_timKiem.Size = new System.Drawing.Size(61, 31);
            this.btn_timKiem.TabIndex = 0;
            this.btn_timKiem.Text = "Tìm";
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 649);
            this.panel2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_taiLai);
            this.flowLayoutPanel1.Controls.Add(this.btn_sua);
            this.flowLayoutPanel1.Controls.Add(this.btn_luu);
            this.flowLayoutPanel1.Controls.Add(this.btn_huy);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 543);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(439, 106);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_taiLai
            // 
            this.btn_taiLai.CheckedState.Parent = this.btn_taiLai;
            this.btn_taiLai.CustomImages.Parent = this.btn_taiLai;
            this.btn_taiLai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taiLai.ForeColor = System.Drawing.Color.White;
            this.btn_taiLai.HoverState.Parent = this.btn_taiLai;
            this.btn_taiLai.Location = new System.Drawing.Point(4, 4);
            this.btn_taiLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_taiLai.Name = "btn_taiLai";
            this.btn_taiLai.ShadowDecoration.Parent = this.btn_taiLai;
            this.btn_taiLai.Size = new System.Drawing.Size(109, 43);
            this.btn_taiLai.TabIndex = 5;
            this.btn_taiLai.Text = "Tải lại";
            this.btn_taiLai.Click += new System.EventHandler(this.btn_taiLai_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.CheckedState.Parent = this.btn_sua;
            this.btn_sua.CustomImages.Parent = this.btn_sua;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.HoverState.Parent = this.btn_sua;
            this.btn_sua.Location = new System.Drawing.Point(121, 4);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.ShadowDecoration.Parent = this.btn_sua;
            this.btn_sua.Size = new System.Drawing.Size(109, 43);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa ";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.CheckedState.Parent = this.btn_huy;
            this.btn_huy.CustomImages.Parent = this.btn_huy;
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.HoverState.Parent = this.btn_huy;
            this.btn_huy.Location = new System.Drawing.Point(4, 55);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btn_luu.Location = new System.Drawing.Point(238, 4);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.ShadowDecoration.Parent = this.btn_luu;
            this.btn_luu.Size = new System.Drawing.Size(109, 43);
            this.btn_luu.TabIndex = 6;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonXuatExcel);
            this.panel1.Controls.Add(this.dgv_phong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(464, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 649);
            this.panel1.TabIndex = 2;
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
            this.buttonXuatExcel.Location = new System.Drawing.Point(0, 591);
            this.buttonXuatExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonXuatExcel.Name = "buttonXuatExcel";
            this.buttonXuatExcel.ShadowDecoration.Parent = this.buttonXuatExcel;
            this.buttonXuatExcel.Size = new System.Drawing.Size(865, 58);
            this.buttonXuatExcel.TabIndex = 8;
            this.buttonXuatExcel.Text = "Xuất EXCEL";
            this.buttonXuatExcel.Click += new System.EventHandler(this.buttonXuatExcel_Click);
            // 
            // dgv_phong
            // 
            this.dgv_phong.AllowUserToAddRows = false;
            this.dgv_phong.AllowUserToResizeColumns = false;
            this.dgv_phong.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgv_phong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_phong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_phong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_phong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_phong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_phong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_phong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_phong.ColumnHeadersHeight = 40;
            this.dgv_phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.TenLoai,
            this.SucChuaSV,
            this.SLDangO,
            this.TenToa});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_phong.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_phong.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_phong.EnableHeadersVisualStyles = false;
            this.dgv_phong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_phong.Location = new System.Drawing.Point(0, 0);
            this.dgv_phong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_phong.Name = "dgv_phong";
            this.dgv_phong.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_phong.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_phong.RowHeadersVisible = false;
            this.dgv_phong.RowHeadersWidth = 51;
            this.dgv_phong.RowTemplate.DividerHeight = 5;
            this.dgv_phong.RowTemplate.Height = 40;
            this.dgv_phong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_phong.Size = new System.Drawing.Size(865, 662);
            this.dgv_phong.TabIndex = 5;
            this.dgv_phong.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_phong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_phong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_phong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_phong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_phong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_phong.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_phong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_phong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_phong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_phong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgv_phong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgv_phong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_phong.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_phong.ThemeStyle.ReadOnly = true;
            this.dgv_phong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_phong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_phong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_phong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_phong.ThemeStyle.RowsStyle.Height = 40;
            this.dgv_phong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgv_phong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_phong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phong_CellClick_1);
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.FillWeight = 99.7395F;
            this.MaPhong.HeaderText = "Phòng";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            // 
            // TenLoai
            // 
            this.TenLoai.DataPropertyName = "TenLoai";
            this.TenLoai.FillWeight = 119.2769F;
            this.TenLoai.HeaderText = "Loại Phòng";
            this.TenLoai.MinimumWidth = 6;
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.ReadOnly = true;
            // 
            // SucChuaSV
            // 
            this.SucChuaSV.DataPropertyName = "SucChuaSV";
            this.SucChuaSV.FillWeight = 47.68382F;
            this.SucChuaSV.HeaderText = "Sức Chứa";
            this.SucChuaSV.MinimumWidth = 6;
            this.SucChuaSV.Name = "SucChuaSV";
            this.SucChuaSV.ReadOnly = true;
            // 
            // SLDangO
            // 
            this.SLDangO.DataPropertyName = "SLDangO";
            this.SLDangO.FillWeight = 80.19871F;
            this.SLDangO.HeaderText = "SV Đang Ở";
            this.SLDangO.MinimumWidth = 6;
            this.SLDangO.Name = "SLDangO";
            this.SLDangO.ReadOnly = true;
            // 
            // TenToa
            // 
            this.TenToa.DataPropertyName = "TenToa";
            this.TenToa.FillWeight = 122.7866F;
            this.TenToa.HeaderText = "Toà";
            this.TenToa.MinimumWidth = 6;
            this.TenToa.Name = "TenToa";
            this.TenToa.ReadOnly = true;
            // 
            // frm_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Phong";
            this.Text = "frm_Phong2";
            this.Load += new System.EventHandler(this.frm_Phong2_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox cb_loaiPhong;
        private Guna.UI2.WinForms.Guna2Button btn_SVDangO;
        private Guna.UI2.WinForms.Guna2TextBox txb_SVDangO;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txb_sucChua;
        private Guna.UI2.WinForms.Guna2TextBox txb_phong;
        private Guna.UI2.WinForms.Guna2TextBox txb_toa;
        private Guna.UI2.WinForms.Guna2TextBox txb_timKiem;
        private Guna.UI2.WinForms.Guna2Button btn_timKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btn_sua;
        private Guna.UI2.WinForms.Guna2Button btn_taiLai;
        private Guna.UI2.WinForms.Guna2Button btn_huy;
        private Guna.UI2.WinForms.Guna2Button btn_luu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_SVDangO;
        private System.Windows.Forms.Label lb_sucChua;
        private System.Windows.Forms.Label lb_loaiPhong;
        private System.Windows.Forms.Label lb_tenToa;
        private System.Windows.Forms.Label lb_maPhong;
        private System.Windows.Forms.Label lb_timKiem;
        private Guna.UI2.WinForms.Guna2Button btn_HoaDonDienNuoc;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SucChuaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLDangO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenToa;
        private Guna.UI2.WinForms.Guna2Button buttonXuatExcel;
    }
}