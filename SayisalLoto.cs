using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeymaCankus_Odev_SayisalLoto
{
    public class SayisalLoto
    {
        public int[] SayiUret()
        {
            Random random = new Random();
            int[] sayi = new int[6];
            for (int i = 0; i < sayi.Length; i++)
            {
                do
                {
                    sayi[i] = random.Next(0, 50);
                } while (!sayi.Contains(sayi[i]));
            }
            return sayi;
        }
        public int[] SayiGir()
        {
            int[] tahmin = new int[6];
            for (int i = 0; i < tahmin.Length; i++)
            {
                Console.WriteLine(); 
                Console.WriteLine($"Lütfen {i+1}. sayıyı giriniz.");
                tahmin[i] = KeyMethods.ReadInt();
                
            }
            return tahmin;
        }
        public void Sonuc(int[] sayi, int[] tahmin)
        {
            string tes = ""; //TahminEdilenSayılar
            int kazanc = 0;
            foreach (int s in sayi)
            {
                foreach (var t in tahmin)
                {
                    if (s == t)
                    {
                        tes += $"{s}" + ", ";
                        kazanc += 10;
                    }
                }
            }

            Console.WriteLine();

            if (tes == "")
            {
                Console.WriteLine($"Hiçbirini tahmin edemediniz :) Kazanç: {kazanc}k TL");
            }
            else
            {
                Console.WriteLine($"Tebrikler, tahmin ettiğiniz sayılar: {tes}kazancınız: {kazanc}k TL");
            }
        }
        public void SayisalLotoV1() 
        {
            #region Giris
            Console.WriteLine("Sayısal Loto oyununa hoşgeldiniz!");
            Console.WriteLine("0-50 arası 6 sayı girme hakkınız bulunmaktadır.");
            Console.WriteLine("Doğru tahmin ettiğiniz her sayı için 10k TL kazanırsınız.");
            Console.WriteLine("Başlamak için lütfen \"Enter\" tuşuna basınız. ");

            KeyMethods.PressEnter();
            #endregion

            int[] sayi = SayiUret();
            int[] tahmin = SayiGir();
            Sonuc(sayi, tahmin);

            

            
        }
    }
}
