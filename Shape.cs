using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPattern
{
    public abstract class Shape
    public Shape CreateSquare()
    {
        Console.WriteLine("You made a square");
        var color = ui.AskForString("Choose a color");
        var side1 = ui.AskForInt("What is the length of a side");

        return new Square(color, side1);
    }
}
