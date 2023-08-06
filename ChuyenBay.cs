using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDichVuHangKhong
{
    public class ChuyenBay
    {
        // Automatic Properties
        public string maChuyenBay { get; set; } // Primary Key
        public string sanBayDi { get; set; }
        public string gioDi { get; set; }
        public string sanBayDen { get; set; }
        public string gioDen { get; set; }

        // Constructor
        public ChuyenBay() { }
        public ChuyenBay(string maChuyenBay, string sanBayDi, string sanBayDen,
            string gioDi, string gioDen, ICollection<LichBay> dslichbay_chuyenbay)
        {
            this.maChuyenBay = maChuyenBay;
            this.sanBayDi = sanBayDi;
            this.sanBayDen = sanBayDen;
            this.gioDi = gioDi;
            this.gioDen = gioDen;
            this.dslichbay_chuyenbay = dslichbay_chuyenbay;
        }
        public ChuyenBay(ChuyenBay cb)
        {
            this.maChuyenBay = cb.maChuyenBay;
            this.sanBayDi = cb.sanBayDi;
            this.sanBayDen = cb.sanBayDen;
            this.gioDi = cb.gioDi;
            this.gioDen = cb.gioDen;
            this.dslichbay_chuyenbay = cb.dslichbay_chuyenbay;
        }

        // related = plural
        public ICollection<LichBay> dslichbay_chuyenbay { get; set; }
    }
}
