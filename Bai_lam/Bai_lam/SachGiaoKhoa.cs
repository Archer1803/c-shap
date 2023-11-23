using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_lam
{
    class SachGiaoKhoa : Sach
    {
        public string ten;
        public string nxb;
        public int sotap, lop, nph, giamua;
        public SachGiaoKhoa():base()
        {
            ten = "";
            nxb = "";
            sotap = 0;
            lop = 1;
            nph = 0;
            giamua = 0;
        }
        public SachGiaoKhoa(string ten, string nxb, int sotap, int lop, int nph, int giamua, string maso)
            : base(maso)
        {
            this.ten = ten;
            this.nxb = nxb;
            this.sotap = sotap;
            this.lop = lop;
            this.nph = nph;
            this.giamua = giamua;
        }
        public void nhap()
        {
            Console.WriteLine(" Nhap ten: ");
            ten = Console.ReadLine();
            Console.WriteLine(" Nhap nxb: ");
            nxb = Console.ReadLine();
            Console.WriteLine(" Nhap so tap: ");
            sotap = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap lop: ");
            lop = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap nam phat hanh: ");
            nph = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap gia mua: ");
            giamua = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine(" Ten sach giao khoa la: {0}", ten);
            Console.WriteLine(" Nha xuat ban la: {0}", nxb);
            Console.WriteLine(" So tap: {0}", sotap);
            Console.WriteLine(" Lop: {0}", lop);
            Console.WriteLine(" Nam phat hanh:{0} ", nph);
            Console.WriteLine(" Gia mua:{0} ", giamua);
        }

    }
}
