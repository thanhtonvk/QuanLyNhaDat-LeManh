using QuanLyNhaDat_LeManh.DAL.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using QuanLyNhaDat_LeManh.Enitities;
namespace QuanLyNhaDat_LeManh.DAL
{
    class HoaDon_DAL : DocGhiFile
    {
        //string mahoadon,string madat,string ngaymua,string ngayban,string makhachhang,string manhanvien,string hinhthucthanhtoan,double thanhtien
        public void DocFile(ArrayList arrayList)
        {
           
            if (File.Exists("Hoadon.txt"))
            {
                StreamReader streamReader = new StreamReader("Hoadon.txt");
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string mahoadon = line.Split("#")[0];
                    string madat = line.Split("#")[1];
                    string ngaymua = line.Split("#")[2];
                    string ngayban = line.Split("#")[3];
                    string makhachhang = line.Split("#")[4];
                    string manhanvien = line.Split("#")[5];
                    string hinhthucthanhtoan = line.Split("#")[6];
                    double  thanhtien = double.Parse(line.Split("#")[7]);
                    arrayList.Add(new HoaDon(mahoadon, madat, ngaymua, ngayban, makhachhang, manhanvien, hinhthucthanhtoan, thanhtien));
                }
                streamReader.Close();
            }
        }

        public void GhiFile(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter("Hoadon.txt");
            foreach (HoaDon hoaDon in arrayList)
            {
                streamWriter.WriteLine(hoaDon.ToString());
            }
            streamWriter.Close();
        }
    }
}
