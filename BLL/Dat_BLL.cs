using QuanLyNhaDat_LeManh.BLL.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyNhaDat_LeManh.Enitities;
namespace QuanLyNhaDat_LeManh.BLL
{
    class Dat_BLL : ChucNang_IF
    {
        public Dat find(ArrayList arrayList)
        {
            Console.WriteLine("Nhập mã hoặc tên: ");
            string keyword = Console.ReadLine();
            Dat result = null;
            foreach (Dat dat in arrayList)
            {
                if (keyword.Equals(dat.Madat) || keyword.Equals(dat.Tendat))
                {
                    result = dat;
                }
            }
            return result;

        }
        public void display(Dat dat)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", dat.Madat, dat.Tendat, dat.Dientich, dat.Giatri, dat.Ngaymua, dat.Ngayban);
        }
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã đất", "Tên đất", "Diện tích", "Giá trị", "Ngày mua", "Ngày bán");
            foreach (Dat dat in arrayList)
            {
                display(dat);
            }
        }

        public void Nhap(ArrayList arrayList)
        {
            //string madat,string tendat,double dientich,double giatri,string ngaymua,string ngayban
            Console.WriteLine("Nhập mã đất");
            string madat = Console.ReadLine();
            Console.WriteLine("Nhập tên đất");
            string tendat = Console.ReadLine();
            Console.WriteLine("Nhập diện tích đất");
            double dientich = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giá trị");
            double giatri = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập ngày mua");
            string ngaymua = Console.ReadLine();
            Console.WriteLine("Nhập ngày bán");
            string ngayban = Console.ReadLine();
            arrayList.Add(new Dat(madat, tendat, dientich, giatri, ngaymua, ngayban));
        }

        public void Sua(ArrayList arrayList)
        {

            Dat kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("Nhập mã đất");
                kq.Madat = Console.ReadLine();
                Console.WriteLine("Nhập tên đất");
                kq.Tendat = Console.ReadLine();
                Console.WriteLine("Nhập diện tích đất");
                kq.Dientich = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập giá trị");
                kq.Giatri = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập ngày mua");
                kq.Ngaymua = Console.ReadLine();
                Console.WriteLine("Nhập ngày bán");
                kq.Ngayban = Console.ReadLine();
                Console.WriteLine("Sửa thành công");
            }
        }

        public void TimKiem(ArrayList arrayList)
        {
            Dat kq = find(arrayList);
            if (kq == null)
            {
                Console.WriteLine("Không tìm thấy");
            }
            else
            {
                Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã đất", "Tên đất", "Diện tích", "Giá trị", "Ngày mua", "Ngày bán");
                display(kq);
            }
        }

        public void Xoa(ArrayList arrayList)
        {
            Dat kq = find(arrayList);
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
