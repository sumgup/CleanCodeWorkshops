using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawShapesLib;
using System.Collections;

namespace DrawShapesClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            var drawShapes = new DrawAllShape();

            var square = new Square();
            square.ItsSide = 10;
            square.ItsSide = 20;


            var circle = new Circle();
            circle.Radius = 10;
            circle.XandY = new Tuple<double, double>(10, 10);


            // TODO : Demo Add triangle

            var list = new ArrayList();

            list.Add(square);
            list.Add(circle);

            drawShapes.DrawAllShapes(list);

            Console.Read();
        }
    }
}
