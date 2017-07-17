using BridgePattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Shape redCircle = new Circle(100, 100, 10, new RedCircle());
            Shape greenCircle = new Circle(100, 100, 10, new GreenCircle());

            redCircle.Draw();
            greenCircle.Draw();

            Console.ReadLine();
        }
    }
}
