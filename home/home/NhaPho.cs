
using code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home
{
    public class NhaPho : KhuDat
    {
        public int sotang;
        public NhaPho(int sotang, string diadiem, double dongia, double dientich) : base(diadiem, dongia, dientich)
        {
            sotang = sotang;
        }
        public NhaPho() : base()
        {
            sotang = 0;
        }
        public void nhap()
        {
            base.nhap();
            Console.Write(" nhao so tang: ");
            sotang = int.Parse(Console.ReadLine());

        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine(" so tang la: " + sotang);

        }
        public override double TinhGiaban()
        {
            return dientich * dongia * sotang;
        }
        public override double TinhDienTich()
        {
            return dientich * sotang;
        }

    }
}

    

