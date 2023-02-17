using System;
namespace Upgift._1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv din bas och höjd");
            int höjd1 = int.Parse(Console.ReadLine());
            int bas2 = int.Parse(Console.ReadLine());    
            AREA(höjd1, bas2);
            Console.WriteLine($"Arean är:{höjd1 * bas2} cm^2");

        }
        static int AREA(int höjd1, int bas2)
        {
            return (höjd1 * bas2);
           
         
        }
    }
}