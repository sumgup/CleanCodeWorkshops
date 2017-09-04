using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemo
{
    // 1. Making a decision that square ISA Rectangle
    public class Rectangle
    {
        private double width;
        private double height;
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
    }

    // 2. Waste of inheritance becase square doesnt need both height and width variable
    public class Square2 : Rectangle
    {
        // 3. Change in width results in height change
        public new double Width
        {
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public new double Height
        {
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
    }
   
}
