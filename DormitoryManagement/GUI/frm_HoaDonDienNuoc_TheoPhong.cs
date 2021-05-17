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
    public partial class frm_HoaDonDienNuoc_TheoPhong : Form
    {
        private HoaDonDienNuocDTO _hoaDonDienNuocDTO;
        private HoaDonDienNuocBLL _hoaDonDienNuocBLL;
        private string _maPhong;
        private bool them = false;
        private bool sua = false;

        public frm_HoaDonDienNuoc_TheoPhong(string maPhong)
        {
            InitializeComponent();
            _hoaDonDienNuocDTO = new HoaDonDienNuocDTO();
            _hoaDonDienNuocBLL = new HoaDonDienNuocBLL();
            this._maPhong = maPhong;
            this.Text += " " + _maPhong.ToString();
        }

        private void LoadData()
        {
            try
            {
                them = false;
                sua = false;

                txb_maHoaDon.ResetText();
                txb_soDien.ResetText();
                txb_soNuoc.ResetText();
                txb_thanhTien.ResetText();
                dtp_ngayLap.ResetText();
                cb_trangThai.ResetText();

                txb_maHoaDon.ReadOnly = txb_soDien.ReadOnly =
                txb_soNuoc.ReadOnly = txb_thanhTien.ReadOnly = true;
                dtp_ngayLap.Enabled = cb_trangThai.Enabled = false;


                btn_them.Enabled = btn_sua.Enabled =
                btn_xoa.Enabled = dgv_hoaDonDienNuoc.Enabled =
                btn_huy.Enabled = true;
                btn_luu.Enabled = false;

                dgv_hoaDonDienNuoc.DataSource = _hoaDonDienNuocBLL.layHoaDonDienNuoc_TheoPhong_DGV(_maPhong);
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

        private void frm_HoaDonDienNuoc_TheoPhong2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

   
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txb_maHoaDon.Text.Trim() != "")
            {
                DialogResult traloi =
                    MessageBox.Show("Bạn muốn xóa?", "", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (traloi == DialogResult.OK)
                {
                    string err = "";

                    if (!_hoaDonDienNuocBLL.xoaHoaDonDienNuoc_TheoMaHoaDon(txb_maHoaDon.Text, ref err))
                    {
                        MessageBox.Show(err);
                    }

                    LoadData();
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_them.Enabled =
                btn_sua.Enabled = btn_xoa.Enabled =
                txb_maHoaDon.Enabled = dtp_ngayLap.Enabled =
                dgv_hoaDonDienNuoc.Enabled = false;

            txb_soDien.Enabled = txb_soNuoc.Enabled =
                txb_thanhTien.Enabled = cb_trangThai.Enabled =
                btn_luu.Enabled = btn_huy.Enabled = true;

            txb_soDien.ReadOnly = txb_soNuoc.ReadOnly =
                txb_thanhTien.ReadOnly = false;

            txb_maHoaDon.ResetText();
            txb_soDien.ResetText();
            txb_soNuoc.ResetText();
            txb_thanhTien.ResetText();
            dtp_ngayLap.ResetText();
            cb_trangThai.ResetText();
            cb_trangThai.Text = "Chưa Thanh Toán";

            them = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txb_maHoaDon.Text.Trim() != "")
            {
                try
                {
                    txb_maHoaDon.Enabled = txb_soDien.Enabled =
                        txb_soNuoc.Enabled = txb_thanhTien.Enabled =
                        dtp_ngayLap.Enabled = false;

                    cb_trangThai.Enabled = true;

                    btn_them.Enabled = btn_sua.Enabled =
                        btn_xoa.Enabled = dgv_hoaDonDienNuoc.Enabled = false;

                    btn_luu.Enabled = true;

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
            if (txb_soDien.Text.Trim() == "" || txb_soNuoc.Text.Trim() == "" ||
                txb_thanhTien.Text == "" || cb_trangThai.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            if (them)
            {
                string err = "";

                _hoaDonDienNuocDTO = new HoaDonDienNuocDTO();
                _hoaDonDienNuocDTO.SoDien = txb_soDien.Text;
                _hoaDonDienNuocDTO.SoNuoc = txb_soNuoc.Text;
                _hoaDonDienNuocDTO.ThanhTien = txb_thanhTien.Text;
                _hoaDonDienNuocDTO.NgayLap = dtp_ngayLap.Value.ToString("yyyy-MM-dd");
                _hoaDonDienNuocDTO.TrangThai = cb_trangThai.Text;
                _hoaDonDienNuocDTO.MaPhong = this._maPhong;

                if (!_hoaDonDienNuocBLL.themHoaDonDienNuoc(_hoaDonDienNuocDTO, ref err))
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

                _hoaDonDienNuocDTO = new HoaDonDienNuocDTO();
                _hoaDonDienNuocDTO.MaHoaDon = txb_maHoaDon.Text;
                _hoaDonDienNuocDTO.TrangThai = cb_trangThai.Text;

                if (!_hoaDonDienNuocBLL.suaHoaDonDienNuoc(_hoaDonDienNuocDTO, ref err))
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

        private void dgv_hoaDonDienNuoc_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string maHD = dgv_hoaDonDienNuoc.Rows[dgv_hoaDonDienNuoc.CurrentCell.RowIndex].Cells[0].Value.ToString();

            try
            {
                HoaDonDienNuocDTO hddn = new HoaDonDienNuocDTO();
                hddn = _hoaDonDienNuocBLL.layHoaDonDienNuoc_TheoMaHoaDon(maHD);
                txb_maHoaDon.Text = hddn.MaHoaDon;
                txb_soDien.Text = hddn.SoDien;
                txb_soNuoc.Text = hddn.SoNuoc;
                txb_thanhTien.Text = hddn.ThanhTien;
                dtp_ngayLap.Value = DateTime.Parse(hddn.NgayLap);
                cb_trangThai.Text = hddn.TrangThai;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgv_hoaDonDienNuoc.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgv_hoaDonDienNuoc.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgv_hoaDonDienNuoc.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgv_hoaDonDienNuoc.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_hoaDonDienNuoc.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgv_hoaDonDienNuoc.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
