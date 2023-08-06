using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDichVuHangKhong
{
    public class ThucUong
    {
        // Automatic properties
        public string TenThucUong { get; set; } // Primary Key
        public int DonGia { get; set; }
        public Loai2 LoaiTU { get; set; } // Foreign Key
        // constructor
        public ThucUong() { }
        public ThucUong(ThucUong TU)
        {
            this.TenThucUong = TU.TenThucUong;
            this.DonGia = TU.DonGia;
            this.LoaiTU = TU.LoaiTU;
            this.LTU_TU = LTU_TU;
        }
        public ThucUong(string TenThucUong, int DonGia, Loai2 LoaiTU, LoaiThucUong LTU_TU)
        {
            this.TenThucUong = TenThucUong;
            this.DonGia = DonGia;
            this.LoaiTU = LoaiTU;
            this.LTU_TU = LTU_TU;
        }
        // related = singular
        public LoaiThucUong LTU_TU { get; set; }
    }
}
