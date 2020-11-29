using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaDat_LeManh.Enitities
{
    class KhachHang
    {
        private string makhachhang;
        private string tenkhachhang;
        private string gioitinh;
        private string sodienthoai;
        private string namsinh;
        private string diachi;
        public KhachHang(string makhachhang,string tenkhachhang,string gioitinh,string sodienthoai,string namsinh,string diachi)
        {
            this.makhachhang = makhachhang;
            this.tenkhachhang = tenkhachhang;
            this.gioitinh = gioitinh;
            this.sodienthoai = sodienthoai;
            this.namsinh = namsinh;
            this.diachi = diachi;
        }
        override
            public string ToString()
        {
            return makhachhang + "#" + tenkhachhang + "#" + gioitinh + "#" + sodienthoai + "#" + namsinh + "#" + diachi;
        }
        public string Makhachhang { get => makhachhang; set => makhachhang = value; }
       
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
        public string Namsinh { get => namsinh; set => namsinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Tenkhachhang { get => tenkhachhang; set => tenkhachhang = value; }
    }
}
