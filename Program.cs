using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDichVuHangKhong
{
    class Program
    {
        //Tao Du Lieu
        public static List<NhanVien> dsNhanVien = new List<NhanVien>();
        public static List<LoaiMayBay> dsLoaiMayBay = new List<LoaiMayBay>();
        public static List<KhaNang> dsKhaNang = new List<KhaNang>();
        public static List<MayBay> dsMayBay = new List<MayBay>();
        public static List<ChuyenBay> dsChuyenBay = new List<ChuyenBay>();
        public static List<LichBay> dsLichBay = new List<LichBay>();
        public static List<PhanCong> dsPhanCong = new List<PhanCong>();
        public static List<KhachHang> dsKhachHang = new List<KhachHang>();
        public static List<DatCho> dsDatCho = new List<DatCho>();
        public static List<LoaiMonAn> dsLoaiMonAn = new List<LoaiMonAn>();
        public static List<MonAn> dsMonAn = new List<MonAn>();
        public static List<LoaiThucUong> dsLoaiThucUong = new List<LoaiThucUong>();
        public static List<ThucUong> dsThucUong = new List<ThucUong>();
        public static List<ThucDon> dsThucDon = new List<ThucDon>();
        public static List<ChiTietThucDon> dsChiTietThucDon = new List<ChiTietThucDon>();
        public static List<LoaiHanhLy> dsLoaiHanhLy = new List<LoaiHanhLy>();
        public static List<HanhLy> dsHanhLy = new List<HanhLy>();
        //Ham Tao Du Lieu
        public static void Taods_NhanVien()
        {
            dsNhanVien.Add(new NhanVien("1006", "Chi", "12/6 NguyenKim", 15000000,
                "8120022",0));
            dsNhanVien.Add(new NhanVien("1005", "Lan", "8 Dien Bien Phu", 10000000,
               "8121222",0));
            dsNhanVien.Add(new NhanVien("1001", "Diep", "36 Nguyen Van Cu", 10000000,
               "8650022", 1));
            dsNhanVien.Add(new NhanVien("1002", "Dao", "5 Truong Dinh", 10000000,
               "8120622", 1));
            dsNhanVien.Add(new NhanVien("1004", "Tai", "12 Nguyen Thai Hoc", 20000000,
               "8130022", 0));
            dsNhanVien.Add(new NhanVien("1003", "Nam", "16/2 Nguyen Truong To", 20000000,
                "8880022", 1));
            dsNhanVien.Add(new NhanVien("1007", "Quang", "390 Xa Lo Ha Noi", 20000000,
               "8129922", 0));
        }

        public static void Taods_LoaiMayBay()
        {
            dsLoaiMayBay.Add(new LoaiMayBay("A310", "Airbus", new List<MayBay>()));
            dsLoaiMayBay.Add(new LoaiMayBay("A320", "Airbus", new List<MayBay>()));
            dsLoaiMayBay.Add(new LoaiMayBay("A330", "Airbus", new List<MayBay>()));
            dsLoaiMayBay.Add(new LoaiMayBay("A340", "Airbus", new List<MayBay>()));
            dsLoaiMayBay.Add(new LoaiMayBay("B727", "Boeing", new List<MayBay>()));
            dsLoaiMayBay.Add(new LoaiMayBay("B747", "Boeing", new List<MayBay>()));
            dsLoaiMayBay.Add(new LoaiMayBay("B757", "Boeing", new List<MayBay>()));
            dsLoaiMayBay.Add(new LoaiMayBay("DC10", "MD", new List<MayBay>()));
            dsLoaiMayBay.Add(new LoaiMayBay("DC09", "MD", new List<MayBay>()));
        }
        public static void Taods_KhaNang()
        {
            dsKhaNang.Add(new KhaNang("1001", "B727", dsLoaiMayBay[4], dsNhanVien[2]));
            dsKhaNang.Add(new KhaNang("1001", "B747", dsLoaiMayBay[5], dsNhanVien[2]));
            dsKhaNang.Add(new KhaNang("1001", "DC10", dsLoaiMayBay[7], dsNhanVien[2]));
            dsKhaNang.Add(new KhaNang("1001", "DC09", dsLoaiMayBay[8], dsNhanVien[2]));
            dsKhaNang.Add(new KhaNang("1002", "A320", dsLoaiMayBay[1], dsNhanVien[3]));
            dsKhaNang.Add(new KhaNang("1002", "A340", dsLoaiMayBay[3], dsNhanVien[3]));
            dsKhaNang.Add(new KhaNang("1002", "B757", dsLoaiMayBay[6], dsNhanVien[3]));
            dsKhaNang.Add(new KhaNang("1002", "DC09", dsLoaiMayBay[8], dsNhanVien[3]));
            dsKhaNang.Add(new KhaNang("1003", "A310", dsLoaiMayBay[0], dsNhanVien[5]));
            dsKhaNang.Add(new KhaNang("1003", "DC09", dsLoaiMayBay[8], dsNhanVien[5]));
        }
        public static void Taods_MayBay()
        {
            dsMayBay.Add(new MayBay(10, "B747", dsLoaiMayBay[5], new List<LichBay>()));
            dsMayBay.Add(new MayBay(11, "B727", dsLoaiMayBay[4], new List<LichBay>()));
            dsMayBay.Add(new MayBay(13, "B727", dsLoaiMayBay[4], new List<LichBay>()));
            dsMayBay.Add(new MayBay(13, "B747", dsLoaiMayBay[5], new List<LichBay>()));
            dsMayBay.Add(new MayBay(21, "DC10", dsLoaiMayBay[7], new List<LichBay>()));
            dsMayBay.Add(new MayBay(21, "DC09", dsLoaiMayBay[8], new List<LichBay>()));
            dsMayBay.Add(new MayBay(22, "B757", dsLoaiMayBay[6], new List<LichBay>()));
            dsMayBay.Add(new MayBay(22, "DC09", dsLoaiMayBay[8], new List<LichBay>()));
            dsMayBay.Add(new MayBay(23, "DC09", dsLoaiMayBay[8], new List<LichBay>()));
            dsMayBay.Add(new MayBay(24, "DC09", dsLoaiMayBay[8], new List<LichBay>()));
            dsMayBay.Add(new MayBay(70, "A310", dsLoaiMayBay[0], new List<LichBay>()));
            dsMayBay.Add(new MayBay(80, "A310", dsLoaiMayBay[0], new List<LichBay>()));
            dsMayBay.Add(new MayBay(93, "B757", dsLoaiMayBay[6], new List<LichBay>()));
            //Them May Bay Theo Loai
            dsLoaiMayBay[5].ds_maybay.Add(dsMayBay[0]);
            dsLoaiMayBay[5].ds_maybay.Add(dsMayBay[3]);

            dsLoaiMayBay[4].ds_maybay.Add(dsMayBay[1]);
            dsLoaiMayBay[4].ds_maybay.Add(dsMayBay[2]);

            dsLoaiMayBay[7].ds_maybay.Add(dsMayBay[4]);

            dsLoaiMayBay[8].ds_maybay.Add(dsMayBay[5]);
            dsLoaiMayBay[8].ds_maybay.Add(dsMayBay[7]);
            dsLoaiMayBay[8].ds_maybay.Add(dsMayBay[8]);
            dsLoaiMayBay[8].ds_maybay.Add(dsMayBay[9]);

            dsLoaiMayBay[6].ds_maybay.Add(dsMayBay[6]);
            dsLoaiMayBay[6].ds_maybay.Add(dsMayBay[12]);

            dsLoaiMayBay[0].ds_maybay.Add(dsMayBay[11]);
            dsLoaiMayBay[0].ds_maybay.Add(dsMayBay[10]);
        }
        public static void Taods_ChuyenBay()
        {
            dsChuyenBay.Add(new ChuyenBay("100", "SLC", "BOS", "08:00", "17:59", new List<LichBay>())); // 0
            dsChuyenBay.Add(new ChuyenBay("112", "DCA", "DEN", "14:00", "18:07", new List<LichBay>())); // 1
            dsChuyenBay.Add(new ChuyenBay("121", "STL", "SLC", "07:00", "09:13", new List<LichBay>())); // 2
            dsChuyenBay.Add(new ChuyenBay("122", "STL", "YYV", "08:30", "10:19", new List<LichBay>())); // 3
            dsChuyenBay.Add(new ChuyenBay("206", "DFW", "STL", "09:00", "11:40", new List<LichBay>())); // 4
            dsChuyenBay.Add(new ChuyenBay("330", "JFK", "YYV", "16:00", "18:53", new List<LichBay>())); // 5
            dsChuyenBay.Add(new ChuyenBay("334", "ORD", "MIA", "12:00", "14:14", new List<LichBay>())); // 6
            dsChuyenBay.Add(new ChuyenBay("335", "MIA", "ORD", "15:00", "17:14", new List<LichBay>())); // 7
            dsChuyenBay.Add(new ChuyenBay("336", "ORD", "MIA", "18:00", "20:14", new List<LichBay>())); // 8
            dsChuyenBay.Add(new ChuyenBay("337", "MIA", "ORD", "20:30", "23:53", new List<LichBay>())); // 9
            dsChuyenBay.Add(new ChuyenBay("394", "DFW", "MIA", "19:00", "21:30", new List<LichBay>())); // 10
            dsChuyenBay.Add(new ChuyenBay("395", "MIA", "DFW", "21:00", "23:43", new List<LichBay>())); // 11
            dsChuyenBay.Add(new ChuyenBay("449", "CDG", "DEN", "10:00", "19:29", new List<LichBay>())); // 12
            dsChuyenBay.Add(new ChuyenBay("930", "YYV", "DCA", "13:00", "16:10", new List<LichBay>())); // 13
            dsChuyenBay.Add(new ChuyenBay("931", "DCA", "YYV", "17:00", "18:10", new List<LichBay>())); // 14
            dsChuyenBay.Add(new ChuyenBay("932", "DCA", "YYV", "18:00", "19:10", new List<LichBay>())); // 15
            dsChuyenBay.Add(new ChuyenBay("991", "BOS", "ORD", "17:00", "18:22", new List<LichBay>())); // 16
        }
        public static void Taods_LichBay()
        {
            dsLichBay.Add(new LichBay(new DateTime(2000, 01, 11), dsChuyenBay[0].maChuyenBay, // 0
                dsMayBay[11].soHieu, dsMayBay[11].maLoai, dsChuyenBay[0], dsMayBay[11]));
            dsLichBay.Add(new LichBay(new DateTime(2000, 01, 11), dsChuyenBay[1].maChuyenBay, // 1
                dsMayBay[4].soHieu, dsMayBay[4].maLoai, dsChuyenBay[1], dsMayBay[4]));
            dsLichBay.Add(new LichBay(new DateTime(2000, 01, 11), dsChuyenBay[4].maChuyenBay, // 2
                dsMayBay[7].soHieu, dsMayBay[7].maLoai, dsChuyenBay[4], dsMayBay[7]));
            dsLichBay.Add(new LichBay(new DateTime(2000, 01, 11), dsChuyenBay[6].maChuyenBay, // 3
                dsMayBay[0].soHieu, dsMayBay[0].maLoai, dsChuyenBay[6], dsMayBay[0]));
            dsLichBay.Add(new LichBay(new DateTime(2000, 01, 11), dsChuyenBay[11].maChuyenBay,// 4
                dsMayBay[8].soHieu, dsMayBay[8].maLoai, dsChuyenBay[11], dsMayBay[8]));
            dsLichBay.Add(new LichBay(new DateTime(2000, 01, 11), dsChuyenBay[16].maChuyenBay,// 5
                dsMayBay[6].soHieu, dsMayBay[6].maLoai, dsChuyenBay[16], dsMayBay[6]));
            dsLichBay.Add(new LichBay(new DateTime(2000, 01, 11), dsChuyenBay[9].maChuyenBay, // 6
                dsMayBay[0].soHieu, dsMayBay[0].maLoai, dsChuyenBay[9], dsMayBay[0]));
            dsLichBay.Add(new LichBay(new DateTime(2000, 10, 31), dsChuyenBay[0].maChuyenBay, // 7
                dsMayBay[1].soHieu, dsMayBay[1].maLoai, dsChuyenBay[0], dsMayBay[1]));
            dsLichBay.Add(new LichBay(new DateTime(2000, 10, 31), dsChuyenBay[1].maChuyenBay, // 8
                dsMayBay[1].soHieu, dsMayBay[1].maLoai, dsChuyenBay[1], dsMayBay[1]));
            dsLichBay.Add(new LichBay(new DateTime(2000, 10, 31), dsChuyenBay[4].maChuyenBay, // 9
                dsMayBay[2].soHieu, dsMayBay[2].maLoai, dsChuyenBay[4], dsMayBay[2]));
            dsLichBay.Add(new LichBay(new DateTime(2000, 10, 31), dsChuyenBay[6].maChuyenBay, // 10
               dsMayBay[0].soHieu, dsMayBay[0].maLoai, dsChuyenBay[6], dsMayBay[0]));
            dsLichBay.Add(new LichBay(new DateTime(2000, 10, 31), dsChuyenBay[7].maChuyenBay, // 11
               dsMayBay[0].soHieu, dsMayBay[0].maLoai, dsChuyenBay[7], dsMayBay[0]));
            dsLichBay.Add(new LichBay(new DateTime(2000, 10, 31), dsChuyenBay[9].maChuyenBay, // 12
               dsMayBay[9].soHieu, dsMayBay[9].maLoai, dsChuyenBay[9], dsMayBay[9]));
            dsLichBay.Add(new LichBay(new DateTime(2000, 10, 31), dsChuyenBay[12].maChuyenBay,// 13
               dsMayBay[10].soHieu, dsMayBay[10].maLoai, dsChuyenBay[12], dsMayBay[10]));
            // them lich bay theo chuyen bay
            dsChuyenBay[0].dslichbay_chuyenbay.Add(dsLichBay[0]);
            dsChuyenBay[0].dslichbay_chuyenbay.Add(dsLichBay[7]);

            dsChuyenBay[1].dslichbay_chuyenbay.Add(dsLichBay[1]);
            dsChuyenBay[1].dslichbay_chuyenbay.Add(dsLichBay[8]);


            dsChuyenBay[4].dslichbay_chuyenbay.Add(dsLichBay[2]);
            dsChuyenBay[4].dslichbay_chuyenbay.Add(dsLichBay[9]);

            dsChuyenBay[6].dslichbay_chuyenbay.Add(dsLichBay[3]);
            dsChuyenBay[6].dslichbay_chuyenbay.Add(dsLichBay[10]);

            dsChuyenBay[7].dslichbay_chuyenbay.Add(dsLichBay[11]);

            dsChuyenBay[9].dslichbay_chuyenbay.Add(dsLichBay[6]);
            dsChuyenBay[9].dslichbay_chuyenbay.Add(dsLichBay[12]);

            dsChuyenBay[11].dslichbay_chuyenbay.Add(dsLichBay[4]);

            dsChuyenBay[12].dslichbay_chuyenbay.Add(dsLichBay[13]);

            dsChuyenBay[16].dslichbay_chuyenbay.Add(dsLichBay[5]);
            // them lich bay theo may bay
            dsMayBay[0].lichbay.Add(dsLichBay[3]);
            dsMayBay[0].lichbay.Add(dsLichBay[6]);
            dsMayBay[0].lichbay.Add(dsLichBay[10]);
            dsMayBay[0].lichbay.Add(dsLichBay[11]);

            dsMayBay[1].lichbay.Add(dsLichBay[7]);
            dsMayBay[1].lichbay.Add(dsLichBay[8]);

            dsMayBay[2].lichbay.Add(dsLichBay[9]);

            dsMayBay[4].lichbay.Add(dsLichBay[1]);

            dsMayBay[6].lichbay.Add(dsLichBay[5]);

            dsMayBay[7].lichbay.Add(dsLichBay[2]);

            dsMayBay[8].lichbay.Add(dsLichBay[4]);

            dsMayBay[9].lichbay.Add(dsLichBay[12]);

            dsMayBay[10].lichbay.Add(dsLichBay[13]);

            dsMayBay[11].lichbay.Add(dsLichBay[0]);
        }
        public static void Taods_PhanCong()
        {
            dsPhanCong.Add(new PhanCong(dsNhanVien[2].maNV, dsLichBay[0].ngayDi, dsLichBay[0].maChuyenBay,
                dsLichBay[0], dsNhanVien[2]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[2].maNV, dsLichBay[7].ngayDi, dsLichBay[7].maChuyenBay,
               dsLichBay[7], dsNhanVien[2]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[3].maNV, dsLichBay[0].ngayDi, dsLichBay[0].maChuyenBay,
               dsLichBay[0], dsNhanVien[3]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[3].maNV, dsLichBay[7].ngayDi, dsLichBay[7].maChuyenBay,
               dsLichBay[7], dsNhanVien[3]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[5].maNV, dsLichBay[7].ngayDi, dsLichBay[7].maChuyenBay,
              dsLichBay[7], dsNhanVien[5]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[5].maNV, dsLichBay[12].ngayDi, dsLichBay[12].maChuyenBay,
              dsLichBay[12], dsNhanVien[5]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[4].maNV, dsLichBay[7].ngayDi, dsLichBay[7].maChuyenBay,
              dsLichBay[7], dsNhanVien[4]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[4].maNV, dsLichBay[12].ngayDi, dsLichBay[12].maChuyenBay,
              dsLichBay[12], dsNhanVien[4]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[1].maNV, dsLichBay[5].ngayDi, dsLichBay[5].maChuyenBay,
             dsLichBay[5], dsNhanVien[0]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[0].maNV, dsLichBay[12].ngayDi, dsLichBay[12].maChuyenBay,
             dsLichBay[12], dsNhanVien[0]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[6].maNV, dsLichBay[1].ngayDi, dsLichBay[1].maChuyenBay,
             dsLichBay[1], dsNhanVien[6]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[6].maNV, dsLichBay[5].ngayDi, dsLichBay[5].maChuyenBay,
             dsLichBay[5], dsNhanVien[6]));
            dsPhanCong.Add(new PhanCong(dsNhanVien[6].maNV, dsLichBay[9].ngayDi, dsLichBay[9].maChuyenBay,
             dsLichBay[9], dsNhanVien[6]));
        }
        public static void Taods_LoaiMonAn()
        {
            dsLoaiMonAn.Add(new LoaiMonAn(Loai1.Trang_Mieng, 10000, 100000, new List<MonAn>()));
            dsLoaiMonAn.Add(new LoaiMonAn(Loai1.Thuc_An_Nhanh, 30000, 200000, new List<MonAn>()));
            dsLoaiMonAn.Add(new LoaiMonAn(Loai1.Do_Man, 15000, 500000, new List<MonAn>()));
            dsLoaiMonAn.Add(new LoaiMonAn(Loai1.Do_Chay, 10000, 80000, new List<MonAn>()));
        }
        public static void Taods_MonAn()
        {
            dsMonAn.Add(new MonAn("Nho", 20000, Loai1.Trang_Mieng, dsLoaiMonAn[0]));
            dsMonAn.Add(new MonAn("Cam", 15000, Loai1.Trang_Mieng, dsLoaiMonAn[0]));
            dsMonAn.Add(new MonAn("Rau cau", 30000, Loai1.Trang_Mieng, dsLoaiMonAn[0]));
            dsMonAn.Add(new MonAn("Humburger", 45000, Loai1.Thuc_An_Nhanh, dsLoaiMonAn[1]));
            dsMonAn.Add(new MonAn("Ga ran", 38000, Loai1.Thuc_An_Nhanh, dsLoaiMonAn[1]));
            dsMonAn.Add(new MonAn("Khoai tay chien", 30000, Loai1.Thuc_An_Nhanh, dsLoaiMonAn[1]));
            dsMonAn.Add(new MonAn("Com suon", 80000, Loai1.Do_Man, dsLoaiMonAn[2]));
            dsMonAn.Add(new MonAn("Pho", 50000, Loai1.Do_Man, dsLoaiMonAn[2]));
            dsMonAn.Add(new MonAn("Xoi man", 20000, Loai1.Do_Man, dsLoaiMonAn[2]));
            dsMonAn.Add(new MonAn("Xoi dau xanh", 15000, Loai1.Do_Chay, dsLoaiMonAn[3]));
            dsMonAn.Add(new MonAn("Rau cu xao", 30000, Loai1.Do_Chay, dsLoaiMonAn[3]));
            dsMonAn.Add(new MonAn("Canh nam", 50000, Loai1.Do_Chay, dsLoaiMonAn[3]));
            // theo mon an theo loai mon an
            dsLoaiMonAn[0].dsMA_LMA.Add(dsMonAn[0]);
            dsLoaiMonAn[0].dsMA_LMA.Add(dsMonAn[1]);
            dsLoaiMonAn[0].dsMA_LMA.Add(dsMonAn[2]);

            dsLoaiMonAn[1].dsMA_LMA.Add(dsMonAn[3]);
            dsLoaiMonAn[1].dsMA_LMA.Add(dsMonAn[4]);
            dsLoaiMonAn[1].dsMA_LMA.Add(dsMonAn[5]);

            dsLoaiMonAn[2].dsMA_LMA.Add(dsMonAn[6]);
            dsLoaiMonAn[2].dsMA_LMA.Add(dsMonAn[7]);
            dsLoaiMonAn[2].dsMA_LMA.Add(dsMonAn[8]);

            dsLoaiMonAn[3].dsMA_LMA.Add(dsMonAn[9]);
            dsLoaiMonAn[3].dsMA_LMA.Add(dsMonAn[10]);
            dsLoaiMonAn[3].dsMA_LMA.Add(dsMonAn[11]);
        }
        public static void Taods_LoaiThucUong()
        {
            dsLoaiThucUong.Add(new LoaiThucUong(Loai2.Nuoc_Uong_Co_Gas, 20000, 50000, new List<ThucUong>()));
            dsLoaiThucUong.Add(new LoaiThucUong(Loai2.Nuoc_Uong_Khong_Gas, 20000, 60000, new List<ThucUong>()));
            dsLoaiThucUong.Add(new LoaiThucUong(Loai2.Nuoc_Ep, 30000, 100000, new List<ThucUong>()));
            dsLoaiThucUong.Add(new LoaiThucUong(Loai2.Nuoc_Khoang, 10000, 20000, new List<ThucUong>()));
        }
        public static void Taods_ThucUong()
        {
            dsThucUong.Add(new ThucUong("Sting", 20000, Loai2.Nuoc_Uong_Co_Gas, dsLoaiThucUong[0]));
            dsThucUong.Add(new ThucUong("Pepsi", 22000, Loai2.Nuoc_Uong_Co_Gas, dsLoaiThucUong[0]));
            dsThucUong.Add(new ThucUong("CocaCola", 23000, Loai2.Nuoc_Uong_Co_Gas, dsLoaiThucUong[0]));
            dsThucUong.Add(new ThucUong("C2", 25000, Loai2.Nuoc_Uong_Khong_Gas, dsLoaiThucUong[1]));
            dsThucUong.Add(new ThucUong("Tra dao", 35000, Loai2.Nuoc_Uong_Khong_Gas, dsLoaiThucUong[1]));
            dsThucUong.Add(new ThucUong("Tra sua", 45000, Loai2.Nuoc_Uong_Khong_Gas, dsLoaiThucUong[1]));
            dsThucUong.Add(new ThucUong("Nuoc ep cam", 50000, Loai2.Nuoc_Ep, dsLoaiThucUong[2]));
            dsThucUong.Add(new ThucUong("Nuoc ep tao", 55000, Loai2.Nuoc_Ep, dsLoaiThucUong[2]));
            dsThucUong.Add(new ThucUong("Nuoc ep dua hau", 44000, Loai2.Nuoc_Ep, dsLoaiThucUong[2]));
            dsThucUong.Add(new ThucUong("LaVie", 10000, Loai2.Nuoc_Khoang, dsLoaiThucUong[3]));
            dsThucUong.Add(new ThucUong("Vinh Hao", 12000, Loai2.Nuoc_Khoang, dsLoaiThucUong[3]));
            dsThucUong.Add(new ThucUong("Aquarfina", 10000, Loai2.Nuoc_Khoang, dsLoaiThucUong[3]));
            //them thuc uong theo loai thuc uong
            dsLoaiThucUong[0].dsTU_LTU.Add(dsThucUong[0]);
            dsLoaiThucUong[0].dsTU_LTU.Add(dsThucUong[1]);
            dsLoaiThucUong[0].dsTU_LTU.Add(dsThucUong[2]);

            dsLoaiThucUong[1].dsTU_LTU.Add(dsThucUong[3]);
            dsLoaiThucUong[1].dsTU_LTU.Add(dsThucUong[4]);
            dsLoaiThucUong[1].dsTU_LTU.Add(dsThucUong[5]);

            dsLoaiThucUong[2].dsTU_LTU.Add(dsThucUong[6]);
            dsLoaiThucUong[2].dsTU_LTU.Add(dsThucUong[7]);
            dsLoaiThucUong[2].dsTU_LTU.Add(dsThucUong[8]);

            dsLoaiThucUong[3].dsTU_LTU.Add(dsThucUong[9]);
            dsLoaiThucUong[3].dsTU_LTU.Add(dsThucUong[10]); 
            dsLoaiThucUong[3].dsTU_LTU.Add(dsThucUong[11]);
        }
        public static void Taods_KhachHang()
        {
            dsKhachHang.Add(new KhachHang("0009", "Nga", "223 Nguyen Trai", "8932220",
               new List<HanhLy>()));
            dsKhachHang.Add(new KhachHang("0101", "Anh", "567 Tran Phu", "8826729",
               new List<HanhLy>()));
            dsKhachHang.Add(new KhachHang("0045", "Thu", "285 Le Loi", "8932203",
               new List<HanhLy>()));
            dsKhachHang.Add(new KhachHang("0012", "Ha", "435 Quang Trung", "8933232",
               new List<HanhLy>()));
            dsKhachHang.Add(new KhachHang("0238", "Hung", "456 Pasteur", "9812101",
               new List<HanhLy>()));
            dsKhachHang.Add(new KhachHang("0397", "Thanh", "234 Le Van Sy", "8952943",
               new List<HanhLy>()));
            dsKhachHang.Add(new KhachHang("0582", "Mai", "789 Nguyen Du", "NULL",
               new List<HanhLy>()));
            dsKhachHang.Add(new KhachHang("0934", "Minh", "678 Le Lai", "NULL",
               new List<HanhLy>()));
            dsKhachHang.Add(new KhachHang("0091", "Hai", "345 Hung Vuong", "8893223",
               new List<HanhLy>()));
            dsKhachHang.Add(new KhachHang("0314", "Phuong", "385 Vo Van Tuan", "8232320",
               new List<HanhLy>()));
            dsKhachHang.Add(new KhachHang("0613", "Vu", "348 CMT8", "8343232",
               new List<HanhLy>()));
            dsKhachHang.Add(new KhachHang("0586", "Son", "123 Bach Dang", "8556223",
               new List<HanhLy>()));
            dsKhachHang.Add(new KhachHang("0422", "Tien", "75 Nguyen Thong", "8332222",
               new List<HanhLy>()));
        }
        public static void Taods_DatCho()
        {
            dsDatCho.Add(new DatCho("0009", new DateTime(2000, 11, 01), "100", dsLichBay[0], dsKhachHang[0]));
            dsDatCho.Add(new DatCho("0009", new DateTime(2000, 10, 01), "449", dsLichBay[13], dsKhachHang[0]));
            dsDatCho.Add(new DatCho("0045", new DateTime(2000, 11, 01), "991", dsLichBay[5], dsKhachHang[2]));
            dsDatCho.Add(new DatCho("0012", new DateTime(2000, 10, 01), "206", dsLichBay[9], dsKhachHang[3]));
            dsDatCho.Add(new DatCho("0238", new DateTime(2000, 10, 01), "334", dsLichBay[10], dsKhachHang[4]));
            dsDatCho.Add(new DatCho("0528", new DateTime(2000, 11, 01), "991", dsLichBay[5], dsKhachHang[6]));
            dsDatCho.Add(new DatCho("0091", new DateTime(2000, 11, 01), "100", dsLichBay[0], dsKhachHang[8]));
            dsDatCho.Add(new DatCho("0314", new DateTime(2000, 10, 01), "449", dsLichBay[13], dsKhachHang[9]));
            dsDatCho.Add(new DatCho("0613", new DateTime(2000, 11, 01), "100", dsLichBay[0], dsKhachHang[10]));
            dsDatCho.Add(new DatCho("0586", new DateTime(2000, 11, 01), "991", dsLichBay[5], dsKhachHang[11]));
            dsDatCho.Add(new DatCho("0586", new DateTime(2000, 10, 01), "100", dsLichBay[7], dsKhachHang[11]));
            dsDatCho.Add(new DatCho("0422", new DateTime(2000, 10, 01), "449", dsLichBay[13], dsKhachHang[12]));
        }
        public static void Taods_ThucDon()
        {
            dsThucDon.Add(new ThucDon("TD01", 65000, dsKhachHang[0].maKH, dsKhachHang[0]));
            dsThucDon.Add(new ThucDon("TD02", 135000, dsKhachHang[1].maKH, dsKhachHang[1]));
            dsThucDon.Add(new ThucDon("TD03", 97000, dsKhachHang[2].maKH, dsKhachHang[2]));
            dsThucDon.Add(new ThucDon("TD04", 124000, dsKhachHang[3].maKH, dsKhachHang[3]));
            dsThucDon.Add(new ThucDon("TD05", 94000, dsKhachHang[4].maKH, dsKhachHang[4]));
            dsThucDon.Add(new ThucDon("TD06", 125000, dsKhachHang[5].maKH, dsKhachHang[5]));
            dsThucDon.Add(new ThucDon("TD07", 53000, dsKhachHang[6].maKH, dsKhachHang[6]));
            dsThucDon.Add(new ThucDon("TD08", 135000, dsKhachHang[7].maKH, dsKhachHang[7]));
            dsThucDon.Add(new ThucDon("TD09", 40000, dsKhachHang[8].maKH, dsKhachHang[8]));
            dsThucDon.Add(new ThucDon("TD10", 75000, dsKhachHang[9].maKH, dsKhachHang[9]));
            dsThucDon.Add(new ThucDon("TD11", 50000, dsKhachHang[10].maKH, dsKhachHang[10]));
            dsThucDon.Add(new ThucDon("TD12", 145000, dsKhachHang[11].maKH, dsKhachHang[11]));
            dsThucDon.Add(new ThucDon("TD13", 130000, dsKhachHang[12].maKH, dsKhachHang[12]));
        }
        public static void Taods_ChiTietThucDon()
        {
            dsChiTietThucDon.Add(new ChiTietThucDon(dsThucDon[0].maThucDon, dsMonAn[3].TenMonAn, 1, dsMonAn[3].DonGia, dsThucUong[0].TenThucUong, 1, dsThucUong[0].DonGia,
                dsThucDon[0], dsMonAn[3], dsThucUong[0]));
            dsChiTietThucDon.Add(new ChiTietThucDon(dsThucDon[1].maThucDon, dsMonAn[6].TenMonAn, 1, dsMonAn[6].DonGia, dsThucUong[7].TenThucUong, 1, dsThucUong[7].DonGia,
                dsThucDon[1], dsMonAn[6], dsThucUong[7]));
            dsChiTietThucDon.Add(new ChiTietThucDon(dsThucDon[2].maThucDon, dsMonAn[9].TenMonAn, 2, 2 * dsMonAn[9].DonGia, dsThucUong[3].TenThucUong, 1, dsThucUong[3].DonGia,
                dsThucDon[2], dsMonAn[9], dsThucUong[3]));
            dsChiTietThucDon.Add(new ChiTietThucDon(dsThucDon[2].maThucDon, dsMonAn[5].TenMonAn, 1, dsMonAn[5].DonGia, dsThucUong[3].TenThucUong, 1, dsThucUong[3].DonGia,
                dsThucDon[2], dsMonAn[5], dsThucUong[3]));
            dsChiTietThucDon.Add(new ChiTietThucDon(dsThucDon[3].maThucDon, dsMonAn[6].TenMonAn, 1, dsMonAn[6].DonGia, dsThucUong[8].TenThucUong, 1, dsThucUong[8].DonGia,
                dsThucDon[3], dsMonAn[6], dsThucUong[8]));
            dsChiTietThucDon.Add(new ChiTietThucDon(dsThucDon[4].maThucDon, dsMonAn[11].TenMonAn, 1, dsMonAn[11].DonGia, dsThucUong[1].TenThucUong, 2, 2 * dsThucUong[1].DonGia,
                dsThucDon[4], dsMonAn[11], dsThucUong[1]));
            dsChiTietThucDon.Add(new ChiTietThucDon(dsThucDon[5].maThucDon, dsMonAn[7].TenMonAn, 1, dsMonAn[7].DonGia, dsThucUong[9].TenThucUong, 1, dsThucUong[9].DonGia,
                dsThucDon[5], dsMonAn[7], dsThucUong[9]));
            dsChiTietThucDon.Add(new ChiTietThucDon(dsThucDon[5].maThucDon, dsMonAn[1].TenMonAn, 1, dsMonAn[1].DonGia, dsThucUong[6].TenThucUong, 1, dsThucUong[6].DonGia,
                dsThucDon[5], dsMonAn[1], dsThucUong[6]));
            dsChiTietThucDon.Add(new ChiTietThucDon(dsThucDon[6].maThucDon, dsMonAn[10].TenMonAn, 1, dsMonAn[10].DonGia, dsThucUong[2].TenThucUong, 1, dsThucUong[2].DonGia,
                dsThucDon[6], dsMonAn[10], dsThucUong[2]));
            dsChiTietThucDon.Add(new ChiTietThucDon(dsThucDon[7].maThucDon, dsMonAn[8].TenMonAn, 2, 2 * dsMonAn[8].DonGia, dsThucUong[4].TenThucUong, 1, dsThucUong[4].DonGia,
                dsThucDon[7], dsMonAn[8], dsThucUong[4]));
            dsChiTietThucDon.Add(new ChiTietThucDon(dsThucDon[7].maThucDon, dsMonAn[1].TenMonAn, 1, dsMonAn[1].DonGia, dsThucUong[5].TenThucUong, 1, dsThucUong[5].DonGia,
                dsThucDon[7], dsMonAn[1], dsThucUong[5]));
            dsChiTietThucDon.Add(new ChiTietThucDon(dsThucDon[8].maThucDon, dsMonAn[2].TenMonAn, 1, dsMonAn[2].DonGia, dsThucUong[11].TenThucUong, 1, dsThucUong[11].DonGia,
                dsThucDon[8], dsMonAn[2], dsThucUong[11]));
            dsChiTietThucDon.Add(new ChiTietThucDon(dsThucDon[9].maThucDon, dsMonAn[7].TenMonAn, 1, dsMonAn[7].DonGia, dsThucUong[3].TenThucUong, 1, dsThucUong[3].DonGia,
                dsThucDon[9], dsMonAn[7], dsThucUong[3]));
            dsChiTietThucDon.Add(new ChiTietThucDon(dsThucDon[10].maThucDon, dsMonAn[4].TenMonAn, 1, dsMonAn[4].DonGia, dsThucUong[10].TenThucUong, 1, dsThucUong[10].DonGia,
                dsThucDon[10], dsMonAn[4], dsThucUong[10]));
            dsChiTietThucDon.Add(new ChiTietThucDon(dsThucDon[11].maThucDon, dsMonAn[5].TenMonAn, 1, dsMonAn[5].DonGia, dsThucUong[3].TenThucUong, 1, dsThucUong[3].DonGia,
                dsThucDon[11], dsMonAn[5], dsThucUong[3]));
            dsChiTietThucDon.Add(new ChiTietThucDon(dsThucDon[11].maThucDon, dsMonAn[6].TenMonAn, 1, dsMonAn[6].DonGia, dsThucUong[9].TenThucUong, 1, dsThucUong[9].DonGia,
                dsThucDon[11], dsMonAn[6], dsThucUong[9]));
            dsChiTietThucDon.Add(new ChiTietThucDon(dsThucDon[12].maThucDon, dsMonAn[9].TenMonAn, 2, 2 * dsMonAn[9].DonGia, dsThucUong[6].TenThucUong, 2, 2 * dsThucUong[6].DonGia,
                dsThucDon[12], dsMonAn[9], dsThucUong[6]));
        }
        public static void Taods_LoaiHanhLy()
        {
            dsLoaiHanhLy.Add(new LoaiHanhLy("MLHL01", TenLoaiHanhLy.Xach_Tay, new List<HanhLy>()));
            dsLoaiHanhLy.Add(new LoaiHanhLy("MLHL02", TenLoaiHanhLy.Ky_Gui, new List<HanhLy>()));
        }
        public static void Taods_HanhLy()
        {
            dsHanhLy.Add(new HanhLy("HL01", 18.0, dsKhachHang[0].maKH, dsLoaiHanhLy[1].MaLoaiHL, dsKhachHang[0], dsLoaiHanhLy[1]));
            dsHanhLy.Add(new HanhLy("HL02", 19.0, dsKhachHang[1].maKH, dsLoaiHanhLy[1].MaLoaiHL, dsKhachHang[1], dsLoaiHanhLy[1]));
            dsHanhLy.Add(new HanhLy("HL03", 11.0, dsKhachHang[2].maKH, dsLoaiHanhLy[1].MaLoaiHL, dsKhachHang[2], dsLoaiHanhLy[1]));
            dsHanhLy.Add(new HanhLy("HL04", 12.0, dsKhachHang[3].maKH, dsLoaiHanhLy[1].MaLoaiHL, dsKhachHang[3], dsLoaiHanhLy[1]));
            dsHanhLy.Add(new HanhLy("HL05", 5.0, dsKhachHang[3].maKH, dsLoaiHanhLy[0].MaLoaiHL, dsKhachHang[3], dsLoaiHanhLy[0]));
            dsHanhLy.Add(new HanhLy("HL06", 7.0, dsKhachHang[4].maKH, dsLoaiHanhLy[0].MaLoaiHL, dsKhachHang[4], dsLoaiHanhLy[0]));
            dsHanhLy.Add(new HanhLy("HL07", 32.0, dsKhachHang[4].maKH, dsLoaiHanhLy[1].MaLoaiHL, dsKhachHang[4], dsLoaiHanhLy[1]));
            dsHanhLy.Add(new HanhLy("HL08", 23.0, dsKhachHang[5].maKH, dsLoaiHanhLy[1].MaLoaiHL, dsKhachHang[5], dsLoaiHanhLy[1]));
            dsHanhLy.Add(new HanhLy("HL09", 30.0, dsKhachHang[6].maKH, dsLoaiHanhLy[1].MaLoaiHL, dsKhachHang[6], dsLoaiHanhLy[1]));
            dsHanhLy.Add(new HanhLy("HL10", 22.0, dsKhachHang[7].maKH, dsLoaiHanhLy[1].MaLoaiHL, dsKhachHang[7], dsLoaiHanhLy[1]));
            dsHanhLy.Add(new HanhLy("HL11", 7.0, dsKhachHang[8].maKH, dsLoaiHanhLy[0].MaLoaiHL, dsKhachHang[8], dsLoaiHanhLy[0]));
            dsHanhLy.Add(new HanhLy("HL12", 9.0, dsKhachHang[9].maKH, dsLoaiHanhLy[0].MaLoaiHL, dsKhachHang[9], dsLoaiHanhLy[0]));
            dsHanhLy.Add(new HanhLy("HL13", 17.0, dsKhachHang[9].maKH, dsLoaiHanhLy[1].MaLoaiHL, dsKhachHang[9], dsLoaiHanhLy[1]));
            dsHanhLy.Add(new HanhLy("HL14", 35.0, dsKhachHang[10].maKH, dsLoaiHanhLy[1].MaLoaiHL, dsKhachHang[10], dsLoaiHanhLy[1]));
            dsHanhLy.Add(new HanhLy("HL15", 19.0, dsKhachHang[11].maKH, dsLoaiHanhLy[1].MaLoaiHL, dsKhachHang[11], dsLoaiHanhLy[1]));
            dsHanhLy.Add(new HanhLy("HL16", 3.0, dsKhachHang[12].maKH, dsLoaiHanhLy[0].MaLoaiHL, dsKhachHang[12], dsLoaiHanhLy[0]));
            dsHanhLy.Add(new HanhLy("HL17", 25.0, dsKhachHang[12].maKH, dsLoaiHanhLy[1].MaLoaiHL, dsKhachHang[12], dsLoaiHanhLy[1]));
            // Nhom Loai Hanh Ly
            dsLoaiHanhLy[0].dsHL_LHL.Add(dsHanhLy[4]);
            dsLoaiHanhLy[0].dsHL_LHL.Add(dsHanhLy[5]);
            dsLoaiHanhLy[0].dsHL_LHL.Add(dsHanhLy[10]);
            dsLoaiHanhLy[0].dsHL_LHL.Add(dsHanhLy[11]);
            dsLoaiHanhLy[0].dsHL_LHL.Add(dsHanhLy[15]);

            dsLoaiHanhLy[1].dsHL_LHL.Add(dsHanhLy[0]);
            dsLoaiHanhLy[1].dsHL_LHL.Add(dsHanhLy[1]);
            dsLoaiHanhLy[1].dsHL_LHL.Add(dsHanhLy[2]);
            dsLoaiHanhLy[1].dsHL_LHL.Add(dsHanhLy[3]);
            dsLoaiHanhLy[1].dsHL_LHL.Add(dsHanhLy[6]);
            dsLoaiHanhLy[1].dsHL_LHL.Add(dsHanhLy[7]);
            dsLoaiHanhLy[1].dsHL_LHL.Add(dsHanhLy[8]);
            dsLoaiHanhLy[1].dsHL_LHL.Add(dsHanhLy[9]);
            dsLoaiHanhLy[1].dsHL_LHL.Add(dsHanhLy[12]);
            dsLoaiHanhLy[1].dsHL_LHL.Add(dsHanhLy[13]);
            dsLoaiHanhLy[1].dsHL_LHL.Add(dsHanhLy[14]);
            dsLoaiHanhLy[1].dsHL_LHL.Add(dsHanhLy[16]);

            // Nhom Khach Hang
            dsKhachHang[0].ds_hanhly.Add(dsHanhLy[0]);

            dsKhachHang[1].ds_hanhly.Add(dsHanhLy[1]);

            dsKhachHang[2].ds_hanhly.Add(dsHanhLy[2]);

            dsKhachHang[3].ds_hanhly.Add(dsHanhLy[3]);
            dsKhachHang[3].ds_hanhly.Add(dsHanhLy[4]);

            dsKhachHang[4].ds_hanhly.Add(dsHanhLy[5]);
            dsKhachHang[4].ds_hanhly.Add(dsHanhLy[6]);

            dsKhachHang[5].ds_hanhly.Add(dsHanhLy[7]);

            dsKhachHang[6].ds_hanhly.Add(dsHanhLy[8]);

            dsKhachHang[7].ds_hanhly.Add(dsHanhLy[9]);

            dsKhachHang[8].ds_hanhly.Add(dsHanhLy[10]);

            dsKhachHang[9].ds_hanhly.Add(dsHanhLy[11]);
            dsKhachHang[9].ds_hanhly.Add(dsHanhLy[12]);

            dsKhachHang[10].ds_hanhly.Add(dsHanhLy[13]);

            dsKhachHang[11].ds_hanhly.Add(dsHanhLy[14]);

            dsKhachHang[12].ds_hanhly.Add(dsHanhLy[15]);
            dsKhachHang[12].ds_hanhly.Add(dsHanhLy[16]);
        }
        //===========================LINQ=============================


        //================Nguyen Thanh Dat - 20110121=====================

        // Danh sach khach hang co mang theo hanh ly li gui
        public static void Linq01_NguyenThanhDat()   
        {
            var list = 
                from p in dsHanhLy
                where p.LHL_HL.TenLoaiHL == TenLoaiHanhLy.Ky_Gui // where p.LHL_HL.MaLoaiHL == "MLHL02"
                select p.KH_HL;
            Console.WriteLine("--------------Ket qua 1------------------");
            Console.WriteLine("DANH SACH KHACH HANG CO MANG HANH LY KI GUI: ");
            foreach (var kq in list)
            {
                Console.WriteLine("Ma Khach Hang: {0} - Ten: {1} - Dia Chi: {2} - SDT: {3}.",
                        kq.maKH, kq.tenKH, kq.diaChi, kq.soDienThoai);
            }
        }

        // 5 khach hang co tong tien thuc don nho nhat va 5 khach hang co tong tien thuc don lon nhat
        public static void Linq02_NguyenThanhDat()
        {
            var SXtien = (
                from p in dsThucDon
                orderby p.gia ascending
                select p)
                .Take(5);
            Console.WriteLine("--------------Ket qua 2------------------");
            Console.WriteLine("--DANH SACH 5 KHACH HANG CO TONG TIEN THUC DON NHO NHAT--");
            foreach( var kq in SXtien)
            {
                Console.WriteLine("Ma Thuc Don: {0} - Ma Khach Hang: {1} - Ten: {2} - So Tien: {3}.",
                    kq.maThucDon, kq.maKhachHang, kq.khachhang.tenKH, kq.gia);
            }
            Console.WriteLine("-----------------------------------------------------------");
            var SXtien2 = (
                from q in dsThucDon
                orderby q.gia ascending
                select q)
                .Skip(8);
            Console.WriteLine("--DANH SACH 5 KHACH HANG CO TONG TIEN O THUC DON LON NHAT--");
            foreach (var kq in SXtien2)
            {
                Console.WriteLine("Ma Thuc Don: {0} - Ma Khach Hang: {1} - Ten: {2} - So Tien: {3}.",
                    kq.maThucDon, kq.maKhachHang, kq.khachhang.tenKH, kq.gia);
            }
        }

        //Danh sach hanh li cua tung khach hang
        public static void Linq03_NguyenThanhDat()
        {
            var List =
                from p in dsHanhLy
                group p by p.KH_HL into g
                select new { KH_HL = g.Key, dsHanhLy = g };
            Console.WriteLine("--------------Ket qua 3------------------");
            Console.WriteLine("--DANH SACH HANG LI CUA TUNG KHACH HANG--");
            foreach(var kq in List)
            {
                Console.WriteLine("Ma khach hang: {0} - Ten khach hang: {1}",
                    kq.KH_HL.maKH, kq.KH_HL.tenKH);
                foreach( var kq2 in kq.dsHanhLy)
                {
                    Console.WriteLine("Loai: {0} - Ma hanh ly: {1} - Trong luong: {2}",
                        kq2.LHL_HL.TenLoaiHL,kq2.MaHL, kq2.TrongLuong);
                }
            }
        }

        //Danh sach khach hang an mon trang mieng
        public static void Linq04_NguyenThanhDat()
        {
            var list =
                from p in dsChiTietThucDon
                where p.monan.LMA_MA.LoaiMA == Loai1.Trang_Mieng
                select new { p.thucdon.khachhang, p.tenMonAn };
            Console.WriteLine("--------------Ket qua 4------------------");
            Console.WriteLine("--DANH SACH KHACH HANG AN MON TRANG MIENG");
            foreach( var kq in list)
            {
                Console.WriteLine("Ma khach hang: {0} - Ten khach hang: {1} - Ten mon an: {2}",
                    kq.khachhang.maKH, kq.khachhang.tenKH, kq.tenMonAn);
            }
        }

        //Tong trong luong hanh li cua tung khach hang
        public static void Linq05_NguyenThanhDat()
        {
            var kl =
                from p in dsHanhLy
                group p by p.KH_HL into g   
                select new { KH_HL = g.Key, Tongtrongluong = g.Sum(p => p.TrongLuong) };
            Console.WriteLine("--------------Ket qua 5------------------");
            Console.WriteLine("--TONG TRONG LUONG CUA TUNG KHACH HANG--");
            foreach( var kq in kl)
            {
                Console.WriteLine("Ma khach hang: {0} - Ten khach hang: {1}",
                    kq.KH_HL.maKH, kq.KH_HL.tenKH);
                Console.WriteLine("Tong trong luong hanh ly: {0}", kq.Tongtrongluong);
            }
        }

        //So luong mon an cua tung khach hang
        public static void Linq06_NguyenThanhDat()
        {
            var dem =
                from p in dsChiTietThucDon
                group p by p.thucdon.khachhang into g
                select new { khachhang = g.Key, countmon = g.Count()};
            Console.WriteLine("--------------Ket qua 6------------------");
            Console.WriteLine("--SO LUONG MON AN CUA TUNG KHACH HANG--");
            foreach( var kq in dem)
            {
                Console.WriteLine("Ma khach hang: {0} - Ten khach hang: {1}",
                    kq.khachhang.maKH, kq.khachhang.tenKH);
                Console.WriteLine(" --> So luong mon an: {0}",
                    kq.countmon);
            }
        }

        //Gia tien trung binh thuc don cua tat ca khach hang
        public static void Linq07_NguyenThanhDat()
        {
            var tb =
                from p in dsThucDon
                select p.gia;
            double trungbinh = tb.Average();

            Console.WriteLine("--------------Ket qua 7------------------");
            Console.WriteLine("--GIA TIEN TRUNG BINH THUC DON CUA TAT CA KHACH HANG--");
            Console.WriteLine("    \t--> {0} VND <--", trungbinh);
        }

        //Danh sach thuc an va nuoc uong co muc gia lon hon 20 000
        public static void Linq08_NguyenThanhDat()
        {
            var list1 =
                from p in dsMonAn
                where p.DonGia > 20000
                select p.TenMonAn;
            var list2 =
                from q in dsThucUong
                where q.DonGia > 20000
                select q.TenThucUong;
            var all = list1.Concat(list2);

            Console.WriteLine("--------------Ket qua 8------------------");
            Console.WriteLine("--TEN MON AN VA THUC UONG CO GIA TREN 20 000 VND--");
            foreach( var kq in all)
            {
                Console.WriteLine(kq);
            }
        }

        //Danh sach mon an theo loai va thuc uong theo loai
        public static void Linq09_NguyenThanhDat()
        {
            var list1 =
                from p in dsMonAn
                group p by p.LoaiMA into g
                select new { LoaiMA = g.Key, dsMonAn = g };
            Console.WriteLine("--------------Ket qua 9------------------");
            Console.WriteLine("--DANH SACH MON AN THEO TUNG LOAI");
            foreach (var kq1 in list1)
            {
                Console.WriteLine("Loai moi an: {0}",
                    kq1.LoaiMA);
                foreach (var kq2 in kq1.dsMonAn)
                {
                    Console.WriteLine("Ten mon an: {0} - Don gia: {1}",
                        kq2.TenMonAn, kq2.DonGia);
                }
            }

            Console.WriteLine();

            var list2 =
                from q in dsThucUong
                group q by q.LoaiTU into g
                select new { LoaiTU = g.Key, dsThucUong = g };
            Console.WriteLine("--DANH SACH THUC UONG THEO TUNG LOAI");
            foreach (var kq3 in list2)
            {
                Console.WriteLine("Loai thuc uong: {0}",
                    kq3.LoaiTU);
                foreach (var kq4 in kq3.dsThucUong)
                {
                    Console.WriteLine("Ten thuc uong: {0} - Don gia: {1}",
                        kq4.TenThucUong, kq4.DonGia);
                }
            }
        }

        //Danh sach mon an va thuc uong duoc dat cua tat ca khach hang
        public static void Linq10_NguyenThanhDat()
        {
            var list1 = (
                from p in dsChiTietThucDon
                select p.tenMonAn)
                .Distinct();

            Console.WriteLine("--------------Ket qua 10------------------");
            Console.WriteLine("--DANH SACH MON AN DUOC DAT CUA KHACH HANG--");
            foreach( var kq1 in list1)
            {
                Console.WriteLine(kq1);
            }

            Console.WriteLine();

            var list2 = (
                from q in dsChiTietThucDon
                select q.tenThucUong)
                .Distinct();
            Console.WriteLine("--DANH SACH THUC UONG DUOC DAT CUA KHACH HANG--");
            foreach (var kq2 in list2)
            {
                Console.WriteLine(kq2);
            }
        }


        //=================Phan Hong Son - 20110560=======================

        // Cho biet ma nhan vien, ten, dia chi, so dien thoai cua nhung phi
        // cong tham gia lich bay co MaCB la 100
        public static void Linq01_HongSon()
        {

            Console.WriteLine("\t\tLINQ 01");

            // Query Expression
            Console.WriteLine(">>>>>> QUERY EXPRESSION <<<<<<");

            var s =
                from pc in dsPhanCong
                join nv in dsNhanVien on pc.maNV equals nv.maNV
                where pc.maCB == "100" && nv.loaiNV == 1
                select new { ID = nv.maNV, Name = nv.tenNV, Address = nv.diaChi, Phone = nv.soDT };
            foreach (var n in s)
            {
                Console.WriteLine("\t- Ma nhan vien: {0}", n.ID);
                Console.WriteLine("\t- Ten nhan vien: {0}", n.Name);
                Console.WriteLine("\t- Dia chi: {0}", n.Address);
                Console.WriteLine("\t- So dien thoai: {0}", n.Phone);
                Console.WriteLine("\t====================");
            }
            // Lambda Expression
            Console.WriteLine(">>>>>> LAMBDA EXPRESSION <<<<<<");

            var ld = dsPhanCong
                .Join(dsNhanVien,
                pc => pc.maNV,
                nv => nv.maNV,
                (pc, nv) => new { Pc = pc, Nv = nv })
                .Where(cb => cb.Pc.maCB == "100" && cb.Nv.loaiNV == 1)
                .Select(k => new {
                    ID = k.Nv.maNV,
                    Name = k.Nv.tenNV,
                    Address = k.Nv.diaChi,
                    Phone = k.Nv.soDT
                });

            foreach (var n in s)
            {
                Console.WriteLine("\t- Ma nhan vien: {0}", n.ID);
                Console.WriteLine("\t- Ten nhan vien: {0}", n.Name);
                Console.WriteLine("\t- Dia chi: {0}", n.Address);
                Console.WriteLine("\t- So dien thoai: {0}", n.Phone);
                Console.WriteLine("\t====================");
            }
        }

        // Cho biet ma loai va so hieu nhung may bay da tung xuat hien tai san bay MIA,
        // khong duoc xuat gia tri trung lap
        public static void Linq02_HongSon()
        {

            Console.WriteLine("\t\tLINQ 02");

            // Query Expression
            Console.WriteLine(">>>>>> QUERY EXPRESSION <<<<<<");
            var query =
                (from cb in dsChuyenBay
                 join lb in dsLichBay on cb.maChuyenBay equals lb.maChuyenBay
                 where cb.sanBayDi == "MIA" || cb.sanBayDen == "MIA"
                 select new { maLoai = lb.maLoai, soHieu = lb.soHieu })
                .Distinct();

            foreach (var qr in query)
            {
                Console.WriteLine("\t- Ma loai: {0}", qr.maLoai);
                Console.WriteLine("\t- So hieu: {0}", qr.soHieu);
                Console.WriteLine("\t====================");
            }


            // Lambda Expression
            Console.WriteLine(">>>>>> LAMBDA EXPRESSION <<<<<<");
            var lambda = dsChuyenBay
                .Join(dsLichBay,
                cb => cb.maChuyenBay,
                lb => lb.maChuyenBay,
                (cb, lb) => new { Cb = cb, Lb = lb })
                .Where(mb => mb.Cb.sanBayDi == "MIA" || mb.Cb.sanBayDen == "MIA")
                .Select(sl => new { maLoai = sl.Lb.maLoai, soHieu = sl.Lb.soHieu })
                .Distinct();

            foreach (var ld in lambda)
            {
                Console.WriteLine("\t- Ma loai: {0}", ld.maLoai);
                Console.WriteLine("\t- So hieu: {0}", ld.soHieu);
                Console.WriteLine("\t====================");
            }
        }

        // Cho biet thong tin cac chuyen bay ma phi cong co ma so 1001 duoc phan cong lai
        public static void Linq03_HongSon()
        {

            Console.WriteLine("\t\tLINQ 03");

            // Query Expression
            Console.WriteLine(">>>>>> QUERY EXPRESSION <<<<<<");
            var query =
                from cb in dsChuyenBay
                join pc in dsPhanCong on cb.maChuyenBay equals pc.maCB
                where pc.maNV == "1001"
                select cb;

            foreach (var qr in query)
            {
                Console.WriteLine("\t- Ma chuyen bay: {0}", qr.maChuyenBay);
                Console.WriteLine("\t- San bay di: {0}", qr.sanBayDi);
                Console.WriteLine("\t- San bay den: {0}", qr.sanBayDen);
                Console.WriteLine("\t- Gio di: {0}", qr.gioDi);
                Console.WriteLine("\t- Gio den: {0}", qr.gioDen);
                Console.WriteLine("\t====================");
            }




            // Lambda Expression
            Console.WriteLine(">>>>>> LAMBDA EXPRESSION <<<<<<");
            var lambda = dsChuyenBay
                .Join(dsPhanCong,
                cb => cb.maChuyenBay,
                pc => pc.maCB,
                (cb, pc) => new { Cb = cb, Pc = pc })
                .Where(w => w.Pc.maNV == "1001")
                .Select(s => s.Cb);

            foreach (var ld in lambda)
            {
                Console.WriteLine("\t- Ma chuyen bay: {0}", ld.maChuyenBay);
                Console.WriteLine("\t- San bay di: {0}", ld.sanBayDi);
                Console.WriteLine("\t- San bay den: {0}", ld.sanBayDen);
                Console.WriteLine("\t- Gio di: {0}", ld.gioDi);
                Console.WriteLine("\t- Gio den: {0}", ld.gioDen);
                Console.WriteLine("\t====================");
            }
        }

        // Cho biet thong tin nhung chuyen bay ha canh xuong ORD va xep theo tu giam dan cua ngay di
        // Thong tin bao gom: Ma chuyen bay, san bay di, san bay den, gio di, gio den, ngay di
        public static void Linq04_HongSon()
        {

            Console.WriteLine("\t\tLINQ 04");

            // Query Expression
            Console.WriteLine(">>>>>> QUERY EXPRESSION <<<<<<");
            var query =
                from cb in dsChuyenBay
                join lb in dsLichBay on cb.maChuyenBay equals lb.maChuyenBay
                where cb.sanBayDen == "ORD"
                orderby lb.ngayDi descending
                select new { cb, lb };

            foreach (var qr in query)
            {
                Console.WriteLine("\t- Ma chuyen bay: {0}", qr.cb.maChuyenBay);
                Console.WriteLine("\t- San bay di: {0}", qr.cb.sanBayDi);
                Console.WriteLine("\t- San  bay den: {0}", qr.cb.sanBayDen);
                Console.WriteLine("\t- Gio di: {0}", qr.cb.gioDi);
                Console.WriteLine("\t- Gio den: {0}", qr.cb.gioDen);
                Console.WriteLine("\t- Ngay bay: {0}", qr.lb.ngayDi);
                Console.WriteLine("\t====================");
            }

            // Lambda Expression
            Console.WriteLine(">>>>>> LAMBDA EXPRESSION <<<<<<");
            var lambda = dsChuyenBay
                .Join(dsLichBay,
                cb => cb.maChuyenBay,
                lb => lb.maChuyenBay,
                (cb, lb) => new { Cb = cb, Lb = lb })
                .Where(w => w.Cb.sanBayDen == "ORD")
                .OrderByDescending(o => o.Lb.ngayDi)
                .Select(s => new { s.Cb, s.Lb });

            foreach (var ld in lambda)
            {
                Console.WriteLine("\t- Ma chuyen bay: {0}", ld.Cb.maChuyenBay);
                Console.WriteLine("\t- San bay di: {0}", ld.Cb.sanBayDi);
                Console.WriteLine("\t- San  bay den: {0}", ld.Cb.sanBayDen);
                Console.WriteLine("\t- Gio di: {0}", ld.Cb.gioDi);
                Console.WriteLine("\t- Gio den: {0}", ld.Cb.gioDen);
                Console.WriteLine("\t- Ngay bay: {0}", ld.Lb.ngayDi);
                Console.WriteLine("\t====================");
            }
        }

        // Cho biet thong tin cua cac nhan vien
        // Chu y liet ke tat ca thong tin cua phi cong roi moi den phuc vu(hoac liet ke tat ca phuc vu roi
        // den phi cong)
        public static void Linq05_HongSon()
        {

            Console.WriteLine("\t\tLINQ 05");

            // Query Expression
            Console.WriteLine(">>>>>> QUERY EXPRESSION <<<<<<");
            var query =
                from nv in dsNhanVien
                group nv by nv.loaiNV into NV
                select new { LoaiNV = NV.Key, thongtin = NV };

            foreach (var qr in query)
            {
                Console.WriteLine("{0}", qr.LoaiNV == 1 ? "Phi cong: " : "Phuc vu: ");
                foreach (var infor in qr.thongtin)
                {
                    Console.WriteLine("\t- Ma nhan vien: {0}", infor.maNV);
                    Console.WriteLine("\t- Ten nhan vien: {0}", infor.tenNV);
                    Console.WriteLine("\t- Dia chi: {0}", infor.diaChi);
                    Console.WriteLine("\t- Luong: {0}", infor.Luong);
                    Console.WriteLine("\t- So dien thoai: {0}", infor.soDT);
                    Console.WriteLine("\t====================");
                }
            }

            // Lambda Expression
            Console.WriteLine(">>>>>> LAMBDA EXPRESSION <<<<<<");
            var lambda = dsNhanVien
                .GroupBy(gb => gb.loaiNV)
                .Select(s => new { LoaiNV = s.Key, thongtin = s });

            foreach (var ld in lambda)
            {
                Console.WriteLine("{0}", ld.LoaiNV == 1 ? "Phi cong:  " : "Phuc vu: ");
                foreach (var infor in ld.thongtin)
                {
                    Console.WriteLine("\t- Ma nhan vien: {0}", infor.maNV);
                    Console.WriteLine("\t- Ten nhan vien: {0}", infor.tenNV);
                    Console.WriteLine("\t- Dia chi: {0}", infor.diaChi);
                    Console.WriteLine("\t- Luong: {0}", infor.Luong);
                    Console.WriteLine("\t- So dien thoai: {0}", infor.soDT);
                    Console.WriteLine("\t====================");
                }
            }
        }

        // Cho biet thong tin ve lich bay ma phi cong Quang da lai(ma chuyen bay, so hieu,
        // ma loai, hang san xuat, thong tin ve may bay do va ngay di)
        public static void Linq06_HongSon()
        {

            Console.WriteLine("\t\tLINQ 06");

            // Query Expression
            Console.WriteLine(">>>>>> QUERY EXPRESSION <<<<<<");
            var query =
                from lb in dsLichBay
                join pc in dsPhanCong on lb.maChuyenBay equals pc.maCB
                where pc.nhanvien.tenNV == "Quang"
                select lb;

            foreach (var qr in query)
            {
                Console.WriteLine("\t- Ma chuyen bay: {0}", qr.maChuyenBay);
                Console.WriteLine("\t- So hieu: {0}", qr.soHieu);
                Console.WriteLine("\t- Ma loai: {0}", qr.maLoai);
                Console.WriteLine("\t- Hang san xuat: {0}", qr.maybay.loaimaybay.hangSX);
                Console.WriteLine("\t- Ngay di: {0}", qr.ngayDi);
                Console.WriteLine("\t====================");
            }

            // Lambda Expression
            Console.WriteLine(">>>>>> LAMBDA EXPRESSION <<<<<<");
            var lambda = dsLichBay
                .Join(dsPhanCong,
                lb => lb.maChuyenBay,
                pc => pc.maCB,
                (lb, pc) => new { Lb = lb, Pc = pc })
                .Where(w => w.Pc.nhanvien.tenNV == "Quang")
                .Select(s => s.Lb);

            foreach (var ld in lambda)
            {
                Console.WriteLine("\t- Ma chuyen bay: {0}", ld.maChuyenBay);
                Console.WriteLine("\t- So hieu: {0}", ld.soHieu);
                Console.WriteLine("\t- Ma loai: {0}", ld.maLoai);
                Console.WriteLine("\t- Hang san xuat: {0}", ld.maybay.loaimaybay.hangSX);
                Console.WriteLine("\t- Ngay di: {0}", ld.ngayDi);
                Console.WriteLine("\t====================");
            }
        }

        // Voi moi san bay den, cho biet so luong chuyen bay ha canh xuong san bay do
        // Ket qua sap xep theo thu tang dan
        public static void Linq07_HongSon()
        {

            Console.WriteLine("\t\tLINQ 07");

            // Query Expression
            Console.WriteLine(">>>>>> QUERY EXPRESSION <<<<<<");
            var query =
                from cb in dsChuyenBay
                group cb by cb.sanBayDen into SLCB
                orderby SLCB.Count()
                select new { SanBay = SLCB.Key, SoLuong = SLCB.Count() };

            foreach (var qr in query)
                Console.WriteLine("\t- San bay {0}: {1}", qr.SanBay, qr.SoLuong);

            // Lambda Expression
            Console.WriteLine(">>>>>> LAMBDA EXPRESSION <<<<<<");
            var lambda = dsChuyenBay
                .GroupBy(g => g.sanBayDen)
                .OrderBy(o => o.Count())
                .Select(s => new { SanBay = s.Key, SoLuong = s.Count() });

            foreach (var ld in lambda)
                Console.WriteLine("\t- San bay {0}: {1}", ld.SanBay, ld.SoLuong);
        }

        // Với moi lich bay cho biet ma chuyen bay, ngay di, so luong nhan vien duoc
        // phan cong trong lich bay do, sap theo thu tu  giam dan so luong
        public static void Linq08_HongSon()
        {

            Console.WriteLine("\t\tLINQ 08");

            // Query Expression
            Console.WriteLine(">>>>>> QUERY EXPRESSION <<<<<<");
            var query =
                from pc in dsPhanCong
                group pc by new { pc.maCB, pc.ngayDi } into g
                orderby g.Count() descending
                select new { Lichbay = g.Key, SoLuong = g.Count() };

            foreach (var qr in query)
            {
                Console.WriteLine("\t- Ma chuyen bay: {0}", qr.Lichbay.maCB);
                Console.WriteLine("\t- Ngay di: {0}", qr.Lichbay.ngayDi);
                Console.WriteLine("\t- So luong nhan vien: {0}", qr.SoLuong);
                Console.WriteLine("\t====================");
            }

            // Lambda Expression
            Console.WriteLine(">>>>>> LAMBDA EXPRESSION <<<<<<");
            var lambda = dsPhanCong
                .GroupBy(pc => new { pc.maCB, pc.ngayDi })
                .OrderByDescending(o => o.Count())
                .Select(s => new { Lichbay = s.Key, SoLuong = s.Count() });

            foreach (var ld in lambda)
            {
                Console.WriteLine("\t- Ma chuyen bay: {0}", ld.Lichbay.maCB);
                Console.WriteLine("\t- Ngay di: {0}", ld.Lichbay.ngayDi);
                Console.WriteLine("\t- So luong nhan vien: {0}", ld.SoLuong);
                Console.WriteLine("\t====================");
            }
        }

        // Voi moi may bay,  cho biet thong tin cua may bay do va so luong chuyen bay den san bay ORD 
        public static void Linq09_HongSon()
        {

            Console.WriteLine("\t\tLINQ 09");

            // Query Expression
            Console.WriteLine(">>>>>> QUERY EXPRESSION <<<<<<");
            var query =
                from mb in dsMayBay
                select new
                {
                    sohieu = mb.soHieu,
                    maloai = mb.maLoai,
                    hangsanxuat = mb.loaimaybay.hangSX,
                    SoLuong = mb.lichbay.Count(c => c.chuyenbay.sanBayDen == "ORD")
                };

            foreach (var qr in query)
            {
                Console.WriteLine("\t- So hieu: {0}  Ma loai: {1}  Hang san xuat: {2}",
                    qr.sohieu, qr.maloai, qr.hangsanxuat);
                Console.WriteLine("\t- So luong chuyen bay: {0}", qr.SoLuong);
                Console.WriteLine("\t====================");
            }

            // Lambda Expression
            Console.WriteLine(">>>>>> LAMBDA EXPRESSION <<<<<<");
            var lambda = dsMayBay
                .Select(mb => new
                {
                    sohieu = mb.soHieu,
                    maloai = mb.maLoai,
                    hangsanxuat = mb.loaimaybay.hangSX,
                    SoLuong = mb.lichbay.Count(c => c.chuyenbay.sanBayDen == "ORD")
                });

            foreach (var ld in lambda)
            {
                Console.WriteLine("\t- So hieu: {0}  Ma loai: {1}  Hang san xuat: {2}",
                    ld.sohieu, ld.maloai, ld.hangsanxuat);
                Console.WriteLine("\t- So luong chuyen bay: {0}", ld.SoLuong);
                Console.WriteLine("\t====================");
            }
        }

        // Tinh tong luong cua cac phi cong va tong luong cua cac phuc vu
        public static void Linq10_HongSon()
        {

            Console.WriteLine("\t\tLINQ 10");

            // Query Expression
            Console.WriteLine(">>>>>> QUERY EXPRESSION <<<<<<");
            var query =
                from nv in dsNhanVien
                group nv by nv.loaiNV into deposit
                select new { Type = deposit.Key, Sum = deposit.Sum(sum => sum.Luong) };

            foreach (var qr in query)
            {
                Console.Write("Nhom {0}: ", qr.Type == 1 ? "Phi cong" : "Phuc vu");
                Console.WriteLine("{0}", qr.Sum);
            }

            // Lambda Expression
            Console.WriteLine(">>>>>> LAMBDA EXPRESSION <<<<<<");
            var lambda = dsNhanVien
                .GroupBy(nv => nv.loaiNV)
                .Select(s => new { Type = s.Key, Sum = s.Sum(sum => sum.Luong) });

            foreach (var ld in lambda)
            {
                Console.Write("Nhom {0}: ", ld.Type == 1 ? "Phi cong" : "Phuc vu");
                Console.WriteLine("{0}", ld.Sum);
            }
        }

        //=================Huynh Thanh Tuan - 20110560=======================

        //Với mỗi phi công, cho biết hãng sản xuất và mã loại máy bay mà phi công này có khả năng lái.
        //Xuất tên phi công, hãng sản xuất và MALOAI
        public static void Linq01_ThanhTuan()
        {
            Console.WriteLine("=======Ket qua Linq01: Hang san xuat va ma loai may bay ma phi cong co kha nang lai===========");
            var q1 = from KN in dsKhaNang
                     from NV in dsNhanVien
                     from LMB in dsLoaiMayBay
                     where KN.maNV == NV.maNV && KN.maLoai == LMB.maLoai
                     select new { Ten = NV.tenNV, HangSX = LMB.hangSX, MaLoai = LMB.maLoai };
            foreach (var n in q1)
            {
                Console.WriteLine("Ten phi Cong: {0}, Hang san xuat: {1}, Ma loai: {2}.", n.Ten, n.HangSX, n.MaLoai);
            }
        }
        //Liệt kê danh sách của nhân viên theo loại
        //xuất mã nhân viên, tên, địa chỉ.
        public static void Linq02_ThanhTuan()
        {
            Console.WriteLine("=======Ket qua Linq02: Liet ke danh sach nhan vien theo loai===========");
            var q2 = from NV in dsNhanVien
                     group NV by NV.loaiNV;
            foreach (var i in q2)
            {
                Console.WriteLine("Danh sach nhan vien la: {0}", (i.Key == 1) ? "Phi cong" : "Tiep vien");

                foreach (var j in i)
                {
                    Console.WriteLine("Ma nhan vien: {0}, Ten nhan vien: {1}, Dia chi: {2}.", j.maNV, j.tenNV, j.diaChi);
                }
            }
        }
        //Cho biết mức lương trung bình của các phi công
        public static void Linq03_ThanhTuan()
        {
            Console.WriteLine("=======Ket qua Linq03: Tinh luong trung binh cua phi cong===========");
            double q3 = dsNhanVien.Where(n => n.loaiNV == 1).Average(n => n.Luong);
            Console.WriteLine("Luong trung binh cua phi cong: {0:0.00}.", q3);
        }
        //Cho biết lương trung bình của các nhân viên không là phi công
        public static void Linq04_ThanhTuan()
        {
            Console.WriteLine("=======Ket qua Linq04: Tinh luong trung binh cua tiep vien===========");
            var q4 = from NV in dsNhanVien
                     group NV by NV.loaiNV into gr
                     where gr.Key == 0
                     let TB = gr.Average(n => n.Luong)
                     select new { LuongTB = TB };
            foreach (var n in q4)
            {
                Console.WriteLine("Luong trung binh cua nhan vien: {0:0.00}.", n.LuongTB);
            }
        }
        //Cho biết mã số, tên, lương của các phi công
        //có khả năng lái nhiều máy bay nhất
        public static void Linq05_ThanhTuan()
        {
            Console.WriteLine("=======Ket qua Linq05: Tim cac phi cong co kha nang lai nhieu may bay===========");
            var q5 = from KN in dsKhaNang
                     group KN by KN.maNV into gr
                     let slg = gr.Count()
                     let LonNhat = gr.Max(n => n.maNV.Count())
                     where slg == LonNhat
                     from NV in dsNhanVien
                     where NV.maNV == gr.Key
                     select NV;

            foreach (var n in q5)
            {
                Console.WriteLine("Ma so: {0}, Ten: {1}, Luong: {2}.", n.maNV, n.tenNV, n.Luong);
            }
        }
        //Cho biết tên phi công đã được phân công vào ít nhất 2 chuyến bay trong cùng một ngày
        public static void Linq06_ThanhTuan()
        {
            Console.WriteLine("=======Ket qua Linq06: Tim phi cong duoc phan cong vao it nhat 2 chuyen bay trong ngay===========");
            var q6 = from PC in dsPhanCong
                     from NV in dsNhanVien
                     where PC.maNV == NV.maNV && NV.loaiNV == 1
                     group new { NV, PC } by new { NV.tenNV, PC.ngayDi } into gr
                     where gr.Count() >= 2
                     select gr.Key;
            foreach (var n in q6)
            {
                Console.WriteLine("Ten Phi Cong: {0}.", n.tenNV);
            }
        }
        //Với mỗi hãng sản xuất, cho biết số lượng máy bay mà hãng đó sản xuất.
        //Xuất ra hãng sản xuất và số lượng.
        public static void Linq07_ThanhTuan()
        {
            Console.WriteLine("=======Ket qua Linq07: So luong may bay cua moi hang san xuat===========");
            var q7 = from LMB in dsLoaiMayBay
                     from MB in dsMayBay
                     where LMB.maLoai == MB.maLoai
                     group LMB by LMB.hangSX into gr
                     select new { HangSX = gr.Key, Slg = gr.Count() };
            foreach (var n in q7)
            {
                Console.WriteLine("Hang san xuat: {0}, So luong: {1}.", n.HangSX, n.Slg);
            }

        }
        //Cho biết hãng sản xuất, mã loại và số hiệu
        //của máy bay được sử dụng nhiều nhất
        public static void Linq08_ThanhTuan()
        {
            Console.WriteLine("=======Ket qua linq08===========");
            var q8 = from LB in dsLichBay
                     from LMB in dsLoaiMayBay
                     where LMB.maLoai == LB.maLoai
                     group new { LMB, LB } by new { LMB.hangSX, LMB.maLoai, LB.soHieu } into gr1
                     let Solg = gr1.Count()

                     where Solg ==

                     (from LB in dsLichBay
                      group LB by new { LB.maLoai, LB.soHieu } into gr
                      let slg = gr.Count()
                      select new { Slg = slg }).Max(n => n.Slg)

                     select new { GT = gr1.Key };

            foreach (var n in q8)
            {
                Console.WriteLine("Hang San Xuat: {0}, Ma Loai May Bay: {1}, So Hieu: {2}", n.GT.hangSX, n.GT.maLoai, n.GT.soHieu);
            }


        }
        //Cho biết thông tin của nhân viên(mã, tên, loaiNV)
        //của nhân viên có lương cao nhất
        public static void Linq09_ThanhTuan()
        {
            Console.WriteLine("=======Ket qua Linq09: Tim cac nhan vien co luong cao nhat===========");
            var q9 = from NV in dsNhanVien
                     where NV.Luong == (from NV1 in dsNhanVien select NV1.Luong).Max(n => n)
                     select NV;
            foreach (var n in q9)
            {
                Console.WriteLine("Ma nhan vien: {0}, Ten nhan vien: {1}, Loai nhan vien: {2}.", n.maNV, n.tenNV, (n.loaiNV == 1) ? "Phi cong" : "Tiep vien");
            }
        }
        //Với mỗi loại nhân viên có tổng lương trên 60000000,
        //cho biết số lượng nhân viên trong từng loại nhân viên đó.
        //xuất loại nhân viên, số lượng nhân viên tương ứng
        public static void Linq10_ThanhTuan()
        {
            Console.WriteLine("=======Ket qua linq10===========");
            var q10 = from NV in dsNhanVien
                      group NV by NV.loaiNV into gr
                      let Luongtong = gr.Sum(n => n.Luong)
                      let Soluong = gr.Count()
                      where Luongtong > 60000000
                      select new { LoaiNV = gr.Key, SLG = Soluong };
            foreach (var n in q10)
            {
                Console.WriteLine("Loai Nhan Vien: {0}, So Luong Nhan Vien: {1}.", n.LoaiNV == 1 ? "Phi Cong" : "Tiep Vien", n.SLG);
            }
        }
        static void Main(string[] args)
        {
            Taods_NhanVien();
            Taods_LoaiMayBay();
            Taods_KhaNang();
            Taods_MayBay();
            Taods_ChuyenBay();
            Taods_LichBay();
            Taods_PhanCong();
            Taods_KhachHang();
            Taods_DatCho();
            Taods_LoaiMonAn();
            Taods_MonAn();
            Taods_LoaiThucUong();
            Taods_ThucUong();
            Taods_ThucDon();
            Taods_ChiTietThucDon();
            Taods_LoaiHanhLy();
            Taods_HanhLy();

            //=====Nguyen Thanh Dat - 20110121========
            Linq01_NguyenThanhDat();
            Linq02_NguyenThanhDat();
            Linq03_NguyenThanhDat();
            Linq04_NguyenThanhDat();
            Linq05_NguyenThanhDat();
            Linq06_NguyenThanhDat();
            Linq07_NguyenThanhDat();
            Linq08_NguyenThanhDat();
            Linq09_NguyenThanhDat(); 
            Linq10_NguyenThanhDat();

            //=====Phan Hong Son - 20110560======
            Linq01_HongSon();
            Linq02_HongSon();
            Linq03_HongSon();
            Linq04_HongSon();
            Linq05_HongSon();
            Linq06_HongSon();
            Linq07_HongSon();
            Linq08_HongSon();
            Linq09_HongSon();
            Linq10_HongSon();

            //=====Huynh Thanh Tuan - 20110120======
            Linq01_ThanhTuan();
            Linq02_ThanhTuan();
            Linq03_ThanhTuan();
            Linq04_ThanhTuan();
            Linq05_ThanhTuan();
            Linq06_ThanhTuan();
            Linq07_ThanhTuan();
            Linq08_ThanhTuan();
            Linq09_ThanhTuan();
            Linq10_ThanhTuan();

            Console.ReadKey();
        }
    }
}
