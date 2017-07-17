using BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Classes
{
    public class GreenCircle : IDrawAPI
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine(String.Format("Drawing circle[ color: green, radius: {0}, x: {1}, y: {2} ]", radius, x, y));
        }
    }
}
