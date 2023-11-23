using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_lam
{
    class MauLuanVanNghienCuu : Sach
    {
        public string tendetai;
        public string tentacgia;
        public int nth;
        public string linhvucnghiencuu;
        public MauLuanVanNghienCuu()
            : base()
        {
            tendetai = "";
            tentacgia = "";
            nth = 0;
            linhvucnghiencuu = "";
        }
        public MauLuanVanNghienCuu(string tendetai, string tentacgia, string linhvucnghiencuu, int nth, string maso)
            : base(maso)
        {
            this.tentacgia = tentacgia;
            this.tendetai = tendetai;
            this.linhvucnghiencuu = linhvucnghiencuu;
            this.nth = nth;

        }
        public void nhap()
        {
            Console.WriteLine(" Nhap ten de tai: ");
            tendetai = Console.ReadLine();
            Console.WriteLine(" Nhap ten tac gia: ");
            tentacgia = Console.ReadLine();
            Console.WriteLine(" Nhap linh vuc nghien cuu : ");
            linhvucnghiencuu = Console.ReadLine();
            Console.WriteLine(" Nhap nam thuc hien: ");
            nth = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine(" Ten de tai la:{0}", tendetai);
            Console.WriteLine(" Ten tac gia la:{0}", tentacgia);
            Console.WriteLine(" Linh vuc nghien cuu la:{0}", linhvucnghiencuu);
            Console.WriteLine(" Ten nam thuc hien la:{0}", nth);
        }
    }

}
