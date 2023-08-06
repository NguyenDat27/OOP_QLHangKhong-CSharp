using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDichVuHangKhong
{
    public class LichBay
    {
        // Automatic Properties
        public string maChuyenBay { get; set; } // Primary Key = Foreign Key
        public DateTime ngayDi { get; set; }    // Primary Key
        public int soHieu { get; set; }      // Foreign Key
        public string maLoai { get; set; }      // Foreign Key

        // Constructor
        public LichBay() { }
        public LichBay(DateTime ngayDi, string maChuyenBay, int soHieu, string maLoai,
            ChuyenBay chuyenbay, MayBay maybay)
        {
            this.ngayDi = ngayDi;
            this.maChuyenBay = maChuyenBay;
            this.soHieu = soHieu;
            this.maLoai = maLoai;
            this.chuyenbay = chuyenbay;
            this.maybay = maybay;
        }
        public LichBay(LichBay lb)
        {
            this.ngayDi = lb.ngayDi;
            this.maChuyenBay = lb.maChuyenBay;
            this.soHieu = lb.soHieu;
            this.maLoai = lb.maLoai;
            this.chuyenbay = lb.chuyenbay;
            this.maybay = lb.maybay;
        }

        // related = singular
        public ChuyenBay chuyenbay { get; set; }
        public MayBay maybay { get; set; }
    }
}
