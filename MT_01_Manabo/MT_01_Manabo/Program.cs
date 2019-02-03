using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MT_01_Manabo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String choice;
            int decimal_num;

            // Menu
            Console.WriteLine("************Menu************");
            Console.WriteLine("[A] ==> decimal number to binary");
            Console.WriteLine("[B] ==> binary number to decimal");
            Console.WriteLine("[C] ==> decimal number to hexadecimal");
            Console.WriteLine("[D] ==> hexadecimal number to decimal");
            Console.WriteLine("[E] ==> hexadecimal number to binary");
            Console.WriteLine("[F] ==> binary number to hexadecimal");
            Console.WriteLine("[G] ==> a binary number to decimal using horner scheme");
            Console.WriteLine("[H] ==> a Roman to Arabic");
            Console.WriteLine("[I] ==> a Arabic to Roman");
            Console.WriteLine("[J] Exit Application\n");

            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();

            // Covert  decimal to binary
            if (choice == "A" || choice == "a")
            {
                Console.Write("Enter decimal number: ");
                decimal_num = Convert.ToInt32(Console.ReadLine());

                string binary = "";
                do
                {
                    binary = (decimal_num % 2) + binary;
                    decimal_num /= 2;
                }
                while (decimal_num > 0);

                Console.Write("The Binary is " + binary);

            // Covert binary to decimal
            }else if(choice == "B" || choice == "b"){
                Console.Write("Enter Binary number: ");
                string binary_num = Console.ReadLine();

                Console.Write("THe Decimal Number is " + Convert.ToInt32(binary_num,2));
            }
            else if (choice == "C" || choice == "c")
            {
                Console.Write("Enter Decimal number: ");
                string decimal_number = Console.ReadLine();

                Console.Write("THe HexaDecimal Number is " + int.Parse(decimal_number, System.Globalization.NumberStyles.HexNumber));

            }
            else if (choice == "D" || choice == "d")
            {
                Console.Write("Enter Hexadecimal number: ");
                string hex_num = Console.ReadLine();

                Console.Write("THe Decimal Number is " + Convert.ToInt32(hex_num, 16));
            }
            else if (choice == "E" || choice == "e")
            {
                Console.Write("Enter Hexadecimal number: ");
                string hexvalue = Console.ReadLine();
                Console.Write("The Binary is " + Convert.ToString(Convert.ToInt32(hexvalue, 16), 2));
            }
            else if (choice == "F" || choice == "f")
            {
                Console.Write("Enter binary number: ");
                string bin = Console.ReadLine();

                int rest = bin.Length % 4;
                bin = bin.PadLeft(rest, '0'); //pad the length out to by divideable by 4

                string output = "";

                for (int i = 0; i <= bin.Length - 4; i += 4)
                {
                    output += string.Format("{0:X}", Convert.ToByte(bin.Substring(i, 4), 2));
                }
                Console.Write("The Hexadecimal is " + output);
            }
            else if (choice == "G" || choice == "g")
            {
                Console.Write("To be solved!");
            }
            else if (choice == "H" || choice == "h"){
                Console.Write("Enter Roman Number: ");
                string roman = Console.ReadLine();
                Dictionary<char, short> lookup = new Dictionary<char, short>();
                lookup.Add('M', 1000);
                lookup.Add('C', 100);
                lookup.Add('L', 50);
                lookup.Add('X', 10);
                lookup.Add('V', 5);
                lookup.Add('I', 1);
                lookup.Add('m', 1000);
                lookup.Add('c', 100);
                lookup.Add('l', 50);
                lookup.Add('x', 10);
                lookup.Add('v', 5);
                lookup.Add('i', 1);

                int arabic = 0;

                for (int i = 0; i < roman.Count(); i++)
                {
                    //
                    // return 0 if not valid roman numeral
                    //
                    if (!lookup.ContainsKey(roman[i]))
                        break;

                    if (i == roman.Count() - 1)
                    {
                        arabic += lookup[roman[i]];
                    }
                    else
                    {
                        if (lookup[roman[i + 1]] > lookup[roman[i]]) arabic -= lookup[roman[i]];
                        else arabic += lookup[roman[i]];
                    }
                }

                Console.Write("The Arabic is " + arabic);


            }
            else if (choice == "I" || choice == "i")
            {
                Console.Write("Enter Roman Number: ");
                int roman = Convert.ToInt32(Console.ReadLine());

                int leftovers;              //store mod results
                string RomanNumeral = "";   //store roman numeral string
                Dictionary<string, int> dict = new Dictionary<string, int>()
                {
                    {"M", 1000},// 1000 = M
                    {"CM", 900},// 900 = CM
                    {"D", 500}, // 500 = D
                    {"CD", 400},// 400 = CD
                    {"C", 100}, // 100 = C
                    {"XC", 90}, // 90 = XC
                    {"L", 50},  // 50 = L
                    {"XL", 40}, // 40 = XL
                    {"X", 10},  // 10 = X
                    {"IX", 9},  // 9 = IX
                    {"V", 5},   // 5 = V
                    {"IV", 4},  // 4 = IV
                    {"I", 1},   // 1 = I
                };
                foreach (KeyValuePair<string, int> pair in dict)
                {
                    if (roman >= pair.Value)
                    {
                        leftovers = roman % pair.Value;
                        int remainder = (roman - leftovers) / pair.Value;
                        roman = leftovers;
                        while (remainder > 0)
                        {
                            RomanNumeral += pair.Key; remainder--;
                        }
                    }
                }
                Console.Write("The Arabic Number is : " + RomanNumeral);


            }
            else if (choice == "J" || choice == "j")
            {
                //Exit Program
                Console.Write("Program Terminated");
            }
            else
            {
                Console.Write("Invalid Choice");
            }

















            Console.ReadLine();
        }
    }
}
