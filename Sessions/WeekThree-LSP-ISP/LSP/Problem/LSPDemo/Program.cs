using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square2();
            square.Width = 1;
            square.Height = 2;

            // Call method and pass square instead of Rectangle

            f(square);
        }

        // 3. If we pass instance of square, square object will be corrupted.
        // VIOLATION OF LSP
        //The f function does not work for derivatives of its arguments.

        // The reason for the failure is that Width and Height were not declared
        //virtual in Rectangle and are therefore not polymorphic.

        // Can fix it by making setter virtual in base class but changing base class because of derived indicates faulty design
        static void f(Rectangle r)
        {
            r.Width = 32;  
        }


    }
}
