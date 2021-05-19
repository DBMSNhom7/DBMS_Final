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
        private int iTinhTrang = 0;

        private int tongSoToa = 0;
        private int tongSoPhong = 0;
        private int soPhongConTrong = 0;
        private int tongSoSinhVien = 0;
        private int choOConTrong = 0;
        private int tinhTrang_Value = 0;

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
            iTinhTrang = 0;

            tongSoToa = _toaBLL.layTongSoToa();
            tongSoPhong = _phongBLL.layTongSoPhong();
            soPhongConTrong = _phongBLL.laySoPhongConTrong();
            tongSoSinhVien = _sinhVienBLL.layTongSoSinhVien();
            choOConTrong = _phongBLL.layTongSucChua() - tongSoSinhVien;

            pgb_tinhTrangKTX.Minimum = 0;
            pgb_tinhTrangKTX.Maximum = 100;
            tinhTrang_Value = (int)(((float)tongSoSinhVien / (tongSoSinhVien + choOConTrong)) * 100);

            sTongSoToa = (int)tongSoToa / 10;
            sTongSoPhong = (int)tongSoPhong / 10;
            sSoPhongConTrong = (int)soPhongConTrong / 10;
            sTongSoSinhVien = (int)tongSoSinhVien / 10;
            sChoOConTrong = (int)choOConTrong / 10;

            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (iTongSoToa <= tongSoToa)
            {
                lb_tongSoToa.Text = iTongSoToa.ToString();
                if (tongSoToa - iTongSoToa < 10) iTongSoToa++;
                else iTongSoToa += sTongSoToa;
            }

            if (iTongSoPhong <= tongSoPhong)
            {
                lb_tongSoPhong.Text = iTongSoPhong.ToString();
                if (tongSoPhong - iTongSoPhong < 10) iTongSoPhong++;
                else iTongSoPhong += sTongSoPhong;
            }

            if (iTinhTrang <= tinhTrang_Value) pgb_tinhTrangKTX.Value = iTinhTrang += 2;

            if (iSoPhongConTrong <= soPhongConTrong)
            {
                lb_phongConTrong.Text = iSoPhongConTrong.ToString();
                if (soPhongConTrong - iSoPhongConTrong < 10) iSoPhongConTrong++;
                else iSoPhongConTrong += sSoPhongConTrong;
            }

            if (iTongSoSinhVien <= tongSoSinhVien)
            {
                lb_soSVDangO.Text = iTongSoSinhVien.ToString();
                if (tongSoSinhVien - iTongSoSinhVien < 10) iTongSoSinhVien++;
                else iTongSoSinhVien += sTongSoSinhVien;
            }

            if (iChoOConTrong <= choOConTrong)
            {
                lb_choOConTrong.Text = iChoOConTrong.ToString();
                if (choOConTrong - iChoOConTrong < 10) iChoOConTrong++;
                else iChoOConTrong += sChoOConTrong;
            }
        }

        private void Dashboard_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Dashboard_Load(null, null);
        }
    }
}
