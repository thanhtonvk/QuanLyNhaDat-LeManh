using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaDat_LeManh.Enitities
{
    class Dat
    {
        private string madat, tendat, ngaymua, ngayban;
        private double dientich, giatri;
        public Dat(string madat,string tendat,double dientich,double giatri,string ngaymua,string ngayban)
        {
            this.madat = madat;
            this.tendat = tendat;
            this.ngayban = ngayban;
            this.ngaymua = ngaymua;
            this.dientich = dientich;
            this.giatri = giatri;
        }
        override
            public string ToString()
        {
            return madat + "#" + tendat + "#" + dientich + "#" + giatri + "#" + ngaymua + "#" + ngayban;
        }
        public string Madat { get => madat; set => madat = value; }
        public string Tendat { get => tendat; set => tendat = value; }
        public string Ngaymua { get => ngaymua; set => ngaymua = value; }
        public string Ngayban { get => ngayban; set => ngayban = value; }
        public double Dientich { get => dientich; set => dientich = value; }
        public double Giatri { get => giatri; set => giatri = value; }
    }
}
