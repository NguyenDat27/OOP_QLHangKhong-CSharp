using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDichVuHangKhong
{
    public class KhachHang
    {
        // Automatic properties
        public string maKH { get; set; }
        public string tenKH { get; set; }
        public string diaChi { get; set; }
        public string soDienThoai { get; set; }
        // Constructor
        public KhachHang() { }
        public KhachHang(KhachHang KH)
        {
            this.maKH = KH.maKH;
            this.tenKH = KH.tenKH;
            this.diaChi = KH.diaChi;
            this.soDienThoai = KH.soDienThoai;
            this.ds_hanhly = KH.ds_hanhly;
        }
        public KhachHang(string maKH, string tenKH, string diaChi, string soDienThoai,
           ICollection<HanhLy> ds_hanhly)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.ds_hanhly = ds_hanhly;
        }
        // related = plural
        public ICollection<HanhLy> ds_hanhly { get; set; }
    }
}
