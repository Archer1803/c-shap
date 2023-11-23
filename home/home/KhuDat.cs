using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code
{
    public class KhuDat
    {
        protected string diadiem;
        protected double dongia;
        protected double dientich;
        public KhuDat()
        {
            diadiem = "";
            dongia = 0.0;
            dientich = 0.0;
        }
        public KhuDat(string diadiem, double dongia, double dientich)
        {
            this.diadiem = diadiem;
            this.dongia = dongia;
            this.dientich = dientich;
        }
        public virtual void nhap()
        {
            Console.Write(" Nhap dia diem: ");
            diadiem = Console.ReadLine();
            Console.Write(" nhap don gia");
            dongia = double.Parse(Console.ReadLine());
            Console.Write(" Nhap dien tich");
            dientich = double.Parse(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine("Dia diem la: " + diadiem);
            Console.WriteLine(" Don gia la: " + dongia);
            Console.WriteLine(" dien tich la: " + dientich);

        }
        public virtual double TinhGiaban()
        {
            Console.Write(" gia ban la: ");
            return dongia * dientich; // gia ban bang dientich*dongia
        }
        public virtual double TinhDienTich()
        {
            Console.Write("Dien tich la: ");
            return dientich;
        }
    }
}