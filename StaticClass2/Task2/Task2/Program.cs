using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Milk[] milkarr = new Milk[0];

            string com = "";

            do
            {
                Milk milk = new();

                Console.Write("Enter Name: ");
                milk.Name = Console.ReadLine();
                Console.Write("Enter Price: ");
                milk.Price = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter Volume: ");
                milk.Volume = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter FatRate: ");
                milk.FatRate = Convert.ToInt32(Console.ReadLine());

                string empty = " ";

                if(milk.Name!=empty && milk.Price>0 && milk.Volume>0 && milk.FatRate > 0)
                {
                    Array.Resize(ref milkarr, milkarr.Length + 1);
                    milkarr[milkarr.Length - 1] = milk;
                    
                }
                else 
                {
                    Console.WriteLine("Error!");
                }

                Console.WriteLine("Yeni bir milk Elave etmek isteyirsinizmi? y/n");
                com = Console.ReadLine();

            } while (com == "y");
            
            for (int i = 0; i < milkarr.Length; i++)
            {
                Console.WriteLine("___________________________");
                Console.WriteLine($"Name: {milkarr[i].Name}\nPrice: {milkarr[i].Price}$\nVolume: {milkarr[i].FatRate}%");
                Console.WriteLine("___________________________");
            }
        }
    }
}
