using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDichVuHangKhong
{
    public enum Loai2
    {
        Nuoc_Uong_Co_Gas,
        Nuoc_Uong_Khong_Gas,
        Nuoc_Ep,
        Nuoc_Khoang,
    }
    public class LoaiThucUong
    {
        // Automatic properties
        public Loai2 LoaiTU { get; set; } // Primary Key
        public int MIN2 { get; set; }
        public int MAX2 { get; set; }
        // constructor
        public LoaiThucUong() { }
        public LoaiThucUong(LoaiThucUong LTU)
        {
            this.LoaiTU = LTU.LoaiTU;
            this.MIN2 = LTU.MIN2;
            this.MAX2 = LTU.MAX2;
            this.dsTU_LTU = LTU.dsTU_LTU;
        }
        public LoaiThucUong(Loai2 LoaiTU, int MIN2, int MAX2,
            ICollection<ThucUong> dsTU_LTU)
        {
            this.LoaiTU = LoaiTU;
            this.MIN2 = MIN2;
            this.MAX2 = MAX2;
            this.dsTU_LTU = dsTU_LTU;
        }
        // related = plural
        public ICollection<ThucUong> dsTU_LTU { get; set; }
    }
}
