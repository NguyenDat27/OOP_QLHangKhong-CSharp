using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDichVuHangKhong
{
    public class MonAn
    {
        // Automatic properties
        public string TenMonAn { get; set; } // Primary Key
        public int DonGia { get; set; }
        public Loai1 LoaiMA { get; set; } // Foreign Key
        // constructor
        public MonAn() { }
        public MonAn(MonAn MA)
        {
            this.TenMonAn = MA.TenMonAn;
            this.DonGia = MA.DonGia;
            this.LoaiMA = MA.LoaiMA;
            this.LMA_MA = MA.LMA_MA;
        }
        public MonAn(string TenMonAn, int DonGia, Loai1 LoaiMA, LoaiMonAn LMA_MA)
        {
            this.TenMonAn = TenMonAn;
            this.DonGia = DonGia;
            this.LoaiMA = LoaiMA;
            this.LMA_MA = LMA_MA;
        }
        // related = singular
        public LoaiMonAn LMA_MA { get; set; }
    }
}
