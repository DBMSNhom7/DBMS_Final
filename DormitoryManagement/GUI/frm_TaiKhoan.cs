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
    public partial class frm_TaiKhoan : Form
    {
        private TaiKhoanBLL _taiKhoanBLL = new TaiKhoanBLL();
        private TaiKhoanDTO _taiKhoanDTO = new TaiKhoanDTO();
        private bool them = false;
        private bool sua = false;

        public frm_TaiKhoan()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                them = false;
                sua = false;

                txb_timKiem.ResetText();
                txb_tenTaiKhoan.ResetText();
                txb_matKhau.ResetText();
                cb_loaiQuyen.ResetText();
                txb_moTa.ResetText();

                lb_timKiem.Enabled = txb_timKiem.Enabled =
                    btn_timKiem.Enabled = txb_tenTaiKhoan.Enabled =
                    txb_moTa.Enabled = btn_them.Enabled =
                    btn_sua.Enabled = btn_xoa.Enabled =
                    btn_taiLai.Enabled = dgv_taiKhoan.Enabled = true;
                txb_matKhau.Enabled = cb_loaiQuyen.Enabled =
                    btn_luu.Enabled = btn_huy.Enabled = false;

                txb_tenTaiKhoan.ReadOnly = txb_moTa.ReadOnly = true;

                dgv_taiKhoan.DataSource = _taiKhoanBLL.layTaiKhoan_DGV();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("permission was denied"))
                    MessageBox.Show("Không có quyền dùng chức năng này!");
                else
                    MessageBox.Show(ex.Message);
            }
        }

        private void frm_TaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_taiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_taiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string tenTK = dgv_taiKhoan.Rows[dgv_taiKhoan.CurrentCell.RowIndex].Cells[0].Value.ToString();
                _taiKhoanDTO = _taiKhoanBLL.layTaiKhoan_TheoTenTK(tenTK);

                txb_tenTaiKhoan.Text = _taiKhoanDTO.TenTaiKhoan;
                txb_matKhau.Text = _taiKhoanDTO.MatKhau;
                cb_loaiQuyen.Text = _taiKhoanDTO.TenLoaiQuyen;
                txb_moTa.Text = _taiKhoanDTO.MoTa;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Object reference not set to an instance of an object"))
                    return;
                else
                    MessageBox.Show(ex.Message);
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            if (txb_timKiem.Text.Trim() != "")
            {
                try
                {
                    dgv_taiKhoan.DataSource =
                        _taiKhoanBLL.layTaiKhoan_TimKiem_DGV("%" + txb_timKiem.Text.Trim() + "%");
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("permission was denied"))
                        MessageBox.Show("Không có quyền dùng chức năng này!");
                    else
                        MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                lb_timKiem.Enabled = txb_timKiem.Enabled =
                    btn_timKiem.Enabled = btn_them.Enabled =
                    btn_sua.Enabled = btn_xoa.Enabled =
                    btn_taiLai.Enabled = dgv_taiKhoan.Enabled = false;

                txb_tenTaiKhoan.Enabled = txb_matKhau.Enabled =
                    cb_loaiQuyen.Enabled = txb_moTa.Enabled =
                    btn_luu.Enabled = btn_huy.Enabled = true;

                txb_tenTaiKhoan.ReadOnly = false;

                txb_timKiem.ResetText();
                txb_tenTaiKhoan.ResetText();
                txb_matKhau.ResetText();
                cb_loaiQuyen.Text = "Trưởng Tòa";
                txb_moTa.ResetText();

                DataTable dt = _taiKhoanBLL.layLoaiTK();
                cb_loaiQuyen.DataSource = dt;
                cb_loaiQuyen.DisplayMember = "TenQuyen";
                cb_loaiQuyen.ValueMember = "IDLoaiQuyen";
                txb_moTa.DataBindings.Clear();
                txb_moTa.DataBindings.Add("Text", dt, "MoTa");

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
                if (txb_tenTaiKhoan.Text.Trim() != "")
                {
                    lb_timKiem.Enabled = txb_timKiem.Enabled =
                        btn_timKiem.Enabled = txb_tenTaiKhoan.Enabled =
                        dgv_taiKhoan.Enabled = btn_them.Enabled =
                        btn_sua.Enabled = btn_xoa.Enabled =
                        btn_taiLai.Enabled = false;
                    txb_matKhau.Enabled = cb_loaiQuyen.Enabled =
                        txb_moTa.Enabled = btn_luu.Enabled =
                        btn_huy.Enabled = true;
                    txb_moTa.ReadOnly = true;

                    DataTable dt = _taiKhoanBLL.layLoaiTK();
                    cb_loaiQuyen.DataSource = dt;
                    cb_loaiQuyen.DisplayMember = "TenQuyen";
                    cb_loaiQuyen.ValueMember = "IDLoaiQuyen";
                    txb_moTa.DataBindings.Clear();
                    txb_moTa.DataBindings.Add("Text", dt, "MoTa");

                    sua = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txb_tenTaiKhoan.Text.Trim() == "" || txb_matKhau.Text.Trim() == "" ||
                cb_loaiQuyen.Text.Trim() == "" || txb_moTa.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            if (them)
            {
                string err = "";

                _taiKhoanDTO = new TaiKhoanDTO();
                _taiKhoanDTO.TenTaiKhoan = txb_tenTaiKhoan.Text;
                _taiKhoanDTO.MatKhau = txb_matKhau.Text;
                _taiKhoanDTO.IDLoaiQuyen = cb_loaiQuyen.SelectedValue.ToString();

                if (!_taiKhoanBLL.themTaiKhoan(_taiKhoanDTO, ref err))
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
                _taiKhoanDTO = new TaiKhoanDTO();
                _taiKhoanDTO.TenTaiKhoan = txb_tenTaiKhoan.Text;
                _taiKhoanDTO.MatKhau = txb_matKhau.Text;
                _taiKhoanDTO.IDLoaiQuyen = cb_loaiQuyen.SelectedValue.ToString();

                if (!_taiKhoanBLL.suaTaiKhoan_TheoTenTK(_taiKhoanDTO, ref err))
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txb_tenTaiKhoan.Text.Trim() != "")
            {
                DialogResult traloi =
                    MessageBox.Show("Bạn muốn xóa " + txb_tenTaiKhoan.Text, "", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (traloi == DialogResult.OK)
                {
                    string err = "";

                    if (!_taiKhoanBLL.xoaTaiKhoan_TheoTenTK(txb_tenTaiKhoan.Text, ref err))
                    {
                        MessageBox.Show(err);
                    }

                    LoadData();
                }
            }
        }

        private void buttonXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgv_taiKhoan.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgv_taiKhoan.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgv_taiKhoan.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgv_taiKhoan.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_taiKhoan.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgv_taiKhoan.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
