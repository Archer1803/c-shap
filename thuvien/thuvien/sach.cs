using Bai_lam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuvien
{
    internal class sach
    {
        public Iquanly Creatsach(int so)
        {

            switch (so)
                {
                case 1:
                    return new xahoi();
                case 2:
                    return new tunhien();
                default:
                    return null;
                  }
        }
    }
}
