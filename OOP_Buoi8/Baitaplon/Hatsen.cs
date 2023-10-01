using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitaplon
{
    internal class Hatsen:ThucPham
    {

        public Hatsen() 
        {
            Carb = 17;
            Fat = 0;
            Fatbaohoa = 1;
            Protein = 4;
            Calo = 89;
        }
        public override void nhap()
        {
            Console.WriteLine("Nhap khoi luong hat sen:");
            base.nhap();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"{Gam}g hat sen co: {Carb}g Carb, {Fat}g Fat, {Fatbaohoa}g Fat bao hoa, {Protein}g Protein, {Calo}Kcal Calo");

        }
    }
}
