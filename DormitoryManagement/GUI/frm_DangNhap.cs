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

                this.Hide();
                frm_TrangChu frm_trangChu = new frm_TrangChu();
                frm_trangChu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }
        }
    }
}
