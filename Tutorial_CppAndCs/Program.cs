using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CppAndCs
{
    public class Program

    {
        
        public const string CppFunctionsDLL = @"\x64\Debug\CppFunctions.dll";


        [DllImport(CppFunctionsDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int AddNumbers(int a, int b);

        [DllImport(CppFunctionsDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SubtractNumbers(int a, int b);

        static void Main(string[] args)
        {
            int input1;
            int input2;

            Console.Write("Input Number 1: ");

            if (!int.TryParse(Console.ReadLine(), out input1))
            {
                Console.WriteLine("Bad Input. Setting input1 to 5");
                input1 = 5;
            }

            Console.Write("Input number 2: ");

            if (!int.TryParse(Console.ReadLine(), out input2))
            {
                Console.WriteLine("Bad input. Setting input2 to 10");
                input2 = 10;
            }

            int output = AddNumbers(input1, input2);

            Console.WriteLine($"Output is: {output}");

            Console.ReadLine();
        }
    }
}