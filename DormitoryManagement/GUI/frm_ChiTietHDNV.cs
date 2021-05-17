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
    public partial class frm_ChiTietHDNV : Form
    {
        public HopDongNVDTO hopDongNVDTO;
        private HopDongNVBLL _hopDongNVBLL;
        private string _maHD;
        private string _proc;

        public frm_ChiTietHDNV(string maHD, string proc)
        {
            InitializeComponent();
            hopDongNVDTO = new HopDongNVDTO();
            _hopDongNVBLL = new HopDongNVBLL();
            this._maHD = maHD;
            this._proc = proc;
        }

        private void LoadData()
        {
            try
            {
                hopDongNVDTO =
                    _hopDongNVBLL.layHDNV_TheoMaHD(_maHD);

                txb_maHD.Text = hopDongNVDTO.MaHD;
                dtp_ngayBatDau.Value = DateTime.Parse(hopDongNVDTO.NgayBatDau);
                dtp_ngayKetThuc.Value = DateTime.Parse(hopDongNVDTO.NgayKetThuc);
                dtp_ngayLap.Value = DateTime.Parse(hopDongNVDTO.NgayLap);
                txb_luongThang.Text = hopDongNVDTO.LuongThang;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_ChiTietHDNV2_Load(object sender, EventArgs e)
        {
            if (_proc == "Them")
            {
                txb_maHD.Enabled = dtp_ngayLap.Enabled = false;
                dtp_ngayLap.ResetText();
                dtp_ngayBatDau.ResetText();
                dtp_ngayKetThuc.ResetText();
            }
            else if (_proc == "Sua")
            {
                LoadData();
                txb_maHD.Enabled = dtp_ngayLap.Enabled = false;
            }
            else
            {
                LoadData();
                txb_maHD.ReadOnly = txb_luongThang.ReadOnly = true;
                dtp_ngayBatDau.Enabled = dtp_ngayKetThuc.Enabled =
                    dtp_ngayLap.Enabled = false;
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txb_luongThang.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            dtp_ngayLap.ResetText();

            hopDongNVDTO.MaHD = "Đã biên nhận";
            hopDongNVDTO.NgayBatDau = dtp_ngayBatDau.Value.ToString("yyyy-MM-dd");
            hopDongNVDTO.NgayKetThuc = dtp_ngayKetThuc.Value.ToString("yyyy-MM-dd");
            hopDongNVDTO.NgayLap = dtp_ngayLap.Value.ToString("yyyy-MM-dd");
            hopDongNVDTO.LuongThang = txb_luongThang.Text;

            this.Close();
        }
    }
}
