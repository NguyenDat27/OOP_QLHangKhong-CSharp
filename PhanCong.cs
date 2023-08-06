using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDichVuHangKhong
{
    public class PhanCong
    {
        // Automatic Properties
        public string maCB { get; set; }
        public DateTime ngayDi { get; set; }
        public string maNV { get; set; }

        // Constructor
        public PhanCong(string maNV, DateTime ngayDi, string maCB, LichBay lichbay, NhanVien nhanvien)
        {
            this.maCB = maCB;
            this.maNV = maNV;
            this.ngayDi = ngayDi;
            this.lichbay = lichbay;
            this.nhanvien = nhanvien;
        }

        // related = singular
        public LichBay lichbay { get; set; }
        public NhanVien nhanvien { get; set; }
    }
}
