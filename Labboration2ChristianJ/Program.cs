using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labboration2ChristianJ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift 1
            Uppgift1_1_WaterBoil();
            Uppgift1_2_PekkasPonnys();
            Uppgift1_3_GårDetAttBada();
            Console.ReadKey();
        }

        
        #region Uppgift 1.1 Metoder

        private static void Uppgift1_1_WaterBoil()
        {
            Console.Write("Hur varmt är vattnet? ");
            int temp = 0;
            int.TryParse(Console.ReadLine(), out temp);
            doesTheWaterBoil(temp);
        }

        private static void doesTheWaterBoil(int temp)
        {
            if(temp==100)
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
            int value = 0;
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
            throw new NotImplementedException();
        }
        #endregion
    }
}
