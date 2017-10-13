using System;

namespace DrawShapesLib
{
    public class Circle : IShape
    {
        public double Radius;
        public Tuple<double, double> XandY;



        public void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }


    }
   
}
