using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDichVuHangKhong
{
    public enum TenLoaiHanhLy
    {
        Xach_Tay,
        Ky_Gui
    }
    public class LoaiHanhLy
    {
        // Automatic properties
        public string MaLoaiHL { get; set; } // Primary Key
        public TenLoaiHanhLy TenLoaiHL { get; set; }
        // constructor
        public LoaiHanhLy() { }
        public LoaiHanhLy(LoaiHanhLy LHL)
        {
            this.MaLoaiHL = LHL.MaLoaiHL;
            this.TenLoaiHL = LHL.TenLoaiHL;
            this.dsHL_LHL = LHL.dsHL_LHL;
        }
        public LoaiHanhLy(string MaLoaiHL, TenLoaiHanhLy TenLoaiHL, ICollection<HanhLy> dsHL_LHL)
        {
            this.MaLoaiHL = MaLoaiHL;
            this.TenLoaiHL = TenLoaiHL;
            this.dsHL_LHL = dsHL_LHL;
        }
        // Lien ket plural
        public ICollection<HanhLy> dsHL_LHL { get; set; }
    }
}
