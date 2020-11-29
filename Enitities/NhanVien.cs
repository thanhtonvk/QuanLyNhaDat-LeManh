using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaDat_LeManh.Enitities
{
    class NhanVien
    {
        private string manhanvien, tennhanvien, chucvu, gioitinh, namsinh, sodienthoai, diachi;
        public NhanVien(string manhanvien,string tennhanvien,string chucvu,string gioitinh,string namsinh,string sodienthoai,string diachi)
        {
            this.manhanvien = manhanvien;
            this.tennhanvien = tennhanvien;
            this.chucvu = chucvu;
            this.gioitinh = gioitinh;
            this.sodienthoai = sodienthoai;
            this.diachi = diachi;
            this.namsinh = namsinh;
        }
        override
            public string ToString()
        {
            return manhanvien + "#" + tennhanvien + "#" + chucvu + "#" + gioitinh + "#" + namsinh + "#" + sodienthoai + "#" + diachi;
        }
        public string Manhanvien { get => manhanvien; set => manhanvien = value; }
        public string Tennhanvien { get => tennhanvien; set => tennhanvien = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Namsinh { get => namsinh; set => namsinh = value; }
        public string Sodienthoai { get => sodienthoai; set => sodienthoai = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
