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

namespace GUI
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
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
            this.Hide();
            frm_Loading _load = new frm_Loading();
            _load.Show();
        }
    }
}
