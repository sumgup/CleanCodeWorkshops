using System;

namespace DrawShapesLib
{  
    public class Square : IShape
    {
        public double ItsSide;
        public Tuple<double, double> TopLeft;

        public void Draw()
        {
            Console.WriteLine("Drawing Square");
        }
    }
   
}
