using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDichVuHangKhong
{
    public class HanhLy
    {
        // Automatic properties
        public string MaHL { get; set; } // Primary Key
        public double TrongLuong { get; set; }
        public string MKH { get; set; } // Foreign Key
        public string MaLoaiHL { get; set; } // Foreign Key
        // constructor
        public HanhLy() { }
        public HanhLy(HanhLy HL)
        {
            this.MaHL = HL.MaHL; 
            this.TrongLuong = HL.TrongLuong;
            this.MKH = HL.MKH;
            this.MaLoaiHL = HL.MaLoaiHL;
            this.KH_HL = HL.KH_HL;
            this.LHL_HL = LHL_HL;
        }
        public HanhLy(string MaHL, double TrongLuong, string MKH, string MaLoaiHL,
                        KhachHang KH_HL, LoaiHanhLy LHL_HL)
        {
            this.MaHL = MaHL;
            this.TrongLuong = TrongLuong;
            this.MKH = MKH;
            this.MaLoaiHL = MaLoaiHL;
            this.KH_HL = KH_HL;
            this.LHL_HL = LHL_HL;
        }
        // related = singular
        public KhachHang KH_HL { get; set; }    
        public LoaiHanhLy LHL_HL { get; set; }
    }
}
