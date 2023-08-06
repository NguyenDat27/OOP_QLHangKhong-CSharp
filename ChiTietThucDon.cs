using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDichVuHangKhong
{
    public class ChiTietThucDon
    {
        // Automatic properties
        public string maThucDon { get; set; } // Primary Key
        public string tenMonAn { get; set; } // Primary Key
        public string tenThucUong { get; set; } // Primary Key
        public int soLuongMonAn { get; set; }
        public int thanhTienMA { get; set; }
        public int soLuongThucUong { get; set; }
        public int thanhTienTU { get; set; }
        // constructor
        public ChiTietThucDon() { }
        public ChiTietThucDon(ChiTietThucDon CTTD)
        {
            this.maThucDon = CTTD.maThucDon;
            this.tenMonAn = CTTD.tenMonAn;
            this.soLuongMonAn = CTTD.soLuongMonAn;
            this.thanhTienMA = CTTD.thanhTienMA;
            this.tenThucUong = CTTD.tenThucUong;
            this.soLuongThucUong = CTTD.soLuongThucUong;
            this.thanhTienTU = CTTD.thanhTienTU;
            this.thucdon = CTTD.thucdon;
            this.monan = CTTD.monan;
            this.thucuong = CTTD.thucuong;
        }
        public ChiTietThucDon(string maThucDon, string tenMonAn, int soLuongMonAn, int thanhTienMA,
            string tenThucUong, int soLuongThucUong, int thanhTienTU,
            ThucDon thucdon, MonAn monan, ThucUong thucuong)
        {
            this.maThucDon = maThucDon;
            this.tenMonAn = tenMonAn;
            this.soLuongMonAn = soLuongMonAn;
            this.thanhTienMA = thanhTienMA;
            this.tenThucUong = tenThucUong;
            this.soLuongThucUong = soLuongThucUong;
            this.thanhTienTU = thanhTienTU;
            this.thucdon = thucdon;
            this.monan = monan;
            this.thucuong = thucuong;
        }
        // related = singular
        public ThucDon thucdon { get; set; }
        public MonAn monan { get; set; }
        public ThucUong thucuong { get; set; }
    }
}
