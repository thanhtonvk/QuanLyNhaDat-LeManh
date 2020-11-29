using System;
using System.Collections;
using System.Text;
using QuanLyNhaDat_LeManh.DAL;
using QuanLyNhaDat_LeManh.BLL;
namespace QuanLyNhaDat_LeManh.GUI
{
    class KhachHang_GUI
    {
        private static void Menu()
        {
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("|             QUẢN LÍ KHÁCH HÀNG                   |");
            Console.WriteLine("|__________________________________________________|");
            Console.WriteLine("|1. Nhập thêm khách hàng                           |");
            Console.WriteLine("|2. Hiện thị danh sách khách hàng                  |");
            Console.WriteLine("|3. Sửa thông tin khách hàng                       |");
            Console.WriteLine("|4. Xóa khách hàng                                 |");
            Console.WriteLine("|5. Tìm kiếm khách hàng                            |");
            Console.WriteLine("|0.Thoát                                           |");
            Console.WriteLine("|__________________________________________________|");
        }
        static KhachHang_DAL khachHang_DAL = new KhachHang_DAL();
        static KhachHang_BLL khachHang_BLL = new KhachHang_BLL();
        static ArrayList arrayList = new ArrayList();
       
        public static void Run()
        {
            khachHang_DAL.DocFile(arrayList);
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
                        khachHang_BLL.Nhap(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        khachHang_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        khachHang_BLL.Hien(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        khachHang_BLL.Sua(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        khachHang_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        khachHang_BLL.Xoa(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        khachHang_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        khachHang_BLL.TimKiem(arrayList);
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
