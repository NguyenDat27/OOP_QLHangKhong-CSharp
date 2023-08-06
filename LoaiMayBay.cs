using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDichVuHangKhong
{
    public class LoaiMayBay
    {
        // Automatic properties
        public string maLoai { get; set; } // primary key
        public string hangSX { get; set; }

        // constructor
        public LoaiMayBay() { }
        public LoaiMayBay(LoaiMayBay lm)
        {
            this.maLoai = lm.maLoai;
            this.hangSX = lm.hangSX;
            this.ds_maybay = lm.ds_maybay;
        }
        public LoaiMayBay(string maLoai, string hangSX, ICollection<MayBay> ds_maybay)
        {
            this.maLoai = maLoai;
            this.hangSX = hangSX;
            this.ds_maybay = ds_maybay;
        }
        // related = plural
        public ICollection<MayBay> ds_maybay { get; set; }
    }
}
