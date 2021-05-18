using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;

namespace GUI
{
    public partial class frm_TrangChu : Form
    {
        public frm_TrangChu(TaiKhoanDTO tk)
        {
            InitializeComponent();
            lb_tenTK.Text = tk.TenTaiKhoan;
            lb_loaiTK.Text = tk.TenLoaiQuyen;
        }

        private void container(object _form)
        {
            if (pnl_container.Controls.Count > 0) pnl_container.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            pnl_container.Controls.Add(fm);
            pnl_container.Tag = fm;
            fm.Show();
        }

        private void frm_TrangChu_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            label_val.Text = "Tổng Quan";
            guna2PictureBox_val.Image = GUI.Properties.Resources.icons8_overview_96px;
            container(new frm_TongQuan());
        }

        private void btn_tongQuan_Click(object sender, EventArgs e)
        {
            label_val.Text = "Tổng Quan";
            guna2PictureBox_val.Image = GUI.Properties.Resources.icons8_overview_96px;
            container(new frm_TongQuan());
        }

        private void btn_qlSinhVien_Click(object sender, EventArgs e)
        {
            label_val.Text = "Quản Lý Sinh Viên";
            guna2PictureBox_val.Image = GUI.Properties.Resources.icons8_student_male_100px;
            container(new frm_SinhVien());
        }

        private void btn_qlNhanVien_Click(object sender, EventArgs e)
        {
            label_val.Text = "Quản Lý Nhân Viên";
            guna2PictureBox_val.Image = GUI.Properties.Resources.icons8_gender_neutral_employee_group_200px;
            container(new frm_NhanVien());
        }

        private void btn_qlPhong_Click(object sender, EventArgs e)
        {
            label_val.Text = "Quản Lý Phòng";
            guna2PictureBox_val.Image = GUI.Properties.Resources.icons8_room_80px;
            container(new frm_Phong());
        }

        private void btn_qlDienNuoc_Click(object sender, EventArgs e)
        {
            label_val.Text = "Quản Lý Điện Nước";
            guna2PictureBox_val.Image = GUI.Properties.Resources.icons8_water_100px;
            container(new frm_HoaDonDienNuoc());
        }

        private void btn_qlKTKL_Click(object sender, EventArgs e)
        {
            label_val.Text = "Quản Lý Khen Thưởng Kỷ Luật";
            guna2PictureBox_val.Image = GUI.Properties.Resources.icons8_certificate_100px;
            container(new frm_KTKL());
        }

        private void btn_qlTaiKhoan_Click(object sender, EventArgs e)
        {
            label_val.Text = "Quản Lý Tài Khoản";
            guna2PictureBox_val.Image = GUI.Properties.Resources.icons8_user_shield_96px;
            container(new frm_TaiKhoan());
        }

        private void frm_TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_dangXuat_Click(object sender, EventArgs e)
        {
            DatabaseConnection.ChangeConnection(false, "", "");

            this.Hide();
            frm_DangNhap fdn = new frm_DangNhap();
            fdn.ShowDialog();
        }
    }
}