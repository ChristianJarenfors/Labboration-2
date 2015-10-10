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
        public static int menuChoice1 = 0;
        public static int menuChoice2 = 0;
        static void Main(string[] args)
        {

            mainMenu();
            ////Selektion
            //Uppgift1_1_WaterBoil();
            //Uppgift1_2_PekkasPonnys();
            //Uppgift1_3_GårDetAttBada();
            ////Iteration-For
            //Uppgift2_1_FizzBuzz();
            //Uppgift2_2_KortLeken();
            ////Iteration-While
            //Uppgift3_1_Quack();
            //Uppgift3_2_MjauMachine();
            ////Valfri Loop
            //Uppgift4_1_Box_a();
            ////oooo
            ////oooo
            ////oooo
            ////oooo
            //Uppgift4_1_Box_b();
            ////oooo
            ////ooo
            ////oo
            ////o
            //Uppgift4_1_Box_c();
            ////xoxo
            ////xoxo
            ////xoxo
            ////xoxo
            //Uppgift4_1_Box_d();
            ////xxxx
            ////oooo
            ////xxxx
            ////oooo
            //Uppgift4_1_Box_e();
            ////xooo
            ////oxoo
            ////ooxo
            ////ooox
            //Uppgift4_1_Box_f();
            ////ooox
            ////ooxo
            ////oxoo
            ////xooo
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
        #endregion
        #region b.        
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
        #endregion
        #region c.
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
        #region d.
        private static void Uppgift4_1_Box_d()
        {
            Menu();
            for (int j = 0; j < jj; j++)
            {
                for (int i = 0; i < ii; i++)
                {
                    if (j % 2 == 0)
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
        #region e.
        private static void Uppgift4_1_Box_e()
        {
            Menu();
            for (int j = 0; j < jj; j++)
            {
                for (int i = 0; i < ii; i++)
                {
                    if (i==j)
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
        #region f.
        private static void Uppgift4_1_Box_f()
        {
            Menu();
            for (int j = 0; j < jj; j++)
            {
                for (int i = 0; i < ii; i++)
                {
                    if ((i+1)==(ii- j))
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
        private static void mainMenu()
        {
            while ((0<=menuChoice1 && menuChoice1 <=4))
            {
                menuChoice1 = miniMain(menuChoice1);
            }
                
            
            
        }
        private static int miniMain(int val1)
        {
            Console.WriteLine("Vilket program vill du köra? Avsluta med #");
            Console.WriteLine("#1. Selektion (3 Options)");
            if (val1 == 1)
            {
                Console.WriteLine("\t#1.1 Does the water boil?");
                Console.WriteLine("\t#1.2 Pekkas Ponny");
                Console.WriteLine("\t#1.3 Can we take a bath?");
            }
            Console.WriteLine("#2. Iteration-For (2 Options)");
            if (val1 == 2)
            {
                Console.WriteLine("\t#2.1 FizzBuzz!");
                Console.WriteLine("\t#2.2 Deck of Cards");
            }
            Console.WriteLine("#3. Iteration-While (2 Options");
            if (val1 == 3)
            {
                Console.WriteLine("\t#3.1 Quack");
                Console.WriteLine("\t#3.2 MjauMachine");
            }
            Console.WriteLine("#4. Valfri Loop (6 Options)");
            if (val1 == 4)
            {
                Console.WriteLine("\t#4.a Even");
                Console.WriteLine("\t#4.b");
                Console.WriteLine("\t#4.c x kolumns");
                Console.WriteLine("\t#4.d x rows");
                Console.WriteLine("\t#4.e Backslash");
                Console.WriteLine("\t#4.f Slash");
            }
            if (val1 == 0)
            {
                Console.Write("Vilken grupp vill du gå in i? ");
                //Console.Write(val1 + ".");
                int.TryParse(Console.ReadLine(), out val1);
                Console.Clear();
            }
            else
            {
                Console.Write("Vilken undermeny vill du gå in i? {0}:",val1);
                choiceRunner(val1,abcdef(Console.ReadLine()));
                Console.ReadKey();
                Console.Clear();
                val1 = 0;
            }
            return val1;
        }
        private static void choiceRunner(int val1, int val2)
        {
            switch (val1)
            {
                default: { break; }
                case 1:
                    {
                        switch (val2)
                        {
                            default:
                                {
                                    break;
                                }
                            case 1:
                                {
                                    Uppgift1_1_WaterBoil();
                                    break;
                                }
                            case 2:
                                {
                                    Uppgift1_2_PekkasPonnys();
                                    break;
                                }
                            case 3:
                                {
                                    Uppgift1_3_GårDetAttBada();
                                    break;
                                }
                        }
                        break;
                    }
                case 2:
                    {
                        switch (val2)
                        {
                            default:
                                {
                                    break;
                                }
                            case 1:
                                {
                                    Uppgift2_1_FizzBuzz();
                                    break;
                                }
                            case 2:
                                {
                                    Uppgift2_2_KortLeken();
                                    break;
                                }
                        }
                        break;
                    }
                case 3:
                    {
                        switch (val2)
                        {
                            default:
                                {                                 
                                    break;
                                }
                            case 1:
                                {
                                    Uppgift3_1_Quack();
                                    break;
                                }
                            case 2:
                                {
                                    Uppgift3_2_MjauMachine();
                                    break;
                                }
                        }
                        break;
                    }
                case 4:
                    {
                        switch (val2)
                        {
                            default:
                                {
                                    break;
                                }
                            case 1:
                                {
                                    Uppgift4_1_Box_a();
                                    break;
                                }
                            case 2:
                                {
                                    Uppgift4_1_Box_b();
                                    break;
                                }
                            case 3:
                                {
                                    Uppgift4_1_Box_c();
                                    break;
                                }
                            case 4:
                                {
                                    Uppgift4_1_Box_d();
                                    break;
                                }
                            case 5:
                                {
                                    Uppgift4_1_Box_e();
                                    break;
                                }
                            case 6:
                                {
                                    Uppgift4_1_Box_f();
                                    break;
                                }
                        }
                        break;
                    }

            }
        }
        private static int abcdef(string s)
        {
            int returning = 0;
            int.TryParse(s, out returning);
            switch (s)
            {
                default:
                    { break; }
                case "a":
                    {
                        returning = 1;
                        break;
                    }
                case "b":
                    {
                        returning = 2;
                        break;
                    }
                case "c":
                    {
                        returning = 3;
                        break;
                    }
                case "d":
                    {
                        returning = 4;
                        break;
                    }
                case "e":
                    {
                        returning = 5;
                        break;
                    }
                case "f":
                    {
                        returning = 6;
                        break;
                    }
               }
            
            return returning;
        }
    }
}
