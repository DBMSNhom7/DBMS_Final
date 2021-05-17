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
    public partial class frm_ChiTietThanNhan : Form
    {
        public ThanNhanDTO thanNhanDTO;
        private ThanNhanBLL _thanNhanBLL;
        private string _CMND_TN;
        private string _proc;

        public frm_ChiTietThanNhan(string CMND_TN, string proc)
        {
            InitializeComponent();
            thanNhanDTO = new ThanNhanDTO();
            _thanNhanBLL = new ThanNhanBLL();
            this._CMND_TN = CMND_TN;
            this._proc = proc;
        }

        private void LoadData()
        {
            try
            {
                thanNhanDTO =
                    _thanNhanBLL.layThanNhan_TheoCMNDTN(_CMND_TN);

                txb_CMND.Text = _CMND_TN;
                txb_hoTen.Text = thanNhanDTO.HoTen;
                cb_gioiTinh.Text = thanNhanDTO.GioiTinh;
                txb_quanHeVoiSV.Text = thanNhanDTO.QuanHeVoiSV;
                txb_diaChi.Text = thanNhanDTO.DiaChi;
                txb_dienThoai.Text = thanNhanDTO.DienThoai;

                this.Text += " Của Sinh Viên " + thanNhanDTO.MaSV;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_ThanNhan2_Load(object sender, EventArgs e)
        {
            if (_proc == "Them")
            {

            }
            else if (_proc == "Sua")
            {
                LoadData();
            }
            else
            {
                LoadData();
                txb_CMND.ReadOnly = txb_hoTen.ReadOnly =
                    txb_quanHeVoiSV.ReadOnly = txb_diaChi.ReadOnly =
                    txb_dienThoai.ReadOnly = true;
                cb_gioiTinh.Enabled = false;
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txb_CMND.Text.Trim() == "" || txb_hoTen.Text.Trim() == "" ||
                cb_gioiTinh.Text == "" || txb_quanHeVoiSV.Text.Trim() == "" ||
                txb_diaChi.Text.Trim() == "" || txb_dienThoai.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            thanNhanDTO.CMND = txb_CMND.Text;
            thanNhanDTO.HoTen = txb_hoTen.Text;
            thanNhanDTO.GioiTinh = cb_gioiTinh.Text;
            thanNhanDTO.QuanHeVoiSV = txb_quanHeVoiSV.Text;
            thanNhanDTO.DiaChi = txb_diaChi.Text;
            thanNhanDTO.DienThoai = txb_dienThoai.Text;

            this.Close();
        }
    }
}
