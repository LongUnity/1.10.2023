using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitaplon
{
    internal abstract class ThucPham
    {
        public double Carb { get; set; }
        public double Fat { get; set; }
        public double Fatbaohoa { get; set; }
        public double Protein { get; set; }
        public double Calo { get; set; }
        public double Gam { get; set; }
        public ThucPham() { }

        public virtual void nhap()
        {
            Gam = double.Parse(Console.ReadLine());
            if (Gam <= 0)
            {
                Console.WriteLine("Khoi luong phai lon hon 0");
                nhap();
            }
        }
        public virtual void xuat()
        {
            if (Gam != 100)
            {
                Fat = (Gam * Fat) / 100;
                Fatbaohoa = (Gam * Fatbaohoa) / 100;
                Protein = (Gam * Protein) / 100;
                Calo = (Gam * Calo) / 100;
            }
        }
    }
}
