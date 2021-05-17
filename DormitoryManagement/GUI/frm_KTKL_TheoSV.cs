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
    public partial class frm_KTKL_TheoSV : Form
    {
        private KTKLDTO _KTKLDTO;
        private KTKLBLL _KTKLBLL;
        private string _maSV;
        private bool them = false;

        public frm_KTKL_TheoSV(string maSV)
        {
            InitializeComponent();
            _KTKLDTO = new KTKLDTO();
            _KTKLBLL = new KTKLBLL();
            this._maSV = maSV;

            this.Text += " " + _maSV.ToString();
        }

        private void LoadData()
        {
            try
            {
                them = false;

                txb_maKTKL.Enabled = txb_moTa.Enabled = true;
                cb_hinhThuc.Enabled = dtp_ngayTao.Enabled = false;
                txb_maKTKL.ReadOnly = txb_moTa.ReadOnly = true;
                btn_luu.Enabled = false;
                btn_them.Enabled = btn_xoa.Enabled = true;
                dgv_KTKL.Enabled = true;

                txb_maKTKL.ResetText();
                cb_hinhThuc.Text = "";
                dtp_ngayTao.ResetText();
                txb_moTa.ResetText();

                dgv_KTKL.DataSource = _KTKLBLL.layKTKL_TheoMaSV_DGV(_maSV);
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
            else this.Close();
        }

        private void frm_KTKL_TheoSV2_Load(object sender, EventArgs e)
        {
            LoadData();
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            txb_maKTKL.ResetText();
            cb_hinhThuc.ResetText();
            dtp_ngayTao.ResetText();
            txb_moTa.ResetText();

            txb_maKTKL.Enabled = false;
            cb_hinhThuc.Enabled = true;
            dtp_ngayTao.Enabled = false;
            txb_moTa.ReadOnly = false;
            btn_luu.Enabled = true;
            btn_them.Enabled = btn_xoa.Enabled = false;
            dgv_KTKL.Enabled = false;

            them = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (cb_hinhThuc.Text.Trim() == "" || txb_moTa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            string err = "";

            _KTKLDTO = new KTKLDTO();
            _KTKLDTO.HinhThuc = cb_hinhThuc.Text;
            _KTKLDTO.NgayTao = dtp_ngayTao.Value.ToString("yyyy-MM-dd");
            _KTKLDTO.MoTa = txb_moTa.Text;
            _KTKLDTO.MaSV = this._maSV;

            if (!_KTKLBLL.themKTKL(_KTKLDTO, ref err))
            {
                MessageBox.Show(err);
            }
            else
            {
                MessageBox.Show("Thêm thành công!");
            }

            LoadData();
        }

        private void dgv_KTKL_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string maKTKL = dgv_KTKL.Rows[dgv_KTKL.CurrentCell.RowIndex].Cells[0].Value.ToString();

            try
            {
                KTKLDTO ktkl = new KTKLDTO();
                ktkl = _KTKLBLL.layKTKL_TheoMaKTKL(maKTKL);

                txb_maKTKL.Text = ktkl.MaKTKL;
                cb_hinhThuc.Items.Add(ktkl.HinhThuc);
                cb_hinhThuc.Text = ktkl.HinhThuc;
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
