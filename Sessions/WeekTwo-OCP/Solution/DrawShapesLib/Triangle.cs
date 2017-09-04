using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawShapesLib
{
    public class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("drawing triangle");
        }
    }
}
