using System;
using System.Collections;
using System.Text;
using QuanLyNhaDat_LeManh.Enitities;
namespace QuanLyNhaDat_LeManh.BLL
{
    class NhanVien_BLL
    {
        public NhanVien find(ArrayList arrayList)
        {
            Console.WriteLine("Nhập mã hoặc tên: ");
            string keyword = Console.ReadLine();
            NhanVien result = null;
            foreach (NhanVien NhanVien in arrayList)
            {
                if (keyword.Equals(NhanVien.Manhanvien) || keyword.Equals(NhanVien.Tennhanvien))
                {
                    result = NhanVien;
                }
            }
            return result;

        }
       
        public void display(NhanVien NhanVien)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|", NhanVien.Manhanvien, NhanVien.Tennhanvien, NhanVien.Chucvu, NhanVien.Gioitinh,NhanVien.Namsinh, NhanVien.Sodienthoai, NhanVien.Diachi);
        }
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã nhân viên", "Tên nhân viên", "Chức vụ", "Giới tính", "Năm sinh","Số điện thoại", "Địa chỉ");
            foreach (NhanVien NhanVien in arrayList)
            {
                display(NhanVien);
            }
        }
        //string manhanvien,string tennhanvien,string chucvu,string gioitinh,string namsinh,string sodienthoai,string diachi
        public void Nhap(ArrayList arrayList)
        {

            Console.WriteLine("Nhập mã nhân viên");
            string manhanvien = Console.ReadLine();
            Console.WriteLine("Nhập tên nhân viên");
            string tennhanvien = Console.ReadLine();
            Console.WriteLine("Nhập chức vụ");
            string chucvu = Console.ReadLine();
            Console.WriteLine("Nhập giới tính");
            string gioitinh = Console.ReadLine();
            Console.WriteLine("Nhập năm sinh");
            string namsinh = Console.ReadLine();
            Console.WriteLine("Nhập số điện thoại");
            string sodienthoai = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ");
            string diachi = Console.ReadLine();
            arrayList.Add(new NhanVien(manhanvien,tennhanvien,chucvu,gioitinh,namsinh,sodienthoai,diachi));
        }

        public void Sua(ArrayList arrayList)
        {

            NhanVien kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("Nhập mã nhân viên");
                kq.Manhanvien = Console.ReadLine();
                Console.WriteLine("Nhập tên nhân viên");
                kq.Tennhanvien= Console.ReadLine();
                Console.WriteLine("Nhập chức vụ");
                kq.Chucvu = Console.ReadLine();
                Console.WriteLine("Nhập giới tính");
                kq.Gioitinh = Console.ReadLine();
                Console.WriteLine("Nhập năm sinh");
                kq.Namsinh = Console.ReadLine();
                Console.WriteLine("Nhập số điện thoại");
                kq.Sodienthoai = Console.ReadLine();
                Console.WriteLine("Nhập địa chỉ");
                kq.Diachi = Console.ReadLine();
            }
        }

        public void TimKiem(ArrayList arrayList)
        {
            NhanVien kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã nhân viên", "Tên nhân viên", "Chức vụ", "Giới tính", "Năm sinh", "Số điện thoại", "Địa chỉ");

                display(kq);
            }
        }

        public void Xoa(ArrayList arrayList)
        {
            NhanVien kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                arrayList.Remove(kq);
                Console.WriteLine("Xóa thành công");
            }
        }
    }
}
