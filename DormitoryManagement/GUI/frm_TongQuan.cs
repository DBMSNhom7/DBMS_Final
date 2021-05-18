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
        private int iTongSoToa = 0, sTongSoToa = 1;
        private int iTongSoPhong = 0, sTongSoPhong = 1;
        private int iSoPhongConTrong = 0, sSoPhongConTrong = 1;
        private int iTongSoSinhVien = 0, sTongSoSinhVien = 1;
        private int iChoOConTrong = 0, sChoOConTrong = 1;

        private int tongSoToa = 0;
        private int tongSoPhong = 0;
        private int soPhongConTrong = 0;
        private int tongSoSinhVien = 0;
        private int choOConTrong = 0;

        private SinhVienBLL _sinhVienBLL = new SinhVienBLL();
        private ToaBLL _toaBLL = new ToaBLL();
        private PhongBLL _phongBLL = new PhongBLL();

        public frm_TongQuan()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            iTongSoToa = 0;
            iTongSoPhong = 0;
            iSoPhongConTrong = 0;
            iTongSoSinhVien = 0;
            iChoOConTrong = 0;

            //progressbarSucChua.Maximum = soPhongSanCo * 4; // giả thử phòng có 4 giường
            //progressbarTyLeThanhToanHopDong.Maximum = tongSoHopDong;
            //progressbarTyLeThanhToanDienNuoc.Maximum = tongSoHoaDonDienNuoc;
            //progressbarPhongDaDung.Percentage = (int)((soPhongDaDung * 1.0f / soPhongSanCo) * 100);
            tongSoToa = _toaBLL.layTongSoToa();
            tongSoPhong = _phongBLL.layTongSoPhong();
            soPhongConTrong = _phongBLL.laySoPhongConTrong();
            tongSoSinhVien = _sinhVienBLL.layTongSoSinhVien();
            choOConTrong = _phongBLL.layTongSucChua() - tongSoSinhVien;

            sTongSoToa = (int)tongSoToa / 10;
            sTongSoPhong = (int)tongSoPhong / 10;
            sSoPhongConTrong = (int)soPhongConTrong / 10;
            sTongSoSinhVien = (int)tongSoSinhVien / 10;
            sChoOConTrong = (int)choOConTrong / 10;

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
            if (iTongSoToa <= tongSoToa)
            {
                if (tongSoToa - iTongSoToa < 10)
                {
                    lb_tongSoToa.Text = iTongSoToa.ToString();
                    iTongSoToa++;
                }
                else
                {
                    lb_tongSoToa.Text = iTongSoToa.ToString();
                    iTongSoToa += sTongSoToa;
                }
            }

            if (iTongSoPhong <= tongSoPhong)
            {
                if (tongSoPhong - iTongSoPhong < 10)
                {
                    lb_tongSoPhong.Text = iTongSoPhong.ToString();
                    iTongSoPhong++;
                }
                else
                {
                    lb_tongSoPhong.Text = iTongSoPhong.ToString();
                    iTongSoPhong += sTongSoPhong;
                }
            }



            if (iSoPhongConTrong <= soPhongConTrong)
            {
                if (soPhongConTrong - iSoPhongConTrong < 10)
                {
                    lb_phongConTrong.Text = iSoPhongConTrong.ToString();
                    iSoPhongConTrong++;
                }
                else
                {
                    lb_phongConTrong.Text = iSoPhongConTrong.ToString();
                    iSoPhongConTrong += sSoPhongConTrong;
                }
            }

            if (iTongSoSinhVien <= tongSoSinhVien)
            {
                if (tongSoSinhVien - iTongSoSinhVien < 10)
                {
                    lb_soSVDangO.Text = iTongSoSinhVien.ToString();
                    iTongSoSinhVien++;
                }
                else
                {
                    lb_soSVDangO.Text = iTongSoSinhVien.ToString();
                    iTongSoSinhVien += sTongSoSinhVien;
                }
            }

            if (iChoOConTrong <= choOConTrong)
            {
                if (choOConTrong - iChoOConTrong < 10)
                {
                    lb_choOConTrong.Text = iChoOConTrong.ToString();
                    iChoOConTrong++;
                }
                else
                {
                    lb_choOConTrong.Text = iChoOConTrong.ToString();
                    iChoOConTrong += sChoOConTrong;
                }
            }

            //// sức chứa hiện tại = số giường sẵn có : số hợp đồng
            //if (progressbarSucChua.Value <= tongSoHopDong) progressbarSucChua.Value += 1;

            //// Tổng số khu
            //if (iSoKhu <= tongSoKhu) { labelTongSoKhu.Text = iSoKhu.ToString(); iSoKhu += 1; }

            //// Số phòng sẵn có
            //if (iSoPhongSanCo <= soPhongSanCo) { textboxTongSoPhongSanCo.Text = iSoPhongSanCo.ToString(); iSoPhongSanCo += 1; }

            //// Tổng số hợp đồng
            //if (iHopDong <= tongSoHopDong) { labelTongSoHopDong.Text = iHopDong.ToString(); iHopDong += 1; }

            // Tổng số sinh viên

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
