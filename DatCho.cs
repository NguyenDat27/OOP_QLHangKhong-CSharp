using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDichVuHangKhong
{
    public class DatCho
    {
        // Automatic properties
        public string maKhachHang { get; set; }
        public DateTime ngayDi { get; set; }
        public string maChuyenBay { get; set; }
        // constructor
        public DatCho(string maKhachHang, DateTime ngayDi, string maChuyenBay, LichBay lichbay, KhachHang khachhang)
        {
            this.maChuyenBay = maChuyenBay;
            this.maKhachHang = maKhachHang;
            this.ngayDi = ngayDi;
            this.lichbay = lichbay;
            this.khachhang = khachhang;
        }
        // related = singular
        public LichBay lichbay { get; set; }
        public KhachHang khachhang { get; set; }
    }
}
