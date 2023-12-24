using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdalGrossMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Ürün Tanımlamaları
            List<Urun> urunler = new List<Urun>();

            Urun u = new Urun();
            u.Isim = "Cips";
            u.Kategori = "Atıştırmalık";
            u.Fiyat = 22;
            u.Stok = 20;
            urunler.Add(u);

            urunler.Add(new Urun("Kola","İçecekler",35,10));
            urunler.Add(new Urun("Çikolata", "Atıştırmalık", 25, 20));
            urunler.Add(new Urun("Sarı Kola", "İçecekler", 20, 45));
            #endregion

            #region Listeleme - Satın Aldırma

            string secenek = "e";
            double toplam = 0;
            while(secenek == "e")
            {
                Console.Clear();
                Console.WriteLine("Lütfen Seçiniz");
                Console.WriteLine("1) Tümü \n2) Atıştırmalıklar\n3) İçecekler");
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        for (int i = 0; i < urunler.Count; i++)
                        {
                            Urun urun = urunler[i];
                            Console.WriteLine((i + 1) + ")" + " " + urun.Isim + " " + urun.Fiyat + "TL " + "Stok:" + urun.Stok);
                        }
                    break;
                    
                    case "2":
                        for (int i = 0; i < urunler.Count; i++)
                        {
                            Urun urun = urunler[i];
                            Console.WriteLine((i + 1) + ")" + " " + urun.Isim + " " + urun.Fiyat + "TL " + "Stok:" + urun.Stok);
                        }
                    break;
                    case "3":
                        for (int i = 0; i < urunler.Count; i++)
                        {
                            Urun urun = urunler[i];
                            Console.WriteLine((i + 1) + ")" + " " + urun.Isim + " " + urun.Fiyat + "TL " + "Stok:" + urun.Stok);
                        }
                    break;
                }

                Console.WriteLine("Lütfen almak istediğiniz ürünün numarasını giriniz");
                int urunno = Convert.ToInt32(Console.ReadLine());

                int index = urunno - 1;

                Console.WriteLine("Kaç adet "+ urunler[index].Isim + " alacaksınız? Max = "+ urunler[index].Stok);
                int adet = Convert.ToInt32(Console.ReadLine());

                if (adet <= urunler[index].Stok)
                {
                    toplam += urunler[index].Fiyat * adet;
                    urunler[index].Stok -= adet; // Stoktan düşürme
                }

                Console.WriteLine("Alışverişe devam edecek misiniz? e/h");
                secenek = Console.ReadLine();
            }
            Console.WriteLine("Toplam = " + toplam+"TL");

            #endregion
        }
    }
}
