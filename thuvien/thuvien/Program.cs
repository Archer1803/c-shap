
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thuvien;

namespace Bai_lam
{
    interface Iquanly
    {
        public void loaisach();
    }
    class thuvien
    {
        static void Main(string[] args)
        {
            sach s = new sach();
            Iquanly q = s.Creatsach(2);
            q.loaisach();
            Console.ReadKey();
        }
    }
}

