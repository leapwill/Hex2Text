using System;
using System.Text;
using System.IO;

namespace Hex2Text
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //get input and make usable
                Console.WriteLine("Enter your hex codes, each character separated by a space: ");
                Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
                string input = Console.ReadLine();
                string[] hexIn = input.Split(' ');

                try
                {
                    //do conversion
                    for (int i = 0; i < hexIn.Length; i++)
                    {
                        //Console.Write("\n" + hexIn[i] + " = ");
                        int hexNum = int.Parse(hexIn[i], System.Globalization.NumberStyles.AllowHexSpecifier);
                        Console.Write((char)hexNum);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nIt appears your input is in an invalid format. Verify correctness and try again.");
                }
                catch (Exception)
                {

                    Console.WriteLine("\nAn unknown error has occurred. Post on Github.");
                }
                
                Console.WriteLine("\nDone!");
            }
        }
    }
}
