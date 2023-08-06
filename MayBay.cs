using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDichVuHangKhong
{
    public class MayBay
    {
        // Automatic properties
        public int soHieu { get; set; } // primary key
        public string maLoai { get; set; } // primary key = foreign key

        // constructor
        public MayBay() { }
        public MayBay(MayBay MB)
        {
            this.soHieu = MB.soHieu;
            this.maLoai = MB.maLoai;
            this.loaimaybay = MB.loaimaybay;
            this.lichbay = MB.lichbay;
        }
        public MayBay(int soHieu, string maLoai, LoaiMayBay loaimaybay, ICollection<LichBay> lichbay)
        {
            this.soHieu = soHieu;
            this.maLoai = maLoai;
            this.loaimaybay = loaimaybay;
            this.lichbay = lichbay;
        }
        // related = singular 
        public LoaiMayBay loaimaybay { get; set; }
        // related = plural
        public ICollection<LichBay> lichbay { get; set; }
    }
}
