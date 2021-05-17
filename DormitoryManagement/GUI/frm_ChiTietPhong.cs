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
using BLL;

namespace GUI
{
    public partial class frm_ChiTietPhong : Form
    {
        public PhongDTO phongDTO;
        private PhongBLL _phongBLL;
        private ToaBLL _toaBLL;
        private string _maPhong;
        private string _proc;

        public frm_ChiTietPhong(string maPhong, string proc)
        {
            InitializeComponent();
            phongDTO = new PhongDTO();
            _phongBLL = new PhongBLL();
            _toaBLL = new ToaBLL();
            this._maPhong = maPhong;
            this._proc = proc;
        }

        private void LoadData()
        {
            try
            {
                phongDTO =
                    _phongBLL.layPhong_TheoMaPhong(_maPhong);

                cb_toa.Items.Add(phongDTO.Toa);
                cb_toa.Text = phongDTO.Toa;
                cb_phong.Text = phongDTO.MaPhong;
                txb_loaiPhong.Text = phongDTO.TenLoai;
                txb_sucChua.Text = phongDTO.SucChuaSV;
                txb_dangO.Text = phongDTO.SLDangO;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_ChiTietPhong2_Load(object sender, EventArgs e)
        {
            if (_proc == "Them")
            {
                DataTable dt = _toaBLL.layToa();
                cb_toa.DataSource = dt;
                cb_toa.DisplayMember = "TenToa";
                cb_toa.ValueMember = "TenToa";
            }
            else if (_proc == "Sua")
            {
                DataTable dt = _toaBLL.layToa();
                cb_toa.DataSource = dt;
                cb_toa.DisplayMember = "TenToa";
                cb_toa.ValueMember = "TenToa";

                phongDTO =
                    _phongBLL.layPhong_TheoMaPhong(_maPhong);
                cb_toa.Text = phongDTO.Toa;
                cb_phong.Text = phongDTO.MaPhong;
            }
            else
            {
                LoadData();
                cb_toa.Enabled = cb_phong.Enabled = false;
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (cb_toa.Text.Trim() == "" || cb_phong.Text.Trim() == "" ||
                txb_loaiPhong.Text == "" || txb_sucChua.Text.Trim() == "" ||
                txb_dangO.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn đủ thông tin!");
                return;
            }

            phongDTO.MaPhong = cb_phong.Text;

            this.Close();
        }
        private void cb_toa_SelectedValueChanged_1(object sender, EventArgs e)
        {
            DataTable dt = _phongBLL.layPhong_TheoToa(cb_toa.Text.ToString());
            cb_phong.ResetText(); txb_loaiPhong.ResetText();
            txb_sucChua.ResetText(); txb_dangO.ResetText();
            cb_phong.DataSource = dt;
            cb_phong.DisplayMember = "MaPhong";
            cb_phong.ValueMember = "MaPhong";

            txb_loaiPhong.DataBindings.Clear();
            txb_sucChua.DataBindings.Clear();
            txb_dangO.DataBindings.Clear();
            txb_loaiPhong.DataBindings.Add("Text", dt, "TenLoai");
            txb_sucChua.DataBindings.Add("Text", dt, "SucChuaSV");
            txb_dangO.DataBindings.Add("Text", dt, "SLDangO");
        }
    }
}