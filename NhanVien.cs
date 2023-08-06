using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDichVuHangKhong
{
    public class NhanVien
    {
        // Automatic Properties
        public string maNV { get; set; } // Primary Key
        public string tenNV { get; set; }
        public string diaChi { get; set; }
        public double Luong { get; set; }
        public string soDT { get; set; }
        public int loaiNV { get; set; }

        // Constructor
        public NhanVien() { }
        public NhanVien(string maNV, string tenNV, string diaChi, double Luong,
            string soDT, int loaiNV)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.diaChi = diaChi;
            this.Luong = Luong;
            this.soDT = soDT;
            this.loaiNV = loaiNV;
        }
        public NhanVien(NhanVien nv)
        {
            this.maNV = nv.maNV;
            this.tenNV = nv.tenNV;
            this.diaChi = nv.diaChi;
            this.Luong = nv.Luong;
            this.soDT = nv.soDT;
            this.loaiNV = nv.loaiNV;
        }
    }
}
