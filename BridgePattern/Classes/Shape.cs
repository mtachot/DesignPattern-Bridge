using BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Classes
{
    public abstract class Shape
    {
        protected IDrawAPI drawAPI;

        protected Shape(IDrawAPI drawAPI)
        {
            this.drawAPI = drawAPI;
        }

        public abstract void Draw();
    }
}
