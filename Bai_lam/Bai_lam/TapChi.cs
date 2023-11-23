using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_lam
{
    class TapChi : Sach
    {
        public string tentapchi, nxb;
        public int sotrang, nah, soluong, giamuatapchi;
        public TapChi()
            : base()
        {
            tentapchi = "";
            nxb = "";
            sotrang = 0;
            nah = 0;
            soluong = 0;
            giamuatapchi = 0;

        }
        public TapChi(string tentapchi, string nxb, int sotrang, int nah, int soluong, int giamuatapchi, string maso)
            : base(maso)
        {
            this.tentapchi = tentapchi;
            this.nxb = nxb;
            this.soluong = soluong;
            this.sotrang = sotrang;
            this.nah = nah;
            this.giamuatapchi = giamuatapchi;
        }
        public void nhap()
        {
            Console.WriteLine(" Nhap ten tap chi: ");
            tentapchi = Console.ReadLine();
            Console.WriteLine(" Nhap nha xuat ban");
            nxb = Console.ReadLine();
            Console.WriteLine(" Nhap so trang: ");
            sotrang = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap nam an hanh");
            nah = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap so luong");
            soluong = int.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap gia mua tap chi");
            giamuatapchi = int.Parse(Console.ReadLine());

        }
        public void xuat()
        {
            Console.WriteLine(" Ten tap chi:{0} ", tentapchi);
            Console.WriteLine(" Nha xuat ban: {0}", nxb);
            Console.WriteLine(" So trang: {0}", sotrang);
            Console.WriteLine(" nam an hanh: {0}", nah);
            Console.WriteLine(" So luong:{0} ", soluong);
            Console.WriteLine(" gia mua tap chi:{0} ", giamuatapchi);
        }
    }
}
