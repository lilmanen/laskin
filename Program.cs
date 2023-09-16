using System;

namespace Kalkulaattori
{
    class Program
    {
        static void Main(string[] args)
        {
            bool LaskinLaskee = true;
            while (LaskinLaskee)

            {
                try
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("***** LASKIN *****");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");

                    Console.Write("Syötä luku: ");
                    double luku1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(" ");

                    Console.Write("Syötä toiminto: ");
                    string toiminto = Console.ReadLine();


                    Console.WriteLine(" ");

                    Console.Write("Syötä toinen luku: ");
                    double luku2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(" ");


                    switch (toiminto)

                    {
                        case "+":
                            Console.Write(luku1 + luku2);
                            break;

                        case "-":
                            Console.Write(luku1 - luku2);
                            break;

                        case "*":
                            Console.Write(luku1 * luku2);
                            break;


                        case "/":
                            if (luku2 != 0)
                            {
                                Console.Write(luku1 / luku2);
                            }
                            else
                            {
                                Console.WriteLine("Nollalla ei voi jakaa");
                                Console.WriteLine("Kokeile uudelleen!");
                            }
                            break;

                        default:
                            Console.WriteLine("Virheellinen toiminto. Sallitut toiminnot: +, -, * tai /");
                            Console.WriteLine("Kokeile uudelleen!");
                            break;


                    }

                

                }

                catch
                {
                    Console.WriteLine("Virheellinen muoto, käytä numeroita");
                    Console.WriteLine("Kokeile uudelleen!");
                }



                Console.ReadLine();


            }

    

        }
    }

}