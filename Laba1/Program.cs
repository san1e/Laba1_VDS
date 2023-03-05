using System;
using System.Linq;

namespace Laba1
{
    internal class Program
    {
        static string DualSys(int num)
        {
            int[] DualSys = new int[9];
            for (int i = 0; i < DualSys.Length; i++)
            {
                int Rem = num % 2;
                int num1 = num / 2;
                num = num1;
                DualSys[i] = Rem;
            }

            string str = string.Join(" ", DualSys.Reverse());
            return str;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введiть число вiд 0 до 65535");
            Console.Write("Десяткова система = ");
            int num = int.Parse(Console.ReadLine());
            string str = DualSys(num);
            Console.WriteLine($"Двiйкова  система = {str}");
        }
    }
}
