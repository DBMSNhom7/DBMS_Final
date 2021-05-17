
namespace GUI
{
    partial class frm_KTKL_TheoSV
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
            this.cb_hinhThuc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txb_moTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_moTa = new System.Windows.Forms.Label();
            this.lb_ngayTao = new System.Windows.Forms.Label();
            this.lb_maKTKL = new System.Windows.Forms.Label();
            this.lb_hinhThuc = new System.Windows.Forms.Label();
            this.btn_KTKL = new Guna.UI2.WinForms.Guna2Button();
            this.txb_maHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_phong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_maKTKL = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_maHD = new Guna.UI2.WinForms.Guna2Button();
            this.btn_chiTietPhong = new Guna.UI2.WinForms.Guna2Button();
            this.dtp_ngayTao = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lb_maHD = new System.Windows.Forms.Label();
            this.lb_phong = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_luu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_huy = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_KTKL = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaKTKL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.buttonXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KTKL)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_hinhThuc
            // 
            this.cb_hinhThuc.BackColor = System.Drawing.Color.Transparent;
            this.cb_hinhThuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_hinhThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_hinhThuc.FocusedColor = System.Drawing.Color.Empty;
            this.cb_hinhThuc.FocusedState.Parent = this.cb_hinhThuc;
            this.cb_hinhThuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_hinhThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_hinhThuc.FormattingEnabled = true;
            this.cb_hinhThuc.HoverState.Parent = this.cb_hinhThuc;
            this.cb_hinhThuc.ItemHeight = 30;
            this.cb_hinhThuc.Items.AddRange(new object[] {
            "Khen Thưởng",
            "Kỷ Luật"});
            this.cb_hinhThuc.ItemsAppearance.Parent = this.cb_hinhThuc;
            this.cb_hinhThuc.Location = new System.Drawing.Point(100, 48);
            this.cb_hinhThuc.Name = "cb_hinhThuc";
            this.cb_hinhThuc.ShadowDecoration.Parent = this.cb_hinhThuc;
            this.cb_hinhThuc.Size = new System.Drawing.Size(173, 36);
            this.cb_hinhThuc.TabIndex = 58;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txb_moTa);
            this.panel3.Controls.Add(this.lb_moTa);
            this.panel3.Controls.Add(this.lb_ngayTao);
            this.panel3.Controls.Add(this.lb_maKTKL);
            this.panel3.Controls.Add(this.lb_hinhThuc);
            this.panel3.Controls.Add(this.cb_hinhThuc);
            this.panel3.Controls.Add(this.btn_KTKL);
            this.panel3.Controls.Add(this.txb_maHD);
            this.panel3.Controls.Add(this.txb_phong);
            this.panel3.Controls.Add(this.txb_maKTKL);
            this.panel3.Controls.Add(this.btn_maHD);
            this.panel3.Controls.Add(this.btn_chiTietPhong);
            this.panel3.Controls.Add(this.dtp_ngayTao);
            this.panel3.Controls.Add(this.lb_maHD);
            this.panel3.Controls.Add(this.lb_phong);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 340);
            this.panel3.TabIndex = 2;
            // 
            // txb_moTa
            // 
            this.txb_moTa.Animated = true;
            this.txb_moTa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_moTa.BorderRadius = 6;
            this.txb_moTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_moTa.DefaultText = "";
            this.txb_moTa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_moTa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_moTa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_moTa.DisabledState.Parent = this.txb_moTa;
            this.txb_moTa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_moTa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_moTa.FocusedState.Parent = this.txb_moTa;
            this.txb_moTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_moTa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_moTa.HoverState.Parent = this.txb_moTa;
            this.txb_moTa.Location = new System.Drawing.Point(100, 133);
            this.txb_moTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_moTa.Multiline = true;
            this.txb_moTa.Name = "txb_moTa";
            this.txb_moTa.PasswordChar = '\0';
            this.txb_moTa.PlaceholderText = "";
            this.txb_moTa.SelectedText = "";
            this.txb_moTa.ShadowDecoration.Parent = this.txb_moTa;
            this.txb_moTa.Size = new System.Drawing.Size(173, 176);
            this.txb_moTa.TabIndex = 63;
            // 
            // lb_moTa
            // 
            this.lb_moTa.AutoSize = true;
            this.lb_moTa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_moTa.Location = new System.Drawing.Point(11, 133);
            this.lb_moTa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_moTa.Name = "lb_moTa";
            this.lb_moTa.Size = new System.Drawing.Size(56, 20);
            this.lb_moTa.TabIndex = 62;
            this.lb_moTa.Text = "Mô Tả:";
            // 
            // lb_ngayTao
            // 
            this.lb_ngayTao.AutoSize = true;
            this.lb_ngayTao.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngayTao.Location = new System.Drawing.Point(11, 93);
            this.lb_ngayTao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ngayTao.Name = "lb_ngayTao";
            this.lb_ngayTao.Size = new System.Drawing.Size(79, 20);
            this.lb_ngayTao.TabIndex = 61;
            this.lb_ngayTao.Text = "Ngày Tạo:";
            // 
            // lb_maKTKL
            // 
            this.lb_maKTKL.AutoSize = true;
            this.lb_maKTKL.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maKTKL.Location = new System.Drawing.Point(11, 17);
            this.lb_maKTKL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_maKTKL.Name = "lb_maKTKL";
            this.lb_maKTKL.Size = new System.Drawing.Size(86, 20);
            this.lb_maKTKL.TabIndex = 59;
            this.lb_maKTKL.Text = "Mã KT - KL:";
            // 
            // lb_hinhThuc
            // 
            this.lb_hinhThuc.AutoSize = true;
            this.lb_hinhThuc.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hinhThuc.Location = new System.Drawing.Point(11, 57);
            this.lb_hinhThuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_hinhThuc.Name = "lb_hinhThuc";
            this.lb_hinhThuc.Size = new System.Drawing.Size(83, 20);
            this.lb_hinhThuc.TabIndex = 60;
            this.lb_hinhThuc.Text = "Hình Thức:";
            // 
            // btn_KTKL
            // 
            this.btn_KTKL.CheckedState.Parent = this.btn_KTKL;
            this.btn_KTKL.CustomImages.Parent = this.btn_KTKL;
            this.btn_KTKL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KTKL.ForeColor = System.Drawing.Color.White;
            this.btn_KTKL.HoverState.Parent = this.btn_KTKL;
            this.btn_KTKL.Location = new System.Drawing.Point(131, 407);
            this.btn_KTKL.Name = "btn_KTKL";
            this.btn_KTKL.ShadowDecoration.Parent = this.btn_KTKL;
            this.btn_KTKL.Size = new System.Drawing.Size(142, 28);
            this.btn_KTKL.TabIndex = 57;
            this.btn_KTKL.Text = "Khen thưởng - Kỷ luật";
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
            this.txb_maHD.Location = new System.Drawing.Point(100, 376);
            this.txb_maHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_maHD.Name = "txb_maHD";
            this.txb_maHD.PasswordChar = '\0';
            this.txb_maHD.PlaceholderText = "";
            this.txb_maHD.SelectedText = "";
            this.txb_maHD.ShadowDecoration.Parent = this.txb_maHD;
            this.txb_maHD.Size = new System.Drawing.Size(173, 25);
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
            this.txb_phong.Location = new System.Drawing.Point(100, 344);
            this.txb_phong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_phong.Name = "txb_phong";
            this.txb_phong.PasswordChar = '\0';
            this.txb_phong.PlaceholderText = "";
            this.txb_phong.SelectedText = "";
            this.txb_phong.ShadowDecoration.Parent = this.txb_phong;
            this.txb_phong.Size = new System.Drawing.Size(173, 25);
            this.txb_phong.TabIndex = 55;
            // 
            // txb_maKTKL
            // 
            this.txb_maKTKL.Animated = true;
            this.txb_maKTKL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_maKTKL.BorderRadius = 6;
            this.txb_maKTKL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_maKTKL.DefaultText = "";
            this.txb_maKTKL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_maKTKL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_maKTKL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_maKTKL.DisabledState.Parent = this.txb_maKTKL;
            this.txb_maKTKL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_maKTKL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_maKTKL.FocusedState.Parent = this.txb_maKTKL;
            this.txb_maKTKL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_maKTKL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_maKTKL.HoverState.Parent = this.txb_maKTKL;
            this.txb_maKTKL.Location = new System.Drawing.Point(100, 17);
            this.txb_maKTKL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_maKTKL.Name = "txb_maKTKL";
            this.txb_maKTKL.PasswordChar = '\0';
            this.txb_maKTKL.PlaceholderText = "";
            this.txb_maKTKL.SelectedText = "";
            this.txb_maKTKL.ShadowDecoration.Parent = this.txb_maKTKL;
            this.txb_maKTKL.Size = new System.Drawing.Size(173, 25);
            this.txb_maKTKL.TabIndex = 4;
            // 
            // btn_maHD
            // 
            this.btn_maHD.CheckedState.Parent = this.btn_maHD;
            this.btn_maHD.CustomImages.Parent = this.btn_maHD;
            this.btn_maHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_maHD.ForeColor = System.Drawing.Color.White;
            this.btn_maHD.HoverState.Parent = this.btn_maHD;
            this.btn_maHD.Location = new System.Drawing.Point(283, 376);
            this.btn_maHD.Name = "btn_maHD";
            this.btn_maHD.ShadowDecoration.Parent = this.btn_maHD;
            this.btn_maHD.Size = new System.Drawing.Size(46, 25);
            this.btn_maHD.TabIndex = 48;
            this.btn_maHD.Text = "...";
            // 
            // btn_chiTietPhong
            // 
            this.btn_chiTietPhong.CheckedState.Parent = this.btn_chiTietPhong;
            this.btn_chiTietPhong.CustomImages.Parent = this.btn_chiTietPhong;
            this.btn_chiTietPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_chiTietPhong.ForeColor = System.Drawing.Color.White;
            this.btn_chiTietPhong.HoverState.Parent = this.btn_chiTietPhong;
            this.btn_chiTietPhong.Location = new System.Drawing.Point(283, 339);
            this.btn_chiTietPhong.Name = "btn_chiTietPhong";
            this.btn_chiTietPhong.ShadowDecoration.Parent = this.btn_chiTietPhong;
            this.btn_chiTietPhong.Size = new System.Drawing.Size(46, 25);
            this.btn_chiTietPhong.TabIndex = 47;
            this.btn_chiTietPhong.Text = "...";
            // 
            // dtp_ngayTao
            // 
            this.dtp_ngayTao.CheckedState.Parent = this.dtp_ngayTao;
            this.dtp_ngayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayTao.HoverState.Parent = this.dtp_ngayTao;
            this.dtp_ngayTao.Location = new System.Drawing.Point(100, 93);
            this.dtp_ngayTao.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_ngayTao.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_ngayTao.Name = "dtp_ngayTao";
            this.dtp_ngayTao.ShadowDecoration.Parent = this.dtp_ngayTao;
            this.dtp_ngayTao.Size = new System.Drawing.Size(173, 32);
            this.dtp_ngayTao.TabIndex = 0;
            this.dtp_ngayTao.Value = new System.DateTime(2021, 5, 10, 21, 59, 56, 437);
            // 
            // lb_maHD
            // 
            this.lb_maHD.AutoSize = true;
            this.lb_maHD.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maHD.Location = new System.Drawing.Point(11, 381);
            this.lb_maHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_maHD.Name = "lb_maHD";
            this.lb_maHD.Size = new System.Drawing.Size(61, 20);
            this.lb_maHD.TabIndex = 38;
            this.lb_maHD.Text = "Mã HD:";
            // 
            // lb_phong
            // 
            this.lb_phong.AutoSize = true;
            this.lb_phong.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phong.Location = new System.Drawing.Point(11, 344);
            this.lb_phong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_phong.Name = "lb_phong";
            this.lb_phong.Size = new System.Drawing.Size(58, 20);
            this.lb_phong.TabIndex = 37;
            this.lb_phong.Text = "Phòng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_luu);
            this.panel2.Controls.Add(this.btn_huy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 450);
            this.panel2.TabIndex = 3;
            // 
            // btn_them
            // 
            this.btn_them.CheckedState.Parent = this.btn_them;
            this.btn_them.CustomImages.Parent = this.btn_them;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.HoverState.Parent = this.btn_them;
            this.btn_them.Location = new System.Drawing.Point(81, 366);
            this.btn_them.Name = "btn_them";
            this.btn_them.ShadowDecoration.Parent = this.btn_them;
            this.btn_them.Size = new System.Drawing.Size(82, 35);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.CheckedState.Parent = this.btn_xoa;
            this.btn_xoa.CustomImages.Parent = this.btn_xoa;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.HoverState.Parent = this.btn_xoa;
            this.btn_xoa.Location = new System.Drawing.Point(169, 366);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.ShadowDecoration.Parent = this.btn_xoa;
            this.btn_xoa.Size = new System.Drawing.Size(82, 35);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.CheckedState.Parent = this.btn_luu;
            this.btn_luu.CustomImages.Parent = this.btn_luu;
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.HoverState.Parent = this.btn_luu;
            this.btn_luu.Location = new System.Drawing.Point(169, 407);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.ShadowDecoration.Parent = this.btn_luu;
            this.btn_luu.Size = new System.Drawing.Size(82, 35);
            this.btn_luu.TabIndex = 6;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.CheckedState.Parent = this.btn_huy;
            this.btn_huy.CustomImages.Parent = this.btn_huy;
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.HoverState.Parent = this.btn_huy;
            this.btn_huy.Location = new System.Drawing.Point(81, 407);
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
            this.panel1.Controls.Add(this.dgv_KTKL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(332, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 450);
            this.panel1.TabIndex = 2;
            // 
            // dgv_KTKL
            // 
            this.dgv_KTKL.AllowUserToAddRows = false;
            this.dgv_KTKL.AllowUserToResizeColumns = false;
            this.dgv_KTKL.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_KTKL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_KTKL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KTKL.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_KTKL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_KTKL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_KTKL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KTKL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_KTKL.ColumnHeadersHeight = 40;
            this.dgv_KTKL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKTKL,
            this.HinhThuc,
            this.NgayTao});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_KTKL.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_KTKL.EnableHeadersVisualStyles = false;
            this.dgv_KTKL.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_KTKL.Location = new System.Drawing.Point(3, 3);
            this.dgv_KTKL.Name = "dgv_KTKL";
            this.dgv_KTKL.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KTKL.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_KTKL.RowHeadersVisible = false;
            this.dgv_KTKL.RowTemplate.DividerHeight = 5;
            this.dgv_KTKL.RowTemplate.Height = 40;
            this.dgv_KTKL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_KTKL.Size = new System.Drawing.Size(462, 444);
            this.dgv_KTKL.TabIndex = 7;
            this.dgv_KTKL.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_KTKL.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_KTKL.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_KTKL.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_KTKL.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_KTKL.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_KTKL.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_KTKL.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_KTKL.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_KTKL.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_KTKL.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_KTKL.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgv_KTKL.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_KTKL.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_KTKL.ThemeStyle.ReadOnly = true;
            this.dgv_KTKL.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_KTKL.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_KTKL.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_KTKL.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_KTKL.ThemeStyle.RowsStyle.Height = 40;
            this.dgv_KTKL.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgv_KTKL.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_KTKL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KTKL_CellClick_1);
            // 
            // MaKTKL
            // 
            this.MaKTKL.DataPropertyName = "MaKTKL";
            this.MaKTKL.HeaderText = "Mã KTKL";
            this.MaKTKL.Name = "MaKTKL";
            this.MaKTKL.ReadOnly = true;
            // 
            // HinhThuc
            // 
            this.HinhThuc.DataPropertyName = "HinhThuc";
            this.HinhThuc.FillWeight = 84.83527F;
            this.HinhThuc.HeaderText = "Hình Thức";
            this.HinhThuc.Name = "HinhThuc";
            this.HinhThuc.ReadOnly = true;
            // 
            // NgayTao
            // 
            this.NgayTao.DataPropertyName = "NgayTao";
            this.NgayTao.FillWeight = 87.33154F;
            this.NgayTao.HeaderText = "Ngày Tạo";
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.ReadOnly = true;
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
            this.buttonXuatExcel.Location = new System.Drawing.Point(357, 391);
            this.buttonXuatExcel.Name = "buttonXuatExcel";
            this.buttonXuatExcel.ShadowDecoration.Parent = this.buttonXuatExcel;
            this.buttonXuatExcel.Size = new System.Drawing.Size(99, 47);
            this.buttonXuatExcel.TabIndex = 10;
            this.buttonXuatExcel.Text = "Xuất EXCEL";
            this.buttonXuatExcel.Click += new System.EventHandler(this.buttonXuatExcel_Click);
            // 
            // frm_KTKL_TheoSV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frm_KTKL_TheoSV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khen thưởng kỷ luật";
            this.Load += new System.EventHandler(this.frm_KTKL_TheoSV2_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KTKL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cb_hinhThuc;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btn_KTKL;
        private Guna.UI2.WinForms.Guna2TextBox txb_maHD;
        private Guna.UI2.WinForms.Guna2TextBox txb_phong;
        private Guna.UI2.WinForms.Guna2TextBox txb_maKTKL;
        private Guna.UI2.WinForms.Guna2Button btn_maHD;
        private Guna.UI2.WinForms.Guna2Button btn_chiTietPhong;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngayTao;
        private System.Windows.Forms.Label lb_maHD;
        private System.Windows.Forms.Label lb_phong;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_them;
        private Guna.UI2.WinForms.Guna2Button btn_xoa;
        private Guna.UI2.WinForms.Guna2Button btn_huy;
        private Guna.UI2.WinForms.Guna2Button btn_luu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_moTa;
        private System.Windows.Forms.Label lb_ngayTao;
        private System.Windows.Forms.Label lb_maKTKL;
        private System.Windows.Forms.Label lb_hinhThuc;
        private Guna.UI2.WinForms.Guna2TextBox txb_moTa;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_KTKL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKTKL;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private Guna.UI2.WinForms.Guna2Button buttonXuatExcel;
    }
}