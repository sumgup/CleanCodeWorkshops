using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemo
{
    public class Circle : Shape
    {
        public Circle() : base(ShapeType.circle) { }

        private Point center;
        private double radius;
        public void Draw() {/* draws the circle */}
    }
}
