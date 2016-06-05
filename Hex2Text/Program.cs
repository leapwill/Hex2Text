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
                Console.WriteLine("Enter your hex codes, each character separated by a space: ");
                
                int readLineBuffer = 4094;
                Stream inputStream = Console.OpenStandardInput(readLineBuffer);
                byte[] inputBytes = new byte[readLineBuffer];
                int outputLength = inputStream.Read(inputBytes, 0, readLineBuffer);
                string input = new string(Encoding.UTF8.GetChars(inputBytes, 0, outputLength));


                string[] hexIn = input.Split(' ');

                string hexDebug = "";
                for (int i = 0; i < hexIn.Length; i++)
                {
                    hexDebug += hexIn[i] + "-";
                }
                Console.WriteLine(hexDebug);

                try
                {
                    for (int i = 0; i < hexIn.Length; i++)
                    {
                        //Console.Write("\n" + hexIn[i] + " = ");
                        int hexNum = int.Parse(hexIn[i], System.Globalization.NumberStyles.AllowHexSpecifier);
                        Console.Write((char)hexNum);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nIt appears your input was in an invalid format. Verify correctness and try again.");
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
