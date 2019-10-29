using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MY VERY OWN AWESOME DEGREE CONVERTER\n");

            while (true)
            {
                Console.Write("Choose degree (C or F): ");
                string d = Console.ReadLine().ToLower();

                //CELCIUS TILL FAHRENHEIT
                if (d == "c")
                {
                    try
                    {
                        Console.WriteLine("You have choosen Celsius");
                        Console.Write("\nEnter degrees: ");
                        int celsius = Convert.ToInt32(Console.ReadLine());
                        double fahrenheit = C2F(celsius);
                        Console.WriteLine("\n" + celsius + " degree Celsius equals " + fahrenheit + " degree Fahrenheit" + "\n\n");
                        Console.Write("Start over (yes/no? ");
                        string so = Console.ReadLine().ToLower();
                        if (so == "yes")
                        {
                            Console.WriteLine("\n");
                        }

                        else if (so == "no")
                        {
                            Console.WriteLine("Have a nice day!");
                            System.Threading.Thread.Sleep(1000);
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Hmmm....\n");
                        }
                    }


                    catch (System.FormatException)
                    {
                        Console.WriteLine("Wrong input! Must be a number.\n");
                    }
                }

                //FAHRENHEIT TILL CELSIUS
                else if (d == "f")
                {
                    try
                    {
                        Console.WriteLine("You have choosen Fahrenheit");
                        Console.Write("\nEnter degrees: ");
                        int fahrenheit = Convert.ToInt32(Console.ReadLine());
                        double celsius = F2C(fahrenheit);
                        Console.WriteLine("\n" + fahrenheit + " degree Fahrenheit equals " + celsius + " degree Celsius" + "\n\n");
                        Console.Write("Start over (yes/no? ");
                        string so = Console.ReadLine().ToLower();
                        if (so == "yes")
                        {
                            Console.WriteLine("\n");
                        }
                        else if (so == "no")
                        {
                            Console.WriteLine("Have a nice day!");
                            System.Threading.Thread.Sleep(1000);
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Hmmm....\n");
                        }
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Wrong input! Must be a number.\n");
                    }

                }

                //ELSE
                else
                {
                    Console.WriteLine("Wrong input!\n");
                }
            }
        }

        public static double F2C(double fahrenheit)
        {
            double celsius = (fahrenheit - 32) * 0.5556;
            return celsius;
        }

        public static double C2F(double celsius)
        {
            double fahrenheit = (celsius * 18 / 10 + 32);
            return fahrenheit;
        }
    }
}
