using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDichVuHangKhong
{
    public enum Loai1
    {
        Trang_Mieng,
        Thuc_An_Nhanh,
        Do_Man,
        Do_Chay
    }
    public class LoaiMonAn
    {
        // Automatic properties
        public Loai1 LoaiMA { get; set; } // Primary Key
        public int MIN1 { get; set; }
        public int MAX1 { get; set; }
        // constructor
        public LoaiMonAn() { }
        public LoaiMonAn(LoaiMonAn LMA)
        {
            this.LoaiMA = LMA.LoaiMA;
            this.MIN1 = LMA.MIN1;
            this.MAX1 = LMA.MAX1;
            this.dsMA_LMA = LMA.dsMA_LMA;
        }
        public LoaiMonAn(Loai1 LoaiMA, int MIN1, int MAX1,
            ICollection<MonAn> dsMA_LMA)
        {
            this.LoaiMA = LoaiMA;
            this.MIN1 = MIN1;
            this.MAX1 = MAX1;
            this.dsMA_LMA = dsMA_LMA;
        }
        // related = plural
        public ICollection<MonAn> dsMA_LMA { get; set; }
    }
}
