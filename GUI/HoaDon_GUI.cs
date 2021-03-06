﻿using System;
using System.Collections;
using System.Text;
using QuanLyNhaDat_LeManh.BLL;
using QuanLyNhaDat_LeManh.DAL;

namespace QuanLyNhaDat_LeManh.GUI
{
    class HoaDon_GUI
    {
        private static void Menu()
        {
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("|             QUẢN LÍ HÓA ĐƠN                      |");
            Console.WriteLine("|__________________________________________________|");
            Console.WriteLine("|1. Nhập hóa đơn                                   |");
            Console.WriteLine("|2. Hiện thị danh sách hóa đơn                     |");
            Console.WriteLine("|3. Sửa thông tin hóa đơn                          |");
            Console.WriteLine("|4. Xóa hóa đơn                                    |");
            Console.WriteLine("|5. Tìm kiếm hóa đơn                               |");
            Console.WriteLine("|0.Thoát                                           |");
            Console.WriteLine("|__________________________________________________|");
        }
        static HoaDon_DAL HoaDon_DAL = new HoaDon_DAL();
        static HoaDon_BLL HoaDon_BLL = new HoaDon_BLL();
        static ArrayList arrayList = new ArrayList();

        public static void Run()
        {
            HoaDon_DAL.DocFile(arrayList);
            int chon;
            while (true)
            {
                Menu();
                //chọn chức  năng
                chon = int.Parse(Console.ReadLine());
                //nếu nhập = 0 thì dừng chương trình
                if (chon == 0) break;
                switch (chon)
                {
                    case 1:
                        HoaDon_BLL.Nhap(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        HoaDon_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        HoaDon_BLL.Hien(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        HoaDon_BLL.Sua(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        HoaDon_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        HoaDon_BLL.Xoa(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        HoaDon_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        HoaDon_BLL.TimKiem(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");

                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default: break;
                }
            }
        }
    }
}
