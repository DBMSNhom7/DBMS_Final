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
    public partial class frm_Phong : Form
    {
        private PhongBLL _phongBLL;
        private PhongDTO _phongDTO;

        public frm_Phong()
        {
            InitializeComponent();
            _phongBLL = new PhongBLL();
        }

        private void LoadData()
        {
            try
            {
                lb_timKiem.Enabled = txb_timKiem.Enabled =
                    btn_timKiem.Enabled = txb_toa.Enabled =
                    txb_phong.Enabled = txb_sucChua.Enabled =
                    txb_SVDangO.Enabled = btn_sua.Enabled =
                    btn_taiLai.Enabled = dgv_phong.Enabled =
                    btn_SVDangO.Enabled = btn_HoaDonDienNuoc.Enabled = true;

                cb_loaiPhong.Enabled = btn_luu.Enabled =
                    btn_huy.Enabled = false;

                txb_toa.ReadOnly = txb_phong.ReadOnly =
                    txb_sucChua.ReadOnly = txb_SVDangO.ReadOnly = true;

                txb_timKiem.ResetText();
                txb_toa.ResetText();
                txb_phong.ResetText();
                cb_loaiPhong.ResetText();
                txb_sucChua.ResetText();
                txb_SVDangO.ResetText();

                dgv_phong.DataSource = _phongBLL.layPhong_DGV();

                DataTable dtLoaiPhong = _phongBLL.layLoaiPhong();
                cb_loaiPhong.DataSource = dtLoaiPhong;
                cb_loaiPhong.DisplayMember = "TenLoai";
                cb_loaiPhong.ValueMember = "MaLoai";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_Phong2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_taiLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private void btn_HoaDonDienNuoc_Click(object sender, EventArgs e)
        {
            if (txb_phong.Text.Trim() != "")
            {
                frm_HoaDonDienNuoc_TheoPhong frmhddn =
                    new frm_HoaDonDienNuoc_TheoPhong(txb_phong.Text);
                frmhddn.ShowDialog();
            }
        }

        private void btn_SVDangO_Click(object sender, EventArgs e)
        {
            if (txb_phong.Text.Trim() != "")
            {
                frm_SinhVien_TheoPhong frmsv =
                    new frm_SinhVien_TheoPhong(txb_phong.Text);
                frmsv.ShowDialog();
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            if (txb_timKiem.Text.Trim() != "")
            {
                dgv_phong.DataSource =
                    _phongBLL.layPhong_TimKiem_DGV("%" + txb_timKiem.Text.Trim() + "%");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txb_phong.Text.Trim() != "")
            {
                lb_timKiem.Enabled = txb_timKiem.Enabled =
                    btn_timKiem.Enabled = txb_toa.Enabled =
                    txb_phong.Enabled = txb_SVDangO.Enabled =
                    btn_sua.Enabled = btn_taiLai.Enabled =
                    dgv_phong.Enabled = btn_SVDangO.Enabled =
                    btn_HoaDonDienNuoc.Enabled = false;

                cb_loaiPhong.Enabled = txb_sucChua.Enabled =
                    btn_luu.Enabled = btn_huy.Enabled = true;

                txb_sucChua.ReadOnly = false;

                cb_loaiPhong.SelectedValue = _phongDTO.MaLoai;
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (cb_loaiPhong.Text.Trim() == "" ||
                txb_sucChua.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            int temp = 0;
            if (!int.TryParse(txb_sucChua.Text, out temp) || temp < 0)
            {
                MessageBox.Show("Sức chứa không hợp lệ!");
                return;
            }

            string err = "";

            _phongDTO = new PhongDTO();
            _phongDTO.MaPhong = txb_phong.Text;
            _phongDTO.MaLoai = cb_loaiPhong.SelectedValue.ToString();
            _phongDTO.SucChuaSV = txb_sucChua.Text;

            if (!_phongBLL.suaPhong(_phongDTO, ref err))
            {
                if (err.Contains("permission was denied"))
                    MessageBox.Show("Không có quyền dùng chức năng này!");
                else
                    MessageBox.Show(err);
            }
            else
            {
                MessageBox.Show("Sửa thành công!");
                LoadData();
            }
        }

        private void dgv_phong_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string maPhong = dgv_phong.Rows[dgv_phong.CurrentCell.RowIndex].Cells[0].Value.ToString();

                _phongDTO = _phongBLL.layPhong_TheoMaPhong(maPhong);

                txb_toa.Text = _phongDTO.Toa;
                txb_phong.Text = _phongDTO.MaPhong;
                cb_loaiPhong.Text = _phongDTO.TenLoai;
                txb_sucChua.Text = _phongDTO.SucChuaSV;
                txb_SVDangO.Text = _phongDTO.SLDangO;
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
            if (dgv_phong.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgv_phong.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgv_phong.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgv_phong.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_phong.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgv_phong.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}