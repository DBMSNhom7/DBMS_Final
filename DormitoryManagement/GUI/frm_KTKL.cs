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
    public partial class frm_KTKL : Form
    {
        private KTKLBLL _KTKLBLL;
        private KTKLDTO _KTKLDTO;
        private SinhVienBLL _sinhVienBLL;
        private bool them = false;

        public frm_KTKL()
        {
            InitializeComponent();
            _KTKLBLL = new KTKLBLL();
            _sinhVienBLL = new SinhVienBLL();
        }

        private void LoadData()
        {
            try
            {
                them = false;

                lb_timKiem.Enabled = txb_timKiem.Enabled =
                    btn_timKiem.Enabled = txb_maKTKL.Enabled =
                    txb_maSV.Enabled = txb_tenSV.Enabled =
                    txb_moTa.Enabled = btn_them.Enabled =
                    btn_xoa.Enabled = btn_taiLai.Enabled =
                    dgv_KTKL.Enabled = true;

                txb_maKTKL.ReadOnly = txb_tenSV.ReadOnly =
                    txb_maSV.ReadOnly = txb_moTa.ReadOnly = true;

                cb_hinhThuc.Enabled = dtp_ngayTao.Enabled =
                    btn_luu.Enabled = btn_huy.Enabled = false;

                txb_timKiem.ResetText();
                txb_maKTKL.ResetText();
                txb_maSV.ResetText();
                txb_tenSV.ResetText();
                dtp_ngayTao.ResetText();
                txb_moTa.ResetText();

                dgv_KTKL.DataSource = _KTKLBLL.layKTKL_DGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_KTKL2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_taiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            if (txb_timKiem.Text.Trim() != "")
            {
                dgv_KTKL.DataSource =
                    _KTKLBLL.layKTKL_TimKiem_DGV("%" + txb_timKiem.Text.Trim() + "%");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txb_maKTKL.Text.Trim() != "")
            {
                DialogResult traloi =
                    MessageBox.Show("Bạn muốn xóa?", "", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (traloi == DialogResult.OK)
                {
                    string err = "";

                    if (!_KTKLBLL.xoaKTKL_TheoMaKTKL(txb_maKTKL.Text, ref err))
                    {
                        MessageBox.Show(err);
                    }

                    LoadData();
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            lb_timKiem.Enabled = txb_timKiem.Enabled =
                btn_timKiem.Enabled = txb_maKTKL.Enabled =
                dtp_ngayTao.Enabled = btn_them.Enabled =
                btn_xoa.Enabled = btn_taiLai.Enabled =
                dgv_KTKL.Enabled = false;

            txb_tenSV.ReadOnly = true;
            txb_maSV.ReadOnly = txb_moTa.ReadOnly = false;

            cb_hinhThuc.Enabled = txb_maSV.Enabled =
                txb_moTa.Enabled = btn_luu.Enabled =
                btn_huy.Enabled = true;

            txb_timKiem.ResetText();
            txb_maKTKL.ResetText();
            cb_hinhThuc.ResetText();
            txb_maSV.ResetText();
            txb_tenSV.ResetText();
            dtp_ngayTao.ResetText();
            txb_moTa.ResetText();

            them = true;
        }

        private void txb_maSV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SinhVienDTO sv = _sinhVienBLL.laySinhVien_TheoMaSV(txb_maSV.Text.Trim());

                if (sv.HoTen != null)
                    txb_tenSV.Text = sv.HoTen;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("There is no row at position 0."))
                    txb_tenSV.ResetText();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (cb_hinhThuc.Text.Trim() == "" || txb_maSV.Text.Trim() == "" ||
                txb_tenSV.Text.Trim() == "" || txb_moTa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            if (them)
            {
                string err = "";

                _KTKLDTO = new KTKLDTO();
                _KTKLDTO.HinhThuc = cb_hinhThuc.Text;
                _KTKLDTO.MaSV = txb_maSV.Text;
                _KTKLDTO.NgayTao = dtp_ngayTao.Value.ToString("yyyy-MM-dd");
                _KTKLDTO.MoTa = txb_moTa.Text;

                if (!_KTKLBLL.themKTKL(_KTKLDTO, ref err))
                {
                    MessageBox.Show(err);
                }
                else
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadData();
                }
            }
        }

   
        private void dgv_KTKL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maKTKL = dgv_KTKL.Rows[dgv_KTKL.CurrentCell.RowIndex].Cells[0].Value.ToString();

            try
            {
                KTKLDTO ktkl = new KTKLDTO();
                ktkl = _KTKLBLL.layKTKL_TheoMaKTKL(maKTKL);

                txb_maKTKL.Text = ktkl.MaKTKL;
                cb_hinhThuc.Text = ktkl.HinhThuc;
                txb_maSV.Text = ktkl.MaSV;
                txb_tenSV.Text = ktkl.TenSV;
                dtp_ngayTao.Value = DateTime.Parse(ktkl.NgayTao);
                txb_moTa.Text = ktkl.MoTa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgv_KTKL.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgv_KTKL.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgv_KTKL.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgv_KTKL.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_KTKL.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgv_KTKL.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}