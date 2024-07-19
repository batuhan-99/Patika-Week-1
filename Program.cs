using System;

namespace yarisma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Kızınca tüküren hayvan hangisidir ? \n a) Lama b) Deve ");
            string cevap = Console.ReadLine();
            cevap = cevap.ToLower();
            if (cevap == "a")
                a = a + 1;
            Console.WriteLine("Dünya'ya en yakın gezegen hangisidir ? \n a) Venüs b) Mars ");
            cevap = Console.ReadLine();
            cevap = cevap.ToLower();
            if (cevap == "b")
                a = a + 1;
            if(a == 2)
            {
                Console.WriteLine("Tebrikler büyük ödülü kazandınız.");
                return;
            }
            Console.WriteLine(" 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ? \n a) 7 b) 12 ");
            cevap = Console.ReadLine();
            cevap = cevap.ToLower();
            if (cevap == "b")
                a = a + 1;
            if (a == 2)
                Console.WriteLine("Tebrikler büyük ödülü kazandınız.");
            else
                Console.WriteLine("Ödülü kazanamadınız.");
        }
    }
}