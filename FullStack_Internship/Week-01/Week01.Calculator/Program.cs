using System;
using System.Collections.Generic ;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week01.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter First Number = ");
                    int FN1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Operation ( + , - , * , / , %) : ");
                    string OP = Console.ReadLine();
                    Console.Write("Enter Second Number = ");
                    int SN2 = Convert.ToInt32(Console.ReadLine());


                    if (OP == "+")
                    {
                        int Sum = FN1 + SN2;
                        Console.WriteLine("Sum :- First Number + Scaund Number = " + Sum);
                    }
                    else if (OP == "-")
                    {
                        int Subtraction = FN1 - SN2;
                        Console.WriteLine("Subtraction :- First Number - Scaund Number = " + Subtraction);
                    }
                    else if (OP == "*")
                    {
                        int Multiplication = FN1 * SN2;
                        Console.WriteLine("Multiplication :- First Number * Scaund Number = " + Multiplication);
                    }
                    else if (OP == "/")
                    {
                        int Division = FN1 / SN2;
                        Console.WriteLine("Division :- First Number / Scaund Number = " + Division);
                    }
                    else if (OP == "%")
                    {
                        int Modulo = FN1 % SN2;
                        Console.WriteLine("Modulo :- First Number % Scaund Number = " + Modulo);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Operation! Please try again.");
                        continue;
                    }
                    

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                break;

            }
        }

       
    }

}
