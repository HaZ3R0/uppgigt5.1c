using System;
namespace uppgift5._1c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många meningar vill du skriva?");
            string antaltext = Console.ReadLine();
            int antal = int.Parse( antaltext );
            string[] mening = new string[antal];
            for (int i = 0; i < antal; i++)
            {
               Console.WriteLine("Skriv en mening");
                mening[i] = Console.ReadLine();
            }
            Console.WriteLine("Här är de meningar du skrev");
            for (int i = 0;i < antal; i++)
            {
                Console.WriteLine(mening[i]);
                Console.WriteLine("");
            }
        }
    }
}