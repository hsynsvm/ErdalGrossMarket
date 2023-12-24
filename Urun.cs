using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdalGrossMarket
{
    public class Urun
    {
        public string Isim {  get; set; }

        public string Kategori { get; set; }

        public double Fiyat { get; set; }

        public int Stok { get; set; }

        public Urun()
        {

        }

        public Urun(string isim,string kategori,double fiyat,int stok) 
        {
            Isim = isim;
            Kategori = kategori;
            Fiyat = fiyat;
            Stok = stok;
        }


    }
}
