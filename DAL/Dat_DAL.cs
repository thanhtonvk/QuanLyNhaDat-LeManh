using QuanLyNhaDat_LeManh.DAL.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using QuanLyNhaDat_LeManh.Enitities;
namespace QuanLyNhaDat_LeManh.DAL
{
    class Dat_DAL : DocGhiFile
    {
        public void DocFile(ArrayList arrayList)
        {
            //string madat,string tendat,double dientich,double giatri,string ngaymua,string ngayban
            if (File.Exists("Dat.txt"))
            {
                StreamReader streamReader = new StreamReader("Dat.txt");
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string madat = line.Split("#")[0];
                    string tendat = line.Split("#")[1];
                    double dientich = double.Parse(line.Split("#")[2]);
                    double giatri = double.Parse(line.Split("#")[3]);
                    string ngaymua = line.Split("#")[4];
                    string ngayban = line.Split("#")[5];
                   
                    arrayList.Add(new Dat(madat,tendat,dientich,giatri,ngaymua,ngayban));
                }
                streamReader.Close();
            }
        }

        public void GhiFile(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter("Dat.txt");
            foreach (Dat dat in arrayList)
            {
                streamWriter.WriteLine(dat.ToString());
            }
            streamWriter.Close();
        }
    }
}
