using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaDat_LeManh.Enitities
{
    class HoaDon
    {
        private string mahoadon, madat, ngaymua, ngayban, makhachhang, manhanvien, hinhthucthanhtoan;
        private double thanhtien;
        public HoaDon(string mahoadon,string madat,string ngaymua,string ngayban,string makhachhang,string manhanvien,string hinhthucthanhtoan,double thanhtien)
        {
            this.mahoadon = mahoadon;
            this.madat = madat;
            this.ngaymua = ngaymua;
            this.ngayban = ngayban;
            this.makhachhang = makhachhang;
            this.manhanvien = manhanvien;
            this.hinhthucthanhtoan = hinhthucthanhtoan;
        }
        override
            public string ToString()
        {
           return mahoadon+"#"+madat + "#" +ngaymua + "#" +ngayban + "#" +makhachhang + "#" +manhanvien + "#" +hinhthucthanhtoan + "#" +thanhtien;
        }
        public string Mahoadon { get => mahoadon; set => mahoadon = value; }
        public string Madat { get => madat; set => madat = value; }
        public string Ngaymua { get => ngaymua; set => ngaymua = value; }
        public string Ngayban { get => ngayban; set => ngayban = value; }
        public string Makhachhang { get => makhachhang; set => makhachhang = value; }
        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
        public string Hinhthucthanhtoan { get => hinhthucthanhtoan; set => hinhthucthanhtoan = value; }
        public double Thanhtien { get => thanhtien; set => thanhtien = value; }
    }
}
