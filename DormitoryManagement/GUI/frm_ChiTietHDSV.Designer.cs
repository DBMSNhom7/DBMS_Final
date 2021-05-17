
namespace GUI
{
    partial class frm_ChiTietHDSV
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
            this.lb_thanhTien = new System.Windows.Forms.Label();
            this.lb_ngayLap = new System.Windows.Forms.Label();
            this.lb_ngayKetThuc = new System.Windows.Forms.Label();
            this.lb_maHD = new System.Windows.Forms.Label();
            this.lb_ngayBatDau = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_ngayLap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_ngayKetThuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_ngayBatDau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txb_thanhTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_maHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_huy = new Guna.UI2.WinForms.Guna2Button();
            this.btn_OK = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_thanhTien
            // 
            this.lb_thanhTien.AutoSize = true;
            this.lb_thanhTien.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thanhTien.Location = new System.Drawing.Point(20, 188);
            this.lb_thanhTien.Name = "lb_thanhTien";
            this.lb_thanhTien.Size = new System.Drawing.Size(111, 25);
            this.lb_thanhTien.TabIndex = 25;
            this.lb_thanhTien.Text = "Thành Tiền:";
            // 
            // lb_ngayLap
            // 
            this.lb_ngayLap.AutoSize = true;
            this.lb_ngayLap.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngayLap.Location = new System.Drawing.Point(20, 145);
            this.lb_ngayLap.Name = "lb_ngayLap";
            this.lb_ngayLap.Size = new System.Drawing.Size(98, 25);
            this.lb_ngayLap.TabIndex = 24;
            this.lb_ngayLap.Text = "Ngày Lập:";
            // 
            // lb_ngayKetThuc
            // 
            this.lb_ngayKetThuc.AutoSize = true;
            this.lb_ngayKetThuc.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngayKetThuc.Location = new System.Drawing.Point(20, 101);
            this.lb_ngayKetThuc.Name = "lb_ngayKetThuc";
            this.lb_ngayKetThuc.Size = new System.Drawing.Size(143, 25);
            this.lb_ngayKetThuc.TabIndex = 23;
            this.lb_ngayKetThuc.Text = "Ngày Kết Thúc:";
            // 
            // lb_maHD
            // 
            this.lb_maHD.AutoSize = true;
            this.lb_maHD.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maHD.Location = new System.Drawing.Point(20, 11);
            this.lb_maHD.Name = "lb_maHD";
            this.lb_maHD.Size = new System.Drawing.Size(78, 25);
            this.lb_maHD.TabIndex = 21;
            this.lb_maHD.Text = "Mã HD:";
            // 
            // lb_ngayBatDau
            // 
            this.lb_ngayBatDau.AutoSize = true;
            this.lb_ngayBatDau.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngayBatDau.Location = new System.Drawing.Point(20, 57);
            this.lb_ngayBatDau.Name = "lb_ngayBatDau";
            this.lb_ngayBatDau.Size = new System.Drawing.Size(136, 25);
            this.lb_ngayBatDau.TabIndex = 22;
            this.lb_ngayBatDau.Text = "Ngày Bắt Đầu:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_ngayLap);
            this.panel1.Controls.Add(this.dtp_ngayKetThuc);
            this.panel1.Controls.Add(this.dtp_ngayBatDau);
            this.panel1.Controls.Add(this.txb_thanhTien);
            this.panel1.Controls.Add(this.txb_maHD);
            this.panel1.Controls.Add(this.lb_maHD);
            this.panel1.Controls.Add(this.lb_thanhTien);
            this.panel1.Controls.Add(this.lb_ngayBatDau);
            this.panel1.Controls.Add(this.lb_ngayLap);
            this.panel1.Controls.Add(this.lb_ngayKetThuc);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 236);
            this.panel1.TabIndex = 26;
            // 
            // dtp_ngayLap
            // 
            this.dtp_ngayLap.BorderRadius = 6;
            this.dtp_ngayLap.CheckedState.Parent = this.dtp_ngayLap;
            this.dtp_ngayLap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_ngayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayLap.HoverState.Parent = this.dtp_ngayLap;
            this.dtp_ngayLap.Location = new System.Drawing.Point(181, 138);
            this.dtp_ngayLap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_ngayLap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_ngayLap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_ngayLap.Name = "dtp_ngayLap";
            this.dtp_ngayLap.ShadowDecoration.Parent = this.dtp_ngayLap;
            this.dtp_ngayLap.Size = new System.Drawing.Size(269, 37);
            this.dtp_ngayLap.TabIndex = 35;
            this.dtp_ngayLap.Value = new System.DateTime(2021, 5, 12, 21, 28, 39, 87);
            // 
            // dtp_ngayKetThuc
            // 
            this.dtp_ngayKetThuc.BorderRadius = 6;
            this.dtp_ngayKetThuc.CheckedState.Parent = this.dtp_ngayKetThuc;
            this.dtp_ngayKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_ngayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayKetThuc.HoverState.Parent = this.dtp_ngayKetThuc;
            this.dtp_ngayKetThuc.Location = new System.Drawing.Point(181, 94);
            this.dtp_ngayKetThuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_ngayKetThuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_ngayKetThuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_ngayKetThuc.Name = "dtp_ngayKetThuc";
            this.dtp_ngayKetThuc.ShadowDecoration.Parent = this.dtp_ngayKetThuc;
            this.dtp_ngayKetThuc.Size = new System.Drawing.Size(269, 37);
            this.dtp_ngayKetThuc.TabIndex = 34;
            this.dtp_ngayKetThuc.Value = new System.DateTime(2021, 5, 12, 21, 28, 39, 87);
            // 
            // dtp_ngayBatDau
            // 
            this.dtp_ngayBatDau.BorderRadius = 6;
            this.dtp_ngayBatDau.CheckedState.Parent = this.dtp_ngayBatDau;
            this.dtp_ngayBatDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_ngayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayBatDau.HoverState.Parent = this.dtp_ngayBatDau;
            this.dtp_ngayBatDau.Location = new System.Drawing.Point(181, 49);
            this.dtp_ngayBatDau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_ngayBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_ngayBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_ngayBatDau.Name = "dtp_ngayBatDau";
            this.dtp_ngayBatDau.ShadowDecoration.Parent = this.dtp_ngayBatDau;
            this.dtp_ngayBatDau.Size = new System.Drawing.Size(269, 37);
            this.dtp_ngayBatDau.TabIndex = 33;
            this.dtp_ngayBatDau.Value = new System.DateTime(2021, 5, 12, 21, 28, 39, 87);
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
            this.txb_thanhTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb_thanhTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_thanhTien.HoverState.Parent = this.txb_thanhTien;
            this.txb_thanhTien.Location = new System.Drawing.Point(181, 188);
            this.txb_thanhTien.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_thanhTien.Name = "txb_thanhTien";
            this.txb_thanhTien.PasswordChar = '\0';
            this.txb_thanhTien.PlaceholderText = "";
            this.txb_thanhTien.SelectedText = "";
            this.txb_thanhTien.ShadowDecoration.Parent = this.txb_thanhTien;
            this.txb_thanhTien.Size = new System.Drawing.Size(269, 31);
            this.txb_thanhTien.TabIndex = 32;
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
            this.txb_maHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb_maHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_maHD.HoverState.Parent = this.txb_maHD;
            this.txb_maHD.Location = new System.Drawing.Point(181, 11);
            this.txb_maHD.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_maHD.Name = "txb_maHD";
            this.txb_maHD.PasswordChar = '\0';
            this.txb_maHD.PlaceholderText = "";
            this.txb_maHD.SelectedText = "";
            this.txb_maHD.ShadowDecoration.Parent = this.txb_maHD;
            this.txb_maHD.Size = new System.Drawing.Size(269, 31);
            this.txb_maHD.TabIndex = 31;
            // 
            // btn_huy
            // 
            this.btn_huy.BorderRadius = 6;
            this.btn_huy.CheckedState.Parent = this.btn_huy;
            this.btn_huy.CustomImages.Parent = this.btn_huy;
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.HoverState.Parent = this.btn_huy;
            this.btn_huy.Location = new System.Drawing.Point(297, 271);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.ShadowDecoration.Parent = this.btn_huy;
            this.btn_huy.Size = new System.Drawing.Size(109, 43);
            this.btn_huy.TabIndex = 32;
            this.btn_huy.Text = "Huỷ";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.BorderRadius = 6;
            this.btn_OK.CheckedState.Parent = this.btn_OK;
            this.btn_OK.CustomImages.Parent = this.btn_OK;
            this.btn_OK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.ForeColor = System.Drawing.Color.White;
            this.btn_OK.HoverState.Parent = this.btn_OK;
            this.btn_OK.Location = new System.Drawing.Point(124, 271);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.ShadowDecoration.Parent = this.btn_OK;
            this.btn_OK.Size = new System.Drawing.Size(109, 43);
            this.btn_OK.TabIndex = 31;
            this.btn_OK.Text = "OK";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // frm_ChiTietHDSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(502, 342);
            this.ControlBox = false;
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_ChiTietHDSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ChiTietHDSV2";
            this.Load += new System.EventHandler(this.frm_ChiTietHDSV2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_thanhTien;
        private System.Windows.Forms.Label lb_ngayLap;
        private System.Windows.Forms.Label lb_ngayKetThuc;
        private System.Windows.Forms.Label lb_maHD;
        private System.Windows.Forms.Label lb_ngayBatDau;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_huy;
        private Guna.UI2.WinForms.Guna2Button btn_OK;
        private Guna.UI2.WinForms.Guna2TextBox txb_maHD;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngayLap;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngayKetThuc;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_ngayBatDau;
        private Guna.UI2.WinForms.Guna2TextBox txb_thanhTien;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}