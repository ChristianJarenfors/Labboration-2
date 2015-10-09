using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labboration2ChristianJ
{
    class Program
    {
        private static int jj = 0,ii=0;
        public static int value = 0;
        public static string svar= ""; 
        static void Main(string[] args)
        {
            //Uppgift 1
            //Uppgift1_1_WaterBoil();
            //Uppgift1_2_PekkasPonnys();
            //Uppgift1_3_GårDetAttBada();
            //Uppgift2_1_FizzBuzz();
            //Uppgift2_2_KortLeken();
            //Uppgift3_1_Quack();
            //Uppgift3_2_MjauMachine();
            Uppgift4_1_Box_a();
            Uppgift4_1_Box_b();
            Uppgift4_1_Box_c();
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
        private static void Uppgift2_1_FizzBuzz()
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

        #region Uppgift 2.2 Metoder
        private static void Uppgift2_2_KortLeken()
        {
            string[] suits = new string[4] {"Hjärter","Klöver","Ruter","Spader" };
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    Console.Write(suits[i]+ " ");
                    if (j>10)
                    {
                        #region Klädswitch 
                        switch (j)
                        {
                            default:
                                {
                                    break;
                                }
                            case 11:
                                {
                                    Console.WriteLine("Knekt");
                                    break;
                                }
                            case 12:
                                {
                                    Console.WriteLine("Dam");
                                    break;
                                }
                            case 13:
                                {
                                    Console.WriteLine("Kung");
                                    break;
                                }
                        }
                        #endregion
                    }
                    else if (j>1)
                    {
                        Console.WriteLine(j);
                    }
                    else
                    {
                        Console.WriteLine("Ess");
                    }
                }
            }
        }
        #endregion

        #region Uppgift 3.1 Metoder
        private static void Uppgift3_1_Quack()
        {
            svar = "quack";
            while (svar=="quack")
            {
                Console.Write("quack? ");
                svar = Console.ReadLine();
                if (svar=="quack")
                {
                    Console.WriteLine("Quack, Quack!");
                }
                else
                {
                    Console.WriteLine("You are not a duck!");
                }
            }
        }
        #endregion

        #region Uppgift 3.2 Metoder
        private static void Uppgift3_2_MjauMachine()
        {
            value = 1;
            while(value!=0)
            {
                Console.Write("Hur många Mjau vill du ha? ");
                int.TryParse(Console.ReadLine(), out value);
                if (value != 0)
                {
                    for (int i = 0; i < value; i++)
                    {
                        Console.Write("Mjau ");
                    }
                    Console.WriteLine();
                }
                else {
                    Console.WriteLine(":(");
                }
            }
        }
        #endregion

        #region Uppgift 4.1 Metoder
        private static void Menu()
        {
            Console.Write("Hur många rader vill du ha? ");
            int.TryParse(Console.ReadLine(), out jj);
            Console.Write("Hur många kolumner vill du ha? ");
            int.TryParse(Console.ReadLine(), out ii);
        }
        #region a.
        private static void Uppgift4_1_Box_a()
        {
            Menu();
            for (int j = 0; j < jj; j++)
            {
                for (int i = 0; i < ii; i++)
                {
                    Console.Write("o");
                }
                Console.WriteLine();
            }
        }
        private static void Uppgift4_1_Box_b()
        {
            Menu();
            for (int j = 0; j < jj; j++)
            {
                for (int i = 0; i < (ii-j); i++)
                {
                    Console.Write("o");
                }
                Console.WriteLine();
            }
        }
        private static void Uppgift4_1_Box_c()
        {
            Menu();
            for (int j = 0; j < jj; j++)
            {
                for (int i = 0; i < ii; i++)
                {
                    if (i%2==0)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write("o");
                    }
                    
                }
                Console.WriteLine();
            }
        }

        #endregion
        #endregion
    }
}
