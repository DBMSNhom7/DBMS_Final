
namespace GUI
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_tieuDe = new System.Windows.Forms.Label();
            this.btn_thoat = new Guna.UI2.WinForms.Guna2Button();
            this.btn_dangNhap = new Guna.UI2.WinForms.Guna2Button();
            this.lb_rememberMe = new System.Windows.Forms.Label();
            this.tsw_rememberMe = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txb_matKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_taiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(108, 77);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.KTX_DHQG;
            this.pictureBox2.Location = new System.Drawing.Point(-96, -188);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1028, 1121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(614, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 747);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lb_tieuDe);
            this.panel2.Controls.Add(this.btn_thoat);
            this.panel2.Controls.Add(this.btn_dangNhap);
            this.panel2.Controls.Add(this.lb_rememberMe);
            this.panel2.Controls.Add(this.tsw_rememberMe);
            this.panel2.Controls.Add(this.txb_matKhau);
            this.panel2.Controls.Add(this.txb_taiKhoan);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 747);
            this.panel2.TabIndex = 2;
            // 
            // lb_tieuDe
            // 
            this.lb_tieuDe.AutoSize = true;
            this.lb_tieuDe.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tieuDe.Location = new System.Drawing.Point(117, 19);
            this.lb_tieuDe.Name = "lb_tieuDe";
            this.lb_tieuDe.Size = new System.Drawing.Size(353, 32);
            this.lb_tieuDe.TabIndex = 31;
            this.lb_tieuDe.Text = "Phần Mềm Quản Lý Ký Túc Xá";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Animated = true;
            this.btn_thoat.BackColor = System.Drawing.Color.Transparent;
            this.btn_thoat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btn_thoat.BorderRadius = 10;
            this.btn_thoat.BorderThickness = 2;
            this.btn_thoat.CheckedState.Parent = this.btn_thoat;
            this.btn_thoat.CustomImages.Parent = this.btn_thoat;
            this.btn_thoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.btn_thoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_thoat.HoverState.Parent = this.btn_thoat;
            this.btn_thoat.Location = new System.Drawing.Point(357, 601);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.ShadowDecoration.Parent = this.btn_thoat;
            this.btn_thoat.Size = new System.Drawing.Size(131, 48);
            this.btn_thoat.TabIndex = 21;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseTransparentBackground = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.Animated = true;
            this.btn_dangNhap.BackColor = System.Drawing.Color.Transparent;
            this.btn_dangNhap.BorderRadius = 10;
            this.btn_dangNhap.CheckedState.Parent = this.btn_dangNhap;
            this.btn_dangNhap.CustomImages.Parent = this.btn_dangNhap;
            this.btn_dangNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btn_dangNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangNhap.ForeColor = System.Drawing.Color.White;
            this.btn_dangNhap.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_dangNhap.HoverState.Parent = this.btn_dangNhap;
            this.btn_dangNhap.Location = new System.Drawing.Point(150, 601);
            this.btn_dangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.ShadowDecoration.Parent = this.btn_dangNhap;
            this.btn_dangNhap.Size = new System.Drawing.Size(131, 48);
            this.btn_dangNhap.TabIndex = 20;
            this.btn_dangNhap.Text = "Đăng nhập";
            this.btn_dangNhap.UseTransparentBackground = true;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click_Click);
            // 
            // lb_rememberMe
            // 
            this.lb_rememberMe.AutoSize = true;
            this.lb_rememberMe.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rememberMe.ForeColor = System.Drawing.Color.Black;
            this.lb_rememberMe.Location = new System.Drawing.Point(192, 541);
            this.lb_rememberMe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_rememberMe.Name = "lb_rememberMe";
            this.lb_rememberMe.Size = new System.Drawing.Size(98, 19);
            this.lb_rememberMe.TabIndex = 18;
            this.lb_rememberMe.Text = "Remember me";
            // 
            // tsw_rememberMe
            // 
            this.tsw_rememberMe.Animated = true;
            this.tsw_rememberMe.Checked = true;
            this.tsw_rememberMe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.tsw_rememberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.tsw_rememberMe.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(1)))), ((int)(((byte)(88)))));
            this.tsw_rememberMe.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.tsw_rememberMe.CheckedState.Parent = this.tsw_rememberMe;
            this.tsw_rememberMe.Location = new System.Drawing.Point(137, 537);
            this.tsw_rememberMe.Margin = new System.Windows.Forms.Padding(4);
            this.tsw_rememberMe.Name = "tsw_rememberMe";
            this.tsw_rememberMe.ShadowDecoration.Parent = this.tsw_rememberMe;
            this.tsw_rememberMe.Size = new System.Drawing.Size(47, 25);
            this.tsw_rememberMe.TabIndex = 17;
            this.tsw_rememberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.tsw_rememberMe.UncheckedState.BorderThickness = 2;
            this.tsw_rememberMe.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.tsw_rememberMe.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.tsw_rememberMe.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.tsw_rememberMe.UncheckedState.Parent = this.tsw_rememberMe;
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
            this.txb_matKhau.Location = new System.Drawing.Point(134, 466);
            this.txb_matKhau.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_matKhau.Name = "txb_matKhau";
            this.txb_matKhau.PasswordChar = '\0';
            this.txb_matKhau.PlaceholderText = "Mật khẩu";
            this.txb_matKhau.SelectedText = "";
            this.txb_matKhau.ShadowDecoration.Parent = this.txb_matKhau;
            this.txb_matKhau.Size = new System.Drawing.Size(335, 44);
            this.txb_matKhau.TabIndex = 16;
            this.txb_matKhau.UseSystemPasswordChar = true;
            // 
            // txb_taiKhoan
            // 
            this.txb_taiKhoan.Animated = true;
            this.txb_taiKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_taiKhoan.BorderRadius = 6;
            this.txb_taiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_taiKhoan.DefaultText = "";
            this.txb_taiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_taiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_taiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_taiKhoan.DisabledState.Parent = this.txb_taiKhoan;
            this.txb_taiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_taiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_taiKhoan.FocusedState.Parent = this.txb_taiKhoan;
            this.txb_taiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_taiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_taiKhoan.HoverState.Parent = this.txb_taiKhoan;
            this.txb_taiKhoan.Location = new System.Drawing.Point(134, 396);
            this.txb_taiKhoan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_taiKhoan.Name = "txb_taiKhoan";
            this.txb_taiKhoan.PasswordChar = '\0';
            this.txb_taiKhoan.PlaceholderText = "Tài khoản";
            this.txb_taiKhoan.SelectedText = "";
            this.txb_taiKhoan.ShadowDecoration.Parent = this.txb_taiKhoan;
            this.txb_taiKhoan.Size = new System.Drawing.Size(335, 44);
            this.txb_taiKhoan.TabIndex = 15;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // frm_DangNhap
            // 
            this.AcceptButton = this.btn_dangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 747);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLKTX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_DangNhap_FormClosing);
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_thoat;
        private Guna.UI2.WinForms.Guna2Button btn_dangNhap;
        private System.Windows.Forms.Label lb_rememberMe;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsw_rememberMe;
        private Guna.UI2.WinForms.Guna2TextBox txb_matKhau;
        private Guna.UI2.WinForms.Guna2TextBox txb_taiKhoan;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lb_tieuDe;
    }
}