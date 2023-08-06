using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDichVuHangKhong
{
    public class ThucDon
    {
        // Automatic properties
        public string maThucDon { get; set; } // Primary Key
        public int gia { get; set; }
        public string maKhachHang { get; set; } // Foreign Key
        // constructor
        public ThucDon() { }
        public ThucDon(ThucDon DC)
        {
            this.maThucDon = DC.maThucDon;
            this.gia = DC.gia;
            this.maKhachHang = DC.maKhachHang;
            this.khachhang = DC.khachhang;
        }
        public ThucDon(string maThucDon, int gia, string maKhachHang, KhachHang khachhang)
        {
            this.maThucDon = maThucDon;
            this.gia = gia;
            this.maKhachHang = maKhachHang;
            this.khachhang = khachhang;
        }
        // related = singular
        public KhachHang khachhang { get; set; }
    }
}
