using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Baitaplon
{
    internal class Cothe
    {
        public double Carb { get; set; }
        public double Fat { get; set; }
        public double Fatbaohoa { get; set; }
        public double Protein { get; set; }
        public double Calo { get; set; }
        public int thoigianchay { get; set; }

        public Cothe() { }

        public void nhap()
        {
            Console.WriteLine("Nhap dinh muc Carb: ");
            Carb = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dinh muc Fat: ");
            Fat = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dinh muc Fat bao hoa: ");
            Fatbaohoa = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dinh muc Protein: ");
            Protein = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dinh muc Calo: ");
            Calo = double.Parse(Console.ReadLine());
        }

        public void kiemTraCarb(Monan monan)
        {
            if (this.Carb <= (monan.tongCarb() * 0.8))
            {
                Console.WriteLine("Du " + ((monan.tongCarb() * 0.8) - this.Carb)+"g Carb");
            }
            else
            {
                Console.WriteLine("Can nap them " + (this.Carb - (monan.tongCarb() * 0.8)) + "g Carb");
            }
        }
        public void kiemTraFat(Monan monan)
        {
            if (this.Fat <= (monan.tongFat() * 0.8))
            {
                Console.WriteLine("Du " + ((monan.tongFat() * 0.8) - this.Fat) + "g Fat");
            }
            else
            {
                Console.WriteLine("Can nap them " + (this.Fat - (monan.tongFat() * 0.8)) + "g Fat");
            }
        }
        public void kiemTraFatbh(Monan monan)
        {
            if (this.Fatbaohoa <= (monan.tongFatbh() * 0.8))
            {
                Console.WriteLine("Du " + ((monan.tongFatbh() * 0.8) - this.Fatbaohoa) + "g Fat bao hoa");
            }
            else
            {
                Console.WriteLine("Can nap them " + (this.Fatbaohoa - (monan.tongFatbh() * 0.8)) + "g Fat bao hoa");
            }
        }
        public void kiemTraProtein(Monan monan)
        {
            if (this.Protein <= (monan.tongProtein() * 0.8))
            {
                Console.WriteLine("Du " + ((monan.tongProtein() * 0.8) - this.Protein) + "g Protein");
            }
            else
            {
                Console.WriteLine("Can nap them " + (this.Protein - (monan.tongProtein() * 0.8)) + "g Protein");
            }
        }
        public int kiemTraCalo(Monan monan)
        {
            if (this.Calo <= (monan.tongCalo() * 0.8))
            {
                Console.WriteLine("Du " + ((monan.tongCalo() * 0.8) - this.Calo) + "Kcal Calo");
                return 1;
            }
            else
            {
                Console.WriteLine("Can nap them " + (this.Calo - (monan.tongCalo() * 0.8)) + "Kcal Calo");
                return 0;
            }
        }
        public double thoiGianChayBo(Monan monan)
        {
            if (this.kiemTraCalo(monan) == 1)
            {                
                return ((monan.tongCalo()- 600)/ 150)*30;//600calo dinh muc toi thieu 1 bua an chia 150 calo nhan 30phut
            }
            else return 0;
        }
    }
}
