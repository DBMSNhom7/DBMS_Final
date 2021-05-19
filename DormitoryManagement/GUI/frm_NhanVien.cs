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
    public partial class frm_NhanVien : Form
    {
        private NhanVienBLL _nhanVienBLL;
        private NhanVienDTO _nhanVienDTO;
        private HopDongNVBLL _hopDongNVBLL;
        private HopDongNVDTO _hopDongNVDTO;
        private ToaBLL _toaBLL;
        private bool them = false;
        private bool sua = false;

        public frm_NhanVien()
        {
            InitializeComponent();
            _nhanVienDTO = new NhanVienDTO();
            _nhanVienBLL = new NhanVienBLL();
            _hopDongNVBLL = new HopDongNVBLL();
            _toaBLL = new ToaBLL();
        }

        private void LoadData()
        {
            try
            {
                them = false;
                sua = false;

                txb_timKiem.ResetText();
                txb_maNV.ResetText();
                txb_hoTen.ResetText();
                dtp_ngaySinh.ResetText();
                txb_diaChi.ResetText();
                txb_dienThoai.ResetText();
                cb_toa.ResetText();
                cb_chucVu.ResetText();
                txb_maHD.ResetText();

                txb_maNV.ReadOnly = txb_hoTen.ReadOnly =
                    txb_diaChi.ReadOnly = txb_dienThoai.ReadOnly =
                    txb_maHD.ReadOnly = true;
                dtp_ngaySinh.Enabled = cb_toa.Enabled =
                    cb_chucVu.Enabled = false;

                lb_timKiem.Enabled = txb_timKiem.Enabled =
                    btn_timKiem.Enabled = btn_taiLai.Enabled =
                    btn_them.Enabled = btn_sua.Enabled =
                    btn_xoa.Enabled = dgv_nhanVien.Enabled = true;
                btn_luu.Enabled = btn_huy.Enabled = false;

                DataTable dtToa = _toaBLL.layToa();
                cb_toa.DataSource = dtToa;
                cb_toa.DisplayMember = "TenToa";
                cb_toa.ValueMember = "TenToa";

                DataTable dtChucVu = _nhanVienBLL.layLoaiChucVu();
                cb_chucVu.DataSource = dtChucVu;
                cb_chucVu.DisplayMember = "TenChucVu";
                cb_chucVu.ValueMember = "MaChucVu";

                dgv_nhanVien.DataSource = _nhanVienBLL.layNhanVien_DGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_NhanVien2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_taiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_maHD_Click(object sender, EventArgs e)
        {
            if (them)
            {
                frm_ChiTietHDNV frmhdnv = new frm_ChiTietHDNV(txb_maHD.Text, "Them");
                frmhdnv.ShowDialog();
                this._hopDongNVDTO = frmhdnv.hopDongNVDTO;
                txb_maHD.Text = this._hopDongNVDTO.MaHD;
            }
            else if (sua)
            {
                frm_ChiTietHDNV frmhdnv = new frm_ChiTietHDNV(txb_maHD.Text, "Sua");
                frmhdnv.ShowDialog();
                this._hopDongNVDTO = frmhdnv.hopDongNVDTO;
                txb_maHD.Text = this._hopDongNVDTO.MaHD;
            }
            else if (txb_maHD.Text.Trim() != "")
            {
                frm_ChiTietHDNV frmhdnv = new frm_ChiTietHDNV(txb_maHD.Text, "");
                frmhdnv.ShowDialog();
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            if (txb_timKiem.Text.Trim() != "")
            {
                dgv_nhanVien.DataSource =
                    _nhanVienBLL.layNhanVien_TimKiem_DGV("%" + txb_timKiem.Text.Trim() + "%");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txb_maNV.Text.Trim() != "")
            {
                DialogResult traloi =
                    MessageBox.Show("Bạn muốn xóa " + txb_hoTen.Text, "", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (traloi == DialogResult.OK)
                {
                    string err = "";

                    if (!_nhanVienBLL.xoaNhanVien_TheoMaNV(txb_maNV.Text, ref err))
                    {
                        if (err.Contains("permission was denied"))
                            MessageBox.Show("Không có quyền dùng chức năng này!");
                        else
                            MessageBox.Show(err);
                    }

                    LoadData();
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                lb_timKiem.Enabled = txb_timKiem.Enabled =
                    btn_timKiem.Enabled = txb_maNV.Enabled =
                    btn_them.Enabled = btn_sua.Enabled =
                    btn_xoa.Enabled = btn_taiLai.Enabled =
                    txb_maHD.Enabled = dgv_nhanVien.Enabled = false;

                txb_hoTen.Enabled = dtp_ngaySinh.Enabled =
                    txb_diaChi.Enabled = txb_dienThoai.Enabled =
                    cb_toa.Enabled = cb_chucVu.Enabled =
                    btn_maHD.Enabled = btn_luu.Enabled =
                    btn_huy.Enabled = true;

                txb_maNV.ReadOnly = txb_hoTen.ReadOnly =
                    txb_diaChi.ReadOnly = txb_dienThoai.ReadOnly = false;

                txb_maNV.ResetText();
                txb_hoTen.ResetText();
                dtp_ngaySinh.ResetText();
                txb_diaChi.ResetText();
                txb_dienThoai.ResetText();
                cb_toa.ResetText();
                cb_chucVu.ResetText();
                txb_maHD.ResetText();

                DataTable dtToa = _toaBLL.layToa();
                cb_toa.DataSource = dtToa;
                cb_toa.DisplayMember = "TenToa";
                cb_toa.ValueMember = "TenToa";

                DataTable dtChucVu = _nhanVienBLL.layLoaiChucVu();
                cb_chucVu.DataSource = dtChucVu;
                cb_chucVu.DisplayMember = "TenChucVu";
                cb_chucVu.ValueMember = "MaChucVu";

                them = true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("permission was denied"))
                    MessageBox.Show("Không có quyền dùng chức năng này!");
                else
                    MessageBox.Show(ex.Message);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_maNV.Text.Trim() != "")
                {
                    lb_timKiem.Enabled = txb_timKiem.Enabled =
                    btn_timKiem.Enabled = btn_them.Enabled =
                    btn_sua.Enabled = btn_xoa.Enabled =
                    btn_taiLai.Enabled = txb_maHD.Enabled =
                    dgv_nhanVien.Enabled = false;

                    txb_hoTen.Enabled = dtp_ngaySinh.Enabled =
                        txb_diaChi.Enabled = txb_dienThoai.Enabled =
                        cb_toa.Enabled = cb_chucVu.Enabled =
                        btn_maHD.Enabled = btn_luu.Enabled =
                        btn_huy.Enabled = true;

                    txb_hoTen.ReadOnly = txb_diaChi.ReadOnly =
                        txb_dienThoai.ReadOnly = false;

                    _hopDongNVDTO =
                        _hopDongNVBLL.layHDNV_TheoMaHD(txb_maHD.Text);

                    DataTable dtToa = _toaBLL.layToa();
                    cb_toa.DataSource = dtToa;
                    cb_toa.DisplayMember = "TenToa";
                    cb_toa.ValueMember = "TenToa";
                    cb_toa.Text = _nhanVienDTO.TenToa;

                    DataTable dtChucVu = _nhanVienBLL.layLoaiChucVu();
                    cb_chucVu.DataSource = dtChucVu;
                    cb_chucVu.DisplayMember = "TenChucVu";
                    cb_chucVu.ValueMember = "MaChucVu";
                    cb_chucVu.SelectedValue = _nhanVienDTO.MaChucVu;

                    sua = true;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("permission was denied"))
                    MessageBox.Show("Không có quyền dùng chức năng này!");
                else
                    MessageBox.Show(ex.Message);
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txb_hoTen.Text.Trim() == "" || txb_diaChi.Text.Trim() == "" ||
                txb_dienThoai.Text.Trim() == "" || cb_toa.Text.Trim() == "" ||
                cb_chucVu.Text.Trim() == "" || txb_maHD.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            if (them)
            {
                string err = "";

                _nhanVienDTO = new NhanVienDTO();
                _nhanVienDTO.HoTen = txb_hoTen.Text;
                _nhanVienDTO.NgaySinh = dtp_ngaySinh.Value.ToString("yyyy-MM-dd");
                _nhanVienDTO.DiaChi = txb_diaChi.Text;
                _nhanVienDTO.DienThoai = txb_dienThoai.Text;
                _nhanVienDTO.TenToa = cb_toa.Text;
                _nhanVienDTO.MaChucVu = cb_chucVu.SelectedValue.ToString();

                if (!_nhanVienBLL.themNhanVien(_nhanVienDTO, _hopDongNVDTO, ref err))
                {
                    if (err.Contains("permission was denied"))
                        MessageBox.Show("Không có quyền dùng chức năng này!");
                    else
                        MessageBox.Show(err);
                }
                else
                {
                    MessageBox.Show("Thêm thành công!");
                }

                LoadData();
            }
            else if (sua)
            {
                string err = "";

                _nhanVienDTO = new NhanVienDTO();
                _nhanVienDTO.MaNV = txb_maNV.Text;
                _nhanVienDTO.HoTen = txb_hoTen.Text;
                _nhanVienDTO.NgaySinh = dtp_ngaySinh.Value.ToString("yyyy-MM-dd");
                _nhanVienDTO.DiaChi = txb_diaChi.Text;
                _nhanVienDTO.DienThoai = txb_dienThoai.Text;
                _nhanVienDTO.TenToa = cb_toa.Text;
                _nhanVienDTO.MaChucVu = cb_chucVu.SelectedValue.ToString();

                if (!_nhanVienBLL.suaNhanVien(_nhanVienDTO, _hopDongNVDTO, ref err))
                {
                    if (err.Contains("permission was denied"))
                        MessageBox.Show("Không có quyền dùng chức năng này!");
                    else
                        MessageBox.Show(err);
                }
                else
                {
                    MessageBox.Show("Sửa thành công!");
                }

                LoadData();
            }
        }

        private void dgv_nhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string maNV = dgv_nhanVien.Rows[dgv_nhanVien.CurrentCell.RowIndex].Cells[0].Value.ToString();

                _nhanVienDTO = _nhanVienBLL.layNhanVien_TheoMaNV(maNV);

                txb_maNV.Text = _nhanVienDTO.MaNV;
                txb_hoTen.Text = _nhanVienDTO.HoTen;
                dtp_ngaySinh.Value = DateTime.Parse(_nhanVienDTO.NgaySinh);
                txb_diaChi.Text = _nhanVienDTO.DiaChi;
                txb_dienThoai.Text = _nhanVienDTO.DienThoai;
                cb_toa.Text = _nhanVienDTO.TenToa;
                cb_chucVu.Text = _nhanVienDTO.TenChucVu;
                txb_maHD.Text = _nhanVienDTO.MaHD;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Object reference not set to an instance of an object"))
                    return;
                else
                    MessageBox.Show(ex.Message);
            }
        }

        private void buttonXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgv_nhanVien.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgv_nhanVien.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgv_nhanVien.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgv_nhanVien.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_nhanVien.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgv_nhanVien.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}