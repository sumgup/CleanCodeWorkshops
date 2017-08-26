using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawShapesLib
{
    /// <summary>
    /// This comparer will search the priorities
    /// hashtable for a shape's type. The priorities
    /// table defines the odering of shapes. Shapes
    /// that are not found precede shapes that are found.
    /// </summary>
    public class ShapeComparer : IComparer
    {
        private static Hashtable priorities = new Hashtable();

        static ShapeComparer()
        {
            // TODO : Can be moved outside
            priorities.Add(typeof(Circle), 1);
            priorities.Add(typeof(Square), 2);
        }
       
        private int PriorityFor(Type type)
        {
            if (priorities.Contains(type))
                return (int)priorities[type];
            else
                return 0;
        }

        public int Compare(object x, object y)
        {
            int priority1 = PriorityFor(x.GetType());
            int priority2 = PriorityFor(y.GetType());
            return priority1.CompareTo(priority2);
        }

    }
}
