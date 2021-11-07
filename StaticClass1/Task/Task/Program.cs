using Sqrt3;
using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------Ucuncu dereceden kok---------");
            Console.WriteLine(Mymath.Sqrt3(a));
        }
    }
}
