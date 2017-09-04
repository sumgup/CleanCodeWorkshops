using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemo
{
    struct Point { double x, y; }

    public class Shape
    {
        private ShapeType type;
        public Shape(ShapeType t) { type = t; }
        public static void DrawShape(Shape s)
        {

            /* Liskov Substitution Principle
            ===================================
            Subtypes must be substitutable for their base types. */

            // Violates OCP - Method is open for modification as new shapes get added
            // Square and Circle cannot be substituted for Shape is a violation
            // 

            //The fact that Square and Circle cannot be substituted for Shape is a violation of LSP

            if (s.type == ShapeType.square)
                (s as Square).Draw();
            else if (s.type == ShapeType.circle)
                (s as Circle).Draw();
        }
    }
}
