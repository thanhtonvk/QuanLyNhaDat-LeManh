using System;
using System.Collections;
using System.Text;

namespace QuanLyNhaDat_LeManh.BLL.Interface
{
    interface ChucNang_IF
    {
        void Nhap(ArrayList arrayList);
        void Hien(ArrayList arrayList);
        void Sua(ArrayList arrayList);
        void Xoa(ArrayList arrayList);
        void TimKiem(ArrayList arrayList);
    }
}
