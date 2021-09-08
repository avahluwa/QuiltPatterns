using System;

namespace QuiltPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Greetings and welcome to the Quilt Pattern Logger!!");
            Console.WriteLine("\nEnter a number to change the text color.");
            Console.WriteLine("\n1) Red\n2) Green\n3) Blue");

            string color;
            color = Console.ReadLine();

            if (color == "1")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (color == "2")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (color == "3")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }

            Console.WriteLine("\nEnter a letter to add a shape to the log");
            Console.WriteLine("S) Square\nR) Rectangle\nT) Triangle");
            Console.WriteLine("\nV) View log input");
            Console.WriteLine("\nQ) Quit");

            string shape;
            shape = Console.ReadLine();

            if (shape == "S")
            {
                Square shapeS = new Square();
            }

        }
    }
}
