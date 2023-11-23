using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_lam
{
    class Program
    {
        static void Main(string[] args)
        {
            SachGiaoKhoa s = new SachGiaoKhoa();
            TapChi t = new TapChi();
            MauLuanVanNghienCuu m = new MauLuanVanNghienCuu();
            Sach h = new Sach();
            Console.WriteLine(" -------Nhap thong tin sach giao khoa --------");
            h.nhap();
            s.nhap();
                    
            Console.WriteLine(" -------Nhap thong tin tap chi --------");
            h.nhap();
            t.nhap();        
            Console.WriteLine(" -------Nhap thong tin mau luan van nghien cuu --------");
            h.nhap();
            m.nhap();
            Console.WriteLine(" -----Thông tin sach giao khoa------");
            h.xuat();
            s.xuat();
            Console.WriteLine(" -----Thông tin tap chi------");
            h.xuat();
            t.xuat();
            Console.WriteLine(" -----Thông tin mau luan van nghien cuu------");
            h.xuat();
            m.xuat();


            Console.ReadKey();
        }
    }
}
