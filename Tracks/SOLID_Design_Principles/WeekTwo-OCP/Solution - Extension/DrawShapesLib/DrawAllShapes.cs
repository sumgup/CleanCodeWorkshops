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

        public void DrawAllShapes(ArrayList shapes)
        {
            shapes.Sort(new ShapeComparer());
            foreach (IShape shape in shapes)
                shape.Draw();
        }

        //public void DrawAllShapes(IList shapes)
        //{
        //    foreach (IShape shape in shapes)
        //        shape.Draw();
        //}

       

    }
}
