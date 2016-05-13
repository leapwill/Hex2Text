using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex2Text
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your hex codes, each character separated by a space:");
                string input = Console.ReadLine();
                string[] hexIn = input.Split(' ');

                foreach (string hexChar in hexIn)
                {
                    int hexNum = int.Parse(hexChar, System.Globalization.NumberStyles.AllowHexSpecifier);
                    Console.Write((char)hexNum);
                }
                Console.WriteLine("\nDone!");
            }
        }
    }
}
