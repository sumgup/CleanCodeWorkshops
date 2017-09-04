using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawShapesLib
{
    public class DrawAllShape
    {
        // VIOLATES : OCP
        public void DrawAllShapes(List<object> shapes)
        {
            foreach (var shape in shapes)
            {
                if (shape is Circle)
                {
                    var square = shape as Circle;
                    square.DrawCircle();
                }

                if (shape is Square)
                {
                    var square = shape as Square;
                    square.DrawSquare();
                }

           

                // Add if for Triangle?

                //    Of course, this program is only a simple example. In real life, the switch statement in the
                //    DrawAllShapes function would be repeated over and over again in various functions all through the
                //    application, each one doing something a little different. There might be one each for dragging shapes,
                //    stretching shapes, moving shapes, deleting shapes, and so on.Adding a new shape to such an
                //    application means hunting for every place that such switch statementsor if/else chainsexist and
                //adding the new shape to each.


                // The simple act of adding a new shape to the application causes a
                // cascade of subsequent changes to many source modules and even more binary modules and binary
                // components.Clearly, the impact of adding a new shape is very large.
            }
        }
    }
}
