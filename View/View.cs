using System;
using System.Collections.Generic;
using System.Text;
using QuanLyNhaDat_LeManh.GUI;
namespace QuanLyNhaDat_LeManh.View
{
    class View
    {
        private static void Menu()
        {
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("|             QUẢN LÍ NHÀ ĐẤT-MẠNH LÊ              |");
            Console.WriteLine("|__________________________________________________|");
            Console.WriteLine("|                1. QUẢN LÝ NHÀ ĐẤT                |");
            Console.WriteLine("|                2. QUẢN LÝ HÓA ĐƠN                |");
            Console.WriteLine("|                3. QUẢN LÝ KHÁCH HÀNG             |");
            Console.WriteLine("|                4. QUẢN LÝ NHÂN VIÊN              |");
            Console.WriteLine("|                0.Thoát                           |");
            Console.WriteLine("|__________________________________________________|");
        }
        public static void Run()
        {
            int chon;
            while (true)
            {
                Menu();
                chon = int.Parse(Console.ReadLine());
                Console.Clear();
                if (chon == 0) break;
                switch (chon)
                {
                    case 1:
                        
                        Dat_GUI.Run();
                        Console.Clear();
                        break;
                    case 2:
                        HoaDon_GUI.Run();
                        Console.Clear();
                        break;
                    case 3:
                        KhachHang_GUI.Run();
                        Console.Clear();
                        break;
                    case 4:
                        NhanVien_GUI.Run();
                        Console.Clear();
                        break;
                    default: break;
                }
            }
        }
    }
}
