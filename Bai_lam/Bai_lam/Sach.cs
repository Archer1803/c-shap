using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_lam
{
    class Sach
    {
        protected  string maso;
        public Sach()
        {
            maso = "";
        }
        public  Sach(string maso)
        {
            this.maso = maso;
        }
        public void nhap()
        {
            Console.Write(" Nhap ma so sach ma ban chon ");
            maso = Console.ReadLine();

        }
        public void xuat()
        {
            Console.Write(" Ma so sach la:{0} ", maso);

        }
    }
}
