using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeymaCankus_Odev_SayisalLoto
{
    public static class KeyMethods
    {
        public static void PressEnter() 
        {
            ConsoleKeyInfo karakter;
            do
            {
                karakter = Console.ReadKey(true);
                if (karakter.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir tuşa basınız.");
                }
            } while (karakter.Key != ConsoleKey.Enter);
        }
        public static int ReadInt()
        {
            ConsoleKeyInfo karakter;
            string sayi = "";
            int deger = 0;
            do
            {
                karakter = Console.ReadKey(true);
                if (karakter.Key != ConsoleKey.Backspace && karakter.Key != ConsoleKey.Enter)
                {
                    bool kontrol;
                    kontrol = int.TryParse(karakter.KeyChar.ToString(), out deger);
                    if (kontrol)
                    {
                        sayi += karakter.KeyChar;
                        Console.Write(karakter.KeyChar);
                    }
                    
                }
                else
                {
                    if (karakter.Key == ConsoleKey.Backspace && sayi.Length > 0)
                    {
                        sayi = sayi.Substring(0, sayi.Length - 1);
                        Console.Write("\b \b");
                    }
                    else if (karakter.Key == ConsoleKey.Enter && sayi.Length ==0)
                    {
                        sayi = $"{deger}";
                        Console.Write(sayi);
                    }
                }
                
            } while (karakter.Key != ConsoleKey.Enter);
            return int.Parse(sayi);
        }
    }
}
