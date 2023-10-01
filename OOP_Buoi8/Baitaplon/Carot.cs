using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitaplon
{
    internal class Carot:ThucPham
    {

        public Carot() 
        {
            Carb = 10;
            Fat = 3;
            Fatbaohoa = 0;
            Protein = 1;
            Calo = 41;
        }
        public override void nhap()
        {
            Console.WriteLine("Nhap khoi luong ca rot:");
            base.nhap();

        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"{Gam}g Ca rot co: {Carb}g Carb, {Fat}g Fat, {Fatbaohoa}g Fat bao hoa, {Protein}g Protein, {Calo}Kcal Calo");
        }
    }
}
