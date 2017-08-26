using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileSaveStrategy
{
    public class File : FileBase
    {
        public File()
        {
            // Default saves to database
            Save = new Database();
        }
    }
}