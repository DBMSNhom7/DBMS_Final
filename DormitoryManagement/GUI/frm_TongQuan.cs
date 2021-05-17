using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class frm_TongQuan : Form
    {
        int iSinhVien = 0;
        int iHopDong = 0;
        int iSoKhu = 0;
        int iSoPhongSanCo = 0;
        int iSoPhongConTrong = 0;
        int tongSoSV = 0;
        private SinhVienBLL _sinhVienBLL = new SinhVienBLL();

        public frm_TongQuan()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            iSinhVien = 0;
            iHopDong = 0;
            iSoPhongSanCo = 0;

            //progressbarSucChua.Maximum = soPhongSanCo * 4; // giả thử phòng có 4 giường
            //progressbarTyLeThanhToanHopDong.Maximum = tongSoHopDong;
            //progressbarTyLeThanhToanDienNuoc.Maximum = tongSoHoaDonDienNuoc;
            //progressbarPhongDaDung.Percentage = (int)((soPhongDaDung * 1.0f / soPhongSanCo) * 100);
            tongSoSV = _sinhVienBLL.layTongSoSinhVien();

            timer.Enabled = true;
        }

        //public static int tongSoKhu = busKhu.TongSoKhu();
        //public static int soPhongSanCo = busPhong.SoPhongSanCo();
        //public static int tongSoHopDong = busHopDong.TongSoHopDong();
        //public static int tongSoHopDongDaThanhToan = busHopDong.TongSoHopDongDaThanhToan();
        //public static int tongSoHoaDonDienNuocDaThanhToan = busDienNuoc.TongSoHoaDonDienNuocDaThanhToan();
        //public static int tongSoHoaDonDienNuoc = busDienNuoc.TongSoHoaDonDienNuoc();
        //public static int soPhongDaDung = busPhong.SoPhongDaDung();
        //public static int soPhongConTrong = soPhongSanCo - soPhongDaDung;
        //public static Tuple<int, int, int, int, int> soSinhVienTheoNganh = busSinhVien.SoSinhVienTheoNganh

        private void timer_Tick(object sender, EventArgs e)
        {
            //// sức chứa hiện tại = số giường sẵn có : số hợp đồng
            //if (progressbarSucChua.Value <= tongSoHopDong) progressbarSucChua.Value += 1;

            //// Tổng số khu
            //if (iSoKhu <= tongSoKhu) { labelTongSoKhu.Text = iSoKhu.ToString(); iSoKhu += 1; }

            //// Số phòng sẵn có
            //if (iSoPhongSanCo <= soPhongSanCo) { textboxTongSoPhongSanCo.Text = iSoPhongSanCo.ToString(); iSoPhongSanCo += 1; }

            //// Tổng số hợp đồng
            //if (iHopDong <= tongSoHopDong) { labelTongSoHopDong.Text = iHopDong.ToString(); iHopDong += 1; }

            // Tổng số sinh viên
            if (iSinhVien <= tongSoSV) { lb_soSVDangO.Text = iSinhVien.ToString(); iSinhVien += 1; }

            // Tỷ lệ thanh toán hợp đồng
            //if (progressbarTyLeThanhToanHopDong.Value <= tongSoHopDongDaThanhToan) { progressbarTyLeThanhToanHopDong.Value += 1; }

            //// Tỷ lệ thanh toán điện nước
            //if (progressbarTyLeThanhToanDienNuoc.Value <= tongSoHoaDonDienNuocDaThanhToan) { progressbarTyLeThanhToanDienNuoc.Value += 1; }

            //// Số phòng còn trống
            //if (iSoPhongConTrong <= soPhongConTrong) { labelSoPhongConTrong.Text = iSoPhongConTrong.ToString(); iSoPhongConTrong += 1; }
        }

        private void Dashboard_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Dashboard_Load(null, null);
        }
    }
}
