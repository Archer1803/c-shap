using code;
using home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_lam
{
    class home
    {
        static void Main(string[] args)
        {
            List<KhuDat> danhsachbatdongsan = new List<KhuDat>();
            int chon = 0;
            KhuDat kd = new KhuDat();
            NhaPho np = new NhaPho();
            SanVuon sv = new SanVuon();
            do
            {
                Console.WriteLine(" danh sach bat dong san");
                Console.WriteLine(" 1. Khu dat");
                Console.WriteLine(" 2. nha pho");
                Console.WriteLine(" 3. nha san vuon");
                Console.WriteLine(" 4. thoat ");
                Console.WriteLine(" chon chuc nang");
                chon = int.Parse(Console.ReadLine());
                if (chon == 1)
                {              
                    kd.nhap();
                    danhsachbatdongsan.Add(kd);
                }
               else  if (chon == 2)
                {                 
                    np.nhap();
                    danhsachbatdongsan.Add(np);
                }
                else if ( chon == 3)
                {
                    sv.nhap();
                    danhsachbatdongsan.Add(sv);
                }
                else if ( chon == 4)
                {
                    break;
                }
            } while (true);
            Console.ReadKey();
         //   Console.Write("--------------------------------------------------------");
           // Console.Write(" xuat danh sach ");
          //  Console.WriteLine(" danh sach khu dat");
          //  kd.xuat();
         //   Console.WriteLine(" danh sach khu nha pho");
        //    np.xuat();
         //   Console.WriteLine(" danh sach san vuon");
          //  sv.xuat();
            foreach( var item in danhsachbatdongsan)
            {
                item.xuat();
                Console.WriteLine(" gia ban cua bds la: " + item.TinhGiaban());
                Console.WriteLine(" dien tich cua bds la:  " + item.TinhDienTich());
                Console.WriteLine(" ----------------------------");
            }
        }
    }
}