using code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home
{
    public class SanVuon:KhuDat
    {
        private double dientivhsanvuon;
        public SanVuon(double dientivhsanvuon, string diadiem, double dongia, double dientich) : base(diadiem, dongia, dientich)
       
        {
            this.dientivhsanvuon = dientivhsanvuon;
        }
        public SanVuon() : base()
        {
            dientivhsanvuon = 0.0;
        }
        public void nhap()
        {
            base.nhap();
            Console.Write(" nhap so tang: ");
            dientivhsanvuon = double.Parse(Console.ReadLine());

        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine(" dien tich san vuon la: " + dientivhsanvuon);

        }
        public override double TinhGiaban()
        {
            return dientich * dongia + dientivhsanvuon * dongia * 0.5;
        }
        public override double TinhDienTich()
        {
            return dientivhsanvuon + dientich;
        }

    }
}
