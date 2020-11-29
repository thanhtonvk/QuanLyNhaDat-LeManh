using QuanLyNhaDat_LeManh.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using QuanLyNhaDat_LeManh.Enitities;
namespace QuanLyNhaDat_LeManh.BLL
{
    class HoaDon_BLL : ChucNang_IF
    {
        public HoaDon find(ArrayList arrayList)
        {
            Console.WriteLine("Nhập mã hoặc tên: ");
            string keyword = Console.ReadLine();
            HoaDon result = null;
            foreach (HoaDon HoaDon in arrayList)
            {
                if (keyword.Equals(HoaDon.Mahoadon) || keyword.Equals(HoaDon.Manhanvien)||keyword.Equals(HoaDon.Madat))
                {
                    result = HoaDon;
                }
            }
            return result;

        }
        public void display(HoaDon HoaDon)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|", HoaDon.Mahoadon, HoaDon.Madat, HoaDon.Ngaymua, HoaDon.Ngayban, HoaDon.Makhachhang, HoaDon.Manhanvien,HoaDon.Hinhthucthanhtoan,HoaDon.Thanhtien);
        }
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|", "Mã hóa đơn", "Mã đất", "Ngày mua", "Ngày bán", "Mã khách hàng", "Mã nhân viên","Hình thức thanh toán","Thành tiền");
            foreach (HoaDon HoaDon in arrayList)
            {
                display(HoaDon);
            }
        }

        public void Nhap(ArrayList arrayList)
        {


            Console.WriteLine("Nhập mã hóa đơn");
            string maHoaDon = Console.ReadLine();
            Console.WriteLine("Nhập mã đất");
            string madat = Console.ReadLine();
            Console.WriteLine("Nhập ngày mua");
            string ngaymua = Console.ReadLine();
            Console.WriteLine("Nhập ngày bán");
            string ngayban = Console.ReadLine();
            Console.WriteLine("Nhập mã khách hàng");
            string makhachhang = Console.ReadLine();
            Console.WriteLine("Nhập mã nhân viên");
            string manhanvien = Console.ReadLine();
            Console.WriteLine("Nhập hình thức thanh toán");
            string hinhthuc = Console.ReadLine();
            Console.WriteLine("Thành tiền");
            double thanhtien = double.Parse(Console.ReadLine());
            arrayList.Add(new HoaDon(maHoaDon, madat, ngaymua, ngayban, makhachhang, manhanvien,hinhthuc,thanhtien));
        }

        public void Sua(ArrayList arrayList)
        {

            HoaDon kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("Nhập mã hóa đơn");
                kq.Mahoadon = Console.ReadLine();
                Console.WriteLine("Nhập mã đất");
               kq.Madat = Console.ReadLine();
                Console.WriteLine("Nhập ngày mua");
                kq.Ngaymua = Console.ReadLine();
                Console.WriteLine("Nhập ngày bán");
                kq.Ngayban = Console.ReadLine();
                Console.WriteLine("Nhập mã khách hàng");
                kq.Makhachhang= Console.ReadLine();
                Console.WriteLine("Nhập mã nhân viên");
                kq.Manhanvien = Console.ReadLine();
                Console.WriteLine("Nhập hình thức thanh toán");
                kq.Hinhthucthanhtoan = Console.ReadLine();
                Console.WriteLine("Thành tiền");
                kq.Thanhtien = double.Parse(Console.ReadLine());
            }
        }

        public void TimKiem(ArrayList arrayList)
        {
            HoaDon kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|{6,-20}|{7,-20}|", "Mã hóa đơn", "Mã đất", "Ngày mua", "Ngày bán", "Mã khách hàng", "Mã nhân viên", "Hình thức thanh toán", "Thành tiền");

                display(kq);
            }
        }

        public void Xoa(ArrayList arrayList)
        {
            HoaDon kq = find(arrayList);
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
