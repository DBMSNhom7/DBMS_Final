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
    public partial class frm_SinhVien_TheoPhong : Form
    {
        private SinhVienDTO _sinhVienDTO;
        private SinhVienBLL _sinhVienBLL;
        private ThanNhanDTO _thanNhanDTO;
        private ThanNhanBLL _thanNhanBLL;
        private HopDongSVDTO _hopDongSVDTO;
        private HopDongSVBLL _hopDongSVBLL;
        private string _maPhong;
        private bool them = false;
        private bool sua = false;

        public frm_SinhVien_TheoPhong(string maPhong)
        {
            InitializeComponent();
            _sinhVienDTO = new SinhVienDTO();
            _sinhVienBLL = new SinhVienBLL();
            _thanNhanBLL = new ThanNhanBLL();
            _hopDongSVBLL = new HopDongSVBLL();
            this._maPhong = maPhong;
            this.Text += " " + _maPhong.ToString();
        }

        private void LoadData()
        {
            try
            {
                them = false;
                sua = false;

                txb_maSV.ResetText();
                txb_CMND.ResetText();
                txb_hoTen.ResetText();
                cb_gioiTinh.ResetText();
                dtp_ngaySinh.ResetText();
                txb_diaChi.ResetText();
                txb_dienThoai.ResetText();
                txb_CMNDTN.ResetText();
                txb_maHD.ResetText();

                txb_maSV.ReadOnly = txb_CMND.ReadOnly =
                txb_hoTen.ReadOnly = txb_diaChi.ReadOnly =
                txb_dienThoai.ReadOnly = txb_CMNDTN.ReadOnly =
                txb_maHD.ReadOnly = true;
                cb_gioiTinh.Enabled = dtp_ngaySinh.Enabled = false;


                btn_them.Enabled = btn_sua.Enabled =
                btn_xoa.Enabled = dgv_sinhVien_TheoPhong.Enabled =
                btn_KTKL.Enabled = true;
                btn_luu.Enabled = false;

                dgv_sinhVien_TheoPhong.DataSource =
                    _sinhVienBLL.laySinhVien_TheoPhong_DGV(_maPhong);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            if (them)
            {
                LoadData();
            }
            else if (sua)
            {
                LoadData();
            }
            else this.Close();
        }

        private void frm_SinhVien_TheoPhong2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_sinhVien_TheoPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maSV =
                dgv_sinhVien_TheoPhong.Rows[dgv_sinhVien_TheoPhong.CurrentCell.RowIndex].Cells[0].Value.ToString();

            try
            {
                SinhVienDTO sv = new SinhVienDTO();
                sv = _sinhVienBLL.laySinhVien_TheoMaSV(maSV);

                txb_maSV.Text = sv.MaSV;
                txb_CMND.Text = sv.CMND;
                txb_hoTen.Text = sv.HoTen;
                cb_gioiTinh.Text = sv.GioiTinh;
                dtp_ngaySinh.Value = DateTime.Parse(sv.NgaySinh);
                txb_diaChi.Text = sv.DiaChi;
                txb_dienThoai.Text = sv.DienThoai;
                txb_CMNDTN.Text = sv.CMNDTN;
                txb_maHD.Text = sv.MaHD;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_chiTietTN_Click(object sender, EventArgs e)
        {
            if (them)
            {
                frm_ChiTietThanNhan frmtn = new frm_ChiTietThanNhan(txb_CMNDTN.Text, "Them");
                frmtn.ShowDialog();
                this._thanNhanDTO = frmtn.thanNhanDTO;
                txb_CMNDTN.Text = this._thanNhanDTO.CMND;
            }
            else if (sua)
            {
                frm_ChiTietThanNhan frmtn = new frm_ChiTietThanNhan(txb_CMNDTN.Text, "Sua");
                frmtn.ShowDialog();
                this._thanNhanDTO = frmtn.thanNhanDTO;
                txb_CMNDTN.Text = this._thanNhanDTO.CMND;
            }
            else if (txb_CMNDTN.Text.Trim() != "")
            {
                frm_ChiTietThanNhan frmtn = new frm_ChiTietThanNhan(txb_CMNDTN.Text, "");
                frmtn.ShowDialog();
            }
        }

        private void btn_maHD_Click(object sender, EventArgs e)
        {
            if (them)
            {
                frm_ChiTietHDSV frmhd = new frm_ChiTietHDSV(txb_maHD.Text, "Them");
                frmhd.ShowDialog();
                this._hopDongSVDTO = frmhd.hopDongSVDTO;
                txb_maHD.Text = this._hopDongSVDTO.MaHD;
            }
            else if (sua)
            {
                frm_ChiTietHDSV frmhd = new frm_ChiTietHDSV(txb_maHD.Text, "Sua");
                frmhd.ShowDialog();
                this._hopDongSVDTO = frmhd.hopDongSVDTO;
                txb_maHD.Text = this._hopDongSVDTO.MaHD;
            }
            else if (txb_maHD.Text.Trim() != "")
            {
                frm_ChiTietHDSV frmhdsv = new frm_ChiTietHDSV(txb_maHD.Text, "");
                frmhdsv.ShowDialog();
            }
        }

        private void btn_KTKL_Click(object sender, EventArgs e)
        {
            if (txb_maSV.Text.Trim() != "")
            {
                frm_KTKL_TheoSV frmktkl = new frm_KTKL_TheoSV(txb_maSV.Text);
                frmktkl.ShowDialog();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txb_maSV.Text.Trim() != "")
            {
                DialogResult traloi =
                    MessageBox.Show("Bạn muốn xóa " + txb_hoTen.Text, "", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (traloi == DialogResult.OK)
                {
                    string err = "";

                    if (!_sinhVienBLL.xoaSinhVien_TheoMaSV(txb_maSV.Text, ref err))
                    {
                        MessageBox.Show(err);
                    }

                    LoadData();
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_KTKL.Enabled = btn_them.Enabled =
                btn_sua.Enabled = btn_xoa.Enabled =
                txb_CMNDTN.Enabled = txb_maHD.Enabled =
                dgv_sinhVien_TheoPhong.Enabled = false;

            txb_maSV.Enabled = txb_CMND.Enabled =
                txb_hoTen.Enabled = cb_gioiTinh.Enabled =
                dtp_ngaySinh.Enabled = txb_diaChi.Enabled =
                txb_dienThoai.Enabled = btn_chiTietTN.Enabled =
                btn_maHD.Enabled = btn_luu.Enabled =
                btn_huy.Enabled = true;

            txb_maSV.ReadOnly = txb_CMND.ReadOnly =
                txb_hoTen.ReadOnly = txb_diaChi.ReadOnly =
                txb_dienThoai.ReadOnly = false;

            txb_maSV.ResetText();
            txb_CMND.ResetText();
            txb_hoTen.ResetText();
            cb_gioiTinh.ResetText();
            dtp_ngaySinh.ResetText();
            txb_diaChi.ResetText();
            txb_dienThoai.ResetText();
            txb_CMNDTN.ResetText();
            txb_maHD.ResetText();

            them = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txb_maSV.Text.Trim() != "")
            {
                try
                {
                    btn_KTKL.Enabled = btn_them.Enabled =
                        btn_sua.Enabled = btn_xoa.Enabled =
                        txb_CMNDTN.Enabled = txb_maHD.Enabled =
                        dgv_sinhVien_TheoPhong.Enabled =
                        txb_maSV.Enabled = false;

                    txb_CMND.Enabled = txb_hoTen.Enabled =
                        cb_gioiTinh.Enabled = dtp_ngaySinh.Enabled =
                        txb_diaChi.Enabled = txb_dienThoai.Enabled =
                        btn_chiTietTN.Enabled = btn_maHD.Enabled =
                        btn_luu.Enabled = btn_huy.Enabled = true;

                    txb_CMND.ReadOnly = txb_hoTen.ReadOnly =
                        txb_diaChi.ReadOnly = txb_dienThoai.ReadOnly = false;

                    _thanNhanDTO =
                        _thanNhanBLL.layThanNhan_TheoCMNDTN(txb_CMNDTN.Text);
                    _hopDongSVDTO =
                        _hopDongSVBLL.layHDSV_TheoMaHD(txb_maHD.Text);

                    sua = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txb_maSV.Text.Trim() == "" || txb_CMND.Text.Trim() == "" ||
                txb_hoTen.Text == "" || cb_gioiTinh.Text.Trim() == "" ||
                txb_diaChi.Text.Trim() == "" || txb_dienThoai.Text.Trim() == "" ||
                txb_CMNDTN.Text.Trim() == "" || txb_maHD.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            if (them)
            {
                string err = "";

                _sinhVienDTO = new SinhVienDTO();
                _sinhVienDTO.MaSV = txb_maSV.Text;
                _sinhVienDTO.CMND = txb_CMND.Text;
                _sinhVienDTO.HoTen = txb_hoTen.Text;
                _sinhVienDTO.GioiTinh = cb_gioiTinh.Text;
                _sinhVienDTO.NgaySinh = dtp_ngaySinh.Value.ToString("yyyy-MM-dd");
                _sinhVienDTO.DiaChi = txb_diaChi.Text;
                _sinhVienDTO.DienThoai = txb_dienThoai.Text;
                _sinhVienDTO.MaPhong = this._maPhong;

                if (!_sinhVienBLL.themSinhVien(_sinhVienDTO, _thanNhanDTO, _hopDongSVDTO, ref err))
                {
                    MessageBox.Show(err);
                }
                else
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadData();
                }
            }
            else if (sua)
            {
                string err = "";

                _sinhVienDTO = new SinhVienDTO();
                _sinhVienDTO.MaSV = txb_maSV.Text;
                _sinhVienDTO.CMND = txb_CMND.Text;
                _sinhVienDTO.HoTen = txb_hoTen.Text;
                _sinhVienDTO.GioiTinh = cb_gioiTinh.Text;
                _sinhVienDTO.NgaySinh = dtp_ngaySinh.Value.ToString("yyyy-MM-dd");
                _sinhVienDTO.DiaChi = txb_diaChi.Text;
                _sinhVienDTO.DienThoai = txb_dienThoai.Text;
                _sinhVienDTO.MaPhong = this._maPhong;

                if (!_sinhVienBLL.suaSinhVien(_sinhVienDTO, _thanNhanDTO, _hopDongSVDTO, ref err))
                {
                    MessageBox.Show(err);
                }
                else
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadData();
                }
            }
        }

        private void buttonXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgv_sinhVien_TheoPhong.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgv_sinhVien_TheoPhong.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgv_sinhVien_TheoPhong.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgv_sinhVien_TheoPhong.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_sinhVien_TheoPhong.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgv_sinhVien_TheoPhong.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}