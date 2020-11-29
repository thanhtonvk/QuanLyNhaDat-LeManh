using QuanLyNhaDat_LeManh.DAL.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using QuanLyNhaDat_LeManh.Enitities;
namespace QuanLyNhaDat_LeManh.DAL
{
    class KhachHang_DAL : DocGhiFile
    {
        public void DocFile(ArrayList arrayList)
        {
            if (File.Exists("Khachhang.txt"))
            {
                string line;
                StreamReader streamReader = new StreamReader("Khachhang.txt");
                while((line = streamReader.ReadLine()) != null)
                {
                    //string makhachhang,string tenkhachhang,string gioitinh,string sodienthoai,string namsinh,string diachi
                    string makhachhang = line.Split("#")[0];
                    string tenkhachhang = line.Split("#")[1];
                    string gioitinh = line.Split("#")[2];
                    string sodienthoai = line.Split("#")[3];
                    string namsinh = line.Split("#")[4];
                    string diachi = line.Split("#")[5];
                    arrayList.Add(new KhachHang(makhachhang, tenkhachhang, gioitinh, sodienthoai, namsinh, diachi));
                }
            }
        }

        public void GhiFile(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter("Khachhang.txt");
            foreach (KhachHang khachHang in arrayList)
            {
                streamWriter.WriteLine(khachHang.ToString());
            }
            streamWriter.Close();
        }
    }
}
