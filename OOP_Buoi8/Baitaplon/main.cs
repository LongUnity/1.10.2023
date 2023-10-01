using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitaplon
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Cothe a = new Cothe();
            a.nhap();

            Console.WriteLine("---------------");
            Monan monan = new Monan();
            monan.nhap();
            monan.xuat();

            Console.WriteLine("---------------");
            a.kiemTraCarb(monan);
            a.kiemTraFat(monan);
            a.kiemTraFatbh(monan);
            a.kiemTraProtein(monan);
            a.kiemTraCalo(monan);
            Console.WriteLine("---------------");
            Console.WriteLine("Can chay bo : "+a.thoiGianChayBo(monan)+" phut");




            Console.ReadKey();
        }
    }
}
