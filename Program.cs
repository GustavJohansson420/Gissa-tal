using System;

namespace Gissa_tal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett tal mellan 1 och 100");
            Random slump=new Random();
            int rand = slump.Next(0,101);
            int poop = 0;
            int poopy = int.Parse(Console.ReadLine());
            while (poopy !=rand) {
                if(poopy < rand) {
                    Console.WriteLine("Talet är för lågt");
                }
                if(poopy > rand) {
                    Console.WriteLine("Talet är för högt");
                }
                Console.WriteLine("Gissa igen");
                poopy=int.Parse(Console.ReadLine());
                poop +=1;
            }
            Console.WriteLine("Rätt svar");
            Console.WriteLine("Du gissade " + poop + " gånger");
        }
    }
}
