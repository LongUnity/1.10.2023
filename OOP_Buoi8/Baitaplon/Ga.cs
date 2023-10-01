using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitaplon
{
    internal class Ga:ThucPham
    {        

        public Ga() 
        {
            Carb = 0;
            Fat = 15;
            Fatbaohoa = 4;
            Protein = 17;
            Calo = 211;
        }
        public override void nhap()
        {
            Console.WriteLine("Nhap khoi luong ga:");
            base.nhap();

        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"{Gam}g ga co: {Carb}g Carb, {Fat}g Fat, {Fatbaohoa}g Fat bao hoa, {Protein}g Protein, {Calo}Kcal Calo");

        }
    }
}
