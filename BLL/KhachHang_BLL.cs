using QuanLyNhaDat_LeManh.BLL.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyNhaDat_LeManh.Enitities;
namespace QuanLyNhaDat_LeManh.BLL
{
    class KhachHang_BLL : ChucNang_IF
    {
       
        public KhachHang find(ArrayList arrayList)
        {
            Console.WriteLine("Nhập mã hoặc tên: ");
            string keyword = Console.ReadLine();
            KhachHang result = null;
            foreach (KhachHang KhachHang in arrayList)
            {
                if (keyword.Equals(KhachHang.Makhachhang) || keyword.Equals(KhachHang.Tenkhachhang))
                {
                    result = KhachHang;
                }
            }
            return result;

        }
        public void display(KhachHang KhachHang)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", KhachHang.Makhachhang, KhachHang.Tenkhachhang, KhachHang.Gioitinh, KhachHang.Sodienthoai, KhachHang.Namsinh, KhachHang.Diachi);
        }
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã khách hàng", "Tên khách hàng", "Giới tính", "Số điện thoại", "Năm sinh", "Địa chỉ");
            foreach (KhachHang KhachHang in arrayList)
            {
                display(KhachHang);
            }
        }

        public void Nhap(ArrayList arrayList)
        {

            Console.WriteLine("Nhập mã khách hàng");
            string makhachhang = Console.ReadLine();
            Console.WriteLine("Nhập tên khách hàng");
            string tenkhachhang = Console.ReadLine();
            Console.WriteLine("Nhập giới tính");
            string gioitinh = Console.ReadLine();
            Console.WriteLine("Nhập số điện thoại");
            string sodienthoai = Console.ReadLine();
            Console.WriteLine("Nhập năm sinh");
            string namsinh = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ");
            string diachi = Console.ReadLine();
            
            arrayList.Add(new KhachHang(makhachhang,tenkhachhang,gioitinh,sodienthoai,namsinh,diachi));
        }

        public void Sua(ArrayList arrayList)
        {

            KhachHang kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("Nhập mã khách hàng");
                kq.Makhachhang = Console.ReadLine();
                Console.WriteLine("Nhập tên khách hàng");
                kq.Tenkhachhang = Console.ReadLine();
                Console.WriteLine("Nhập giới tính");
                kq.Gioitinh = Console.ReadLine();
                Console.WriteLine("Nhập số điện thoại");
                kq.Sodienthoai = Console.ReadLine();
                Console.WriteLine("Nhập năm sinh");
                kq.Namsinh = Console.ReadLine();
                Console.WriteLine("Nhập địa chỉ");
                kq.Diachi = Console.ReadLine();
            }
        }

        public void TimKiem(ArrayList arrayList)
        {
            KhachHang kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã khách hàng", "Tên khách hàng", "Giới tính", "Số điện thoại", "Năm sinh", "Địa chỉ");

                display(kq);
            }
        }

        public void Xoa(ArrayList arrayList)
        {
            KhachHang kq = find(arrayList);
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
