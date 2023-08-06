using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDichVuHangKhong
{
    public class KhaNang
    {
        // Automatic properties
        public string maNV { get; set; } // primary key = Foreign Key
        public string maLoai { get; set; } // primary key = Foreign Key

        // constructor
        public KhaNang(string maNV, string maLoai, LoaiMayBay loaimaybay, NhanVien nhanvien)
        {
            this.maLoai = maLoai;
            this.maNV = maNV;
            this.nhanvien = nhanvien;
            this.loaimaybay = loaimaybay;
        }
        // related = singular 
        public NhanVien nhanvien { get; set; }
        public LoaiMayBay loaimaybay { get; set; }
    }
}
