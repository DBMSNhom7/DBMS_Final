
namespace GUI
{
    partial class frm_ChiTietPhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_phong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_toa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_dangO = new System.Windows.Forms.Label();
            this.lb_sucChua = new System.Windows.Forms.Label();
            this.lb_loaiPhong = new System.Windows.Forms.Label();
            this.lb_toa = new System.Windows.Forms.Label();
            this.lb_maPhong = new System.Windows.Forms.Label();
            this.txb_dangO = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_sucChua = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_loaiPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_huy = new Guna.UI2.WinForms.Guna2Button();
            this.btn_OK = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_phong);
            this.panel1.Controls.Add(this.cb_toa);
            this.panel1.Controls.Add(this.lb_dangO);
            this.panel1.Controls.Add(this.lb_sucChua);
            this.panel1.Controls.Add(this.lb_loaiPhong);
            this.panel1.Controls.Add(this.lb_toa);
            this.panel1.Controls.Add(this.lb_maPhong);
            this.panel1.Controls.Add(this.txb_dangO);
            this.panel1.Controls.Add(this.txb_sucChua);
            this.panel1.Controls.Add(this.txb_loaiPhong);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 258);
            this.panel1.TabIndex = 31;
            // 
            // cb_phong
            // 
            this.cb_phong.BackColor = System.Drawing.Color.Transparent;
            this.cb_phong.BorderRadius = 6;
            this.cb_phong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_phong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_phong.FocusedColor = System.Drawing.Color.Empty;
            this.cb_phong.FocusedState.Parent = this.cb_phong;
            this.cb_phong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_phong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_phong.FormattingEnabled = true;
            this.cb_phong.HoverState.Parent = this.cb_phong;
            this.cb_phong.ItemHeight = 30;
            this.cb_phong.ItemsAppearance.Parent = this.cb_phong;
            this.cb_phong.Location = new System.Drawing.Point(200, 59);
            this.cb_phong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_phong.Name = "cb_phong";
            this.cb_phong.ShadowDecoration.Parent = this.cb_phong;
            this.cb_phong.Size = new System.Drawing.Size(268, 36);
            this.cb_phong.TabIndex = 40;
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
            this.cb_toa.ItemsAppearance.Parent = this.cb_toa;
            this.cb_toa.Location = new System.Drawing.Point(200, 9);
            this.cb_toa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_toa.Name = "cb_toa";
            this.cb_toa.ShadowDecoration.Parent = this.cb_toa;
            this.cb_toa.Size = new System.Drawing.Size(268, 36);
            this.cb_toa.TabIndex = 39;
            this.cb_toa.SelectedValueChanged += new System.EventHandler(this.cb_toa_SelectedValueChanged_1);
            // 
            // lb_dangO
            // 
            this.lb_dangO.AutoSize = true;
            this.lb_dangO.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dangO.Location = new System.Drawing.Point(13, 206);
            this.lb_dangO.Name = "lb_dangO";
            this.lb_dangO.Size = new System.Drawing.Size(83, 25);
            this.lb_dangO.TabIndex = 38;
            this.lb_dangO.Text = "Đang Ở:";
            // 
            // lb_sucChua
            // 
            this.lb_sucChua.AutoSize = true;
            this.lb_sucChua.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sucChua.Location = new System.Drawing.Point(13, 161);
            this.lb_sucChua.Name = "lb_sucChua";
            this.lb_sucChua.Size = new System.Drawing.Size(98, 25);
            this.lb_sucChua.TabIndex = 37;
            this.lb_sucChua.Text = "Sức Chứa:";
            // 
            // lb_loaiPhong
            // 
            this.lb_loaiPhong.AutoSize = true;
            this.lb_loaiPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loaiPhong.Location = new System.Drawing.Point(13, 116);
            this.lb_loaiPhong.Name = "lb_loaiPhong";
            this.lb_loaiPhong.Size = new System.Drawing.Size(112, 25);
            this.lb_loaiPhong.TabIndex = 36;
            this.lb_loaiPhong.Text = "Loại Phòng:";
            // 
            // lb_toa
            // 
            this.lb_toa.AutoSize = true;
            this.lb_toa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_toa.Location = new System.Drawing.Point(13, 20);
            this.lb_toa.Name = "lb_toa";
            this.lb_toa.Size = new System.Drawing.Size(46, 25);
            this.lb_toa.TabIndex = 34;
            this.lb_toa.Text = "Tòa:";
            // 
            // lb_maPhong
            // 
            this.lb_maPhong.AutoSize = true;
            this.lb_maPhong.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maPhong.Location = new System.Drawing.Point(13, 69);
            this.lb_maPhong.Name = "lb_maPhong";
            this.lb_maPhong.Size = new System.Drawing.Size(105, 25);
            this.lb_maPhong.TabIndex = 35;
            this.lb_maPhong.Text = "Mã Phòng:";
            // 
            // txb_dangO
            // 
            this.txb_dangO.Animated = true;
            this.txb_dangO.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_dangO.BorderRadius = 6;
            this.txb_dangO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_dangO.DefaultText = "";
            this.txb_dangO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_dangO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_dangO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_dangO.DisabledState.Parent = this.txb_dangO;
            this.txb_dangO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_dangO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_dangO.FocusedState.Parent = this.txb_dangO;
            this.txb_dangO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb_dangO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_dangO.HoverState.Parent = this.txb_dangO;
            this.txb_dangO.Location = new System.Drawing.Point(200, 202);
            this.txb_dangO.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_dangO.Name = "txb_dangO";
            this.txb_dangO.PasswordChar = '\0';
            this.txb_dangO.PlaceholderText = "";
            this.txb_dangO.SelectedText = "";
            this.txb_dangO.ShadowDecoration.Parent = this.txb_dangO;
            this.txb_dangO.Size = new System.Drawing.Size(269, 31);
            this.txb_dangO.TabIndex = 32;
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
            this.txb_sucChua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb_sucChua.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_sucChua.HoverState.Parent = this.txb_sucChua;
            this.txb_sucChua.Location = new System.Drawing.Point(200, 156);
            this.txb_sucChua.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_sucChua.Name = "txb_sucChua";
            this.txb_sucChua.PasswordChar = '\0';
            this.txb_sucChua.PlaceholderText = "";
            this.txb_sucChua.SelectedText = "";
            this.txb_sucChua.ShadowDecoration.Parent = this.txb_sucChua;
            this.txb_sucChua.Size = new System.Drawing.Size(269, 31);
            this.txb_sucChua.TabIndex = 31;
            // 
            // txb_loaiPhong
            // 
            this.txb_loaiPhong.Animated = true;
            this.txb_loaiPhong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txb_loaiPhong.BorderRadius = 6;
            this.txb_loaiPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_loaiPhong.DefaultText = "";
            this.txb_loaiPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_loaiPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_loaiPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_loaiPhong.DisabledState.Parent = this.txb_loaiPhong;
            this.txb_loaiPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_loaiPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_loaiPhong.FocusedState.Parent = this.txb_loaiPhong;
            this.txb_loaiPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb_loaiPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_loaiPhong.HoverState.Parent = this.txb_loaiPhong;
            this.txb_loaiPhong.Location = new System.Drawing.Point(200, 111);
            this.txb_loaiPhong.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txb_loaiPhong.Name = "txb_loaiPhong";
            this.txb_loaiPhong.PasswordChar = '\0';
            this.txb_loaiPhong.PlaceholderText = "";
            this.txb_loaiPhong.SelectedText = "";
            this.txb_loaiPhong.ShadowDecoration.Parent = this.txb_loaiPhong;
            this.txb_loaiPhong.Size = new System.Drawing.Size(269, 31);
            this.txb_loaiPhong.TabIndex = 30;
            // 
            // btn_huy
            // 
            this.btn_huy.BorderRadius = 6;
            this.btn_huy.CheckedState.Parent = this.btn_huy;
            this.btn_huy.CustomImages.Parent = this.btn_huy;
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.HoverState.Parent = this.btn_huy;
            this.btn_huy.Location = new System.Drawing.Point(273, 284);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.ShadowDecoration.Parent = this.btn_huy;
            this.btn_huy.Size = new System.Drawing.Size(109, 43);
            this.btn_huy.TabIndex = 30;
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
            this.btn_OK.Location = new System.Drawing.Point(100, 284);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.ShadowDecoration.Parent = this.btn_OK;
            this.btn_OK.Size = new System.Drawing.Size(109, 43);
            this.btn_OK.TabIndex = 29;
            this.btn_OK.Text = "OK";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // frm_ChiTietPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(499, 343);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_OK);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_ChiTietPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSS";
            this.Load += new System.EventHandler(this.frm_ChiTietPhong2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txb_dangO;
        private Guna.UI2.WinForms.Guna2TextBox txb_sucChua;
        private Guna.UI2.WinForms.Guna2TextBox txb_loaiPhong;
        private Guna.UI2.WinForms.Guna2Button btn_huy;
        private Guna.UI2.WinForms.Guna2Button btn_OK;
        private System.Windows.Forms.Label lb_dangO;
        private System.Windows.Forms.Label lb_sucChua;
        private System.Windows.Forms.Label lb_loaiPhong;
        private System.Windows.Forms.Label lb_toa;
        private System.Windows.Forms.Label lb_maPhong;
        private Guna.UI2.WinForms.Guna2ComboBox cb_toa;
        private Guna.UI2.WinForms.Guna2ComboBox cb_phong;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}