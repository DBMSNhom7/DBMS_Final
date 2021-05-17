
namespace GUI
{
    partial class frm_TaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_taiLai = new Guna.UI2.WinForms.Guna2Button();
            this.btn_huy = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_KTKL = new Guna.UI2.WinForms.Guna2DataGridView();
            this.IDTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txb_tenTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_IDTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_luu = new Guna.UI2.WinForms.Guna2Button();
            this.cb_loaiQuyen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txb_matKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_timKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sua = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txb_moTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_matKhau = new System.Windows.Forms.Label();
            this.lb_loaiQuyen = new System.Windows.Forms.Label();
            this.lb_moTa = new System.Windows.Forms.Label();
            this.lb_tenTaiKhoan = new System.Windows.Forms.Label();
            this.lb_IDTaiKhoan = new System.Windows.Forms.Label();
            this.lb_timKiem = new System.Windows.Forms.Label();
            this.btn_timKiem = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KTKL)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_taiLai
            // 
            this.btn_taiLai.CheckedState.Parent = this.btn_taiLai;
            this.btn_taiLai.CustomImages.Parent = this.btn_taiLai;
            this.btn_taiLai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taiLai.ForeColor = System.Drawing.Color.White;
            this.btn_taiLai.HoverState.Parent = this.btn_taiLai;
            this.btn_taiLai.Location = new System.Drawing.Point(6, 72);
            this.btn_taiLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_taiLai.Name = "btn_taiLai";
            this.btn_taiLai.ShadowDecoration.Parent = this.btn_taiLai;
            this.btn_taiLai.Size = new System.Drawing.Size(109, 43);
            this.btn_taiLai.TabIndex = 5;
            this.btn_taiLai.Text = "Tải lại";
            // 
            // btn_huy
            // 
            this.btn_huy.CheckedState.Parent = this.btn_huy;
            this.btn_huy.CustomImages.Parent = this.btn_huy;
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.HoverState.Parent = this.btn_huy;
            this.btn_huy.Location = new System.Drawing.Point(240, 72);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.ShadowDecoration.Parent = this.btn_huy;
            this.btn_huy.Size = new System.Drawing.Size(109, 43);
            this.btn_huy.TabIndex = 7;
            this.btn_huy.Text = "Huỷ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonXuatExcel);
            this.panel1.Controls.Add(this.dgv_KTKL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(478, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 554);
            this.panel1.TabIndex = 4;
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
            this.buttonXuatExcel.Location = new System.Drawing.Point(0, 496);
            this.buttonXuatExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonXuatExcel.Name = "buttonXuatExcel";
            this.buttonXuatExcel.ShadowDecoration.Parent = this.buttonXuatExcel;
            this.buttonXuatExcel.Size = new System.Drawing.Size(865, 58);
            this.buttonXuatExcel.TabIndex = 10;
            this.buttonXuatExcel.Text = "Xuất EXCEL";
            // 
            // dgv_KTKL
            // 
            this.dgv_KTKL.AllowUserToAddRows = false;
            this.dgv_KTKL.AllowUserToResizeColumns = false;
            this.dgv_KTKL.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgv_KTKL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_KTKL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KTKL.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_KTKL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_KTKL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_KTKL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KTKL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_KTKL.ColumnHeadersHeight = 40;
            this.dgv_KTKL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTaiKhoan,
            this.TenTaiKhoan,
            this.TenQuyen});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_KTKL.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_KTKL.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_KTKL.EnableHeadersVisualStyles = false;
            this.dgv_KTKL.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dgv_KTKL.Location = new System.Drawing.Point(0, 0);
            this.dgv_KTKL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_KTKL.Name = "dgv_KTKL";
            this.dgv_KTKL.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KTKL.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_KTKL.RowHeadersVisible = false;
            this.dgv_KTKL.RowHeadersWidth = 51;
            this.dgv_KTKL.RowTemplate.DividerHeight = 5;
            this.dgv_KTKL.RowTemplate.Height = 40;
            this.dgv_KTKL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_KTKL.Size = new System.Drawing.Size(865, 546);
            this.dgv_KTKL.TabIndex = 9;
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
            this.dgv_KTKL.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgv_KTKL.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgv_KTKL.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_KTKL.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_KTKL.ThemeStyle.ReadOnly = true;
            this.dgv_KTKL.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_KTKL.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_KTKL.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_KTKL.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_KTKL.ThemeStyle.RowsStyle.Height = 40;
            this.dgv_KTKL.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgv_KTKL.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // IDTaiKhoan
            // 
            this.IDTaiKhoan.DataPropertyName = "IDTaiKhoan";
            this.IDTaiKhoan.HeaderText = "ID";
            this.IDTaiKhoan.MinimumWidth = 6;
            this.IDTaiKhoan.Name = "IDTaiKhoan";
            this.IDTaiKhoan.ReadOnly = true;
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            this.TenTaiKhoan.FillWeight = 84.83527F;
            this.TenTaiKhoan.HeaderText = "Tài Khoản";
            this.TenTaiKhoan.MinimumWidth = 6;
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            this.TenTaiKhoan.ReadOnly = true;
            // 
            // TenQuyen
            // 
            this.TenQuyen.DataPropertyName = "TenQuyen";
            this.TenQuyen.FillWeight = 87.33154F;
            this.TenQuyen.HeaderText = "Loại Quyền";
            this.TenQuyen.MinimumWidth = 6;
            this.TenQuyen.Name = "TenQuyen";
            this.TenQuyen.ReadOnly = true;
            // 
            // txb_tenTaiKhoan
            // 
            this.txb_tenTaiKhoan.Animated = true;
            this.txb_tenTaiKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_tenTaiKhoan.BorderRadius = 6;
            this.txb_tenTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_tenTaiKhoan.DefaultText = "";
            this.txb_tenTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_tenTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_tenTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_tenTaiKhoan.DisabledState.Parent = this.txb_tenTaiKhoan;
            this.txb_tenTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_tenTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_tenTaiKhoan.FocusedState.Parent = this.txb_tenTaiKhoan;
            this.txb_tenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_tenTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_tenTaiKhoan.HoverState.Parent = this.txb_tenTaiKhoan;
            this.txb_tenTaiKhoan.Location = new System.Drawing.Point(156, 128);
            this.txb_tenTaiKhoan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_tenTaiKhoan.Name = "txb_tenTaiKhoan";
            this.txb_tenTaiKhoan.PasswordChar = '\0';
            this.txb_tenTaiKhoan.PlaceholderText = "";
            this.txb_tenTaiKhoan.SelectedText = "";
            this.txb_tenTaiKhoan.ShadowDecoration.Parent = this.txb_tenTaiKhoan;
            this.txb_tenTaiKhoan.Size = new System.Drawing.Size(231, 31);
            this.txb_tenTaiKhoan.TabIndex = 53;
            // 
            // txb_IDTaiKhoan
            // 
            this.txb_IDTaiKhoan.Animated = true;
            this.txb_IDTaiKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_IDTaiKhoan.BorderRadius = 6;
            this.txb_IDTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_IDTaiKhoan.DefaultText = "";
            this.txb_IDTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_IDTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_IDTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_IDTaiKhoan.DisabledState.Parent = this.txb_IDTaiKhoan;
            this.txb_IDTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_IDTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_IDTaiKhoan.FocusedState.Parent = this.txb_IDTaiKhoan;
            this.txb_IDTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_IDTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_IDTaiKhoan.HoverState.Parent = this.txb_IDTaiKhoan;
            this.txb_IDTaiKhoan.Location = new System.Drawing.Point(156, 69);
            this.txb_IDTaiKhoan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_IDTaiKhoan.Name = "txb_IDTaiKhoan";
            this.txb_IDTaiKhoan.PasswordChar = '\0';
            this.txb_IDTaiKhoan.PlaceholderText = "";
            this.txb_IDTaiKhoan.SelectedText = "";
            this.txb_IDTaiKhoan.ShadowDecoration.Parent = this.txb_IDTaiKhoan;
            this.txb_IDTaiKhoan.Size = new System.Drawing.Size(231, 31);
            this.txb_IDTaiKhoan.TabIndex = 52;
            // 
            // btn_luu
            // 
            this.btn_luu.CheckedState.Parent = this.btn_luu;
            this.btn_luu.CustomImages.Parent = this.btn_luu;
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.HoverState.Parent = this.btn_luu;
            this.btn_luu.Location = new System.Drawing.Point(123, 72);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.ShadowDecoration.Parent = this.btn_luu;
            this.btn_luu.Size = new System.Drawing.Size(109, 43);
            this.btn_luu.TabIndex = 6;
            this.btn_luu.Text = "Lưu";
            // 
            // cb_loaiQuyen
            // 
            this.cb_loaiQuyen.BackColor = System.Drawing.Color.Transparent;
            this.cb_loaiQuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_loaiQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_loaiQuyen.FocusedColor = System.Drawing.Color.Empty;
            this.cb_loaiQuyen.FocusedState.Parent = this.cb_loaiQuyen;
            this.cb_loaiQuyen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_loaiQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_loaiQuyen.FormattingEnabled = true;
            this.cb_loaiQuyen.HoverState.Parent = this.cb_loaiQuyen;
            this.cb_loaiQuyen.ItemHeight = 30;
            this.cb_loaiQuyen.ItemsAppearance.Parent = this.cb_loaiQuyen;
            this.cb_loaiQuyen.Location = new System.Drawing.Point(156, 250);
            this.cb_loaiQuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_loaiQuyen.Name = "cb_loaiQuyen";
            this.cb_loaiQuyen.ShadowDecoration.Parent = this.cb_loaiQuyen;
            this.cb_loaiQuyen.Size = new System.Drawing.Size(151, 36);
            this.cb_loaiQuyen.TabIndex = 58;
            // 
            // txb_matKhau
            // 
            this.txb_matKhau.Animated = true;
            this.txb_matKhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_matKhau.BorderRadius = 6;
            this.txb_matKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_matKhau.DefaultText = "";
            this.txb_matKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_matKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_matKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_matKhau.DisabledState.Parent = this.txb_matKhau;
            this.txb_matKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_matKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_matKhau.FocusedState.Parent = this.txb_matKhau;
            this.txb_matKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_matKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_matKhau.HoverState.Parent = this.txb_matKhau;
            this.txb_matKhau.Location = new System.Drawing.Point(156, 187);
            this.txb_matKhau.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_matKhau.Name = "txb_matKhau";
            this.txb_matKhau.PasswordChar = '\0';
            this.txb_matKhau.PlaceholderText = "";
            this.txb_matKhau.SelectedText = "";
            this.txb_matKhau.ShadowDecoration.Parent = this.txb_matKhau;
            this.txb_matKhau.Size = new System.Drawing.Size(231, 31);
            this.txb_matKhau.TabIndex = 54;
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
            this.txb_timKiem.Location = new System.Drawing.Point(156, 21);
            this.txb_timKiem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_timKiem.Name = "txb_timKiem";
            this.txb_timKiem.PasswordChar = '\0';
            this.txb_timKiem.PlaceholderText = "";
            this.txb_timKiem.SelectedText = "";
            this.txb_timKiem.ShadowDecoration.Parent = this.txb_timKiem;
            this.txb_timKiem.Size = new System.Drawing.Size(231, 31);
            this.txb_timKiem.TabIndex = 4;
            // 
            // btn_them
            // 
            this.btn_them.CheckedState.Parent = this.btn_them;
            this.btn_them.CustomImages.Parent = this.btn_them;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.HoverState.Parent = this.btn_them;
            this.btn_them.Location = new System.Drawing.Point(6, 21);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.ShadowDecoration.Parent = this.btn_them;
            this.btn_them.Size = new System.Drawing.Size(109, 43);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm";
            // 
            // btn_sua
            // 
            this.btn_sua.CheckedState.Parent = this.btn_sua;
            this.btn_sua.CustomImages.Parent = this.btn_sua;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.HoverState.Parent = this.btn_sua;
            this.btn_sua.Location = new System.Drawing.Point(123, 21);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.ShadowDecoration.Parent = this.btn_sua;
            this.btn_sua.Size = new System.Drawing.Size(109, 43);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 554);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txb_moTa);
            this.panel3.Controls.Add(this.lb_matKhau);
            this.panel3.Controls.Add(this.lb_loaiQuyen);
            this.panel3.Controls.Add(this.lb_moTa);
            this.panel3.Controls.Add(this.lb_tenTaiKhoan);
            this.panel3.Controls.Add(this.lb_IDTaiKhoan);
            this.panel3.Controls.Add(this.lb_timKiem);
            this.panel3.Controls.Add(this.cb_loaiQuyen);
            this.panel3.Controls.Add(this.txb_matKhau);
            this.panel3.Controls.Add(this.txb_tenTaiKhoan);
            this.panel3.Controls.Add(this.txb_IDTaiKhoan);
            this.panel3.Controls.Add(this.txb_timKiem);
            this.panel3.Controls.Add(this.btn_timKiem);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(468, 421);
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
            this.txb_moTa.Location = new System.Drawing.Point(156, 310);
            this.txb_moTa.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_moTa.Multiline = true;
            this.txb_moTa.Name = "txb_moTa";
            this.txb_moTa.PasswordChar = '\0';
            this.txb_moTa.PlaceholderText = "";
            this.txb_moTa.SelectedText = "";
            this.txb_moTa.ShadowDecoration.Parent = this.txb_moTa;
            this.txb_moTa.Size = new System.Drawing.Size(231, 107);
            this.txb_moTa.TabIndex = 74;
            // 
            // lb_matKhau
            // 
            this.lb_matKhau.AutoSize = true;
            this.lb_matKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matKhau.Location = new System.Drawing.Point(11, 196);
            this.lb_matKhau.Name = "lb_matKhau";
            this.lb_matKhau.Size = new System.Drawing.Size(101, 25);
            this.lb_matKhau.TabIndex = 73;
            this.lb_matKhau.Text = "Mật Khẩu:";
            // 
            // lb_loaiQuyen
            // 
            this.lb_loaiQuyen.AutoSize = true;
            this.lb_loaiQuyen.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loaiQuyen.Location = new System.Drawing.Point(11, 266);
            this.lb_loaiQuyen.Name = "lb_loaiQuyen";
            this.lb_loaiQuyen.Size = new System.Drawing.Size(113, 25);
            this.lb_loaiQuyen.TabIndex = 72;
            this.lb_loaiQuyen.Text = "Loại Quyền:";
            // 
            // lb_moTa
            // 
            this.lb_moTa.AutoSize = true;
            this.lb_moTa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_moTa.Location = new System.Drawing.Point(11, 319);
            this.lb_moTa.Name = "lb_moTa";
            this.lb_moTa.Size = new System.Drawing.Size(71, 25);
            this.lb_moTa.TabIndex = 71;
            this.lb_moTa.Text = "Mô Tả:";
            // 
            // lb_tenTaiKhoan
            // 
            this.lb_tenTaiKhoan.AutoSize = true;
            this.lb_tenTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenTaiKhoan.Location = new System.Drawing.Point(11, 132);
            this.lb_tenTaiKhoan.Name = "lb_tenTaiKhoan";
            this.lb_tenTaiKhoan.Size = new System.Drawing.Size(73, 25);
            this.lb_tenTaiKhoan.TabIndex = 70;
            this.lb_tenTaiKhoan.Text = "Tên TK:";
            // 
            // lb_IDTaiKhoan
            // 
            this.lb_IDTaiKhoan.AutoSize = true;
            this.lb_IDTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IDTaiKhoan.Location = new System.Drawing.Point(11, 78);
            this.lb_IDTaiKhoan.Name = "lb_IDTaiKhoan";
            this.lb_IDTaiKhoan.Size = new System.Drawing.Size(64, 25);
            this.lb_IDTaiKhoan.TabIndex = 69;
            this.lb_IDTaiKhoan.Text = "ID TK:";
            // 
            // lb_timKiem
            // 
            this.lb_timKiem.AutoSize = true;
            this.lb_timKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timKiem.Location = new System.Drawing.Point(11, 21);
            this.lb_timKiem.Name = "lb_timKiem";
            this.lb_timKiem.Size = new System.Drawing.Size(49, 25);
            this.lb_timKiem.TabIndex = 68;
            this.lb_timKiem.Text = "Tìm:";
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.CheckedState.Parent = this.btn_timKiem;
            this.btn_timKiem.CustomImages.Parent = this.btn_timKiem;
            this.btn_timKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timKiem.ForeColor = System.Drawing.Color.White;
            this.btn_timKiem.HoverState.Parent = this.btn_timKiem;
            this.btn_timKiem.Location = new System.Drawing.Point(396, 21);
            this.btn_timKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.ShadowDecoration.Parent = this.btn_timKiem;
            this.btn_timKiem.Size = new System.Drawing.Size(61, 31);
            this.btn_timKiem.TabIndex = 0;
            this.btn_timKiem.Text = "Tìm";
            // 
            // btn_xoa
            // 
            this.btn_xoa.CheckedState.Parent = this.btn_xoa;
            this.btn_xoa.CustomImages.Parent = this.btn_xoa;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.HoverState.Parent = this.btn_xoa;
            this.btn_xoa.Location = new System.Drawing.Point(240, 21);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.ShadowDecoration.Parent = this.btn_xoa;
            this.btn_xoa.Size = new System.Drawing.Size(109, 43);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xoá";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_them);
            this.panel4.Controls.Add(this.btn_sua);
            this.panel4.Controls.Add(this.btn_huy);
            this.panel4.Controls.Add(this.btn_luu);
            this.panel4.Controls.Add(this.btn_xoa);
            this.panel4.Controls.Add(this.btn_taiLai);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 432);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(481, 122);
            this.panel4.TabIndex = 75;
            // 
            // frm_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_TaiKhoan";
            this.Text = "frm_TaiKhoan2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KTKL)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_taiLai;
        private Guna.UI2.WinForms.Guna2Button btn_huy;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txb_tenTaiKhoan;
        private Guna.UI2.WinForms.Guna2TextBox txb_IDTaiKhoan;
        private Guna.UI2.WinForms.Guna2Button btn_luu;
        private Guna.UI2.WinForms.Guna2ComboBox cb_loaiQuyen;
        private Guna.UI2.WinForms.Guna2TextBox txb_matKhau;
        private Guna.UI2.WinForms.Guna2TextBox txb_timKiem;
        private Guna.UI2.WinForms.Guna2Button btn_them;
        private Guna.UI2.WinForms.Guna2Button btn_sua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btn_timKiem;
        private Guna.UI2.WinForms.Guna2Button btn_xoa;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lb_matKhau;
        private System.Windows.Forms.Label lb_loaiQuyen;
        private System.Windows.Forms.Label lb_moTa;
        private System.Windows.Forms.Label lb_tenTaiKhoan;
        private System.Windows.Forms.Label lb_IDTaiKhoan;
        private System.Windows.Forms.Label lb_timKiem;
        private Guna.UI2.WinForms.Guna2TextBox txb_moTa;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_KTKL;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQuyen;
        private Guna.UI2.WinForms.Guna2Button buttonXuatExcel;
        private System.Windows.Forms.Panel panel4;
    }
}