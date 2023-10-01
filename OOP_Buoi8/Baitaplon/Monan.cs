using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitaplon
{
    internal class Monan
    {

        public List<ThucPham> ds { get; set; }

        public Monan() { }
        public void nhap()
        {
            ds = new List<ThucPham>();

            ThucPham a= new Ga();
            a.nhap();
            ds.Add(a);
            ThucPham b = new Hatsen();
            b.nhap();
            ds.Add(b);
            ThucPham c = new Carot();
            c.nhap();
            ds.Add(c);
            ThucPham d = new Taodo();
            d.nhap();
            ds.Add(d);
            ThucPham e = new Namdongco();
            e.nhap();
            ds.Add(e);
        }
        public void xuat()
        {

            foreach (var item in ds)
            {
                item.xuat();
            }
        }
        
        public double tongCarb()
        {
            double tongcarb = 0;
            
            foreach (var item in ds)
            {
                tongcarb += item.Carb;
                
            }
            return tongcarb;
        }
        public double tongFat()
        {            
            double tongfat = 0;            
            foreach (var item in ds)
            {                
                tongfat += item.Fat;
            }
            return tongfat;
        }
        public double tongFatbh()
        {
            
            double tongfatbh = 0;
            
            foreach (var item in ds)
            {
                
                tongfatbh += item.Fatbaohoa;
                
            }

            return tongfatbh;
        }
        public double tongProtein()
        {            
            double tongprotein = 0;
            foreach (var item in ds)
            {
               
                tongprotein += item.Protein;
            }

            return tongprotein;
        }
        public double tongCalo()
        {
            double tongcalo = 0;
            foreach (var item in ds)
            {

                tongcalo += item.Calo;
            }

            return tongcalo;
        }

    }
}
