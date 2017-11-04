using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperativeToFunctional
{
    public class Functional
    {
        public FileInfo DownloadHtml(Uri uri)
        {
            return default;
        }

        public FileInfo ConvertToWord(FileInfo htmlDocument)
        {
            return default;
        }

        public void UploadToOneDrive(FileInfo file)
        {

        }

        private void Foo()
        {
            Func<Uri, FileInfo> downloadHtml = DownloadHtml;
            Func<FileInfo, FileInfo> convert = ConvertToWord;
            Action<FileInfo> upload = UploadToOneDrive;
        }

        private void BuildDocument(Func<Uri, FileInfo> downloadHtml, Func<FileInfo, FileInfo> convert, Action<FileInfo> upload)
        {
            var uri = new Uri("www.microsoft.com");


            var htmlFile = downloadHtml(uri);
            var convertedFile = convert(htmlFile);
            upload(convertedFile);
        }

      

        internal static void BuildDocument(Uri uri, FileInfo template)
        {
            DocumentBuilder builder = new DocumentBuilder(
                new WebClient(), new DocumentConverter(template), new OneDriveClient());
            builder.Build(uri);
        }
    }
}
