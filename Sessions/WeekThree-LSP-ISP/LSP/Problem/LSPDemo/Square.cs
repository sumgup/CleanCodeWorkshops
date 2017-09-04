using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemo
{
    public class Square : ShapeBase
    {
        private Point topLeft;
        private double side;
        public Square() : base(ShapeType.square) { }
        public void Draw() {/* draws the square */}
    }
}
