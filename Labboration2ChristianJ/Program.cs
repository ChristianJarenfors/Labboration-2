using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labboration2ChristianJ
{
    class Program
    {
        public static int value = 0;
          
        static void Main(string[] args)
        {
            //Uppgift 1
            Uppgift1_1_WaterBoil();
            Uppgift1_2_PekkasPonnys();
            Uppgift1_3_GårDetAttBada();
            Uppgift2_2_FizzBuzz();
            Console.ReadKey();
        }

        


        #region Uppgift 1.1 Metoder

        private static void Uppgift1_1_WaterBoil()
        {
            Console.Write("Hur varmt är vattnet? ");
            int.TryParse(Console.ReadLine(), out value);
            doesTheWaterBoil(value);
        }

        private static void doesTheWaterBoil(int temp)
        {
            if(temp>=100)
            {
                Console.WriteLine("Det kokar!!!");
            }else if(temp>=50)
            {
                Console.WriteLine("Det är halvvägs nu.");
            }
            else
            {
                Console.WriteLine("Det kokar inte.");
            }
        }
        #endregion

        #region Uppgift 1.2 Metoder
        private static void Uppgift1_2_PekkasPonnys()
        {
            Console.Write("Hur gammal är du? ");
            int.TryParse(Console.ReadLine(), out value);
            if (value<12)
            {
                Console.WriteLine("Du är för ung för att rida");
            }
            else
            {
                Console.Write("Hur mycket väger du? ");
                int.TryParse(Console.ReadLine(), out value);
                ponnyGroup(value);
            }
        }

        private static void ponnyGroup(int value)
        {
            if (value<=30)
            {
                Console.WriteLine("Du ska ha en A ponny.");
            }
            else if (value<=50)
            {
                Console.WriteLine("Du ska ha en B ponny.");
            }
            else if (value<=65)
            {
                Console.WriteLine("Du ska ha en C ponny.");
            }
            else
            {
                Console.WriteLine("Det finns ingen ponny för denna viktklass.");
            }
        }
        #endregion

        #region Uppgift 1.3 Metoder
        private static void Uppgift1_3_GårDetAttBada()
        {

            Console.Write("Finns det vatten? (ja/nej): ");
            if(Console.ReadLine()=="ja")
            {
                Console.Write("Vilken temperatur har vattnet? ");
                int.TryParse(Console.ReadLine(), out value);
                if (value>=30)
                {
                    Console.WriteLine("Varsågod att bada.");
                }
                else
                {
                    Console.WriteLine("Det går inte att bada. (Vattnet är för kallt)");
                }
            }
            else
            {
                Console.WriteLine("Det går inte att bada. (Inget vatten)");
            }

        }
        #endregion

        #region Uppgift 2.1 Metoder
        private static void Uppgift2_2_FizzBuzz()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i%3==0||i%5==0)
                {
                    Console.Write(i + ". ");
                    if (i % 3==0)
                    {
                        Console.Write("Fizz");
                    }
                    if (i%5==0)
                    {
                        Console.Write("Buzz");
                    }
                    Console.WriteLine();
                }
            }
        }
        #endregion
    }
}
