using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitaplon
{
    internal class Taodo:ThucPham
    {

        public Taodo() 
        {
            Carb = 3;
            Fat = 1;
            Fatbaohoa = 0;
            Protein = 1;
            Calo = 52;
        }
        public override void nhap()
        {
            Console.WriteLine("Nhap khoi luong tao do:");
            base.nhap();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine($"{Gam}g tao do co: {Carb}g Carb, {Fat}g Fat, {Fatbaohoa}g Fat bao hoa, {Protein}g Protein, {Calo}Kcal Calo");
        }
    }
}
