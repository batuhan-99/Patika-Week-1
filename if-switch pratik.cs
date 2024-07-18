using System;

namespace Pratikifelse
{
    class Program
    {
        static void Main(string[] args)
        { //Çok fazla seçenek olduğu için switch case metodunu kullandım.
            Console.WriteLine("Ruya Manavina Hos geldiniz!");
            Console.WriteLine("Elma = 2 TL \n" +
                "Armut = 3 TL \n" +
                "Çilek = 2 TL \n" +
                "Muz = 3 TL \n" +
                "Diger butun meyveler 4 TL");
            Console.WriteLine("Hangi meyveyi satin almak istersiniz? (Elma, Armut, Çilek, Muz, Diğer)");
            string meyve = Console.ReadLine();
            meyve = meyve.ToUpper();
            switch (meyve)
            {
                case "ARMUT":
                    Console.Write("Seçtiğiniz meyvenin fiyatı 3 TL'dir.");
                    break;
                case "ELMA":
                    Console.Write("Seçtiğiniz meyvenin fiyatı 2 TL'dir.");
                    break;
                case "ÇİLEK":
                    Console.Write("Seçtiğiniz meyvenin fiyati 2 TL'dir.");
                    break;
                case "MUZ":
                    Console.Write("Seçtiğiniz meyvenin fiyatı 3 TL'dir.");
                    break;
                case "DİGER":
                    Console.Write("Diğer meyveler 4 TL");
                    break;
                default:
                    Console.Write("Aradığınız meyve bulunamadı.");
                    break;
            }

            
        }
    }
}