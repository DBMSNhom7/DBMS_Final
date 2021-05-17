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
using System.Configuration;
using DTO;
using BLL;
using DAL;

namespace GUI
{
    public partial class frm_DangNhap : Form
    {
        private TaiKhoanBLL _taiKhoanBLL;
        private TaiKhoanDTO _taiKhoanDTO;

        public frm_DangNhap()
        {
            InitializeComponent();
            _taiKhoanBLL = new TaiKhoanBLL();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            if (GUI.Properties.Settings.Default.Username != string.Empty)
            {
                txb_taiKhoan.Text = GUI.Properties.Settings.Default.Username;
                txb_matKhau.Text = GUI.Properties.Settings.Default.Password;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK) Application.Exit();
        }

        private void frm_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_dangNhap_Click_Click(object sender, EventArgs e)
        {
            if (txb_taiKhoan.Text.Trim() == "" ||
                txb_matKhau.Text.Trim() == "")
                return;

            string taiKhoan = txb_taiKhoan.Text;
            string matKhau = txb_matKhau.Text;

            if (_taiKhoanBLL.dangNhap(taiKhoan, matKhau))
            {
                _taiKhoanDTO = _taiKhoanBLL.layTaiKhoan_TheoTenTK(taiKhoan);

                DatabaseConnection.ChangeConnection(true,
                    _taiKhoanDTO.TenTaiKhoan, _taiKhoanDTO.MatKhau);

                if (tsw_rememberMe.Checked == true)
                {
                    GUI.Properties.Settings.Default.Username = taiKhoan;
                    GUI.Properties.Settings.Default.Password = matKhau;
                    GUI.Properties.Settings.Default.Save();
                }
                else
                {
                    GUI.Properties.Settings.Default.Username = string.Empty;
                    GUI.Properties.Settings.Default.Password = string.Empty;
                    GUI.Properties.Settings.Default.Save();
                }

                this.Hide();
                frm_Loading frm_loading = new frm_Loading(_taiKhoanDTO);
                frm_loading.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }
        }
    }
}
