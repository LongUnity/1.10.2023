using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitaplon
{
    internal class Namdongco:ThucPham
    {    

        public Namdongco() 
        {
            Carb = 1;
            Fat = 0;
            Fatbaohoa = 0;
            Protein = 15;
            Calo = 10;
        }
        public override void nhap()
        {
            Console.WriteLine("Nhap khoi luong nam dong co:");
            base.nhap();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"{Gam}g Nam dong co co: {Carb}g Carb, {Fat}g Fat, {Fatbaohoa}g Fat bao hoa, {Protein}g Protein, {Calo}Kcal Calo");
        }
    }
}
