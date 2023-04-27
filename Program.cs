namespace SeymaCankus_Odev_SayisalLoto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayisalLoto oyna = new SayisalLoto();
            ConsoleKeyInfo cevap;

            do
            {
                Console.Clear();
                oyna.SayisalLotoV1();
                Console.WriteLine("Yeniden oynamak ister misiniz? Herhangi bir tuşa basın.");
                Console.WriteLine("Eğer çıkmak isterseniz \"esc\" tuşuna basın.");
                cevap = Console.ReadKey(true);
                if (cevap.Key == ConsoleKey.Escape)
                {
                    break;
                }

            } while (cevap.Key != ConsoleKey.Escape);
        }
    }
}