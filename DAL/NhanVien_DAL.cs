using QuanLyNhaDat_LeManh.DAL.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using QuanLyNhaDat_LeManh.Enitities;

namespace QuanLyNhaDat_LeManh.DAL
{
    class NhanVien_DAL : DocGhiFile
    {
        public void DocFile(ArrayList arrayList)
        {
            //string manhanvien,string tennhanvien,string chucvu,string gioitinh,string namsinh,string sodienthoai,string diachi
            if (File.Exists("Nhanvien.txt"))
            {
                StreamReader streamReader = new StreamReader("Nhanvien.txt");
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string manhanvien = line.Split("#")[0];
                    string tennhanvien = line.Split("#")[1];
                    string chucvu = line.Split("#")[2];
                    string gioitinh = line.Split("#")[3];
                    string namsinh = line.Split("#")[4];
                    string sodienthoai = line.Split("#")[5];
                    string diachi = line.Split("#")[6];
                    arrayList.Add(new NhanVien(manhanvien, tennhanvien,chucvu, gioitinh, namsinh, sodienthoai, diachi));
                }
                streamReader.Close();
            }
        }

        public void GhiFile(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter("Nhanvien.txt");
            foreach(NhanVien nhanVien in arrayList)
            {
                streamWriter.WriteLine(nhanVien.ToString());
            }
            streamWriter.Close();
        }
    }
}
