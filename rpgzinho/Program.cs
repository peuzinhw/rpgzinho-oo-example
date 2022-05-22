using System;
using rpgzinho.src.entities;

namespace rpgzinho
{

    class Program
    {
        static void Main(string[]args)
        {
            Hero Arus = new Hero("Arus", 42, "Knight", "Sword");
            Hero Teseus = new Hero("Teseus", 99, "Mage", "Wand");
            
            Console.WriteLine(Arus + " " + Teseus);
        } 

    }
}


