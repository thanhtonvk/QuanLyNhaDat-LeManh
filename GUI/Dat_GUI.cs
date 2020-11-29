using System;
using System.Collections;
using System.Text;
using QuanLyNhaDat_LeManh.DAL;
using QuanLyNhaDat_LeManh.BLL;
namespace QuanLyNhaDat_LeManh.GUI
{
    class Dat_GUI
    {
        private static void Menu()
        {
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("|             QUẢN LÍ NHÀ ĐẤT                      |");
            Console.WriteLine("|__________________________________________________|");
            Console.WriteLine("|1. Nhập thêm nhà đất                              |");
            Console.WriteLine("|2. Hiện thị danh sách nhà đất                     |");
            Console.WriteLine("|3. Sửa thông tin nhà đất                          |");
            Console.WriteLine("|4. Xóa thông tin nhà đất                          |");
            Console.WriteLine("|5. Tìm kiếm nhà đất                               |");
            Console.WriteLine("|0.Thoát                                           |");
            Console.WriteLine("|__________________________________________________|");
        }
        static Dat_DAL Dat_DAL = new Dat_DAL();
        static Dat_BLL Dat_BLL = new Dat_BLL();
        static ArrayList arrayList = new ArrayList();

        public static void Run()
        {
            Dat_DAL.DocFile(arrayList);
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
                        Dat_BLL.Nhap(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        Dat_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Dat_BLL.Hien(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Dat_BLL.Sua(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        Dat_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Dat_BLL.Xoa(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        Dat_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Dat_BLL.TimKiem(arrayList);
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
