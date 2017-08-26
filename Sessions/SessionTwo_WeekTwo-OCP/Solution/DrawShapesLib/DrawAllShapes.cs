using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawShapesLib
{
    public class DrawAllShape
    {
        public void DrawAllShapes(IList shapes)
        {
            foreach (IShape shape in shapes)
                shape.Draw();
        }

        //   In a real application, the Shape class would have many more methods.Yet adding a new shape to the
        //application is still quite simple, since all that is required is to create the new derivative and implement
        //all its functions.There is no need to hunt through all the application, looking for places that require
        //changes. This solution is not fragile.

        // TODO : Ordering of shapes, draw Circles first than Square
    }
}
