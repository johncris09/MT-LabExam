using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MIT_05_MANABO
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator cal = new Calculator();
            int choice;
            double fnum, snum;
            Console.WriteLine("---- Menu ----");
            Console.WriteLine("[1] -> Add");
            Console.WriteLine("[2] -> Minus");
            Console.WriteLine("[3] -> Times");
            Console.WriteLine("[4] -> Divide");
            Console.WriteLine("[5] -> Modulus");
            Console.WriteLine("[0] -> Exit");

            try
            {
                Console.Write("Enter your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
            
                switch (choice)
                {
                    case 1:
                        // Addition
                        Console.Write("Enter First Number: ");
                        fnum = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Second Number: ");
                        snum = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Sum: " + cal.Add(fnum, snum));
                        break;
                    case 2:
                        // Subtraction
                        Console.Write("Enter First Number: ");
                        fnum = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Second Number: ");
                        snum = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Difference: " + cal.Minus(fnum, snum));
                        break;
                    case 3:
                        // Multiplication
                        Console.Write("Enter First Number: ");
                        fnum = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Second Number: ");
                        snum = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Product: " + cal.Times(fnum, snum));
                        break;
                    case 4:
                        // Division
                        Console.Write("Enter First Number: ");
                        fnum = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Second Number: ");
                        snum = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Quotient: " + cal.Divide(fnum, snum));
                        break;
                    case 5:
                        // Division
                        Console.Write("Enter First Number: ");
                        fnum = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter Second Number: ");
                        snum = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Result: " + cal.Modulu(fnum, snum));
                        break;
                    case 0:
                        // Exit Program
                        Console.Write("Program Terminated....");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }

            

            Console.ReadLine();
        }
    }
}
