using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Le Phu Qui
            Console.Write("Nhap chieu dai: ");
            float chieuDai = float.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            float chieuRong = float.Parse(Console.ReadLine());

            float dienTich = chieuDai * chieuRong;
            float chuVi = (chieuDai + chieuRong) * 2;
            Console.WriteLine("Dien tich cua hinh chu nhat la: {0}", dienTich);
            Console.WriteLine("Chu vi cua hinh chu nhat la: {0}", chuVi);
            Console.ReadKey();
        }
    }
}
