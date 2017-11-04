using System;
using System.IO;

namespace ImperativeToFunctional
{
    // TODO : Convert this class into Functional
    public class Imperative
    {
       
        internal static void BuildDocument(Uri uri, FileInfo template)
        {
            DocumentBuilder builder = new DocumentBuilder(
                new WebClient(), new DocumentConverter(template), new OneDriveClient());
            builder.Build(uri);
        }
    }

    public class DocumentBuilder
    {
        private readonly WebClient webClient;

        private readonly DocumentConverter documentConverter;

        private readonly IUpload iUpload;

        public DocumentBuilder(
           WebClient webClient, DocumentConverter documentConverter,  IUpload upload)
        {
            this.webClient = webClient;
            this.documentConverter = documentConverter;
            iUpload = upload;
        }

        public void Build(Uri uri)
        {
            var htmlDocument = webClient.Download(uri);
            var wordDocument = documentConverter.ToWord(htmlDocument);
            iUpload.Upload(wordDocument);
        }
    }

    public class WebClient
    {
        public FileInfo Download(Uri uri)
        {
            return default;
        }
    }

    public class DocumentConverter
    {
        public DocumentConverter(FileInfo template)
        {
            Template = template;
        }

        public FileInfo Template { get; private set; }

        public FileInfo ToWord(FileInfo htmlDocument)
        {
            return default;
        }
    }

    public class OneDriveClient :IUpload 
    {
        public void Upload(FileInfo file) { }
    }

    public class GoogleDriveClient : IUpload
    {
        public void Upload(FileInfo file) { }
    }

    public interface IUpload
    {
       void Upload(FileInfo file);
    }

   
}
