using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperativeToFunctional
{
    class Functional
    {
        internal static void BuildDocument(Uri uri, FileInfo template)
        {
            DocumentBuilder builder = new DocumentBuilder(
                new WebClient(), new DocumentConverter(template), new OneDriveClient());
            builder.Build(uri);
        }
    }
}
