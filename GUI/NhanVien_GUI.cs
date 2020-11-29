using System;
using System.Collections;
using System.Text;
using QuanLyNhaDat_LeManh.BLL;
using QuanLyNhaDat_LeManh.DAL;
namespace QuanLyNhaDat_LeManh.GUI
{
    class NhanVien_GUI
    {
        public static void Menu()
        {
            Console.WriteLine("___________________________________________________");
            Console.WriteLine("|             QUẢN LÍ NHÂN VIÊN                    |");
            Console.WriteLine("|__________________________________________________|");
            Console.WriteLine("|1. Nhập thêm nhân viên                            |");
            Console.WriteLine("|2. Hiện thị danh sách nhân viên                   |");
            Console.WriteLine("|3. Sửa thông tin nhân viên                        |");
            Console.WriteLine("|4. Xóa nhân viên                                  |");
            Console.WriteLine("|5. Tìm kiếm nhân viên                             |");
            Console.WriteLine("|0.Thoát                                           |");
            Console.WriteLine("|__________________________________________________|");
        }
        static NhanVien_DAL nhanVien_DAL = new NhanVien_DAL();
        static NhanVien_BLL nhanVien_BLL = new NhanVien_BLL();
        static ArrayList arrayList = new ArrayList();
        public static void Run()
        {
            nhanVien_DAL.DocFile(arrayList);
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
                        nhanVien_BLL.Nhap(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        nhanVien_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        nhanVien_BLL.Hien(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        nhanVien_BLL.Sua(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        nhanVien_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        nhanVien_BLL.Xoa(arrayList);
                        Console.WriteLine("Nhập phím bất kì để tiếp tục");
                        nhanVien_DAL.GhiFile(arrayList);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        nhanVien_BLL.TimKiem(arrayList);
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
