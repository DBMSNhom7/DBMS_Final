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
using System.Threading;

namespace GUI
{
    public partial class frm_ChiTietHDSV : Form
    {
        public HopDongSVDTO hopDongSVDTO;
        private HopDongSVBLL _hopDongSVBLL;
        private string _maHD;
        private string _proc;

        public frm_ChiTietHDSV(string maHD, string proc)
        {
            InitializeComponent();
            hopDongSVDTO = new HopDongSVDTO();
            _hopDongSVBLL = new HopDongSVBLL();
            this._maHD = maHD;
            this._proc = proc;
        }

        private void LoadData()
        {
            try
            {
                hopDongSVDTO =
                    _hopDongSVBLL.layHDSV_TheoMaHD(_maHD);

                txb_maHD.Text = hopDongSVDTO.MaHD;
                dtp_ngayBatDau.Value = DateTime.Parse(hopDongSVDTO.NgayBatDau);
                dtp_ngayKetThuc.Value = DateTime.Parse(hopDongSVDTO.NgayKetThuc);
                dtp_ngayLap.Value = DateTime.Parse(hopDongSVDTO.NgayLap);
                txb_thanhTien.Text = hopDongSVDTO.ThanhTien;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_ChiTietHDSV2_Load(object sender, EventArgs e)
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
                txb_maHD.ReadOnly = txb_thanhTien.ReadOnly = true;
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
            if (txb_thanhTien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            dtp_ngayLap.ResetText();

            hopDongSVDTO.MaHD = "Đã biên nhận";
            hopDongSVDTO.NgayBatDau = dtp_ngayBatDau.Value.ToString("yyyy-MM-dd");
            hopDongSVDTO.NgayKetThuc = dtp_ngayKetThuc.Value.ToString("yyyy-MM-dd");
            hopDongSVDTO.NgayLap = dtp_ngayLap.Value.ToString("yyyy-MM-dd");
            hopDongSVDTO.ThanhTien = txb_thanhTien.Text;

            this.Close();
        }
    }
}